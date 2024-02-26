
using HomeWork_26._02._2024.Helper.Constants;
using HomeWork_26._02._2024.Models;
using HomeWork_26._02._2024.Services;

namespace HomeWork_26._02._2024.Controllers
{
    internal class EmployeeController
    {
        private readonly EmployeeServices employeeServices;

        public EmployeeController()
        {
            employeeServices = new EmployeeServices();
        }
        public void GetAll()
        {
            var result = employeeServices.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname);
            }
        }

        public void GetAllByAge()
        {
            var result = employeeServices.GetAllByAge(employeeServices.GetAll(),30);

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.age);
            }
        }

        public void GetCountByAge()
        {
            Console.WriteLine("Add first age:");
            int firstAge = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Add last age:");
            int lastAge = int.Parse(Console.ReadLine());

            var result = employeeServices.GetCountByAge(employeeServices.GetAll(), firstAge, lastAge);
           
            Console.WriteLine(result);
        }
        public void GetSumOfAge()
        {
            int sumOfAge = employeeServices.SumOfAges(employeeServices.GetAll());
            Console.WriteLine(sumOfAge);
        }
        public void GetAllByEmail()
        {
            Console.WriteLine("Add your text");
            string str = Console.ReadLine();

            Employee[] employees = employeeServices.GetAll();

            Employee[] checkedEmployees = employeeServices.GetAllByEmail(employeeServices.GetAll(), str);

            if(checkedEmployees.Count() == 0)
            {
                Console.WriteLine(ResponseMessages.NotFound);
                return;
            }

            foreach(Employee employee in checkedEmployees)
            {
                Console.WriteLine(employee.email);
            }
        }
    }
}
