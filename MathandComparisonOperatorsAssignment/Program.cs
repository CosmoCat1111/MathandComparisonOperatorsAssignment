using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //opening welcome
            Console.WriteLine("Welcome to the Anonymous Income Comparison Program");
            //requesting person1 info
            Console.WriteLine("Please enter Person 1 information:");
            Console.WriteLine("What is your hourly Rate?");
            String HrRate1 = Console.ReadLine();
            Console.WriteLine("What are your hours per week worked?");
            String HrsWeek1 = Console.ReadLine();
            //requesting person 2 info
            Console.WriteLine("Please enter Person 2 information:");
            Console.WriteLine("What is your hourly Rate?");
            String HrRate2 = Console.ReadLine();
            Console.WriteLine("What are your hours per week worked?");
            String HrsWeek2 = Console.ReadLine();
            //converting to yearly salary amounts
            int yearlySalary1 = Convert.ToInt32(HrRate1) * Convert.ToInt32(HrsWeek1) * 52;
            Console.ReadLine(); 
            int yearlySalary2 = Convert.ToInt32(HrRate2) * Convert.ToInt32(HrsWeek2) * 52;
            Console.ReadLine();
            //displaying what outcome of yearly salary is
            Console.WriteLine("The Yearly salary of Person 1 is: ");
            Console.WriteLine(yearlySalary1);
            Console.WriteLine("The Yearly salary of Person 2 is: ");
            Console.WriteLine(yearlySalary2);
            //using true or false to show if person1 makes more and displaying it
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool is1or2More = yearlySalary1 > yearlySalary2;
            Console.WriteLine(is1or2More);
            Console.ReadLine();

        }
    }
}
