using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.DAL;

namespace Northwind.WinUI.Forms.FormEmployees
{
    public partial class FormListEmployees : Form
    {
        public FormListEmployees()
        {
            InitializeComponent();
        }
        EmployeeManagement employeeManagement = new EmployeeManagement();
        private void FormListEmployees_Load(object sender, EventArgs e)
        {
            employeeManagement.GetEmployees();
        }
    }
}
