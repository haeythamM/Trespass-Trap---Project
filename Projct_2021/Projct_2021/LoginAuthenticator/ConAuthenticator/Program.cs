using LibLoginAuthenticator;
using System;

namespace ConAuthenticator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginAuthenticator log = new LoginAuthenticator();

            Console.WriteLine("User Id please :");
            log.userName = Console.ReadLine();
            Console.WriteLine("Password  Please:");
            log.password = Console.ReadLine();
            bool? checkPoint = log.Authenticate();




            if (checkPoint == null)
            {
                Console.WriteLine("you should enter the fill info please");

            }
            if (checkPoint == false)
            {
                Console.WriteLine("Try agamin");

            }
            if (checkPoint == true)
            {
                Console.WriteLine("Great !");

            }




            Console.ReadKey();

        }
    }
}
