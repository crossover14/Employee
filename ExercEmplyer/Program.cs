using System;

namespace ExercEmplyer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of emploees: ");
            int numberEmployee = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployee; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per Hour");
                double valuePerhour = double.Parse(Console.ReadLine());


            }
           
        }
    }
}
