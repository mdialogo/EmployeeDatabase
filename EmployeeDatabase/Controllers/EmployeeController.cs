using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDialogo_DB.BPL;

namespace EmployeeDatabase.Controllers
{
    public class EmployeeController
    {
        private IEmployee _employeeView;

        public EmployeeController(IEmployee view)
        {
            _employeeView = view;
            _employeeView.SetController(this);
        }

        public void LoadEmployeeView()
        {
            EmployeeBPO bpo = new EmployeeBPO();
            _employeeView.SetupGrid(bpo.GetAllEmployees());
        }
    }
}
