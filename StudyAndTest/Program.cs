using System;
using StudyAndTest;

namespace StudyAndTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter problem (0 for quit):");
            byte problem = byte.Parse(Console.ReadLine());

            while (problem != 0)
            {
                switch (problem)
                {
                    case 1:
                        Console.WriteLine("############### BEGIN ##############");
                        Problem01.HungryGarfield();
                        Console.WriteLine("################ END ###############");
                        break;
                    case 2:
                        Console.WriteLine("############### BEGIN ##############");
                        Problem02.EncodedAnswers();
                        Console.WriteLine("################ END ###############");
                        break;
                    case 3:
                        Console.WriteLine("############### BEGIN ##############");
                        Problem03.FallenInLove();
                        Console.WriteLine("################ END ###############");
                        break;
                    case 4:
                        Console.WriteLine("############### BEGIN ##############");
                        Console.WriteLine("Problem 4");
                        Console.WriteLine("################ END ###############");
                        break;
                    case 5:
                        Console.WriteLine("############### BEGIN ##############");
                        Console.WriteLine("Problem 5");
                        Console.WriteLine("################ END ###############");
                        break;
                    default:
                        Console.WriteLine("Solution does not exist");
                        break;
                }
                Console.WriteLine("Enter problem (0 for quit):");
                problem = byte.Parse(Console.ReadLine());
            }
        }
    }
}
