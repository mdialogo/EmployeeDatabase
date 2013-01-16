using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeDatabase.Controllers;

namespace EmployeeDatabase
{
    public partial class Employee : Form, IEmployee
    {
        private EmployeeController _employeeController;

        public Employee()
        {
            InitializeComponent();
        }

        #region IEmployee implementation
        public void SetController(EmployeeController controller)
        {
            _employeeController = controller;
        }

        public void SetupGrid(object src)
        {
            //this.employeeBindingSource.DataSource = src;
            this.gridEmployee.DataSource = src;
        }
        #endregion
    }
}
