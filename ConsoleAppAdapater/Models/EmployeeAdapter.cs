using ConsoleAppAdapater.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAdapater.Models
{
    public class EmployeeAdapter : IWerknemer
    {
        private IEmployee _employee;

        public EmployeeAdapter(IEmployee employee)
        {
            _employee = employee;
        }

        public void BetaalSalaris()
        {
            _employee.PaySalary();
        }

        public string VolledigeNaam()
        {
            return _employee.FullName(); 
        }
    }
}
