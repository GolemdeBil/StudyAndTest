using System;

namespace StudyAndTest
{
    class Problem02
    {
        public static void EncodedAnswers()
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