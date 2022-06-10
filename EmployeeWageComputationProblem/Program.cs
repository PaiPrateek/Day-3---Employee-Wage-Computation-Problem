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
            int FullDayPresent = 0;
            int PartTimePresent = 0;
            int AbsentPresent=0;
            int Absent=0;
            int Present = 1;
            int TotalWagePerMonth=0;
            int MaxWorkingHour = 100;
            int MaxWorkingDays = 20;
            int TotalWorkingHour = 0;
            int TotalWorkingDays = 0;
            int WorkingHour = 0;
            int WorkingDays = 0;

            while(TotalWorkingDays < MaxWorkingDays && TotalWorkingHour < MaxWorkingHour)
            {

                Random random = new Random();
                int Presence = random.Next(0, 3);

                switch (Presence)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        EmployeeWage = (WagePerHour * Absent);
                        WorkingHour = Absent;
                        AbsentPresent++;
                        break;

                    case 1:
                        Console.WriteLine("Employee is Present (Full Time)");
                        EmployeeWage = (WagePerHour * Present) * FullDayHour;
                        WorkingHour = FullDayHour;
                        FullDayPresent++;
                        break;

                    case 2:
                        Console.WriteLine("Employee is Present (Part Time)");
                        EmployeeWage = (WagePerHour * Present) * PartTimeHour;
                        WorkingHour = PartTimeHour;
                        PartTimePresent++;
                        break;
                }
                TotalWorkingHour+=WorkingHour;
                TotalWagePerMonth += EmployeeWage;
                Console.WriteLine("Employee Daily Wage is :{0}",EmployeeWage);
                Console.WriteLine("..........................................");
            }
            Console.WriteLine("Employee Monthly Wage is :{0}", TotalWagePerMonth);
            Console.WriteLine("..........................................");
            Console.WriteLine("Number of Day Employee Absent in a Month is: " + AbsentPresent);
            Console.WriteLine("..........................................");
            Console.WriteLine("Number of Day Employee Present (Full Day) in a Month is: " + FullDayPresent);
            Console.WriteLine("..........................................");
            Console.WriteLine("Number of Day Employee Present (Part Time) in a Month is: " + PartTimePresent);
            Console.WriteLine("..........................................");
            Console.WriteLine("Total Working Hours is :" + TotalWorkingHour);
            Console.WriteLine("..........................................");
        }
    }
}
