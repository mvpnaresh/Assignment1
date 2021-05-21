using Assignment1.Implementation;
using Assignment1.Implementation.Orders;
using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Order order = new PhysicalProductOrder();

            var orderProcessingSteps = order.ProcessOrder();

            foreach (var item in orderProcessingSteps)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();



        }
    }
}
