using ExercicioCSharpHeranca1.Entities;
using System.Globalization;

namespace ExercicioCSharpHeranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y' |  outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourceEmployee(name, hours, valuePerHours, additionalCharge);
                    list.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHours);
                    list.Add(employee);
                }
            }
            Console.WriteLine("PAYMENTS: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}