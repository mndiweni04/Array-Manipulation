using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Array_TimeTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbDisplayTimeTbl.Font = new Font("Consolas", 10);
        }
        public string[,,] timetable = new string[3, 5, 6];
        public string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        public string[] Periods = { "Period 1", "Period 2", "Period 3", "Period 4", "Period 5", "Period 6" };

        private void btnViewTimeTbl_Click(object sender, EventArgs e)
        {
            rtbDisplayTimeTbl.Clear();

            int selectedGrade = cbGrade.SelectedIndex;
            if (selectedGrade < 0) return;

            bool isEmpty = true;
            for (int day = 0; day < 5 && isEmpty; day++)
            {
                for (int period = 0; period < 6 && isEmpty; period++)
                {
                    if (timetable[selectedGrade, day, period] != null)
                        isEmpty = false;
                }
            }

            if (isEmpty)
            {
                MessageBox.Show($"No subjects entered yet for Grade {selectedGrade + 1}.");
                return; // Prevent rendering an empty timetable
            }

            rtbDisplayTimeTbl.AppendText($"Grade {selectedGrade + 1} Weekly Timetable\n\n");
            rtbDisplayTimeTbl.AppendText("        ");
            foreach (var day in Days)
                rtbDisplayTimeTbl.AppendText($"{day,-12}");

            rtbDisplayTimeTbl.AppendText("\n");

            for (int period = 0; period < 6; period++)
            {
                rtbDisplayTimeTbl.AppendText($"{Periods[period],-8}");
                for (int day = 0; day < 5; day++)
                {
                    string subject = timetable[selectedGrade, day, period];
                    rtbDisplayTimeTbl.AppendText($"{(subject ?? "-"),-12}");
                }
                rtbDisplayTimeTbl.AppendText("\n");
            }
        }

        public void AddSubject(int iGrade, int iDay, int iPeriod, string Subject)
        {
            if (timetable[iGrade, iDay, iPeriod] != null)
            {
                DialogResult result = MessageBox.Show("This slot already has a subject. Overwrite?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }

            if (iGrade < 0 || iGrade >= 3 || iDay < 0 || iDay >= 5 || iPeriod < 0 || iPeriod >= 6)
                return;

            timetable[iGrade,iDay,iPeriod] = Subject;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int grade = cbGrade.SelectedIndex;
            int day = cbDay.SelectedIndex;
            int period = cbPeriod.SelectedIndex;
            string subject = tbEnterSub.Text;

            if (grade < 0 || day < 0 || period < 0 || string.IsNullOrWhiteSpace(subject))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            AddSubject(grade, day, period, subject);
            MessageBox.Show("Subject added successfully!");
            tbEnterSub.Clear();
        }

        private void btnSearchSub_Click(object sender, EventArgs e)
        {
            string keyword = tbEnterSub.Text.Trim().ToLower();
            rtbDisplayTimeTbl.Clear();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a subject to search.");
                return;
            }

            bool found = false;

            for (int grade = 0; grade < 3; grade++)
            {
                for (int day = 0; day < 5; day++)
                {
                    for (int period = 0; period < 6; period++)
                    {
                        string subject = timetable[grade, day, period];
                        if (!string.IsNullOrEmpty(subject) && subject.ToLower().Contains(keyword))
                        {
                            rtbDisplayTimeTbl.AppendText(
                                $"Grade {grade + 1} | {Days[day]} | {Periods[period]}: {subject}\n");
                            found = true;
                        }
                    }
                }
            }

            if (!found)
            {
                rtbDisplayTimeTbl.AppendText($"No matches found for \"{tbEnterSub.Text}\".\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbEnterSub.Clear();

            cbGrade.SelectedIndex = -1;
            cbDay.SelectedIndex = -1;
            cbPeriod.SelectedIndex = -1;

            rtbDisplayTimeTbl.Clear();
        }
    }
}
