using UNI__PLANNER;
using UNI__PLANNER.Models;
using UNI__PLANNER.Models.Enums.UNI__PLANNER.Models.Enums;
using UNI__PLANNER.Services;
using UNI__PLANNER.Session;

namespace WinFormsApp2
{

    public partial class Form2 : Form
    {
        void UpdateStats()
        {
            int total = dataGridTasks.Rows.Count;

            int completed = 0;
            int pending = 0;
            int overdue = 0;

            foreach (DataGridViewRow row in dataGridTasks.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString();

                if (status == "Completed")
                    completed++;
                else if (status == "Pending")
                    pending++;
                else if (status == "Overdue")
                    overdue++;
            }

            labeltotaltasks.Text = total.ToString();
            labelcompleted.Text = completed.ToString();
            labelpending.Text = pending.ToString();
            labeloverdue.Text = overdue.ToString();
        }

        private IEnumerable<string> allLines;
        private int index;
        private bool isOdd;

        public void cleartxt()
        {
            txtname2.Clear();
            txtid2.Clear();
            txtsecion.Clear();
        }
        public Form2()
        {
            InitializeComponent();
        }

        bool IsOddWeek(DateTime date)
        {
            int weekNumber = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                date,
                System.Globalization.CalendarWeekRule.FirstDay,
                DayOfWeek.Saturday);

            return weekNumber % 2 != 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var student = UserSession.CurrentStudent;

                labelwelcome.Text = "Welcome, " + student.Name;
                labelID.Text = student.ID;
                labelsection.Text = student.Section;

                labeldate.Text = UserSession.Date.ToShortDateString();
                labelDateSchedule.Text = UserSession.Date.ToShortDateString();

                ScheduleHelper helper = new ScheduleHelper();
                WeekType weekType = helper.IsOddWeek(UserSession.Date)
                 ? WeekType.Odd
                 : WeekType.Even;

                labelweekstatus.Text = weekType.ToString();
                labelwsd.Text = weekType.ToString();

                //section31
                UniversityData data = new UniversityData();

                var days = new List<string> { "Staurday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };
                string dayName = UserSession.Date.DayOfWeek.ToString();

                string subject = "";

                if (weekType == WeekType.Even)
                {
                    switch (dayName)
                    {
                        case "Saturday":
                            subject = "Probability Lecture";
                            break;

                        case "Sunday":
                            subject = "IS , IT Lecture";
                            break;

                        case "Monday":
                            subject = "Calculus , OOP Lecture";
                            break;

                        case "Tuesday":
                            subject = "Logic Lecture";
                            break;

                        case "Wednesday":
                            subject = "There are no lectures.";
                            break;

                        case "Thursday":
                            subject = "There are no lectures.";
                            break;

                        case "Friday":
                            subject = "There are no lectures.";
                            break;
                    }
                }
                else
                {
                    switch (dayName)
                    {
                        case "Saturday":
                            subject = "IS , Probability , Calculus Section";
                            break;

                        case "Sunday":
                            subject = "There are no Sections.";
                            break;

                        case "Monday":
                            subject = "There are no Sections.";
                            break;

                        case "Tuesday":
                            subject = "There are no Sections.";
                            break;

                        case "Wednesday":
                            subject = "There are no Sections.";
                            break;

                        case "Thursday":
                            subject = "IT , OOP , Logic Section";
                            break;

                        case "Friday":
                            subject = "There are no Sections.";
                            break;
                    }
                }



                labelDay.Text = dayName;
                labelSubject.Text = subject;

                ScheduleManagerLecture managerlec = new ScheduleManagerLecture();
                var lectures = managerlec.GetSchedule(student.Section, weekType);
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c is Label)
                        c.Text = "";
                }

                foreach (var lec in lectures)
                {
                    string day = lec.Day_.Trim();
                    string time = lec.Time_.Trim();

                    //Odd Week
                    if (day == "Saturday" && time == "12:20")
                        sa12.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Sunday" && time == "10:20")
                        su10.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Sunday" && time == "12:20")
                        su12.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Monday" && time == "8:30")
                        m8.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Monday" && time == "10:20")
                        m10.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Tuesday" && time == "8:30")
                        tu8.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    //Event Week
                    if (day == "Saturday" && time == "9:00")
                        sa9.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Sunday" && time == "7:30")
                        su7.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Sunday" && time == "9:00")
                        su9.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Monday" && time == "9:00")
                        m9.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Tuesday" && time == "7:30")
                        tu7.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";

                    else if (day == "Wednesday" && time == "9:00")
                        w9.Text = $"{lec.Subject_}\n{lec.Instructor_}\n{lec.Location_}";
                }

                ScheduleManagerSection managersec = new ScheduleManagerSection();
                var sections = managersec.GetSchedule(student.Section,weekType);

