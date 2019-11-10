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
    public partial class FormUpdateEmployee : Form
    {
        public FormUpdateEmployee()
        {
            InitializeComponent();
        }
        EmployeeController employeeController = new EmployeeController();
        List<Employee> employees;
        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            employees = employeeController.GetEmployees();

            cmbEmployeeList.DataSource = employeeController.GetEmployees();
            cmbEmployeeList.DisplayMember = "NameWithTitle";
            cmbEmployeeList.ValueMember = "EmployeeID";

            cmbReportsToList.DataSource = employees; ;
            cmbReportsToList.DisplayMember = "NameWithTitle";
            cmbReportsToList.ValueMember = "EmployeeID";
        }
        //Show Employee Detail
        private void btnShowEmployeeDetail_Click(object sender, EventArgs e)
        {
            
            foreach (var employee in employees)
            {
                if(employee.EmployeeID == Convert.ToInt32(cmbEmployeeList.SelectedValue))
                {
                    txtName.Text = employee.FirstName;
                    txtSurname.Text = employee.LastName;
                    txtTitle.Text = employee.Title;
                    txtTitleOfCourtesy.Text = employee.TitleOfCourtesy;
                    cmbReportsToList.SelectedValue = employee.ReportsTo;
                    txtExtension.Text = employee.Extension;
                    txtNotes.Text = employee.Notes;
                    txtAddress.Text = employee.Address;
                    txtCity.Text = employee.City;
                    txtRegion.Text = employee.Region;
                    txtPostalCode.Text = employee.PostalCode;
                    txtCountry.Text = employee.Country;
                    txtHomePhone.Text = employee.HomePhone;
                    dateBirth.Value = (DateTime)employee.BirthDate;
                    dateHire.Value = (DateTime)employee.HireDate;
                }
            }
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtTitle.Enabled = true;
            txtTitleOfCourtesy.Enabled = true;
            txtRegion.Enabled = true;
            cmbReportsToList.Enabled = true;
            txtExtension.Enabled = true;
            txtNotes.Enabled = true;
            txtAddress.Enabled = true;
            txtCity.Enabled = true;
            txtPostalCode.Enabled = true;
            txtCountry.Enabled = true;
            txtHomePhone.Enabled = true;
            dateBirth.Enabled = true;
            dateHire.Enabled = true;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
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
            employee.EmployeeID = Convert.ToInt32(cmbEmployeeList.SelectedValue);

            bool isUpdated = employeeController.UpdateEmployee(employee);
            if (isUpdated)
            {
                MessageBox.Show("Successfully Updated");
            }
        }
    }
}
