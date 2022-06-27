
using CourierSevice.Core.Contracts;
using PersonsAndCustomers;
using PersonsAndCustomers.interfacePersonsAndCustomers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourierSevice
{
    public class Engine : IEngine
    {
        public void Run()
        {

            while (true)
            {
                Console.WriteLine("========= Choice of 4 options =========");
                Console.WriteLine("----------1.   Add Worker    ----------");
                Console.WriteLine("----------2.   Add Customer  ----------");
                Console.WriteLine("----------3.   Add Parcel    ----------");
                Console.WriteLine("----------4. Add Delivery    ----------");
                Console.WriteLine("----------       Exit        ----------");
                string choice = Console.ReadLine();
                if (choice == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    if (choice == "1")
                    {
                        Console.WriteLine("Fill -> Name,Family ");
                        string[] input = Console.ReadLine()
                       .Split(",", StringSplitOptions.RemoveEmptyEntries);
                        IPerson person = new Worker(input[0], input[1], input[2], int.Parse(input[3])
                            , int.Parse(input[4]), input[5], input[6], input[7], input[8]);

                        Console.WriteLine($"New Worker    {input[0]} - Add");

                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Fill -> Name,Family and email ");
                        string[] input = Console.ReadLine()
                       .Split(",", StringSplitOptions.RemoveEmptyEntries);
                        IPerson person = new Customer(input[0], input[1], input[2], int.Parse(input[3]));

                        if (input.Length > 4)
                        {
                            person.DataOfBirth = int.Parse(input[4]);
                        }

                        Console.WriteLine($"New Customer    {input[0]} - Add");
                    }
                    else if (choice == "3")
                    {


                    }


                }
                catch (Exception e)
                {

                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally
                {

                    Console.WriteLine("The 'try catch' is finished.");
                    //  Run();
                }

            }

        }

    }
}
