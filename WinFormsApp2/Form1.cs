using UNI__PLANNER.Services;
using UNI__PLANNER.Session;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtid.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtid.Text))
            {
                errorProvider1.SetError(txtid, "ID is required");
                return;
            }

            StudentManager manager = new StudentManager();
            var student = manager.Find(txtid.Text);

            if (student != null)
            {
                UserSession.CurrentStudent = student;
                UserSession.Date = dateTimePicker1.Value;

                new Form2().Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(txtid, "ID not found");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
