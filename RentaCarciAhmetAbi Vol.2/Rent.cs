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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }
        Rent_A_Car rent;
        User user;
        public string User { get; set; }//For write user.
        public int Password { get; set; }
        private void Rent_Load(object sender, EventArgs e)
        {
            RentFormFunction();
        }
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            mainmenuImgPanelFunction();
        }
        private void mainmenuImgPanel_Click(object sender, EventArgs e)
        {
            mainmenuImgPanelFunction();
        }
        private void RentaCar_Click(object sender, EventArgs e)
        {
            RentaCarFunction();
        }
        private void rentCarImgPanel_Click(object sender, EventArgs e)
        {
            RentaCarFunction();
        }
        //Customer Events
        Customer customer;
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerButtonFunction();
        }
        private void addCustomerImgPanel_Click(object sender, EventArgs e)
        {
            AddCustomerButtonFunction();
        }
        private void customerAddButton_Click(object sender, EventArgs e)
        {
            AddCustomersFunction();
        }
        private void customerDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCustomersFunction();
        }
        private void customerUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomersFunction();
        }
        private void customerCleanButton_Click(object sender, EventArgs e)
        {
            CleanCustomerTextFunction();
        }
        private void customerGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustomerDoubleClick();
        }
        //Car Events
        Cars car;
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarButtonFunction();
        }
        private void addCarImgPanel_Click(object sender, EventArgs e)
        {
            AddCarButtonFunction();
        }
        private void carAddButton_Click(object sender, EventArgs e)
        {
            AddCarsFunction();
        }
        private void carDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCarsFunction();
        }
        private void carUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCarsFunction();
        }
        private void carCleanButton_Click(object sender, EventArgs e)
        {
            CleanCarsTextFunction();
        }
        private void carGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CarsDoubleClick();
        }
        //Rented Car Event
        RentedCars rentedCars;
        private void RentedCarsButton_Click(object sender, EventArgs e)
        {
            RentedCarsButtonFunction();
        }
        private void rentedCarImgPanel_Click(object sender, EventArgs e)
        {
            RentedCarsButtonFunction();
        }
        private void rentDeleteButton_Click_1(object sender, EventArgs e)
        {
            DeleteRentedFunction();
        }
        //Rent Taking Back Events
        RentTakingBack rentTakingBack = new RentTakingBack();
        private void TakingBackButton_Click(object sender, EventArgs e)
        {
            TakingBackButtonFunction();
        }
        private void takingBackImgPanel_MouseClick(object sender, MouseEventArgs e)
        {
            TakingBackButtonFunction();
        }
        private void takeBackButton_Click(object sender, EventArgs e)
        {
            takeBackButtonFunction();
        }
        //All Rented Cars Events
        AllRentedCars allRentedCars;
        private void AllRentedCarsButton_Click(object sender, EventArgs e)
        {
            AllRentedCarsButtonFunction();
        }
        private void allRentedCarsImgPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AllRentedCarsButtonFunction();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitButtonFunction();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            minimizeButtonFunction();
        }

        





        //Form Method
        void RentFormFunction()
        {
            rent = new Rent_A_Car();
            user = new User();
            user.UserName = User;
            user.Password = Password;
            user.UserWrite();
            userIdLabel.Text = user.UserIdLabel.ToString();
            userNameLabel.Text = user.UserNameLabel;
            userSurnameLabel.Text = user.UserSurnameLabel;
            userDepartmentLabel.Text = user.UserDepartmentLabel;
            if (userDepartmentLabel.Text == "Sef" || userDepartmentLabel.Text == "sef")
                AddCarButton.Enabled = true;
            else
                AddCarButton.Enabled = false;
            addCarsPanel.Visible = false;
            rentedCarsPanel.Visible = false;
            customerPanel.Visible = false;
            TodayTakingBackPanel.Visible = false;
            allRentedCarsPanel.Visible = false;
        }
        //Main Menu Method
        void mainmenuImgPanelFunction()
        {
            customerPanel.Visible = false;
            addCarsPanel.Visible = false;
            rentedCarsPanel.Visible = false;
            allRentedCarsPanel.Visible = false;
            TodayTakingBackPanel.Visible = false;
        }
        //RentaCar Button Method
        void RentaCarFunction()
        {
            mainmenuImgPanelFunction();
            rent = new Rent_A_Car();
            rent.ShowDialog();
        }
        //CustomersMethods
        void AddCustomerButtonFunction()
        {
            customerPanel.Visible = true;
            rentedCarsPanel.Visible = false;
            addCarsPanel.Visible = false;
            TodayTakingBackPanel.Visible = false;
            allRentedCarsPanel.Visible = false;
            customerIdTxt.Text = customerGridView.Rows.Count.ToString();
            customer = new Customer();
            customerGridView.DataSource = customer.Write();
        }
        void AddCustomersFunction()
        {
            customerIdTxt.Text = customerGridView.Rows.Count.ToString();
            customer = new Customer();
            customer.CustomerId = customerGridView.Rows.Count;
            customer.CustomerName = customerNameTxt.Text;
            customer.Surname = customerSurnameTxt.Text;
            customer.Sokak = customerSokTxt.Text;
            customer.Mahalle = customerMahTxt.Text;
            customer.Ilce = customerIlceTxt.Text;
            customer.Il = customerIlTxt.Text;
            customer.Adress = customerAdressTxt.Text;
            customer.Add();
            customerGridView.DataSource = customer.Write();
            CleanCustomerTextFunction();
        }
        void DeleteCustomersFunction()
        {
            customer = new Customer();
            int selected = customerGridView.SelectedRows[0].Index;
            int key = int.Parse(customerGridView[0, selected].Value.ToString());
            customer.Key = key;
            customer.Delete();
            customerGridView.DataSource = customer.Write();
            CleanCustomerTextFunction();
        }
        void UpdateCustomersFunction()
        {
            customerAddButton.Enabled = true;
            customer = new Customer();
            customer.CustomerId = int.Parse(customerIdTxt.Text);
            customer.CustomerName = customerNameTxt.Text;
            customer.Surname = customerSurnameTxt.Text;
            customer.Sokak = customerSokTxt.Text;
            customer.Mahalle = customerMahTxt.Text;
            customer.Ilce = customerIlceTxt.Text;
            customer.Il = customerIlTxt.Text;
            customer.Adress = customerAdressTxt.Text;
            customer.Update();
            customerGridView.DataSource = customer.Write();
            CleanCustomerTextFunction();
        }
        void CleanCustomerTextFunction()
        {
            customerAddButton.Enabled = true;
            customerIdTxt.Text = customerGridView.Rows.Count.ToString();
            customerNameTxt.Text = "";
            customerSurnameTxt.Text = "";
            customerSokTxt.Text = "";
            customerMahTxt.Text = "";
            customerIlTxt.Text = "";
            customerIlceTxt.Text = "";
            customerAdressTxt.Text = "";
        }
        void CustomerDoubleClick()
        {
            try
            {
                customerAddButton.Enabled = false;
                DataGridViewRow dataGridViewRow = customerGridView.SelectedRows[0];
                customerIdTxt.Text = dataGridViewRow.Cells[0].Value.ToString();
                customerNameTxt.Text = dataGridViewRow.Cells[1].Value.ToString();
                customerSurnameTxt.Text = dataGridViewRow.Cells[2].Value.ToString();
                customerSokTxt.Text = dataGridViewRow.Cells[3].Value.ToString();
                customerMahTxt.Text = dataGridViewRow.Cells[4].Value.ToString();
                customerIlTxt.Text = dataGridViewRow.Cells[5].Value.ToString();
                customerIlceTxt.Text = dataGridViewRow.Cells[6].Value.ToString();
                customerAdressTxt.Text = dataGridViewRow.Cells[7].Value.ToString();
                customerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
        //CarsMethods
        void AddCarButtonFunction()
        {
            car = new Cars();
            carIdTxt.Text = carGridView.Rows.Count.ToString();
            addCarsPanel.Visible = true;
            rentedCarsPanel.Visible = false;
            customerPanel.Visible = false;
            TodayTakingBackPanel.Visible = false;
            allRentedCarsPanel.Visible = false;
            carGridView.DataSource = car.Write();
        }
        void AddCarsFunction()
        {
            carIdTxt.Text = carGridView.Rows.Count.ToString();
            car = new Cars();
            car.CarId = carGridView.Rows.Count;
            car.CarClass = carClassCBox.SelectedItem.ToString();
            car.CarBrand = carBrandTxt.Text;
            car.CarModel = carModelTxt.Text;
            car.CarAge = int.Parse(carAgeCBox.SelectedItem.ToString());
            car.CarPrice = int.Parse(carPriceTxt.Text);
            car.Add();
            carGridView.DataSource = car.Write();
            CleanCarsTextFunction();
        }
        void DeleteCarsFunction()
        {
            try
            {
                car = new Cars();
                int selected = carGridView.SelectedRows[0].Index;
                int key = int.Parse(carGridView[0, selected].Value.ToString());
                car.Key = key;
                car.Delete();
                carGridView.DataSource = car.Write();
                CleanCarsTextFunction(); 
            }
            catch (ArgumentOutOfRangeException)
            { 
                MessageBox.Show("Yazi alanlari doluyken silme islemi gerceklestirilemez.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.None);
                CleanCarsTextFunction();
            }
        }
        void UpdateCarsFunction()
        {
            carAddButton.Enabled = true;
            car = new Cars();
            car.CarId = int.Parse(carIdTxt.Text);
            car.CarClass = carClassCBox.SelectedItem.ToString();
            car.CarBrand = carBrandTxt.Text;
            car.CarModel = carModelTxt.Text;
            car.CarAge = int.Parse(carAgeCBox.SelectedItem.ToString());
            car.CarPrice = int.Parse(carPriceTxt.Text);
            car.Update();
            carGridView.DataSource = car.Write();
            CleanCarsTextFunction();
        }
        void CleanCarsTextFunction()
        {
            carAddButton.Enabled = true;
            carIdTxt.Text = carGridView.Rows.Count.ToString();
            carClassCBox.SelectedItem = "";
            carBrandTxt.Text = "";
            carModelTxt.Text = "";
            carAgeCBox.SelectedItem = "";
            carPriceTxt.Text = "";
        }
        void CarsDoubleClick()
        {
            try
            {
                carAddButton.Enabled = false;
                DataGridViewRow dataGridViewRow = carGridView.SelectedRows[0];
                carIdTxt.Text = dataGridViewRow.Cells[0].Value.ToString();
                carClassCBox.SelectedItem = dataGridViewRow.Cells[1].Value.ToString();
                carBrandTxt.Text = dataGridViewRow.Cells[2].Value.ToString();
                carModelTxt.Text = dataGridViewRow.Cells[3].Value.ToString();
                carAgeCBox.SelectedItem = dataGridViewRow.Cells[4].Value.ToString();
                carPriceTxt.Text = dataGridViewRow.Cells[5].Value.ToString();
                carGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
        //Rentedcars Methods
        void RentedCarsButtonFunction()
        {
            rentedCarsPanel.Visible = true;
            customerPanel.Visible = false;
            addCarsPanel.Visible = false;
            TodayTakingBackPanel.Visible = false;
            allRentedCarsPanel.Visible = false;
            rentedCars = new RentedCars();
            rentedCarsGridView.DataSource = rentedCars.Write();
            if (userDepartmentLabel.Text == "Sef")
                rentDeleteButton.Visible = true;
        }
        void DeleteRentedFunction()
        {
            try
            {
                rentedCars = new RentedCars();
                int selected = rentedCarsGridView.SelectedRows[0].Index;
                int key = Convert.ToInt32(rentedCarsGridView[0, selected].Value.ToString());
                rentedCars.Key = key;
                rentedCars.Delete();
                rentedCarsGridView.DataSource = rentedCars.Write();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("!!!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.None); }
        }
        //Rent Taking Back Methods
        void TakingBackButtonFunction()
        {
            rentTakingBack = new RentTakingBack();
            TodayTakingBackPanel.Visible = true;
            rentedCarsPanel.Visible = false;
            customerPanel.Visible = false;
            addCarsPanel.Visible = false;
            allRentedCarsPanel.Visible = false;
            if (int.Parse(DateTime.Now.Day.ToString()) > 10)
                rentTakingBack.TakingBack = DateTime.Today.ToShortDateString();
            else
                rentTakingBack.TakingBack = 0 + DateTime.Today.ToShortDateString();
            todayTakingBackDataGrid.DataSource = rentTakingBack.Write();
        }
        void takeBackButtonFunction()
        {
            rentTakingBack = new RentTakingBack();
            int selected = todayTakingBackDataGrid.SelectedRows[0].Index;
            int key = Convert.ToInt32(todayTakingBackDataGrid[0, selected].Value.ToString());
            rentTakingBack.Key = key;
            rentTakingBack.Update();
            todayTakingBackDataGrid.DataSource = rentTakingBack.Write();
        }
        //All Rented Cars Methods
        void AllRentedCarsButtonFunction()
        {
            allRentedCarsPanel.Visible = true;
            rentedCarsPanel.Visible = false;
            customerPanel.Visible = false;
            addCarsPanel.Visible = false;
            TodayTakingBackPanel.Visible = false;
            allRentedCars = new AllRentedCars();
            allRentedCarsDataGrid.DataSource = allRentedCars.Write();
        }
        //Close Rent form Method
        void ExitButtonFunction()
        {
            this.Dispose();
        }
        //Minimize Rent form Method
        void minimizeButtonFunction()
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
