using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Testes1.Model;

namespace Testes1.Infraestrutura
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        void IEmployeeRepository.Add(Employee employee)
        {
           _context.Employees.Add(employee);
           _context.SaveChanges();
        }
        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }
    }
}