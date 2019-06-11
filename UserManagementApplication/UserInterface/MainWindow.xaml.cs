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
using UserManagementApplication.UserInterface;

namespace UserManagementApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
                    txt_email.Text = Properties.Settings.Default.Password;
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
                Properties.Settings.Default.Password = txt_email.Text;
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

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Forgot_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ForgetPassword calling = new ForgetPassword();
            calling.ShowDialog();
        }
    }
}
