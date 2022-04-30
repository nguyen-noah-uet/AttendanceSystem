namespace AttendanceSystem
{
    partial class StudentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(398, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(416, 72);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(117, 29);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Thêm sinh viên";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(416, 126);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(117, 29);
            this.ModifyButton.TabIndex = 3;
            this.ModifyButton.Text = "Chỉnh sửa";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Enabled = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(416, 183);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(117, 29);
            this.DeleteStudentButton.TabIndex = 4;
            this.DeleteStudentButton.Text = "Xóa sinh viên";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Enabled = false;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(416, 388);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 29);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(416, 442);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 29);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Hủy bỏ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 483);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentForm";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button AddStudentButton;
        private Button ModifyButton;
        private Button DeleteStudentButton;
        private Button SaveButton;
        private Button CancelButton;
    }
}