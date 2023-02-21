using System;
namespace Forfun
{
    class Challenges
    {
        //Challenge One
        //Write a function that will take the a given string and reverse the order of words.
        public static void reverse_string()
        {
            string noun = "Emmanuel";
            int Length = noun.Length - 1;
            string newnoun = "";
            // int change = 0;
            for (int i = 0; i <= Length;)
            {
                newnoun = newnoun + noun[Length];
                Length--;
            }
                Console.WriteLine(newnoun);
        }

        //Challenge Two
        /*Write a function that will increase the salary of a worker after every four years till
        35 years is over*/
        public static void for_payment()
        {
            int salary = 100000;
            int years = 35;
            Console.WriteLine(salary);
            for (int i = 4; i < years; i = i+4)
            {
                salary = salary + 10000;
                Console.WriteLine(salary); 
            }
        }
    }
}
