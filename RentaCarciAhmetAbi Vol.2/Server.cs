using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCarciAhmetAbi_Vol._2
{
    class Server
    {
        public SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = RentACar; Integrated Security = True");
        public SqlCommand cmd;
        public SqlDataAdapter sqlDataAdapter;
        public SqlDataReader sqlDataReader;
        public DataTable dataTable;
        public DataSet dataSet;
        public void Open() { con.Open(); }
        public void Close() { con.Close(); }
    }
    class Login
    {
        Server server;
        public string User { get; set; }
        public int Password { get; set; }
        public bool TrueorFalse { get; set; }
        public void UserLogin()
        {
            server = new Server();
            server.con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = RentACar; Integrated Security = True");
            server.Open();
            server.cmd = new SqlCommand("select * from employes where employee_name='" + User + "'and employee_password='" + Password + "'", server.con);
            server.sqlDataReader = server.cmd.ExecuteReader();
            if (server.sqlDataReader.Read())
                TrueorFalse = true;
            else
                TrueorFalse = false;
            server.Close();
        }
    }
   
    class User
    {
        RentACar rent;
        Server server;
        public string UserName { get; set; } 
        public int Password { get; set; }
        public int UserIdLabel { get; set; }
        public string UserNameLabel { get; set; }
        public string UserSurnameLabel { get; set; }
        public string UserDepartmentLabel { get; set; }
        public void UserWrite()
        {
            rent = new RentACar();
            server = new Server();
            server.Open();
            server.sqlDataAdapter = new SqlDataAdapter("select * from employes where employee_name= '" + UserName + "' and employee_password= '" + Password + "'", server.con);
            server.dataSet = new DataSet();
            server.sqlDataAdapter.Fill(server.dataSet, "employes");
            if(server.dataSet.Tables[0].Rows.Count > 0)
            {
                UserIdLabel =Convert.ToInt32(server.dataSet.Tables[0].Rows[0]["employee_id"]);
                UserNameLabel = server.dataSet.Tables[0].Rows[0]["employee_name"].ToString();
                UserSurnameLabel = server.dataSet.Tables[0].Rows[0]["employee_surname"].ToString();
                UserDepartmentLabel = server.dataSet.Tables[0].Rows[0]["department"].ToString();
            }
            server.Close();
            rent.EmployeeId = UserIdLabel;
        }
    }

    class RentACar
    {

        Server server;
        public int RentedId { get; set; }
        public int CarId { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public string GDate { get; set; }
        public string TDate { get; set; }
        public string PaymentType { get; set; } = "Nakit";
        public int RentPrice { get; set; }
        public string CarClass { get; set; }
        public DataTable CustomersRentWrite()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select customer_id, customer_name, customer_surname from customers order by customer_id desc", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public DataTable CarsRentWrite()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select * from cars order by car_id desc", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public DataTable RentCarQuery()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select * from cars where car_class like'"+ CarClass +"'" , server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public void Add()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Insert into rented_cars values('" + RentedId + "','" + CarId + "','" + EmployeeId + "','" + CustomerId + "','" + GDate + "','" + TDate + "','" + PaymentType + "','" + RentPrice + "','"+ "Musteride" +"')", server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
    }
    class Customer
    {
        Server server;
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Surname { get; set; }
        public string Sokak { get; set; }
        public string Mahalle { get; set; }
        public string Ilce { get; set; }
        public string Il { get;  set; }
        public string Adress { get; set; }
        public int Key { get; set; }
        public DataTable Write()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("select * from customers order by customer_id desc", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public void Add()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Insert into customers values(" + CustomerId + ",'" + CustomerName + "','" + Surname + "','" + Sokak + "','" + Mahalle + "','" + Ilce + "','" + Il + "','" + Adress + "')", server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
        public void Delete()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Delete from customers where customer_id like'" + Key + "'", server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
        public void Update()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Update customers set customer_name='" + CustomerName + "', customer_surname='" + Surname + "',adress_sok='" + Sokak + "',adress_mah='" + Mahalle + "',adress_ilce='" + Ilce + "',adress_il='" + Il + "',adress_note='" + Adress + "' where customer_id=" + CustomerId , server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
    }
    class Cars
    {
        Server server;
        public int CarId { get; set; }
        public string CarClass { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarAge { get; set; }
        public int CarPrice { get; set; }
        public int Key { get; set; }
        public DataTable Write()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select * from cars order by car_id desc", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public void Add()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Insert into cars values(" + CarId + ",'" + CarClass + "','" + CarBrand + "','" + CarModel + "','" + CarAge + "','" + CarPrice + "')", server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
        public void Delete()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Delete from cars where car_id like'" + Key + "'", server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
        public void Update()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Update cars set car_class='" + CarClass + "',car_brand='" + CarBrand + "',car_model='" + CarModel + "',car_age='" + CarAge + "',car_price='" + CarPrice + "' where car_id=" + CarId, server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
    }
    class RentedCars
    {
        Server server;
        public int Key { get; set; }
        public DataTable Write()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select * from rented_cars where durumu like'" + "Musteride" + "'", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public void Delete()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Delete from rented_cars where rented_id like'" + Key + "'", server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
    }

    class RentTakingBack
    {
        Server server;
        public string TakingBack { get; set; }
        public int Key { get; set; }
        public DataTable Write()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select * from rented_cars where t_date like'" + TakingBack + "'and durumu like'" + "Musteride" + "'", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
        public void Update()
        {
            server = new Server();
            server.Open();
            server.cmd = new SqlCommand("Update rented_cars set durumu='" + "Tamamlandi" + "' where rented_id=" + Key , server.con);
            server.cmd.ExecuteNonQuery();
            server.Close();
        }
    }
    class AllRentedCars
    {
        Server server;
        public DataTable Write()
        {
            server = new Server();
            server.sqlDataAdapter = new SqlDataAdapter("Select * from rented_cars", server.con);
            server.dataTable = new DataTable();
            server.sqlDataAdapter.Fill(server.dataTable);
            return server.dataTable;
        }
    }
}
