using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    class Ecncapsulation
    {
            static void Main(string[] args)
            {

                Account a = new Account();
                a.SetBalance(100.00);
                a.BalanceDetails();
                Console.ReadLine();
            }
        }

    }

