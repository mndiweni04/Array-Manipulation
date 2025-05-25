using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Calendar
{
    internal class Program
    {
        static string[] Days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
        static object[,] CalDays = new object[6,7];
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a desired month(1-12): ");
            int iMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a desired year(e.g., 2025): ");
            int iYear = int.Parse(Console.ReadLine());

            Console.WriteLine(Calendar(iMonth,iYear));
        }

        static string Calendar(int month, int year)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var day in Days)
                sb.Append($"{day,-6}");
            sb.AppendLine();

            int iNumberDays = DateTime.DaysInMonth(year, month);
            int iStartDay = (int)new DateTime(year, month, 1).DayOfWeek;
            int row = 0, coloumn = iStartDay;

            for (int i = 1;  i <= iNumberDays; i++) {
                CalDays[row, coloumn] = i;
                coloumn++;

                if (coloumn == 7)
                {
                    coloumn = 0;
                    row++;
                }
                ;
            }

            for (int i = 0; i < CalDays.GetLength(0); i++)
            {
                for (int j = 0; j < CalDays.GetLength(1); j++)
                {
                    if (CalDays[i, j] != null)
                        sb.Append($"{CalDays[i, j],-6}");
                    else
                        sb.Append("      ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
