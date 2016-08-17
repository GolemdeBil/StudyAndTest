using System;

namespace StudyAndTest
{
    class Problem03
    {
        public static void FallenInLove()
        {
            Console.WriteLine("Enter size of the flower:");
            byte sizeOfFlower = byte.Parse(Console.ReadLine());

            // example
            // sizeOfFlower = 3
            /*##......##......##   <- 
              #~#....#..#....#~#     segment 1
              #~~#..#....#..#~~#   <-
              .#~~~#......#~~~#.   <- 
              ...#~~#....#~~#...     segment 2
              .....#~#..#~#.....
              .......####.......   <- 
              ........##........   <-
              ........##........     segment 3
              ........##........   <- */

            char symbol = '#';
            int leafSpace = 0;
            int insideSpace = 2 * sizeOfFlower;
            int middleSpace = 0;

            for (int i = 0; i < sizeOfFlower; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", symbol, new string('~', leafSpace), new string('.', insideSpace), new string('.', middleSpace));

                leafSpace++;
                insideSpace -= 2;
                middleSpace += 2;
            }

            int outsideSpace = 1;

            for (int i = 0; i <= sizeOfFlower; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', outsideSpace), symbol, new string('~', leafSpace), new string('.', middleSpace));

                middleSpace -= 2;
                leafSpace--;
                outsideSpace += 2;
            }

            for (int i = 0; i < sizeOfFlower; i++)
            {
                Console.WriteLine("{0}{1}{1}{0}", new string('.', 2 * sizeOfFlower + 2), symbol);
            }

        }
    }
}
