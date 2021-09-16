using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.VisualBasic;

namespace Bank
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        bankaccount _accountdetails;
        public Window1(bankaccount accountdetails)
        {
            InitializeComponent();
            _accountdetails = accountdetails;
        }

        private void withdraw_Click(object sender, RoutedEventArgs e)
        {
            Transaction_window win = new Transaction_window(_accountdetails);
            win.Button.Content = "Withdraw";
            win.Show();
        }

        private void deposit_Click(object sender, RoutedEventArgs e)
        {
            Transaction_window win = new Transaction_window(_accountdetails);
            win.Button.Content = "Deposit";
            win.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Name.Text = _accountdetails.Name;
            DOB.Text = _accountdetails.DOB.Date.ToString("dd/MM/yyyy");
            phnumber.Text = _accountdetails.PhoneNumber;
            gender.Text = _accountdetails.Gender;
            address.Text = _accountdetails.Address;
            acctnum.Text = _accountdetails.AccountNumber.ToString();
            balance.Text = _accountdetails.Balance.ToString();
        }
    }
}
