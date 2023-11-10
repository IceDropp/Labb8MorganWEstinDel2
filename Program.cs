namespace Labb8MorganWEstinDel2
{
    using System;
    using System.Collections.Generic;

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Skapa en lista och lägg till objekt
            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= 5; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? 'F' : 'M',
                    Salary = 50000 + i * 10000
                };

                employeeList.Add(employee);
            }

            // Kolla om ett visst objekt finns i listan med Contains()-metoden
            Employee employeeToCheck = employeeList.Find(e => e.Id == 2);
            if (employeeList.Contains(employeeToCheck))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            // Använd Find()-metoden för att hitta och skriva ut det första objektet i listan med Gender = "Male"
            Employee maleEmployee = employeeList.Find(e => e.Gender == 'M');
            Console.WriteLine($"\nFirst Male Employee found: Id: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");

            // Använd FindAll()-metoden för att hitta och skriva ut alla objekt i listan med Gender = "Male"
            List<Employee> maleEmployees = employeeList.FindAll(e => e.Gender == 'M');
            Console.WriteLine("\nAll Male Employees:");
            foreach (var maleEmp in maleEmployees)
            {
                Console.WriteLine($"Id: {maleEmp.Id}, Name: {maleEmp.Name}, Gender: {maleEmp.Gender}, Salary: {maleEmp.Salary}");
            }
        }
    }
}