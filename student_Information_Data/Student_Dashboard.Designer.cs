namespace student_Information_Data
{
    partial class Student_Dashboard
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
            dgvStudents = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(31, 95);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(494, 347);
            dgvStudents.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(446, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 30);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(216, 66);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(204, 23);
            txtSearch.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(264, 30);
            label1.TabIndex = 21;
            label1.Text = "STUDENT INFORMATION";
            // 
            // Student_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 467);
            Controls.Add(dgvStudents);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "Student_Dashboard";
            Text = "Student_Dashboard";
            Load += Student_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvStudents;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
    }
}