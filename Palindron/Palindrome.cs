using System;
namespace Palindron
{
    public class Palindrome
    {
        public bool checkString()
        {
            int end = word.Length - 1;
            int start = 0;
            while (start <= end)
            {
                if (word[start] != word[end])
                {
                    return false;
                }
                // Console.WriteLine(Word[end]);
                start++;
                end--;

            }

            return true;
        }
    }
}