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

namespace AppHealth.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWnd.xaml
    /// </summary>
    public partial class LoginWnd : Window
    {
        public LoginWnd()
        {
            InitializeComponent();
            //LoginFrame.NavigationService.Navigate(new LoginPage());
        }

        private void btnRegistratio_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow RegWnd = new();
            RegWnd.Show();
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWnd = new();
            MainWnd.Show();
            Close();

        }
    }
}
