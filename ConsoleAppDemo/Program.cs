using System;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(new Order().getId());
            // Console.WriteLine(new Order().getId());
            // Console.WriteLine(new Order().getId());
            // new Order().Id = 999; // Forbidden!
            // Console.WriteLine(new Order().Id);
            // Console.WriteLine(new Order().Id);
            // Console.WriteLine(new Order().Id);
            
            // Console.WriteLine(new Order());
            // Console.WriteLine(new Order());
            // Console.WriteLine(new Order());
            
            // Console.WriteLine(new Order(1, 2, 190, new decimal(99.09)));
            // Console.WriteLine(new Order(1, 2, 190, new decimal(99.09)));
            // Console.WriteLine(new Order(1, 2, 190, new decimal(99.09)));
            
            /* new Order(1, 2, 190, new decimal(99.09))
                .PrintInfo(() => Console.WriteLine("Test")); */

            new Order(1, 2, 190, new decimal(99.09))
                .PrintInfo(order => Console.WriteLine($"Id = {order.Id}, ProductId = {order.ProductId}"));
        }
    }
}