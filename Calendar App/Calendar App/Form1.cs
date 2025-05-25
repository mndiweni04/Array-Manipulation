using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbCal.Font = new Font("Consolas", 10);
        }
        static string[] Days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        private void btnPrintDate_Click(object sender, EventArgs e)
        {
            rtbCal.Clear();
            if(!int.TryParse(tbYear.Text, out int iYear) || iYear < 1000 || iYear > 9999) 
            { MessageBox.Show("Please enter a valid year."); tbYear.Clear(); }

            int iMonth = cbMonth.SelectedIndex + 1;

            rtbCal.AppendText(GenerateCalendar(iMonth, iYear));
        }

        public string GenerateCalendar(int iMonth, int iYear)
        {
            object[,] calGrid = BuildCalendarGrid(iMonth, iYear);
            return RenderCalendarGrid(calGrid);
        }

        public object[,] BuildCalendarGrid(int iMonth, int iYear)
        {
            object[,] grid = new object[6, 7];
            int daysInMonth = DateTime.DaysInMonth(iYear, iMonth);
            int iStartDay = (int)new DateTime(iYear, iMonth, 1).DayOfWeek;

            int row = 0, col = iStartDay;

            for (int day = 1; day <= daysInMonth; day++)
            {
                grid[row, col] = day;
                col++;

                if (col == 7)
                {
                    col = 0;
                    row++;
                }
            }

            return grid;
        }
    
        public string RenderCalendarGrid(object[,] grid)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var day in Days) sb.Append($"{day,-6}");

            sb.AppendLine();

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] != null)
                        sb.Append($"{grid[i, j],-6}");
                    else
                        sb.Append("      ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
