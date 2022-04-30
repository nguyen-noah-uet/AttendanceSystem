namespace AttendanceSystem
{
    partial class ModifyStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh viên :";
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Location = new System.Drawing.Point(129, 9);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(73, 20);
            this.StudentIdLabel.TabIndex = 1;
            this.StudentIdLabel.Text = "StudentId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sinh Viên :";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(129, 56);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(225, 27);
            this.StudentNameTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(22, 132);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(260, 132);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Hủy bỏ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(129, 89);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(62, 24);
            this.maleRadioButton.TabIndex = 6;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Nam";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(218, 89);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(50, 24);
            this.femaleRadioButton.TabIndex = 7;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Nữ";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModifyStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 187);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentIdLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyStudentForm";
            this.Text = "Chỉnh sửa";
            this.Load += new System.EventHandler(this.ModifyStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label StudentIdLabel;
        private Label label3;
        private TextBox StudentNameTextBox;
        private Button SaveButton;
        private Button CancelButton;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
    }
}