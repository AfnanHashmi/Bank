using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bankaccount accnt = new bankaccount();


        private void submit_Click(object sender, RoutedEventArgs e)
        {
            bool name = Name.Text.Length != 0;
            bool add = address.Text.Length != 0;
            bool phone = phnumber.Text.Length == 10;
            bool date = DOB.SelectedDate.HasValue == true;
            List<bool> bools = new List<bool> { name, add, phone, date };
            if (name && phone && add && date)
            {

                accnt.Name = Name.Text;
                accnt.PhoneNumber = phnumber.Text;
                accnt.Address = address.Text;
                accnt.DOB = (DateTime)DOB.SelectedDate;
                accnt.Gender = (string)((ComboBoxItem)gender.SelectedValue).Content;
                string content = $"your generated account number is {accnt.AccountNumber}";
                MessageBox.Show(content);
                acctnum.Text = accnt.AccountNumber.ToString();
                confirm.IsEnabled = true;
            }
            else
            {
                MessageBox.Show($"Pls fill All fields correctly\n1.Check If you have left any filed missing\n2.Phone Number must be 10 of digits");
            }

            
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        { 
            accnt.Balance = Double.Parse(initial.Text);
            MessageBox.Show($"Account with number {accnt.AccountNumber} is created\nBalance = {accnt.Balance}");
            Window1 win = new Window1(accnt);
            win.Show();
            Close();
        }

        private void phnumber_KeyDown(object sender, KeyEventArgs e)
        {
            bool isalpha = e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            bool isnum = e.Key >= Key.D0 && e.Key <= Key.D9;
            if (isalpha || isnum)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

    }
}
