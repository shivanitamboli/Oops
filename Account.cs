using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    public class Account
    {

            private double balance;
            public double GetBalance()
            {
                return balance;

            }


            public double SetBalance(double amount)
            {
                if (amount > 0)
                {
                    balance = +amount;
                    return balance;
                }

                else
                {
                    Console.WriteLine("pls pass value");
                    return balance;
                }

            }

            public void BalanceDetails()
            {
                Console.WriteLine("acc bal=" + balance);
            }


        }


    }






