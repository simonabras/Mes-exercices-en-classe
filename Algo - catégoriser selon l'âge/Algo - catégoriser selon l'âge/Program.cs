using System;

namespace Algo___catégoriser_selon_l_âge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string category= "";

            Console.WriteLine("Entrez votre âge : ");
            age = Int32.Parse(Console.ReadLine());

            if (age > 5 && age < 15)
            {
                if (age <= 7) category = "Poussin";
                else if (age <= 9) category = "Pupile";
                else if (age <= 11) category = "Minime";
                else if (age <= 14) category = "Cadel";

                Console.WriteLine($"Catégorie : {category}");
            }
            else Console.WriteLine("Age trop petit ou trop grand");
        }
    }
}
