using HandsOnMVCUsingViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingViewModel.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _empList;

        public EmployeeRepository()
        {
            _empList = new List<Employee>()
            {
                new Employee() { Eid=1, Ename="Aiswarya", Pid="P001"},
                new Employee() { Eid=1, Ename="Abhishek", Pid="P002"},
                new Employee() { Eid=1, Ename="Lalitha", Pid="P003"},
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _empList;
        }

        public Employee GetEmpById(int id)
        {
            Employee emp = _empList.FirstOrDefault(e => e.Eid == id);
            return emp;
        }
    }
}
