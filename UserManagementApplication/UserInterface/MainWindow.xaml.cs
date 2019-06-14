﻿using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using Common.Repository.Application;
using DataAccess.Context;
using DataAccess.ViewModels;
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
using UserManagementApplication.UserInterface;

namespace UserManagementApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ILoginService iLoginService = new LoginService();
        MyContext myContext = new MyContext();

        public MainWindow()
        {
            InitializeComponent();
            init_data();
        }

        private void init_data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txt_email.Text = Properties.Settings.Default.UserName;
                    txt_password.Password = Properties.Settings.Default.Password;
                    checkRememer.IsChecked = true;
                }
                else
                {
                    txt_email.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void save_data()
        {
            if (checkRememer.IsChecked == true)
            {
                Properties.Settings.Default.UserName = txt_email.Text;
                Properties.Settings.Default.Password = txt_password.Password;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txt_email.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }

        public void Login()
        {
            ILoginService login = new LoginService();
            if (login.CekLogin(txt_email.Text, txt_password.Password) == true)
            {
                MessageBox.Show("Login Success", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                DashBoard dashboard = new DashBoard();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Fail", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                txt_password.Clear();
                txt_password.Focus();
            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            Login();
            save_data();
        }

        private void Forgot_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ForgetPassword ForgetPassword = new ForgetPassword();
            ForgetPassword.Show();
            this.Hide();
        }
    }
}
