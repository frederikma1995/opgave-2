using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse2
{
    class Program
    {
        static void Main(string[] args)
        { int subtotal = 0;
            int i=1;
            int[] price = new int[3];
            int[] quantity = new int[3];
            Indkøb(i, price, quantity);
            for (int j = 0; j < 3; j++)
            {
                subtotal += price[j] * quantity[j];
            }
            Math(subtotal);

            Console.ReadLine();



        }

       static public void Indkøb(int i,int[] price, int[] quantity)
        {
            for (i = 0; i < 3; i++)
            {

                Console.Write("Enter the price of item {0}: ", i+1);
                price[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the quantity of item {0}: ", i+1);
                quantity[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        static public void Math(int subtotal)
        {
            Console.WriteLine("Subtotal: $" + subtotal);
            var tax = ((subtotal * 5.5) / 100);
            Console.WriteLine("Tax: $" + tax);
            var total = subtotal + tax;
            Console.WriteLine("Total: $" + total);
        }
    }
}
