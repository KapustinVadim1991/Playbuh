using System;
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

                    //BuisnessLogic buisnessLogic = new BuisnessLogic();

                    //var b = buisnessLogic.GetEmployees();

                    //foreach (var e in b)
                    //{
                    //    Console.WriteLine(e.FirstName);
                    //}

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
