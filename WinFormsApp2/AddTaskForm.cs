using UNI__PLANNER.Models;

namespace UNI__PLANNER
{
    public partial class AddTaskForm : Form
    {
        public TaskItem NewTask { get; set; }
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if ((string.IsNullOrWhiteSpace(txtTitle.Text)) ||
               (string.IsNullOrWhiteSpace(cmbSubject.Text)) ||
               (string.IsNullOrWhiteSpace(cmbPriority.Text)) ||
               (string.IsNullOrWhiteSpace(cmbStatus.Text)))
            {
                errorProvider1.SetError(txtTitle, "Text Title is required");
                errorProvider1.SetError(cmbSubject, "Subject selection is required");
                errorProvider1.SetError(cmbPriority, "Priority selection is required");
                errorProvider1.SetError(cmbStatus, "Status selection is required");
                return;
            }
            
                NewTask = new TaskItem
                {
                    Title = txtTitle.Text,
                    Subject = cmbSubject.Text,
                    DueDate = dtpDate.Value.ToShortDateString(),
                    Status = cmbStatus.Text,
                    Priority = cmbPriority.Text
                };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
