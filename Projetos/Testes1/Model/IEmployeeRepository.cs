using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes1.Model
{
    public interface IEmployeeRepository
    {
        void add(Employee employee);

        List<Employee> Get();
    }
}