namespace WS_8_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] myEmployees = new Employee[5];


           PartTimeEmployee employee = new PartTimeEmployee();

            myEmployees[0] = employee;

            employee.Name = "una";
            employee.Gender = "female";
            employee.HourlyRate = 50;
            employee.HoursWorked = 10;

            
  


            PartTimeEmployee employee2 = 
                new PartTimeEmployee("Viv","Male", 10.50, 30);

            Console.WriteLine(employee2.CalcPay());

            myEmployees[1] = employee2;

            Employee employee3 =
                new Employee("Sue", "Male", 10.50);

            Employee employee4 =
                new Employee("Jim", "Male", 15.50);

            Employee employee5 =
                new Employee("Mike", "Male", 9.50);

            myEmployees[2] = employee3;
            myEmployees[3] = employee4;
            myEmployees[4] = employee5;


            for (int i = 0; i < myEmployees.Length; i++)
            {
                Console.WriteLine($" Employee {myEmployees[i].Name} is paid {myEmployees[i].CalcPay()}");

                
            }

            for (int i = 0; i < myEmployees.Length; i++)
            {
                Console.WriteLine(myEmployees[i]);
            }
        }
    }
}