using Dashboard_Statistics_App.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard_Statistics_App
{
    public partial class Form1 : Form
    {
        private Dashboard model;

        public Form1()
        {
            InitializeComponent();

            //dateTimePickerStart.Value = DateTime.Today.AddDays(-7);
            //dateTimePickerEnd.Value = DateTime.Now;
            setDemoDates();
            buttonDemo.Select();
            setColorUI(buttonDemo);

            model = new Dashboard();
            loadData();
        }

        private void loadData()
        {
            var data = model.loadData(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            if (data == true)
            {
                labelNumberOfOrdersNumber.Text = model.numberOfOrders.ToString();
                labelTotalRevenueNumber.Text = "€" + model.totalRevenue.ToString();
                labelTotalProfitNumber.Text = "€" + model.totalProfit.ToString();
                labelNumberOfCustomersNumber.Text = model.numberOfCustomers.ToString();
                labelNumberOfSuppliersNumber.Text = model.numberOfSupplier.ToString();
                labelNumberOfProductsNumber.Text = model.numberOfProducts.ToString();

                chartRevenue.DataSource = model.revenueList;
                chartRevenue.Series[0].XValueMember = "date";
                chartRevenue.Series[0].YValueMembers = "totalAmount";
                chartRevenue.DataBind();

                chartTopProduct.DataSource = model.topProductsList;
                chartTopProduct.Series[0].XValueMember = "Key";
                chartTopProduct.Series[0].YValueMembers = "Value";
                chartTopProduct.DataBind();

                dataGridViewInsufficientProducts.DataSource = model.insufficientProductsList;
                dataGridViewInsufficientProducts.Columns[0].HeaderText = "Items";
                dataGridViewInsufficientProducts.Columns[1].HeaderText = "Units";
                Console.WriteLine("VIEW LOADED");
            }
            else Console.WriteLine("SAME VIEW");
        }
        private void disableCustomDates()
        {
            dateTimePickerStart.Enabled = false;
            dateTimePickerEnd.Enabled = false;
            buttonSetCustomRange.Visible = false;
            labelStartDate.Cursor = Cursors.Default;
            labelEndDate.Cursor = Cursors.Default;
        }

        private void enableCustomDates()
        {
            dateTimePickerStart.Enabled = true;
            dateTimePickerEnd.Enabled = true;
            buttonSetCustomRange.Visible = true;
            labelStartDate.Cursor = Cursors.Hand;
            labelEndDate.Cursor = Cursors.Hand;
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Now;
            loadData();
            disableCustomDates();
            setColorUI(sender);
        }

        private void buttonLast7Days_Click(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Today.AddDays(-7);
            dateTimePickerEnd.Value = DateTime.Now;
            loadData();
            disableCustomDates();
            setColorUI(sender);
        }

        private void buttonLast30Days_Click(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Today.AddDays(-30);
            dateTimePickerEnd.Value = DateTime.Now;
            loadData();
            disableCustomDates();
            setColorUI(sender);
        }

        private void buttonThisMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateTimePickerEnd.Value = DateTime.Now;
            loadData();
            disableCustomDates();
            setColorUI(sender);
        }

        private void buttonCustomRange_Click(object sender, EventArgs e)
        {
            enableCustomDates();
            setColorUI(sender);
        }

        private void buttonSetCustomRange_Click(object sender, EventArgs e)
        {
            loadData();
            setColorUI(sender);
        }

        private Button clickedButton;
        private void setColorUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = buttonCustomRange.FlatAppearance.BorderColor;
            btn.ForeColor = Color.FromArgb(250, 249, 247);
            if (clickedButton != null & clickedButton != btn)
            {
                clickedButton.BackColor = this.BackColor;
                clickedButton.ForeColor = Color.FromArgb(250, 249, 247);
            }
            clickedButton = btn;
        }

        private void labelStartDate_Click(object sender, EventArgs e)
        {
            if (clickedButton == buttonCustomRange)
            {
                dateTimePickerStart.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void labelEndDate_Click(object sender, EventArgs e)
        {
            if (clickedButton == buttonCustomRange)
            {
                dateTimePickerEnd.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            labelStartDate.Text = dateTimePickerStart.Text;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            labelEndDate.Text = dateTimePickerEnd.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStartDate.Text = dateTimePickerStart.Text;
            labelEndDate.Text = dateTimePickerEnd.Text;
            dataGridViewInsufficientProducts.Columns[1].Width = 50;
        }
        private void setDemoDates()
        {
            var dateStart = new DateTime(2020, 4, 30);
            var dateEnd = new DateTime(2021, 6, 23);
            dateTimePickerStart.Value = dateStart;
            dateTimePickerEnd.Value = dateEnd;
        }
        private void buttonDemo_Click(object sender, EventArgs e)
        {
            setDemoDates();
            loadData();
            setColorUI(sender);
        }

        private void buttonFindMe_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/PinkFlamingoz");
            setColorUI(sender);
        }

        private void linkLabelFindMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/PinkFlamingoz");
        }
    }
}
