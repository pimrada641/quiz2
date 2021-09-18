using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Total Rose: ");
            int rose = int.Parse(Console.ReadLine());

            Console.Write("Input Total sunflower: ");
            int sunflower = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Rose\n----------\n");

            Rose rose1 = new Rose();

            Console.Write("ID: ");
            rose1.ID = int.Parse(Console.ReadLine());

            Console.Write("Plant name: ");
            rose1.Name = Console.ReadLine();

            Console.Write("Plant description: ");
            rose1.descrip = Console.ReadLine();

            Console.Write("Amount: ");
            rose1.amount = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            rose1.height = Console.ReadLine();

            Console.Write("Circumference: ");
            rose1.circum = Console.ReadLine();

            Console.WriteLine("\nInput Rose\n----------\n");

            Rose rose2 = new Rose();

            Console.Write("ID: ");
            rose2.ID = int.Parse(Console.ReadLine());

            Console.Write("Plant name: ");
            rose2.Name = Console.ReadLine();

            Console.Write("Plant description: ");
            rose2.descrip = Console.ReadLine();

            Console.Write("Amount: ");
            rose2.amount = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            rose2.height = Console.ReadLine();

            Console.Write("Circumference: ");
            rose2.circum = Console.ReadLine();

            Console.WriteLine("\nInput Sunflower\n----------\n");

            Sunflower sunflower1 = new Sunflower();

            Console.Write("ID: ");
            sunflower1.ID = int.Parse(Console.ReadLine());

            Console.Write("Plant name: ");
            sunflower1.Name = Console.ReadLine();

            Console.Write("Plant description: ");
            sunflower1.descrip = Console.ReadLine();

            Console.Write("Amount: ");
            sunflower1.amount = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            sunflower1.height = Console.ReadLine();

            Console.Write("Circumference: ");
            sunflower1.circum = Console.ReadLine();

            Console.WriteLine("\nInput Sunflower\n----------\n");

            Sunflower sunflower2 = new Sunflower();

            Console.Write("ID: ");
            sunflower2.ID = int.Parse(Console.ReadLine());

            Console.Write("Plant name: ");
            sunflower2.Name = Console.ReadLine();

            Console.Write("Plant description: ");
            sunflower2.descrip = Console.ReadLine();

            Console.Write("Amount: ");
            sunflower2.amount = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            sunflower2.height = Console.ReadLine();

            Console.Write("Circumference: ");
            sunflower2.circum = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Rose Information\n----------\n");
            Console.WriteLine("Rose name: {0}",rose1.Name);
            Console.WriteLine("Rose name: {0}", rose2.Name);

            Console.WriteLine("Sunflower Information\n----------\n");
            Console.WriteLine("Sunflower name: {0}", sunflower1.Name);
            Console.WriteLine("Sunflower name: {0}", sunflower1.Name);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Rose Information\n----------\n");
            Console.WriteLine("ID: {0}", rose1.ID);
            Console.WriteLine("Plant description: {0}", rose1.descrip);
            Console.WriteLine("Amount: {0}", rose1.amount);
            Console.WriteLine("Height: {0}", rose1.height);
            Console.WriteLine("Circumference: {0}", rose1.circum);

            Console.WriteLine("Sunflower Information\n----------\n");
            Console.WriteLine("Sunflower name: {0}", sunflower1.ID);
            Console.WriteLine("Plant description: {0}", sunflower1.descrip);
            Console.WriteLine("Amount: {0}", sunflower1.amount);
            Console.WriteLine("Height: {0}", sunflower1.height);
            Console.WriteLine("Circumference: {0}", sunflower1.circum);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Rose Information\n----------\n");
            Console.WriteLine("ID: {0}", rose2.ID);
            Console.WriteLine("Plant description: {0}", rose2.descrip);
            Console.WriteLine("Amount: {0}", rose2.amount);
            Console.WriteLine("Height: {0}", rose2.height);
            Console.WriteLine("Circumference: {0}", rose2.circum);

            Console.WriteLine("Sunflower Information\n----------\n");
            Console.WriteLine("Sunflower name: {0}", sunflower2.ID);
            Console.WriteLine("Plant description: {0}", sunflower2.descrip);
            Console.WriteLine("Amount: {0}", sunflower2.amount);
            Console.WriteLine("Height: {0}", sunflower2.height);
            Console.WriteLine("Circumference: {0}", sunflower2.circum);

        }
    }

    class Rose
    {
        public int ID, amount;
        public string Name, descrip, height, circum;
    }

    class Sunflower
    {
        public int ID, amount;
        public string Name, descrip, height, circum;
    }
}
