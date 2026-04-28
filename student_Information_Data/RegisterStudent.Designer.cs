namespace student_Information_Data
{
    partial class RegisterStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            btnSave = new Button();
            txtAge = new TextBox();
            cmbSection = new ComboBox();
            cmbCourse = new ComboBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(cmbSection);
            panel1.Controls.Add(cmbCourse);
            panel1.Controls.Add(txtLastname);
            panel1.Controls.Add(txtFirstname);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-4, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 618);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(16, 522);
            button1.Name = "button1";
            button1.Size = new Size(124, 41);
            button1.TabIndex = 32;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(456, 522);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 41);
            btnSave.TabIndex = 27;
            btnSave.Text = "REGISTER";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 14.25F);
            txtAge.Location = new Point(183, 198);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(227, 33);
            txtAge.TabIndex = 25;
            // 
            // cmbSection
            // 
            cmbSection.Font = new Font("Segoe UI", 14.25F);
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(183, 159);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(227, 33);
            cmbSection.TabIndex = 24;
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 14.25F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(183, 120);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(227, 33);
            cmbCourse.TabIndex = 23;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 14.25F);
            txtLastname.Location = new Point(183, 84);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(227, 33);
            txtLastname.TabIndex = 22;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 14.25F);
            txtFirstname.Location = new Point(183, 45);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(227, 33);
            txtFirstname.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 237);
            label7.Name = "label7";
            label7.Size = new Size(111, 30);
            label7.TabIndex = 20;
            label7.Text = "Birthdate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(118, 197);
            label6.Name = "label6";
            label6.Size = new Size(58, 30);
            label6.TabIndex = 19;
            label6.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 158);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 18;
            label5.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 119);
            label4.Name = "label4";
            label4.Size = new Size(86, 30);
            label4.TabIndex = 17;
            label4.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 84);
            label3.Name = "label3";
            label3.Size = new Size(122, 30);
            label3.TabIndex = 16;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 45);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 15;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(2, 18);
            label1.Name = "label1";
            label1.Size = new Size(467, 37);
            label1.TabIndex = 14;
            label1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(183, 243);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 33;
            // 
            // button2
            // 
            button2.Location = new Point(533, 2);
            button2.Name = "button2";
            button2.Size = new Size(59, 31);
            button2.TabIndex = 15;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(588, 648);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterStudent";
            Load += RegisterStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private TextBox txtAge;
        private ComboBox cmbSection;
        private ComboBox cmbCourse;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Button button2;
    }
}