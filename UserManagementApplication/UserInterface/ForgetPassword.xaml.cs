using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.Context;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Shapes;

namespace UserManagementApplication.UserInterface
{
    /// <summary>
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Window
    {
        ILoginService iLoginService = new LoginService();
        MyContext myContext = new MyContext();

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void img_Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
            Close();
        }

        private void img_Back_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow Login = new MainWindow();
            Login.Show();
            this.Hide();
        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            //int changed;
            //string loginemailid = txt_email.Text.Trim();
            //string oldpass = txt_PasswordOld.Password.Trim();
            //string newpass = txt_PasswordNew.Password.Trim();
            //string retypepass = txt_passwordReType.Password.Trim();


            //if (loginemailid != null && retypepass != null)
            //{
            //    changed = mydac.changeuserpassword(loginemailid, oldpass, newpass, retypepass);
            //    if (changed == 1)
            //    {
            //        MessageBox.Show("Your new Password Updated");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Updation Failed,Ensure Your Login Information Is Correct");
            //}
        }
    }
}
