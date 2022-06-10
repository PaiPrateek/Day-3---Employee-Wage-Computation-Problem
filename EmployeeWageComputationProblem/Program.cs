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
            int PartTimeHour = 4;
            int EmployeeWage=0;
            int Absent=0;
            int Present = 1;
            Random random = new Random();
            int Presence = random.Next(0,3);

            switch(Presence)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    EmployeeWage = (WagePerHour * Absent)*FullDayHour;
                    break;


                case 1:
                    Console.WriteLine("Employee is Present (Full Time)");
                    EmployeeWage = (WagePerHour * Present) * FullDayHour;
                    break;

                case 2:
                    Console.WriteLine("Employee is Present (Part Time)");
                    EmployeeWage = (WagePerHour * Present) * PartTimeHour;
                    break;
            }

            Console.WriteLine("Employee Daily Wage is :{0}", EmployeeWage);
        }
    }
}
