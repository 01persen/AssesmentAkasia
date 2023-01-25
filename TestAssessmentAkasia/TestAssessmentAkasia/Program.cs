using BusinessLogic;
using System;

namespace TestAssessmentAkasia
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic oLogic = new Logic();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(oLogic.Proses(i));
            }
            
        }
    }
}
