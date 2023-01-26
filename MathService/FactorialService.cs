namespace MathService;
using System;

public class FactorialService
{
    public static int GetFactorial(int num)
    {
        if (num < 0)
        {
            throw new ArgumentException("Negative numbers not allowed!!!");
        }
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = result * i;
        }
        return result;
    }
}
