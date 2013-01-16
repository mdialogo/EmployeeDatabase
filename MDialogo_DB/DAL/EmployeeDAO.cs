using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDialogo_DB.Data;

namespace MDialogo_DB.DAL
{
    internal class EmployeeDAO
    {
        public EmployeeDataContext EmployeeDB { get; set; }

        public EmployeeDAO()
        {
            EmployeeDB = new EmployeeDataContext();
        }

        public List<HR_Employee> GetAllEmployees()
        {
            var query = from e in EmployeeDB.HR_Employees
                        select e;
            return query.ToList();
        }
    }
}
