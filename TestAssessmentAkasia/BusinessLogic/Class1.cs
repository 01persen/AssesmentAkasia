using System;

namespace BusinessLogic
{
    public class Logic
    {
        public string Proses(int i)
        {
            string result = string.Empty;
            int k;
            if (i%3 == 0 && i % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (i % 5 == 0)
            {
                result = "Buzz";
            }else if(i % 3 == 0)
            {
                result = "Fizz";
            }
            else
            {
                result = i.ToString();
            }
            return result;
        }
    }
}
