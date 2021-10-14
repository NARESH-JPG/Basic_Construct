using System;

namespace Basic_Construct_For_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("What is Your fav Snack\n");

            string name = Console.ReadLine();

            Console.WriteLine("How many Plates You can have it at a time?\n");
            //Coverting bydefault value in string into int
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine(count);
            if (count >= 2)
            {

                Console.WriteLine("Too much of snacking is not a healthy sign..!!");
            }

        }
    }
}
