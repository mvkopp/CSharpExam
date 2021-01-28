using System;

namespace Exam.Impl
{
    public class FizzBuzzService
    {
        public string Play(int upperBound)
        {
            string res = "";
            for(int i = 1; i <= upperBound; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    res += i;
                }
                if (i % 3 == 0)
                {
                    res += "Fizz";
                }
                if (i % 5 == 0)
                {
                    res += "Buzz";
                }
                
            }
            return res;
        }
    }
}
