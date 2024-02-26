
using HomeWork_26._02._2024.Models;

namespace HomeWork_26._02._2024.Services
{
    internal class EmployeeServices : Employee
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                id = 1,
                name = "employee1",
                surname = "emplpoyev1",
                address = "aaddress1",
                email = "email1@gmail.com",
                age = 30
            };
            Employee employee2 = new()
            {
                id = 2,
                name = "employee2",
                surname = "emplpoyev2",
                address = "aaddress2",
                email = "email2@gmail.com",
                age = 24
            };
            Employee employee3 = new()
            {
                id = 3,
                name = "employee3",
                surname = "emplpoyev3",
                address = "aaddress3",
                email = "email3@gmail.com",
                age = 36
            };
            Employee employee4 = new()
            {
                id = 4,
                name = "employee4",
                surname = "emplpoyev4",
                address = "aaddress4",
                email = "email4@gmail.com",
                age = 44
            };
            Employee employee5 = new()
            {
                id = 5,
                name = "employee5",
                surname = "emplpoyev5",
                address = "aaddress5",
                email = "email5@gmail.com",
                age = 51
            };
            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };
            return employees;
        }

        public Employee[] GetAllByAge(Employee[] employees, int age)
        {
            return employees.Where(m=>m.age > age).ToArray();
        }

        public int GetCountByAge(Employee[] employees,int firstAge, int lastAge)
        {
            return employees.Where(m=> m.age > firstAge && m.age < lastAge).Count();
        }

        public int SumOfAges(Employee[] employees)
        {
            return employees.Sum(m=> m.age);
        }

        public Employee[] GetAllByEmail(Employee[] employees, string str)
        {
            return employees.Where(m=> m.email.StartsWith(str)).ToArray();
        }
    }
}
