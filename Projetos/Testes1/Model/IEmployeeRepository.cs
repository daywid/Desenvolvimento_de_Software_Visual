using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes1.Model
{
    public interface IEmployeeRepository
    {
        public void Add(Employee employee);

        public List<Employee> Get();
    }
}