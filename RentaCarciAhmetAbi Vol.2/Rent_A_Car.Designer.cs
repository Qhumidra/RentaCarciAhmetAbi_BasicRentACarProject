
namespace RentaCarciAhmetAbi_Vol._2
{
    partial class Rent_A_Car
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carClassComboBox = new System.Windows.Forms.ComboBox();
            this.rentIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carRentDataGrid = new System.Windows.Forms.DataGridView();
            this.customerRentDataGrid = new System.Windows.Forms.DataGridView();
            this.RentButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rentSearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dailyButton = new System.Windows.Forms.Button();
            this.rentPriceButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tDateTimeMTxt = new System.Windows.Forms.MaskedTextBox();
            this.gDateTimeMTxt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerSurnameLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.carPriceLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.carIdLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rentedDataGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.rentPriceLabel = new System.Windows.Forms.Label();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carRentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRentDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.Location = new System.Drawing.Point(12, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 21);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "00";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.Location = new System.Drawing.Point(1166, 18);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 21);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // carClassComboBox
            // 
            this.carClassComboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.carClassComboBox.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carClassComboBox.FormattingEnabled = true;
            this.carClassComboBox.Items.AddRange(new object[] {
            "Ekonomi",
            "Luks",
            "Premium",
            "Van"});
            this.carClassComboBox.Location = new System.Drawing.Point(585, 39);
            this.carClassComboBox.Name = "carClassComboBox";
            this.carClassComboBox.Size = new System.Drawing.Size(121, 29);
            this.carClassComboBox.TabIndex = 8;
            // 
            // rentIdTxt
            // 
            this.rentIdTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rentIdTxt.Enabled = false;
            this.rentIdTxt.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentIdTxt.Location = new System.Drawing.Point(207, 39);
            this.rentIdTxt.Name = "rentIdTxt";
            this.rentIdTxt.Size = new System.Drawing.Size(100, 28);
            this.rentIdTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kiralama Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(401, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Araba Sinifi: ";
            // 
            // carRentDataGrid
            // 
            this.carRentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carRentDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carRentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.carRentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carRentDataGrid.Location = new System.Drawing.Point(12, 497);
            this.carRentDataGrid.Name = "carRentDataGrid";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carRentDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.carRentDataGrid.Size = new System.Drawing.Size(657, 211);
            this.carRentDataGrid.TabIndex = 12;
            this.carRentDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carRentDataGrid_CellMouseDoubleClick);
            // 
            // customerRentDataGrid
            // 
            this.customerRentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerRentDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerRentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customerRentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerRentDataGrid.Location = new System.Drawing.Point(818, 497);
            this.customerRentDataGrid.Name = "customerRentDataGrid";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerRentDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customerRentDataGrid.Size = new System.Drawing.Size(470, 211);
            this.customerRentDataGrid.TabIndex = 13;
            this.customerRentDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerRentDataGrid_CellMouseDoubleClick);
            // 
            // RentButton
            // 
            this.RentButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RentButton.Enabled = false;
            this.RentButton.FlatAppearance.BorderSize = 0;
            this.RentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentButton.Location = new System.Drawing.Point(675, 666);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(137, 42);
            this.RentButton.TabIndex = 14;
            this.RentButton.Text = "Kirala";
            this.RentButton.UseVisualStyleBackColor = false;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // rentSearchButton
            // 
            this.rentSearchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rentSearchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentSearchButton.FlatAppearance.BorderSize = 0;
            this.rentSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentSearchButton.Location = new System.Drawing.Point(763, 38);
            this.rentSearchButton.Name = "rentSearchButton";
            this.rentSearchButton.Size = new System.Drawing.Size(170, 29);
            this.rentSearchButton.TabIndex = 15;
            this.rentSearchButton.Text = "Sinifina Gore Ara";
            this.rentSearchButton.UseVisualStyleBackColor = false;
            this.rentSearchButton.Click += new System.EventHandler(this.rentSearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dailyButton);
            this.groupBox1.Controls.Add(this.rentPriceButton);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tDateTimeMTxt);
            this.groupBox1.Controls.Add(this.gDateTimeMTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.customerSurnameLabel);
            this.groupBox1.Controls.Add(this.customerNameLabel);
            this.groupBox1.Controls.Add(this.customerIdLabel);
            this.groupBox1.Controls.Add(this.carPriceLabel);
            this.groupBox1.Controls.Add(this.carModelLabel);
            this.groupBox1.Controls.Add(this.carBrandLabel);
            this.groupBox1.Controls.Add(this.carIdLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 424);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // dailyButton
            // 
            this.dailyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dailyButton.FlatAppearance.BorderSize = 0;
            this.dailyButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.dailyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyButton.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dailyButton.Location = new System.Drawing.Point(944, 178);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(100, 28);
            this.dailyButton.TabIndex = 34;
            this.dailyButton.Text = "gunun tarihi";
            this.dailyButton.UseVisualStyleBackColor = false;
            this.dailyButton.Click += new System.EventHandler(this.dailyButton_Click);
            // 
            // rentPriceButton
            // 
            this.rentPriceButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rentPriceButton.FlatAppearance.BorderSize = 0;
            this.rentPriceButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.rentPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentPriceButton.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentPriceButton.Location = new System.Drawing.Point(621, 355);
            this.rentPriceButton.Name = "rentPriceButton";
            this.rentPriceButton.Size = new System.Drawing.Size(224, 54);
            this.rentPriceButton.TabIndex = 33;
            this.rentPriceButton.Text = "Fiyat Al";
            this.rentPriceButton.UseVisualStyleBackColor = false;
            this.rentPriceButton.Click += new System.EventHandler(this.rentPriceButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(940, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 24);
            this.label14.TabIndex = 32;
            this.label14.Text = "Geri Alis tarihi: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(940, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Kiralama Tarihi: ";
            // 
            // tDateTimeMTxt
            // 
            this.tDateTimeMTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tDateTimeMTxt.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tDateTimeMTxt.Location = new System.Drawing.Point(1050, 276);
            this.tDateTimeMTxt.Mask = "00/00/0000";
            this.tDateTimeMTxt.Name = "tDateTimeMTxt";
            this.tDateTimeMTxt.Size = new System.Drawing.Size(121, 28);
            this.tDateTimeMTxt.TabIndex = 30;
            this.tDateTimeMTxt.ValidatingType = typeof(System.DateTime);
            // 
            // gDateTimeMTxt
            // 
            this.gDateTimeMTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gDateTimeMTxt.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gDateTimeMTxt.Location = new System.Drawing.Point(1050, 178);
            this.gDateTimeMTxt.Mask = "00/00/0000";
            this.gDateTimeMTxt.Name = "gDateTimeMTxt";
            this.gDateTimeMTxt.Size = new System.Drawing.Size(121, 28);
            this.gDateTimeMTxt.TabIndex = 29;
            this.gDateTimeMTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(265, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "TL";
            // 
            // customerSurnameLabel
            // 
            this.customerSurnameLabel.AutoSize = true;
            this.customerSurnameLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerSurnameLabel.Location = new System.Drawing.Point(691, 212);
            this.customerSurnameLabel.Name = "customerSurnameLabel";
            this.customerSurnameLabel.Size = new System.Drawing.Size(178, 24);
            this.customerSurnameLabel.TabIndex = 24;
            this.customerSurnameLabel.Text = "______________";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerNameLabel.Location = new System.Drawing.Point(691, 133);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(178, 24);
            this.customerNameLabel.TabIndex = 23;
            this.customerNameLabel.Text = "______________";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerIdLabel.Location = new System.Drawing.Point(691, 54);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(34, 24);
            this.customerIdLabel.TabIndex = 22;
            this.customerIdLabel.Text = "00";
            // 
            // carPriceLabel
            // 
            this.carPriceLabel.AutoSize = true;
            this.carPriceLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carPriceLabel.Location = new System.Drawing.Point(213, 291);
            this.carPriceLabel.Name = "carPriceLabel";
            this.carPriceLabel.Size = new System.Drawing.Size(46, 24);
            this.carPriceLabel.TabIndex = 21;
            this.carPriceLabel.Text = "000";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carModelLabel.Location = new System.Drawing.Point(213, 212);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(178, 24);
            this.carModelLabel.TabIndex = 20;
            this.carModelLabel.Text = "______________";
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carBrandLabel.Location = new System.Drawing.Point(213, 133);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(178, 24);
            this.carBrandLabel.TabIndex = 19;
            this.carBrandLabel.Text = "______________";
            // 
            // carIdLabel
            // 
            this.carIdLabel.AutoSize = true;
            this.carIdLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carIdLabel.Location = new System.Drawing.Point(213, 54);
            this.carIdLabel.Name = "carIdLabel";
            this.carIdLabel.Size = new System.Drawing.Size(34, 24);
            this.carIdLabel.TabIndex = 18;
            this.carIdLabel.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(567, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Soyisim: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(603, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Isim: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(531, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Musteri no: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gunluk Ucreti: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Araba modeli: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Araba markasi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Araba no: ";
            // 
            // rentedDataGrid
            // 
            this.rentedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedDataGrid.Location = new System.Drawing.Point(12, 497);
            this.rentedDataGrid.Name = "rentedDataGrid";
            this.rentedDataGrid.Size = new System.Drawing.Size(276, 211);
            this.rentedDataGrid.TabIndex = 17;
            this.rentedDataGrid.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(759, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "TL";
            // 
            // rentPriceLabel
            // 
            this.rentPriceLabel.AutoSize = true;
            this.rentPriceLabel.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rentPriceLabel.Location = new System.Drawing.Point(707, 578);
            this.rentPriceLabel.Name = "rentPriceLabel";
            this.rentPriceLabel.Size = new System.Drawing.Size(46, 21);
            this.rentPriceLabel.TabIndex = 26;
            this.rentPriceLabel.Text = "000";
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paymentTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentTypeComboBox.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Karti"});
            this.paymentTypeComboBox.Location = new System.Drawing.Point(675, 602);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(137, 29);
            this.paymentTypeComboBox.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(446, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "00";
            // 
            // Rent_A_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.paymentTypeComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rentPriceLabel);
            this.Controls.Add(this.rentedDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rentSearchButton);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.customerRentDataGrid);
            this.Controls.Add(this.carRentDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentIdTxt);
            this.Controls.Add(this.carClassComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Rent_A_Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent_A_Car";
            this.Load += new System.EventHandler(this.Rent_A_Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carRentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRentDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox carClassComboBox;
        private System.Windows.Forms.TextBox rentIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView carRentDataGrid;
        private System.Windows.Forms.DataGridView customerRentDataGrid;
        private System.Windows.Forms.Button RentButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button rentSearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label customerSurnameLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label carPriceLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.Label carIdLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView rentedDataGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label rentPriceLabel;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox tDateTimeMTxt;
        private System.Windows.Forms.MaskedTextBox gDateTimeMTxt;
        private System.Windows.Forms.Button rentPriceButton;
        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Label label12;
    }
}