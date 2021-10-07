using System;

namespace Algo___Table_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string table = "0";

            while(number < 500)
            {
                number = number + 5;
                table = table + ", " + number;
            }

            Console.WriteLine(table);
        }
    }
}

