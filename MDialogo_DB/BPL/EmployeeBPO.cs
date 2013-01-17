using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDialogo_DB.Data;
using MDialogo_DB.DAL;

namespace MDialogo_DB.BPL
{
    public class EmployeeBPO
    {
        private EmployeeDAO dao = new EmployeeDAO();

        public List<HR_Employee> GetAllEmployees()
        {
            return dao.GetAllEmployees();
        }

        public bool CommitChangesToDB()
        {
            return dao.Commit();
        }
    }
}
