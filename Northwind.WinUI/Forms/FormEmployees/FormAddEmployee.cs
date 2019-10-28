using Northwind.BLL;
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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }
        EmployeeController employeeController = new EmployeeController();
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeController.GetEmployees();
            cmbReportsToList.DataSource = employees; ;
            cmbReportsToList.DisplayMember = "NameWithTitle";
            cmbReportsToList.ValueMember = "EmployeeID";
        }
    }
}
