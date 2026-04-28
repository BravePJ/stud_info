namespace student_Information_Data
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
            panel1 = new Panel();
            btnRegister = new Button();
            btnLogIn = new Button();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogIn);
            panel1.Location = new Point(-1, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 211);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(272, 82);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 39);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click_1;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Black;
            btnLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(85, 83);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(120, 38);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Student";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 0;
            label1.Text = "LOG IN SYSTEM";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 7);
            button2.Name = "button2";
            button2.Size = new Size(59, 31);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(476, 253);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogIn;
        private Button btnRegister;
        private Button button2;
    }
}
