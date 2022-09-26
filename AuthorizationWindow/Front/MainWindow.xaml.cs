using AuthorizationWindow.Core;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuthorizationWindow
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

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            if (user.CheckingUser(LoginFromUser.Text, PasswordFromUser.Text))
            {
                MessageBox.Show("Authorization was successful", "Authorization", MessageBoxButton.OK, MessageBoxImage.Information);
                LoginFromUser.Text = "";
                PasswordFromUser.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid login or password", "Authorization", MessageBoxButton.OK, MessageBoxImage.Warning);
                LoginFromUser.Text = "";
                PasswordFromUser.Text = "";
            }
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string PasswordOfUSer;

        //    if(PasswordFromUser.Text.StartsWith = "#")

        //    if (Convert.ToString(ShowOrHideButton.Content) == "Скрыть пароль")
        //    {
        //        int numOfPoints = PasswordFromUser.Text.Length;
        //        PasswordOfUSer = PasswordFromUser.Text;
        //        PasswordFromUser.Text = "";
        //        for (int i = 0; i < numOfPoints; i++)
        //        {
        //            PasswordFromUser.Text += "#";   //Как сделать жирную точку?
        //        }
        //        ShowOrHideButton.Content = "Показать пароль";
        //    }
        //    else
        //    {
        //        PasswordFromUser.Text = PasswordOfUSer;
        //    }
        //}
    }
}
