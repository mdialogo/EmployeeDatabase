using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EmployeeDatabase.Controllers;

namespace EmployeeDatabase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Employee employeeView = new Employee();
            EmployeeController employeeController = new EmployeeController(employeeView);

            employeeController.LoadEmployeeView();
            Application.Run(employeeView);
        }
    }
}
