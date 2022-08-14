namespace Dashboard_Statistics_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNumberOfOrdersNumber = new System.Windows.Forms.Label();
            this.labelNumberOfOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalRevenueNumber = new System.Windows.Forms.Label();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalProfitNumber = new System.Windows.Forms.Label();
            this.labelTotalProfit = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNumberOfProductsNumber = new System.Windows.Forms.Label();
            this.labelNumberOfProducts = new System.Windows.Forms.Label();
            this.labelNumberOfSuppliersNumber = new System.Windows.Forms.Label();
            this.labelNumberOfSuppliers = new System.Windows.Forms.Label();
            this.labelTotalCounter = new System.Windows.Forms.Label();
            this.labelNumberOfCustomersNumber = new System.Windows.Forms.Label();
            this.labelNumberOfCustomers = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewInsufficientProducts = new System.Windows.Forms.DataGridView();
            this.labelInsufficientProducts = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonSetCustomRange = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonCustomRange = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonLast30Days = new System.Windows.Forms.Button();
            this.buttonLast7Days = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.buttonFindMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelFindMe = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsufficientProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProduct)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelNumberOfOrdersNumber);
            this.panel1.Controls.Add(this.labelNumberOfOrders);
            this.panel1.Location = new System.Drawing.Point(246, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 69);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelNumberOfOrdersNumber
            // 
            this.labelNumberOfOrdersNumber.AutoSize = true;
            this.labelNumberOfOrdersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfOrdersNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfOrdersNumber.Location = new System.Drawing.Point(75, 28);
            this.labelNumberOfOrdersNumber.Name = "labelNumberOfOrdersNumber";
            this.labelNumberOfOrdersNumber.Size = new System.Drawing.Size(78, 25);
            this.labelNumberOfOrdersNumber.TabIndex = 1;
            this.labelNumberOfOrdersNumber.Text = "100000";
            // 
            // labelNumberOfOrders
            // 
            this.labelNumberOfOrders.AutoSize = true;
            this.labelNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNumberOfOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfOrders.Location = new System.Drawing.Point(75, 0);
            this.labelNumberOfOrders.Name = "labelNumberOfOrders";
            this.labelNumberOfOrders.Size = new System.Drawing.Size(132, 20);
            this.labelNumberOfOrders.TabIndex = 0;
            this.labelNumberOfOrders.Text = "Number of orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.labelTotalRevenueNumber);
            this.panel2.Controls.Add(this.labelTotalRevenue);
            this.panel2.Location = new System.Drawing.Point(548, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 69);
            this.panel2.TabIndex = 10;
            // 
            // labelTotalRevenueNumber
            // 
            this.labelTotalRevenueNumber.AutoSize = true;
            this.labelTotalRevenueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenueNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelTotalRevenueNumber.Location = new System.Drawing.Point(75, 29);
            this.labelTotalRevenueNumber.Name = "labelTotalRevenueNumber";
            this.labelTotalRevenueNumber.Size = new System.Drawing.Size(78, 25);
            this.labelTotalRevenueNumber.TabIndex = 1;
            this.labelTotalRevenueNumber.Text = "100000";
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelTotalRevenue.Location = new System.Drawing.Point(75, 0);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(112, 20);
            this.labelTotalRevenue.TabIndex = 0;
            this.labelTotalRevenue.Text = "Total Revenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.labelTotalProfitNumber);
            this.panel3.Controls.Add(this.labelTotalProfit);
            this.panel3.Location = new System.Drawing.Point(939, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 69);
            this.panel3.TabIndex = 10;
            // 
            // labelTotalProfitNumber
            // 
            this.labelTotalProfitNumber.AutoSize = true;
            this.labelTotalProfitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProfitNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelTotalProfitNumber.Location = new System.Drawing.Point(76, 29);
            this.labelTotalProfitNumber.Name = "labelTotalProfitNumber";
            this.labelTotalProfitNumber.Size = new System.Drawing.Size(78, 25);
            this.labelTotalProfitNumber.TabIndex = 1;
            this.labelTotalProfitNumber.Text = "100000";
            // 
            // labelTotalProfit
            // 
            this.labelTotalProfit.AutoSize = true;
            this.labelTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotalProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelTotalProfit.Location = new System.Drawing.Point(76, 0);
            this.labelTotalProfit.Name = "labelTotalProfit";
            this.labelTotalProfit.Size = new System.Drawing.Size(85, 20);
            this.labelTotalProfit.TabIndex = 0;
            this.labelTotalProfit.Text = "Total Profit";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.labelNumberOfProductsNumber);
            this.panel4.Controls.Add(this.labelNumberOfProducts);
            this.panel4.Controls.Add(this.labelNumberOfSuppliersNumber);
            this.panel4.Controls.Add(this.labelNumberOfSuppliers);
            this.panel4.Controls.Add(this.labelTotalCounter);
            this.panel4.Controls.Add(this.labelNumberOfCustomersNumber);
            this.panel4.Controls.Add(this.labelNumberOfCustomers);
            this.panel4.Location = new System.Drawing.Point(842, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 226);
            this.panel4.TabIndex = 10;
            // 
            // labelNumberOfProductsNumber
            // 
            this.labelNumberOfProductsNumber.AutoSize = true;
            this.labelNumberOfProductsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfProductsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfProductsNumber.Location = new System.Drawing.Point(84, 183);
            this.labelNumberOfProductsNumber.Name = "labelNumberOfProductsNumber";
            this.labelNumberOfProductsNumber.Size = new System.Drawing.Size(70, 24);
            this.labelNumberOfProductsNumber.TabIndex = 6;
            this.labelNumberOfProductsNumber.Text = "100000";
            // 
            // labelNumberOfProducts
            // 
            this.labelNumberOfProducts.AutoSize = true;
            this.labelNumberOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfProducts.Location = new System.Drawing.Point(80, 163);
            this.labelNumberOfProducts.Name = "labelNumberOfProducts";
            this.labelNumberOfProducts.Size = new System.Drawing.Size(149, 20);
            this.labelNumberOfProducts.TabIndex = 5;
            this.labelNumberOfProducts.Text = "Number of products";
            // 
            // labelNumberOfSuppliersNumber
            // 
            this.labelNumberOfSuppliersNumber.AutoSize = true;
            this.labelNumberOfSuppliersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfSuppliersNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfSuppliersNumber.Location = new System.Drawing.Point(84, 124);
            this.labelNumberOfSuppliersNumber.Name = "labelNumberOfSuppliersNumber";
            this.labelNumberOfSuppliersNumber.Size = new System.Drawing.Size(70, 24);
            this.labelNumberOfSuppliersNumber.TabIndex = 4;
            this.labelNumberOfSuppliersNumber.Text = "100000";
            // 
            // labelNumberOfSuppliers
            // 
            this.labelNumberOfSuppliers.AutoSize = true;
            this.labelNumberOfSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfSuppliers.Location = new System.Drawing.Point(80, 104);
            this.labelNumberOfSuppliers.Name = "labelNumberOfSuppliers";
            this.labelNumberOfSuppliers.Size = new System.Drawing.Size(150, 20);
            this.labelNumberOfSuppliers.TabIndex = 3;
            this.labelNumberOfSuppliers.Text = "Number of suppliers";
            // 
            // labelTotalCounter
            // 
            this.labelTotalCounter.AutoSize = true;
            this.labelTotalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelTotalCounter.Location = new System.Drawing.Point(3, 0);
            this.labelTotalCounter.Name = "labelTotalCounter";
            this.labelTotalCounter.Size = new System.Drawing.Size(56, 25);
            this.labelTotalCounter.TabIndex = 2;
            this.labelTotalCounter.Text = "Total";
            // 
            // labelNumberOfCustomersNumber
            // 
            this.labelNumberOfCustomersNumber.AutoSize = true;
            this.labelNumberOfCustomersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfCustomersNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfCustomersNumber.Location = new System.Drawing.Point(84, 55);
            this.labelNumberOfCustomersNumber.Name = "labelNumberOfCustomersNumber";
            this.labelNumberOfCustomersNumber.Size = new System.Drawing.Size(70, 24);
            this.labelNumberOfCustomersNumber.TabIndex = 1;
            this.labelNumberOfCustomersNumber.Text = "100000";
            // 
            // labelNumberOfCustomers
            // 
            this.labelNumberOfCustomers.AutoSize = true;
            this.labelNumberOfCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelNumberOfCustomers.Location = new System.Drawing.Point(80, 35);
            this.labelNumberOfCustomers.Name = "labelNumberOfCustomers";
            this.labelNumberOfCustomers.Size = new System.Drawing.Size(161, 20);
            this.labelNumberOfCustomers.TabIndex = 0;
            this.labelNumberOfCustomers.Text = "Number of customers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.dataGridViewInsufficientProducts);
            this.panel5.Controls.Add(this.labelInsufficientProducts);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.panel5.Location = new System.Drawing.Point(246, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 226);
            this.panel5.TabIndex = 11;
            // 
            // dataGridViewInsufficientProducts
            // 
            this.dataGridViewInsufficientProducts.AllowUserToResizeRows = false;
            this.dataGridViewInsufficientProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInsufficientProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.dataGridViewInsufficientProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInsufficientProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewInsufficientProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(174)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(174)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInsufficientProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewInsufficientProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInsufficientProducts.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewInsufficientProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewInsufficientProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.dataGridViewInsufficientProducts.Location = new System.Drawing.Point(16, 39);
            this.dataGridViewInsufficientProducts.Name = "dataGridViewInsufficientProducts";
            this.dataGridViewInsufficientProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(174)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInsufficientProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewInsufficientProducts.RowHeadersVisible = false;
            this.dataGridViewInsufficientProducts.RowTemplate.Height = 25;
            this.dataGridViewInsufficientProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInsufficientProducts.Size = new System.Drawing.Size(547, 168);
            this.dataGridViewInsufficientProducts.TabIndex = 3;
            // 
            // labelInsufficientProducts
            // 
            this.labelInsufficientProducts.AutoSize = true;
            this.labelInsufficientProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsufficientProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelInsufficientProducts.Location = new System.Drawing.Point(52, 0);
            this.labelInsufficientProducts.Name = "labelInsufficientProducts";
            this.labelInsufficientProducts.Size = new System.Drawing.Size(186, 25);
            this.labelInsufficientProducts.TabIndex = 2;
            this.labelInsufficientProducts.Text = "Insufficient Products";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            chartArea17.Area3DStyle.Inclination = 10;
            chartArea17.Area3DStyle.IsRightAngleAxes = false;
            chartArea17.Area3DStyle.PointDepth = 200;
            chartArea17.Area3DStyle.PointGapDepth = 200;
            chartArea17.Area3DStyle.Rotation = 10;
            chartArea17.Area3DStyle.WallWidth = 10;
            chartArea17.AxisX.IsMarginVisible = false;
            chartArea17.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea17.AxisX.LineColor = System.Drawing.Color.White;
            chartArea17.AxisX.LineWidth = 0;
            chartArea17.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea17.AxisX.MajorGrid.LineWidth = 0;
            chartArea17.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea17.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea17.AxisY.LabelStyle.Format = "€{0}";
            chartArea17.AxisY.LineColor = System.Drawing.Color.White;
            chartArea17.AxisY.LineWidth = 0;
            chartArea17.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea17.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            chartArea17.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea17);
            legend17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            legend17.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend17.ForeColor = System.Drawing.SystemColors.Control;
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend17);
            this.chartRevenue.Location = new System.Drawing.Point(246, 326);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(5);
            this.chartRevenue.Name = "chartRevenue";
            series17.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series17.BackSecondaryColor = System.Drawing.Color.LightSkyBlue;
            series17.BorderColor = System.Drawing.Color.Cyan;
            series17.BorderWidth = 5;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            series17.Legend = "Legend1";
            series17.MarkerBorderColor = System.Drawing.Color.Cyan;
            series17.MarkerColor = System.Drawing.Color.Cyan;
            series17.MarkerSize = 12;
            series17.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series17.Name = "Series1";
            this.chartRevenue.Series.Add(series17);
            this.chartRevenue.Size = new System.Drawing.Size(883, 321);
            this.chartRevenue.TabIndex = 13;
            this.chartRevenue.Text = "chartRevenue";
            title17.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            title17.Name = "Title1";
            title17.Text = " Revenue";
            this.chartRevenue.Titles.Add(title17);
            // 
            // chartTopProduct
            // 
            this.chartTopProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            chartArea18.Area3DStyle.IsClustered = true;
            chartArea18.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            chartArea18.Name = "ChartArea1";
            this.chartTopProduct.ChartAreas.Add(chartArea18);
            legend18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            legend18.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend18.ForeColor = System.Drawing.Color.White;
            legend18.IsTextAutoFit = false;
            legend18.Name = "Legend1";
            this.chartTopProduct.Legends.Add(legend18);
            this.chartTopProduct.Location = new System.Drawing.Point(1146, 94);
            this.chartTopProduct.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProduct.Name = "chartTopProduct";
            series18.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series18.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            series18.BorderWidth = 5;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series18.IsValueShownAsLabel = true;
            series18.LabelForeColor = System.Drawing.Color.White;
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            series18.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartTopProduct.Series.Add(series18);
            this.chartTopProduct.Size = new System.Drawing.Size(293, 550);
            this.chartTopProduct.TabIndex = 14;
            this.chartTopProduct.Text = "chartTopProduct";
            title18.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            title18.Name = "Title1";
            title18.Text = "10 Best selling products";
            this.chartTopProduct.Titles.Add(title18);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelStartDate.Location = new System.Drawing.Point(93, 344);
            this.labelStartDate.MinimumSize = new System.Drawing.Size(130, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(130, 20);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "8/14/2022";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonThisMonth.Location = new System.Drawing.Point(3, 76);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(220, 53);
            this.buttonThisMonth.TabIndex = 3;
            this.buttonThisMonth.Text = "This Month";
            this.buttonThisMonth.UseVisualStyleBackColor = false;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonSetCustomRange
            // 
            this.buttonSetCustomRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonSetCustomRange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonSetCustomRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetCustomRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSetCustomRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonSetCustomRange.Location = new System.Drawing.Point(0, 340);
            this.buttonSetCustomRange.Name = "buttonSetCustomRange";
            this.buttonSetCustomRange.Size = new System.Drawing.Size(87, 49);
            this.buttonSetCustomRange.TabIndex = 8;
            this.buttonSetCustomRange.Text = "Set";
            this.buttonSetCustomRange.UseVisualStyleBackColor = false;
            this.buttonSetCustomRange.Visible = false;
            this.buttonSetCustomRange.Click += new System.EventHandler(this.buttonSetCustomRange_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd MMM, yyyy";
            this.dateTimePickerEnd.Enabled = false;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(97, 369);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // buttonCustomRange
            // 
            this.buttonCustomRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonCustomRange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonCustomRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCustomRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonCustomRange.Location = new System.Drawing.Point(3, 288);
            this.buttonCustomRange.Name = "buttonCustomRange";
            this.buttonCustomRange.Size = new System.Drawing.Size(220, 53);
            this.buttonCustomRange.TabIndex = 7;
            this.buttonCustomRange.Text = "Custom Range";
            this.buttonCustomRange.UseVisualStyleBackColor = false;
            this.buttonCustomRange.Click += new System.EventHandler(this.buttonCustomRange_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonToday.Location = new System.Drawing.Point(3, 235);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(220, 53);
            this.buttonToday.TabIndex = 6;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = false;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonLast30Days
            // 
            this.buttonLast30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonLast30Days.Location = new System.Drawing.Point(3, 129);
            this.buttonLast30Days.Name = "buttonLast30Days";
            this.buttonLast30Days.Size = new System.Drawing.Size(220, 53);
            this.buttonLast30Days.TabIndex = 4;
            this.buttonLast30Days.Text = "Last 30 Days";
            this.buttonLast30Days.UseVisualStyleBackColor = false;
            this.buttonLast30Days.Click += new System.EventHandler(this.buttonLast30Days_Click);
            // 
            // buttonLast7Days
            // 
            this.buttonLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonLast7Days.Location = new System.Drawing.Point(3, 182);
            this.buttonLast7Days.Name = "buttonLast7Days";
            this.buttonLast7Days.Size = new System.Drawing.Size(220, 53);
            this.buttonLast7Days.TabIndex = 5;
            this.buttonLast7Days.Text = "Last 7 Days";
            this.buttonLast7Days.UseVisualStyleBackColor = false;
            this.buttonLast7Days.Click += new System.EventHandler(this.buttonLast7Days_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd MMM, yyyy";
            this.dateTimePickerStart.Enabled = false;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(97, 345);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelEndDate.Location = new System.Drawing.Point(93, 368);
            this.labelEndDate.MinimumSize = new System.Drawing.Size(130, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(130, 20);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "8/14/2022";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEndDate.Click += new System.EventHandler(this.labelEndDate_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.labelTitle.Location = new System.Drawing.Point(-7, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "View Magic";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.linkLabelFindMe);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.buttonFindMe);
            this.panel6.Controls.Add(this.buttonDemo);
            this.panel6.Controls.Add(this.buttonThisMonth);
            this.panel6.Controls.Add(this.labelEndDate);
            this.panel6.Controls.Add(this.labelTitle);
            this.panel6.Controls.Add(this.labelStartDate);
            this.panel6.Controls.Add(this.dateTimePickerStart);
            this.panel6.Controls.Add(this.dateTimePickerEnd);
            this.panel6.Controls.Add(this.buttonLast30Days);
            this.panel6.Controls.Add(this.buttonLast7Days);
            this.panel6.Controls.Add(this.buttonToday);
            this.panel6.Controls.Add(this.buttonCustomRange);
            this.panel6.Controls.Add(this.buttonSetCustomRange);
            this.panel6.Location = new System.Drawing.Point(-5, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 683);
            this.panel6.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 93);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(8, 158);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(16, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // buttonDemo
            // 
            this.buttonDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonDemo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonDemo.Location = new System.Drawing.Point(4, 407);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(220, 53);
            this.buttonDemo.TabIndex = 9;
            this.buttonDemo.Text = "Demo Date";
            this.buttonDemo.UseVisualStyleBackColor = false;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // buttonFindMe
            // 
            this.buttonFindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.buttonFindMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.buttonFindMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFindMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.buttonFindMe.Location = new System.Drawing.Point(17, 609);
            this.buttonFindMe.Name = "buttonFindMe";
            this.buttonFindMe.Size = new System.Drawing.Size(198, 53);
            this.buttonFindMe.TabIndex = 10;
            this.buttonFindMe.Text = "Find Me";
            this.buttonFindMe.UseVisualStyleBackColor = false;
            this.buttonFindMe.Click += new System.EventHandler(this.buttonFindMe_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(0, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 53);
            this.label1.TabIndex = 11;
            this.label1.Text = "Looking forward to work with ❤ \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelFindMe
            // 
            this.linkLabelFindMe.AutoSize = true;
            this.linkLabelFindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.linkLabelFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelFindMe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.linkLabelFindMe.Location = new System.Drawing.Point(63, 570);
            this.linkLabelFindMe.Name = "linkLabelFindMe";
            this.linkLabelFindMe.Size = new System.Drawing.Size(111, 17);
            this.linkLabelFindMe.TabIndex = 12;
            this.linkLabelFindMe.TabStop = true;
            this.linkLabelFindMe.Text = "Hristijan Stavrov";
            this.linkLabelFindMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFindMe_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1453, 653);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chartTopProduct);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dashboard Statistics App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsufficientProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProduct)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumberOfOrdersNumber;
        private System.Windows.Forms.Label labelNumberOfOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotalRevenueNumber;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalProfitNumber;
        private System.Windows.Forms.Label labelTotalProfit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelNumberOfCustomersNumber;
        private System.Windows.Forms.Label labelNumberOfCustomers;
        private System.Windows.Forms.Label labelTotalCounter;
        private System.Windows.Forms.Label labelNumberOfSuppliersNumber;
        private System.Windows.Forms.Label labelNumberOfSuppliers;
        private System.Windows.Forms.Label labelNumberOfProductsNumber;
        private System.Windows.Forms.Label labelNumberOfProducts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelInsufficientProducts;
        private System.Windows.Forms.DataGridView dataGridViewInsufficientProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProduct;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Button buttonThisMonth;
        private System.Windows.Forms.Button buttonSetCustomRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonCustomRange;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonLast30Days;
        private System.Windows.Forms.Button buttonLast7Days;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFindMe;
        private System.Windows.Forms.LinkLabel linkLabelFindMe;
    }
}