                foreach (var sec in sections)
                {
                    string day = sec.Day_.Trim();
                    string time = sec.Time_.Trim();
                    //Odd Week
                    if (day == "Saturday" && time == "9:00")
                        sa9.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Sunday" && time == "7:30")
                        su7.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Sunday" && time == "9:00")
                        su9.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Tuesday" && time == "7:30")
                        tu7.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Wednesday" && time == "7:30")
                        w7.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Wednesday" && time == "9:00")
                        w9.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    //Event Week
                    if (day == "Saturday" && time == "10:20")
                        sa10.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Saturday" && time == "12:20")
                        sa12.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Saturday" && time == "2:10")
                        sa2.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Thursday" && time == "8:30")
                        th8.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Thursday" && time == "12:20")
                        th12.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";

                    else if (day == "Thursday" && time == "2:10")
                        th2.Text = $"{sec.Subject_}\n{sec.Instructor_}\n{sec.Location_}";
                }



                foreach (DataGridViewRow row in dataGridTasks.Rows)
                {
                    string status = row.Cells["Status"].Value.ToString();

                    if (status == "Completed")
                        row.Cells["Status"].Style.BackColor = Color.LightGreen;

                    else if (status == "Pending")
                        row.Cells["Status"].Style.BackColor = Color.Orange;

                    else if (status == "Overdue")
                        row.Cells["Status"].Style.BackColor = Color.Red;
                }
                UpdateStats();

                dataGridTasks.Rows.Add("Assignment 1", "OOP", "25/04/2026", "Pending", "High");
                dataGridTasks.Rows.Add("Project", "IT", "28/04/2026", "Completed", "Medium");
                dataGridTasks.Rows.Add("Homework", "Logic", "30/04/2026", "Pending", "Low");
                dataGridTasks.Rows.Add("Quiz", "Calculus", "27/04/2026", "Overdue", "High");
                dataGridTasks.Rows.Add("Report", "IS", "29/04/2026", "Completed", "Medium");

                UpdateStats();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(CtrlDashBoard);
            //labeldate.Text =
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowPanel(ctrlacademicschedule);
        }
        private void ShowPanel(Panel panelToShow)
        {
            CtrlDashBoard.Visible = false;
            ctrlSettings.Visible = false;
            ctrlacademicschedule.Visible = false;
            ctrlTaskManager.Visible = false;
            ctrlAcademicTimeLine.Visible = false;

            panelToShow.Visible = true;

            panelToShow.BringToFront();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            ShowPanel(ctrlSettings);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = txtid2.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter ID first!");
                return;
            }

            StudentManager manager = new StudentManager();
            Student student = manager.Find(id);

            if (student != null)
            {
                txtname2.Text = student.Name;
                txtsecion.Text = student.Section;
            }
            else
            {
                MessageBox.Show("Student not found!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtname2.Text) ||
            string.IsNullOrWhiteSpace(txtid2.Text) ||
            string.IsNullOrWhiteSpace(txtsecion.Text))
            {
                MessageBox.Show("Please enter all data and try again");
                return;
            }

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.txt");

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "");
                }

                string[] allLines = File.ReadAllLines(path);

                // 🔴 check duplicate BEFORE saving
                foreach (string line in allLines)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 3 && data[1].Trim() == txtid2.Text.Trim())
                    {
                        MessageBox.Show("This ID already exists ❌");
                        return;
                    }
                }

                // 🟢 save after validation
                string record = $"{txtname2.Text},{txtid2.Text},{txtsecion.Text}{Environment.NewLine}";
                File.AppendAllText(path, record);

                MessageBox.Show("Saved successfully ✅");

                cleartxt();
                txtname2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem with saving: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            System.Windows.Forms.TextBox txtshow = new System.Windows.Forms.TextBox();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Font = this.Font;
            frm.Icon = this.Icon;
            frm.Size = this.Size;
            frm.Text = "All Data";

            txtshow.Multiline = true;
            txtshow.Dock = DockStyle.Fill;
            txtshow.ScrollBars = ScrollBars.Vertical;
            txtshow.ReadOnly = true;
            txtshow.BackColor = Color.White;

            frm.Controls.Add(txtshow);

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.txt");

                if (File.Exists(path))
                {
                    string data = File.ReadAllText(path);

                    txtshow.Text = data.Replace(",", " ; ");
                }
                else
                {
                    txtshow.Text = "No data has been recorded yet.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem reading the file: " + ex.Message);
            }

            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ShowPanel(ctrlAcademicTimeLine);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel(ctrlTaskManager);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddTaskForm frm = new AddTaskForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var t = frm.NewTask;

                dataGridTasks.Rows.Add(
                    t.Title,
                    t.Subject,
                    t.DueDate,
                    t.Status,
                    t.Priority
                );
                UpdateStats();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.SelectedRows.Count > 0)
            {
                dataGridTasks.Rows.RemoveAt(dataGridTasks.SelectedRows[0].Index);
                UpdateStats();
            }
            else
            {
                MessageBox.Show("Select a task first!");
            }
        }
    }
}
