using System;
using System.Collections;
namespace Dictionaries
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee ("Ceo", "Sercan", 24,200),
                new Employee ("Manager", "Ercan", 24,200),
                new Employee ("Hr", "Mami", 27,120),
                new Employee ("Secretary", "Ali", 26,100),
                new Employee ("Lead Developer", "Mert", 23,100),
                new Employee ("Intern","Ernest",20,10),
            };

            /*Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"}
            };*/

            Dictionary<string, Employee> employeesDirectoryy = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectoryy.Add (emp.Role, emp);
            }
            string KeyToUpdate = "HR";
            if (employeesDirectoryy.ConstainsKey(KeyToUpdate))
            {
                employeesDirectory
            }
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee> ();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // numarasını yazdığın employee i dictionaryden çekmek
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue);
            }

            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", key);
            }
            // Rolünü yazdığın employee i dictionaryden çekmek
            Employee result = null;
            if ( employeesDirectory.TryGetValue("Intern", out result) ) 
            {
                Console.WriteLine("Value retrieved.");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }
           
        }
    }
    class Employee
    {
        //properties
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        // yearly salary = rate * hours worked * weekdays * weeks * months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        //Simple Constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
