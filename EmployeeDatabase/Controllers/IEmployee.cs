using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeDatabase.Controllers;

namespace EmployeeDatabase.Controllers
{
    public interface IEmployee
    {
        void SetController(EmployeeController controller);
        void SetupGrid(object src);
    }
}
