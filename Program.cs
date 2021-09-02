using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ISPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == ISPresent)
                Console.WriteLine("prsent");
            else
                Console.WriteLine("Abs");
            Console.Read();
        }
    }
}
