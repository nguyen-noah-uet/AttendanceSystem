namespace AttendanceSystem
{
    partial class AddStudentToSubjectClassForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.ClassIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(358, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(476, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(373, 382);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.SelectionChanged += new System.EventHandler(dataGridView2_OnSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sinh viên trong lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tất cả sinh viên:";
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(376, 117);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã lớp:";
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(146, 33);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(82, 20);
            this.ClassNameLabel.TabIndex = 6;
            this.ClassNameLabel.Text = "ClassName";
            // 
            // ClassIdLabel
            // 
            this.ClassIdLabel.AutoSize = true;
            this.ClassIdLabel.Location = new System.Drawing.Point(320, 33);
            this.ClassIdLabel.Name = "ClassIdLabel";
            this.ClassIdLabel.Size = new System.Drawing.Size(55, 20);
            this.ClassIdLabel.TabIndex = 7;
            this.ClassIdLabel.Text = "ClassId";
            // 
            // AddStudentToClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.ClassIdLabel);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddStudentToClassForm";
            this.Text = "Thêm sinh viên vào lớp";
            this.Load += new System.EventHandler(this.AddStudentToClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Button AddButton;
        private Label label3;
        private Label ClassNameLabel;
        private Label ClassIdLabel;
    }
}