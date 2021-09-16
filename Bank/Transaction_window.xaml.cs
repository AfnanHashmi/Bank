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

namespace Bank
{
    /// <summary>
    /// Interaction logic for Transaction_window.xaml
    /// </summary>
    public partial class Transaction_window : Window
    {
        private bankaccount _accountdetails;
        public Transaction_window(bankaccount accnt)
        {
            InitializeComponent();
            _accountdetails = accnt;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button.Content == "Withdraw")
            {
                double AmountToBeWithdrawn = double.Parse(amount.Text);
                _accountdetails.MakeWithdrawal(AmountToBeWithdrawn);
                MessageBox.Show($"Withdrawal Succesfull\nBalance = {_accountdetails.Balance}");
                foreach(Window win in Application.Current.Windows)
                {
                    if (win.GetType() == typeof(Window1))
                    {
                        win.Close();
                        Window1 alwin = new Window1(_accountdetails);
                        alwin.balance.Text = _accountdetails.Balance.ToString();
                        alwin.Show();
                    }
                }
            }
            if ((string)Button.Content == "Deposit")
            {
                double AmountToBeWithdrawn = double.Parse(amount.Text);
                _accountdetails.MakeDiposit(AmountToBeWithdrawn);
                MessageBox.Show($"Deposit Succesfull\nBalance = {_accountdetails.Balance}");
                foreach (Window win in Application.Current.Windows)
                {
                    if (win.GetType() == typeof(Window1))
                    {
                        win.Close();
                        Window1 alwin = new Window1(_accountdetails);
                        alwin.balance.Text = _accountdetails.Balance.ToString();
                        alwin.Show();
                    }
                }
            }
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
