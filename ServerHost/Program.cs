using System;
using System.Globalization;
using System.ServiceModel;
using BLogic;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var host = new ServiceHost(typeof(BuisnessLogic)))
                {
                    host.Open();

                    Console.WriteLine($"Хост запущен");

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+e.StackTrace+e.InnerException?.Message);
            }
            Console.ReadLine();
        }
    }
}
