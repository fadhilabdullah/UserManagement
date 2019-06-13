using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.ViewModels;
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

namespace UserManagementApplication.UserInterface
{
    /// <summary>
    /// Interaction logic for UserManagement.xaml
    /// </summary>
    public partial class InputUser : UserControl
    {
        IUserService iUserService = new UserService();

        UserVM userVM = new UserVM();
        public InputUser()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            bool result;
            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                var UserParam = new UserVM(txt_Password.Text, txt_ConfirmPassword.Text);
                result = iUserService.Insert(UserParam);
                MessageBox.Show(result ? "Insert Succesfully" : "Insert Failed");
            }           
        }
    }
}
