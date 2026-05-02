namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            txtid = new TextBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 3500;
            toolTip1.BackColor = Color.FromArgb(247, 248, 240);
            toolTip1.ForeColor = Color.FromArgb(53, 88, 114);
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(53, 88, 114);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(122, 170, 206);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.FromArgb(247, 248, 240);
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // txtid
            // 
            txtid.Cursor = Cursors.IBeam;
            txtid.ForeColor = Color.FromArgb(53, 88, 114);
            resources.ApplyResources(txtid, "txtid");
            txtid.Name = "txtid";
            toolTip1.SetToolTip(txtid, resources.GetString("txtid.ToolTip"));
            txtid.KeyPress += textBox2_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(53, 88, 114);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(247, 248, 240);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(122, 170, 206);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(53, 88, 114);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.MinDate = new DateTime(2026, 2, 7, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(53, 88, 114);
            label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(53, 88, 114);
            label2.Name = "label2";
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(53, 88, 114);
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(247, 248, 240);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(53, 88, 114);
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel2;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox txtid;
    }
}
