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
            int WorkingDaysPerMonth = 20;
            int TotalWagePerMonth=0;

            for(int day=0;day<WorkingDaysPerMonth;day++)
            {

                Random random = new Random();
                int Presence = random.Next(0, 3);

                switch (Presence)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        EmployeeWage = (WagePerHour * Absent);
                        AbsentPresent++;
                        break;

                    case 1:
                        Console.WriteLine("Employee is Present (Full Time)");
                        EmployeeWage = (WagePerHour * Present) * FullDayHour;
                        FullDayPresent++;
                        break;

                    case 2:
                        Console.WriteLine("Employee is Present (Part Time)");
                        EmployeeWage = (WagePerHour * Present) * PartTimeHour;
                        PartTimePresent++;
                        break;
                }
                TotalWagePerMonth += EmployeeWage;
                Console.WriteLine("Employee Day{0} Wage is :{1}",day,EmployeeWage);
                Console.WriteLine("..........................................");
            }
            Console.WriteLine("Employee Monthly Wage is :{0}", TotalWagePerMonth);
            Console.WriteLine("Number of Day Employee Absent in a Month is: " + AbsentPresent);
            Console.WriteLine("Number of Day Employee Present (Full Day) in a Month is: " + FullDayPresent);
            Console.WriteLine("Number of Day Employee Present (Part Time) in a Month is: " + PartTimePresent);
        }
    }
}
