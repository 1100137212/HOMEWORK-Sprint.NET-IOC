
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao :IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees =new  List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "Gin";
            employees1.Name = "小俊";
            employees1.Age = 22;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Chin";
            employees2.Name = "小慶";
            employees2.Age = 22;
            employees.Add(employees2);


            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id="1100137212";
            employees.Name="林俊慶";
            employees.Age=22;
            return employees;
        }

    }
}
