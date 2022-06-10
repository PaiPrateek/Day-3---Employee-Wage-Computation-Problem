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
            int WagePerHour = 20;
            int FullDayHour = 8;
            int EmployeeWage=0;
            int Absent=0;
            int Present = 1;
            Random random = new Random();
            int Presence = random.Next(0,2);

            if(Presence == 0)
            {
                Console.WriteLine("Employee is Absent");
                EmployeeWage = (WagePerHour * Absent)*FullDayHour;


            }
            else
            {
                Console.WriteLine("Employee is Present");
                EmployeeWage = (WagePerHour * Present) * FullDayHour;

            }
            Console.WriteLine("Employee Daily Wage is :{0}", EmployeeWage);
        }
    }
}
