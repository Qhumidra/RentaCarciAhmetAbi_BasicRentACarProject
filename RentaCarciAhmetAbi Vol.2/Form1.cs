﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Clean()
        {
            userName_txtbox.Text = "";
            password_txtbox.Text = "";
        }
        Rent rent = new Rent();
        Login login = new Login();
        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                rent.User = userName_txtbox.Text;
                rent.Password = int.Parse(password_txtbox.Text);
                login.User = userName_txtbox.Text;
                login.Password = int.Parse(password_txtbox.Text);
                login.UserLogin();
                bool trueorfalse = login.TrueorFalse;
                if (trueorfalse == true)
                {
                    rent.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya sifre hatali", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clean();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Kullanici adi veya sifre hatali", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clean();
            }
        }
    }
}
