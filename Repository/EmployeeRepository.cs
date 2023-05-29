using Big_Bang_Assessment_1.Model;
using Microsoft.EntityFrameworkCore;

namespace Big_Bang_Assessment_1.Repository
{
    public class EmployeeRepository :IEmployee
    {
        private readonly HotelDbcontext _context;

        public EmployeeRepository(HotelDbcontext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeesById(int EmployeeId)
        {
            return _context.Employees.Find(EmployeeId);
        }

        public Employee PostEmployee(Employee employee)
        {
            var hotel = _context.Hotels.Find(employee.Hotel.HotelId);
            employee.Hotel = hotel;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }


        public Employee PutEmployee(int EmployeeId, Employee employee)
        {
            var emp = _context.Hotels.Find(employee.Hotel.HotelId);
            employee.Hotel = emp;

            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();

            return employee;
        }




        public Employee DeleteEmployee(int EmployeeId)
        {
            var employee = _context.Employees.Find(EmployeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }
    }
}
