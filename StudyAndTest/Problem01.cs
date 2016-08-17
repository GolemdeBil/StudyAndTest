using System;

namespace StudyAndTest
{
    class Problem01
    {
        public static void HungryGarfield()
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
}