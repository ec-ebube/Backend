using System;
namespace ExcetionHandler
{
    public class ExceptionClass
    {
      public void example(int x, int y)
      {
        try
        {
            if (y<=0)
        {
            throw new ArithmeticException("Cannot be divided by zero");
        } else
        {
            int z = x/y;
            Console.WriteLine(z);
        }
        }
        catch (Exception e)
        {
           Console.WriteLine(e.Message);
        }
      }  
    }
}