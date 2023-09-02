using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Activity__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter the Amount of the Bill");
            amount = Convert.ToInt32((Console.ReadLine()));
            if (amount >= 10000)
            {
                float discount1;
                discount1 = amount * 8 / 100;
                Console.WriteLine("discount price :"+discount1);

                float discount_amount1;
                discount_amount1 = amount - discount1;
                Console.WriteLine("your discounted amount will be: "+discount_amount1);
            }
            else if (amount >= 8000)
            {
                float discount2;
                discount2 = amount * 5 / 100;
                Console.WriteLine("discount price :" + discount2);

                float discount_amount2;
                discount_amount2 = amount - discount2;
                Console.WriteLine("your discounted amount will be: "+ discount_amount2);
            }
            else if (amount >= 5000)
            {
                float discount3;
                discount3 = amount * 2 / 100;
                Console.WriteLine("discount price :" + discount3);

                float discount_amount3;
                discount_amount3 = amount - discount3;
                Console.WriteLine("your discounted amount will be: "+ discount_amount3);  
            }
            else
            {
                Console.WriteLine("No discount.. you final bill price is : "+amount);
            }



            Console.ReadKey();












        }
    }
}
