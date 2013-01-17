using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDialogo_DB.Data;
using MDialogo_DB.Properties;

namespace MDialogo_DB.DAL
{
    internal class EmployeeDAO
    {
        internal EmployeeDataContext EmployeeDB { get; set; }

        internal EmployeeDAO()
        {
            EmployeeDB = new EmployeeDataContext(Settings.Default.MDialogo_DBConnectionString2);
        }

        internal List<HR_Employee> GetAllEmployees()
        {
            var query = from e in EmployeeDB.HR_Employees
                        select e;
            return query.ToList();
        }

        internal bool Commit()
        {
            try
            {
                EmployeeDB.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
