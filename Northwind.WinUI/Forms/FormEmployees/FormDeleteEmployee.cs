using Northwind.BLL;
using Northwind.DAL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms.FormEmployees
{
    public partial class FormDeleteEmployee : Form
    {
        public FormDeleteEmployee()
        {
            InitializeComponent();
        }
        EmployeeController employeeController = new EmployeeController();
        private void FormDeleteEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeController.GetEmployees();
            cmbEmployeeList.DataSource = employees;
            cmbEmployeeList.DisplayMember = "NameWithTitle";
            cmbEmployeeList.ValueMember = "EmployeeID";
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeID = Convert.ToInt32(cmbEmployeeList.SelectedValue);
            employee.BirthDate = DateTime.Now;
            employee.HireDate = DateTime.Now;

            bool isDeleted = employeeController.DeleteEmployee(employee);
            if (isDeleted)
            {
                MessageBox.Show("Successfully Deleted");
                cmbEmployeeList.Items.Remove(employee.EmployeeID);
                cmbEmployeeList.DataSource = employeeController.GetEmployees();
            }
        }
    }
}
