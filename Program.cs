using System;

namespace userdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your PINcode");
            string PINcode = Console.ReadLine();

            if (PINcode == "1234")
            {
                Console.WriteLine("Hello, what is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello {0}", name );


            }else
                Console.WriteLine("Invalid PIN");



            { 



            }


        }
    }
}
