using System;


namespace StudyAndTest
{
    class StudyAndTest
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
                        {
                            Console.WriteLine("############### BEGIN ##############");
                            Problem01.Problem(); ;
                            Console.WriteLine("################ END ###############");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("############### BEGIN ##############");
                            Problem02.Problem();
                            Console.WriteLine("################ END ###############");
                        }
                        break;
                    case 3:
                        Console.WriteLine("############### BEGIN ##############");
                        Console.WriteLine("Problem 3");
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
                Console.WriteLine("Enter problem:");
                problem = byte.Parse(Console.ReadLine());
            }
        }
    }

    class Problem01
    {
        public static void Problem()
        {
            Console.WriteLine("Enter sum of money:");
            float givenMoney = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter dollar exchange rate:");
            float exchangeRate = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter pizza price in BGN:");
            float pizzaPrice = float.Parse(Console.ReadLine()) / exchangeRate;

            Console.WriteLine("Enter lasagna price  BGN:");
            float lasagnaPrice = float.Parse(Console.ReadLine()) / exchangeRate;

            Console.WriteLine("Enter sandwich price  BGN:");
            float sandwichPrice = float.Parse(Console.ReadLine()) / exchangeRate;

            Console.WriteLine("Enter pizza quantity:");
            uint pizzaQuantity = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter lasagna quantity:");
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter sandwich quantity:");
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            float neededMoney = pizzaPrice * pizzaQuantity + lasagnaPrice * lasagnaQuantity + sandwichPrice * sandwichQuantity;
            if (givenMoney >= neededMoney)
            {
                Console.WriteLine("Garfield is well fed, John is awesome.Money left: ${0}.", givenMoney - neededMoney);
            }
            else
            {
                Console.WriteLine("Garfield is hungry.John is a badass.Money needed: ${0}.", neededMoney - givenMoney);
            }
        }
    }

    class Problem02
    {
        public static void Problem()
        {
            Console.WriteLine("Enter number of questions:");
            byte questionCount = byte.Parse(Console.ReadLine());

            string answers = "";
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            for (byte i = 0; i < questionCount; i++)
            {
                Console.WriteLine("Enter answer to question #" + (i + 1) + ":");
                uint encodedAnswer = uint.Parse(Console.ReadLine());

                if (encodedAnswer % 4 == 0)
                {
                    answers += "a ";
                    countA += 1;
                }
                else if (encodedAnswer % 4 == 1)
                {
                    answers += "b ";
                    countB += 1;
                }
                else if (encodedAnswer % 4 == 2)
                {
                    answers += "c ";
                    countC += 1;
                }
                else if (encodedAnswer % 4 == 3)
                {
                    answers += "d ";
                    countD += 1;
                }
            }

            Console.WriteLine(answers);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", countA, countB, countC, countD);
        }
    }
}
