using Dashboard_Statistics_App.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace Dashboard_Statistics_App.Models
{
    public struct RevenueByDate
    {
        public string date { get; set; }
        public decimal totalAmount { get; set; }
    }

    public class Dashboard : databaseConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int daysNumber;

        public int numberOfCustomers { get; private set; }
        public int numberOfSupplier { get; private set; }
        public int numberOfProducts { get; private set; }

        public List<KeyValuePair<string, int>> topProductsList { get; private set; }
        public List<KeyValuePair<string, int>> insufficientProductsList { get; private set; }
        public List<RevenueByDate> revenueList { get; private set; }

        public int numberOfOrders { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal totalProfit { get; set; }

        public Dashboard()
        {

        }

        private void getNumberItems()
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "select count(id) from Customer";
                    numberOfCustomers = (int)command.ExecuteScalar();

                    command.CommandText = "select count(id) from Supplier";
                    numberOfSupplier = (int)command.ExecuteScalar();

                    command.CommandText = "select count(id) from Product";
                    numberOfProducts = (int)command.ExecuteScalar();

                    command.CommandText = "select count(id) from [Order] where OrderDate between @fromDate and @endDate";

                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    numberOfOrders = (int)command.ExecuteScalar();

                }
            }
        }

        private void getOrderStatistics()
        {
            revenueList = new List<RevenueByDate>();
            totalProfit = 0;
            totalRevenue = 0;

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"select OrderDate,sum(TotalAmount) from [Order] where OrderDate between @fromDate and @endDate group by OrderDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();

                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        totalRevenue += (decimal)reader[1];
                    }
                    totalProfit = totalRevenue * 0.3m;
                    reader.Close();

                    // if (daysNumber <= 30)
                    // {
                    //    foreach (var item in resultTable)
                    //    {
                    //        revenueList.Add(new RevenueByDate() { date = item.Key.ToString("dd MMM"), totalAmount = item.Value });
                    //    }
                    // }

                    if (daysNumber <= 1)
                    {
                        revenueList = (from orderList in resultTable group orderList by orderList.Key.ToString("hh tt") into order select new RevenueByDate { date = order.Key, totalAmount = order.Sum(amount => amount.Value) }).ToList();
                    }
                    else if (daysNumber <= 30)
                    {
                        revenueList = (from orderList in resultTable group orderList by orderList.Key.ToString("dd MMM") into order select new RevenueByDate { date = order.Key, totalAmount = order.Sum(amount => amount.Value) }).ToList();
                    }

                    else if (daysNumber <= 92)
                    {
                        revenueList = (from orderList in resultTable group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday) into order select new RevenueByDate { date = "Week " + order.Key.ToString(), totalAmount = order.Sum(amount => amount.Value) }).ToList();
                    }
                    else if (daysNumber <= (365 * 2))
                    {
                        bool isYear = daysNumber <= 365 ? true : false;
                        revenueList = (from orderList in resultTable group orderList by orderList.Key.ToString("MMM yyyy") into order select new RevenueByDate { date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key, totalAmount = order.Sum(amount => amount.Value) }).ToList();
                    }
                    else
                    {
                        revenueList = (from orderList in resultTable group orderList by orderList.Key.ToString("yyyy") into order select new RevenueByDate { date = order.Key, totalAmount = order.Sum(amount => amount.Value) }).ToList();
                    }

                }
            }
        }

        private void getProductStatistics()
        {
            topProductsList = new List<KeyValuePair<string, int>>();
            insufficientProductsList = new List<KeyValuePair<string, int>>();

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;

                    command.Connection = connection;
                    command.CommandText = @"select top 10 P.ProductName, sum(OrderItem.Quantity) as Q from OrderItem inner join Product P on P.Id = OrderItem.ProductId inner join [Order] O on O.Id = OrderItem.OrderId where OrderDate between @fromDate and @endDate group by P.ProductName order by Q desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        topProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    command.CommandText = @"select ProductName, Stock from Product where Stock <= 10 and IsDiscontinued = 0";
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        insufficientProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        public bool loadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.daysNumber = (endDate - startDate).Days;

                getNumberItems();
                getOrderStatistics();
                getProductStatistics();
                Console.WriteLine("NEW DATA: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("SAME DATA: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
