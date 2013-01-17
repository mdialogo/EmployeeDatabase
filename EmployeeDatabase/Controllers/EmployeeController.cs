using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDialogo_DB.BPL;
using System.Windows.Forms;

namespace EmployeeDatabase.Controllers
{
    public class EmployeeController
    {
        private IEmployee _employeeView;
        private EmployeeBPO bpo = new EmployeeBPO();

        public EmployeeController(IEmployee view)
        {
            _employeeView = view;

            _employeeView.SetController(this);
        }

        public void LoadEmployeeView()
        {
            _employeeView.SetupGrid(bpo.GetAllEmployees());
        }

        public void CommitChangesToDB()
        {
            bool success = bpo.CommitChangesToDB();
            if (success)
            {
                MessageBox.Show("Changes have been saved to database");
            }
        }
    }
}
