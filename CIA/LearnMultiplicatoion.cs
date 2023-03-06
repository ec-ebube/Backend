using System;
namespace CIA
{
    public class LearnMultiplicatoion
    {
        public static void Multiplication_gen()
        {
            Random random = new Random();
            for(int i = 0; i <= 10; i++)
            {
                int firstNum = random.Next(10);
                int lastNum = random.Next(10);
                Boolean correct = false;
                Console.WriteLine($"What is the product of {firstNum} and {lastNum}");
                int studentAns = Convert.ToInt32(Console.ReadLine());
                int mainAns = firstNum * lastNum;
                if (studentAns == mainAns)
                {
                    correct = true;
                }
                while (!correct)
                {
                    Console.WriteLine($"What is the product of {firstNum} and {lastNum}");
                    studentAns = Convert.ToInt32(Console.ReadLine());

                    if (studentAns == mainAns)
                    {
                        correct = true;
                    }
                }
                

                if (studentAns > mainAns)
                {
                    if (studentAns - mainAns <= 10)
                    {
                        Console.WriteLine("Your Ans is a bit higher than the correct ans");
                    }
                    else
                    {
                        Console.WriteLine("Your ans is far higher from the correct ans");
                    }
                }
                if (studentAns < mainAns)
                {
                    if (studentAns - mainAns <= -10)
                    {
                        Console.WriteLine("Your ans ia a bit lower than the correct ans");
                    }
                    else
                    {
                        Console.WriteLine("Your ans is far lower from the correct ans");
                    }
                }
                if (studentAns == mainAns)
                {
                    Console.WriteLine("Your answer is correct");
                }
            }
        }
    }
}