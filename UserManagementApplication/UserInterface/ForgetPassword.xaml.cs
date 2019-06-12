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
    }
}
