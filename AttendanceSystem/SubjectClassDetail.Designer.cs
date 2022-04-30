namespace AttendanceSystem
{
    partial class SubjectClassDetail
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
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassIdLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(345, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(OnSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sinh viên trong lớp:";
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(152, 24);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(82, 20);
            this.ClassNameLabel.TabIndex = 2;
            this.ClassNameLabel.Text = "ClassName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã lớp:";
            // 
            // ClassIdLabel
            // 
            this.ClassIdLabel.AutoSize = true;
            this.ClassIdLabel.Location = new System.Drawing.Point(363, 24);
            this.ClassIdLabel.Name = "ClassIdLabel";
            this.ClassIdLabel.Size = new System.Drawing.Size(55, 20);
            this.ClassIdLabel.TabIndex = 4;
            this.ClassIdLabel.Text = "ClassId";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(363, 352);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Hủy bỏ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(363, 317);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(363, 57);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(119, 29);
            this.AddStudentButton.TabIndex = 7;
            this.AddStudentButton.Text = "Thêm sinh viên";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(363, 92);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(119, 29);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Chỉnh sửa";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(363, 127);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Xóa khỏi lớp";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClassDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(507, 393);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClassIdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClassDetail";
            this.Text = "Chi tiết lớp học";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label ClassNameLabel;
        private Label label2;
        private Label ClassIdLabel;
        private Button CancelButton;
        private Button SaveButton;
        private Button AddStudentButton;
        private Button EditButton;
        private Button DeleteButton;
    }
}