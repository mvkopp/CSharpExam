using System;

namespace Exam.Impl
{
    public class Armstrong
    {
        public bool IsArmstrong(int input)
        {
            int res = 0;
            for (int i = input; i > 0; i = i / 10)
            {
                res += (int)Math.Pow(i % 10, 3.0);
            }
            
            if (input == res) return true;
            else return false;
        }
    }
}
