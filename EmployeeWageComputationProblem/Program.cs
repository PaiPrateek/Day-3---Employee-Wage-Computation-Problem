using System;

namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckEmployeePresence();

        }
        public static void CheckEmployeePresence()
        {
            Random random = new Random();
            int Presence = random.Next(0,2);

            if(Presence == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
