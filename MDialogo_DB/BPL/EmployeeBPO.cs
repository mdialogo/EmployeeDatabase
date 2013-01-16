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
        public List<HR_Employee> GetAllEmployees()
        {
            EmployeeDAO dao = new EmployeeDAO();
            return dao.GetAllEmployees();
        }
    }
}
