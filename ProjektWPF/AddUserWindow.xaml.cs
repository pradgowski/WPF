﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public int id;
        public string name;
        public string surname;
        public string email;
        public Int64 phone;
        public string address;

        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void AddUserOk(object sender, RoutedEventArgs e)
        {
            long number;
            this.name = nameBox.Text;
            this.surname = surnameBox.Text;
            this.email = emailBox.Text;
            this.address = addressesComboBox.SelectedItem.ToString();
            if(Int64.TryParse(phoneBox.Text, out number) == false)
            {
                MessageBox.Show("Podaj prawidłowy numer telefonu");
            }
            else 
            {
                this.phone = number;
                DialogResult = true;
                this.Close();
            }
        }

        private void AddUserCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
