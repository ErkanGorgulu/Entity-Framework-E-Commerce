using Northwind.BLL;
using Northwind.DAL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms.FormEmployees
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }
        EmployeeController employeeController = new EmployeeController();
        SqlConnection sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeController.GetEmployees();
            cmbReportsToList.DataSource = employees; ;
            cmbReportsToList.DisplayMember = "NameWithTitle";
            cmbReportsToList.ValueMember = "EmployeeID";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtName.Text;
            employee.LastName = txtSurname.Text;
            employee.Title = txtTitle.Text;
            employee.TitleOfCourtesy = txtTitleOfCourtesy.Text;
            employee.BirthDate = (dateBirth.Value);
            employee.HireDate = (dateHire.Value);
            employee.Address = txtAddress.Text;
            employee.City = txtCity.Text;
            employee.Region = txtRegion.Text;
            employee.PostalCode = txtPostalCode.Text;
            employee.Country = txtCountry.Text;
            employee.HomePhone = txtHomePhone.Text;
            employee.Extension = txtExtension.Text;
            employee.Notes = txtNotes.Text;
            employee.ReportsTo = Convert.ToInt32(cmbReportsToList.SelectedValue);

            bool isAdded = employeeController.AddEmployee(employee);
            if (isAdded)
            {
                MessageBox.Show("Successfully Added");
            }
        }
    }
}
