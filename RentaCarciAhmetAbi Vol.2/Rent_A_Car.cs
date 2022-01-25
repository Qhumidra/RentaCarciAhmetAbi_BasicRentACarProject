using RentaCarciAhmetAbi_Vol._2.RentaCarciAhmetAbi_Vol._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCarciAhmetAbi_Vol._2
{
    public partial class Rent_A_Car : Form
    {
        public Rent_A_Car()
        {
            InitializeComponent();
        }
        //Form Event
        RentACar rentACar;
        AllRentedCars allRented;
        private void Rent_A_Car_Load(object sender, EventArgs e)
        {
            Rent_A_Car_LoadFunction();
        }
        //Timer Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1_TickFunction();
        }
        //Rent Button Event
        private void RentButton_Click(object sender, EventArgs e)
        {
            RentButtonFunction();
        }
        private void rentPriceButton_Click(object sender, EventArgs e)
        {
            rentPriceButtonFunction();
        }
        private void dailyButton_Click(object sender, EventArgs e)
        {
            dailyButtonFunction();
        }
        private void rentSearchButton_Click(object sender, EventArgs e)
        {
            rentSearchButtonFunction();
        }
        private void carRentDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carDoubleClickFunction();
        }
        private void customerRentDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerDoubleClickFunction();
        }



        public string Label { get; set; }
        //Load Method
        void Rent_A_Car_LoadFunction()
        {
            label12.Text = Label;
            rentACar = new RentACar();
            allRented = new AllRentedCars();
            rentedDataGrid.DataSource = allRented.Write();
            rentIdTxt.Text = rentedDataGrid.Rows.Count.ToString();
            customerRentDataGrid.DataSource = rentACar.CustomersRentWrite();
            carRentDataGrid.DataSource = rentACar.CarsRentWrite();
            timer1.Start();
        }
        //Timer Method
        void timer1_TickFunction()
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        //Rent Button Method
        void RentButtonFunction()
        {
            try
            {
                rentACar = new RentACar();
                rentACar.RentedId = int.Parse(rentIdTxt.Text);
                rentACar.CarId = int.Parse(carIdLabel.Text);
                rentACar.EmployeeId = 2; //I Can't solve this problem. 
                rentACar.CustomerId = int.Parse(customerIdLabel.Text);
                rentACar.GDate = gDateTimeMTxt.Text;
                rentACar.TDate = tDateTimeMTxt.Text;
                if (paymentTypeComboBox.SelectedItem == null)
                    rentACar.PaymentType = "Nakit";
                else
                    rentACar.PaymentType = paymentTypeComboBox.SelectedItem.ToString();
                rentACar.RentPrice = int.Parse(rentPriceLabel.Text);

                this.Hide();
            }
            catch (NullReferenceException) { MessageBox.Show("Bos gecme... Kardesim Kac Kere Diyecez ya...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.None); }
        }
        //Show Price Method
        void rentPriceButtonFunction()
        {
            try
            {
                if (DateTime.Parse(gDateTimeMTxt.Text) < DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    MessageBox.Show("Gecmis bir tarih giremezsin...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.None);
                    gDateTimeMTxt.Text = "";
                }
                else
                {
                    if (DateTime.Parse(gDateTimeMTxt.Text) > DateTime.Parse(tDateTimeMTxt.Text))
                    {
                        MessageBox.Show("Verilen tarihten daha gecmis bir tarih veremezsin...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.None);
                        tDateTimeMTxt.Text = "";
                    }
                    else
                    {
                        RentButton.Enabled = true;
                        TimeSpan days = Convert.ToDateTime(tDateTimeMTxt.Text) - Convert.ToDateTime(gDateTimeMTxt.Text);
                        double price = int.Parse(carPriceLabel.Text) * int.Parse(days.TotalDays.ToString());
                        rentPriceLabel.Text = price.ToString();
                    }
                }
            }
            catch (FormatException){ MessageBox.Show("Bos gecme...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.None);}
            catch (NullReferenceException) { MessageBox.Show("Bos gecme... Kardesim Kac Kere Diyecez ya...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.None); }
        }    
        //Search Method
        void rentSearchButtonFunction()
        {
            try 
            {
                if (int.Parse(DateTime.Today.Month.ToString()) > 10)
                    tDateTimeMTxt.Text = 0 + DateTime.Today.ToString();
                else
                    tDateTimeMTxt.Text = DateTime.Today.ToString();
                rentACar = new RentACar();
                rentACar.CarClass = carClassComboBox.SelectedItem.ToString();
                carRentDataGrid.DataSource = rentACar.RentCarQuery();
            }
            catch (NullReferenceException) { }
        }
        //Rent Selection Methods
        void carDoubleClickFunction()
        {
            try
            {
                DataGridViewRow dataGridViewRow = carRentDataGrid.SelectedRows[0];
                carIdLabel.Text = dataGridViewRow.Cells[0].Value.ToString();
                carBrandLabel.Text = dataGridViewRow.Cells[2].Value.ToString();
                carModelLabel.Text = dataGridViewRow.Cells[3].Value.ToString();
                carPriceLabel.Text = dataGridViewRow.Cells[5].Value.ToString();
                carRentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
        void customerDoubleClickFunction()
        {
            try
            {
                DataGridViewRow dataGridViewRow = customerRentDataGrid.SelectedRows[0];
                customerIdLabel.Text = dataGridViewRow.Cells[0].Value.ToString();
                customerNameLabel.Text = dataGridViewRow.Cells[1].Value.ToString();
                customerSurnameLabel.Text = dataGridViewRow.Cells[2].Value.ToString();
                customerRentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
        //Today write button Method
        void dailyButtonFunction()
        {
            if (int.Parse(DateTime.Now.Day.ToString()) > 10)
                gDateTimeMTxt.Text = DateTime.Today.ToShortDateString();
            else
                gDateTimeMTxt.Text = 0 + DateTime.Today.ToShortDateString();
        }
    }
}
