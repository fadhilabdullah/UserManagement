using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.Context;
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
    /// Interaction logic for InputEmployee.xaml
    /// </summary>
    public partial class InputEmployee : UserControl
    {
        IEmployeeService iEmployeeService = new EmployeeService();
        IProvinceService iProvinceService = new ProvinceService();
        IRegencyService iRegencyService = new RegencyService();
        IDistrictService iDistrictService = new DistrictService();
        IVillageService iVillageService = new VillageService();
        IDepartmentService iDepartmentService = new DepartmentService();
        IPositionService iPositionService = new PositionService(); 

        EmployeeVM employeeVM = new EmployeeVM();

        public InputEmployee()
        {
            InitializeComponent();
            //GetData();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            bool result;
            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                var EmployeeParam = new EmployeeVM(txt_Nama.Text, txt_Address.Text ,cmb_Gender.Text, cmb_Relegion.Text, 
                    cmb_MartialStatus.Text, txt_PhoneNumber.Text, cmb_EmployeeStatus.Text, txt_Email.Text, 
                    Convert.ToDouble(txt_Salary.Text), Convert.ToInt32(cmb_NmDepartment.SelectedValue), 
                    Convert.ToInt32(cmb_Village.SelectedValue), Convert.ToInt32(cmb_Position.SelectedValue));
                result = iEmployeeService.Insert(EmployeeParam);
                MessageBox.Show(result ? "Insert Succesfully" : "Insert Failed");
            }
            else
            {
                employeeVM.Update(Convert.ToInt32(txt_Id.Text), txt_Nama.Text, txt_Address.Text, cmb_Gender.Text, cmb_Relegion.Text,
                    cmb_MartialStatus.Text, txt_PhoneNumber.Text, cmb_EmployeeStatus.Text, txt_Email.Text,
                    Convert.ToDouble(txt_Salary.Text), Convert.ToInt32(cmb_NmDepartment.SelectedValue),
                    Convert.ToInt32(cmb_Village.SelectedValue), Convert.ToInt32(cmb_Position.SelectedValue));
                result = iEmployeeService.Update(employeeVM.Id, employeeVM);
                MessageBox.Show(result ? "Edit Succesfully" : "Edit Failed");
            }
            txt_Nama.Text = "";
            txt_Address.Text = "";
            cmb_Gender.Text = "";
            cmb_Relegion.Text = "";
            cmb_MartialStatus.Text = "";
            txt_PhoneNumber.Text = "";
            cmb_EmployeeStatus.Text = "";
            txt_Email.Text = "";
            txt_Salary.Text = "";
            cmb_Position.Text = "";
            cmb_Province.Text = "";
            cmb_Regency.Text = "";
            cmb_District.Text = "";
            cmb_Village.Text = "";
            cmb_NmDepartment.Text = "";
            dtp_JoinDate.Text = "";
            //GetData();
        }

        private void GetData()
        {
            cmb_Province.ItemsSource = iProvinceService.Get();
            cmb_Regency.ItemsSource = iRegencyService.Get();
            cmb_District.ItemsSource = iDistrictService.Get();
            cmb_Village.ItemsSource = iVillageService.Get();
            cmb_Position.ItemsSource = iPositionService.Get();
            cmb_NmDepartment.ItemsSource = iDepartmentService.Get();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            txt_Nama.Text = "";
            txt_Address.Text = "";
            cmb_Gender.Text = "";
            cmb_Relegion.Text = "";
            cmb_MartialStatus.Text = "";
            txt_PhoneNumber.Text = "";
            cmb_EmployeeStatus.Text = "";
            txt_Email.Text = "";
            txt_Salary.Text = "";
            cmb_Position.Text = "";
            cmb_Province.Text = "";
            cmb_Regency.Text = "";
            cmb_District.Text = "";
            cmb_Village.Text = "";
            cmb_NmDepartment.Text = "";
            dtp_JoinDate.Text = "";
        }
    }
}
