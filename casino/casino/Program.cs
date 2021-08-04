using System;

namespace casino
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age:");
            Console.WriteLine();
            byte age = byte.Parse(Console.ReadLine());

            if (age <= 17)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.Clear();
            }

            Console.WriteLine("Welcome to casino \"NEVADA\" !");
            Console.WriteLine();

            Console.WriteLine("ATTENTION!!! \nbet step is 5 $ \n\nEnter your bid: ");
            Console.WriteLine();
            byte bid = byte.Parse(Console.ReadLine());

            if (bid % 5 == 0 && bid <= 100)
            {
                ;
            }

            else
            {
                Console.WriteLine("Read casino \"NEVADA\" rules!");
            }

            Console.Clear();

            Console.WriteLine("Your bet: " + bid + "$");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Where it stops, nobody knows...");
            Console.WriteLine();

            Random rand1 = new();
            int d1 = rand1.Next(1, 10);
            Random rand2 = new();
            int d2 = rand2.Next(1, 10);
            Random rand3 = new();
            int d3 = rand3.Next(1, 10);

            int drums = (d1 * 100 + d2 * 10 + d3);

            int drum1 = drums / 100;
            int drum2 = (drums % 100) / 10;
            int drum3 = drums % 10;

            Console.WriteLine(drums);

            if (drums == 111)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (10 * 1.5)) + "$");
            }

            else if (drums == 222)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (20 * 1.5)) + "$");
            }
            else if (drums == 333)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (30 * 1.5)) + "$");
            }
            else if (drums == 444)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (40 * 1.5)) + "$");
            }
            else if (drums == 555)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (50 * 1.5)) + "$");
            }
            else if (drums == 666)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (60 * 1.5)) + "$");
            }
            else if (drums == 777)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (150 * 1.5)) + "$");
            }
            else if (drums == 888)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (80 * 1.5)) + "$");
            }
            else if (drums == 999)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (90 * 1.5)) + "$");
            }
            else if (drum1 == 1 && drum2 == 1)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (1 * 1.25)) + "$");
            }
            else if (drum1 == 2 && drum2 == 2)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (2 * 1.25)) + "$");
            }
            else if (drum1 == 3 && drum2 == 3)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (3 * 1.25)) + "$");
            }
            else if (drum1 == 4 && drum2 == 4)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (4 * 1.25)) + "$");
            }
            else if (drum1 == 5 && drum2 == 5)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (5 * 1.25)) + "$");
            }
            else if (drum1 == 6 && drum2 == 6)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (6 * 1.25)) + "$");
            }
            else if (drum1 == 7 && drum2 == 7)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (15 * 1.25)) + "$");
            }
            else if (drum1 == 8 && drum2 == 8)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (8 * 1.25)) + "$");
            }
            else if (drum1 == 9 && drum2 == 9)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * (9 * 1.25)) + "$");
            }
            else if (drum1 == 7 || drum2 == 7 || drum3 == 7)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * 1.6) + "$");
            }
            else if (drum1 == 9 || drum2 == 9 || drum3 == 9)
            {
                Console.WriteLine("\nCongratulations, you WIN !!!\n\nYOU WIN " + (bid * 1.35) + "$");
            }
            else
            {
                Console.WriteLine("\nYou LOSE! \nTry more :)");
            }

            }
        }
    }


