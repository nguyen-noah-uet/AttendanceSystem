namespace AttendanceSystem
{
    partial class AddStudentForm
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
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.maleRatioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sinh viên:";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(142, 32);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(220, 27);
            this.StudentNameTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(40, 137);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 29);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(266, 137);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Hủy bỏ";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // maleRatioButton
            // 
            this.maleRatioButton.AutoSize = true;
            this.maleRatioButton.Location = new System.Drawing.Point(142, 65);
            this.maleRatioButton.Name = "maleRatioButton";
            this.maleRatioButton.Size = new System.Drawing.Size(62, 24);
            this.maleRatioButton.TabIndex = 4;
            this.maleRatioButton.TabStop = true;
            this.maleRatioButton.Text = "Nam";
            this.maleRatioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(142, 95);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(50, 24);
            this.femaleRadioButton.TabIndex = 5;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Nữ";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 172);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRatioButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddStudentForm";
            this.Text = "Thêm sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox StudentNameTextBox;
        private Button OkButton;
        private Button CancelButton;
        private RadioButton maleRatioButton;
        private RadioButton femaleRadioButton;
    }
}