using ConsoleAppAdapater.Models.Interfaces;

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
