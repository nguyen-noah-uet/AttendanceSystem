namespace AttendanceSystem
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AttendanceTap = new System.Windows.Forms.TabPage();
            this.SelectDayCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AttendanceButton = new System.Windows.Forms.Button();
            this.AllStudentsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassDetailButton = new System.Windows.Forms.Button();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AttendanceTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AttendanceTap);
            this.tabControl1.Controls.Add(this.ReportTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // AttendanceTap
            // 
            this.AttendanceTap.Controls.Add(this.SelectDayCheckBox);
            this.AttendanceTap.Controls.Add(this.SaveButton);
            this.AttendanceTap.Controls.Add(this.AttendanceButton);
            this.AttendanceTap.Controls.Add(this.AllStudentsButton);
            this.AttendanceTap.Controls.Add(this.label3);
            this.AttendanceTap.Controls.Add(this.ClassDetailButton);
            this.AttendanceTap.Controls.Add(this.AddClassButton);
            this.AttendanceTap.Controls.Add(this.dataGridView1);
            this.AttendanceTap.Controls.Add(this.dateTimePicker1);
            this.AttendanceTap.Controls.Add(this.label1);
            this.AttendanceTap.Controls.Add(this.comboBox1);
            this.AttendanceTap.Location = new System.Drawing.Point(4, 29);
            this.AttendanceTap.Name = "AttendanceTap";
            this.AttendanceTap.Padding = new System.Windows.Forms.Padding(3);
            this.AttendanceTap.Size = new System.Drawing.Size(957, 494);
            this.AttendanceTap.TabIndex = 0;
            this.AttendanceTap.Text = "Điểm danh";
            this.AttendanceTap.UseVisualStyleBackColor = true;
            // 
            // SelectDayCheckBox
            // 
            this.SelectDayCheckBox.AutoSize = true;
            this.SelectDayCheckBox.Checked = true;
            this.SelectDayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SelectDayCheckBox.Location = new System.Drawing.Point(528, 70);
            this.SelectDayCheckBox.Name = "SelectDayCheckBox";
            this.SelectDayCheckBox.Size = new System.Drawing.Size(127, 24);
            this.SelectDayCheckBox.TabIndex = 14;
            this.SelectDayCheckBox.Text = "Lọc theo ngày:";
            this.SelectDayCheckBox.UseVisualStyleBackColor = true;
            this.SelectDayCheckBox.CheckedChanged += new System.EventHandler(this.SelectDayCheckBox_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(827, 349);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 64);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.Location = new System.Drawing.Point(827, 179);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(123, 61);
            this.AttendanceButton.TabIndex = 11;
            this.AttendanceButton.Text = "Điểm danh";
            this.AttendanceButton.UseVisualStyleBackColor = true;
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // AllStudentsButton
            // 
            this.AllStudentsButton.Location = new System.Drawing.Point(712, 28);
            this.AllStudentsButton.Name = "AllStudentsButton";
            this.AllStudentsButton.Size = new System.Drawing.Size(238, 33);
            this.AllStudentsButton.TabIndex = 10;
            this.AllStudentsButton.Text = "Danh sách tất cả sinh viên";
            this.AllStudentsButton.UseVisualStyleBackColor = true;
            this.AllStudentsButton.Click += new System.EventHandler(this.AllStudentsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "UsernameLabel";
            // 
            // ClassDetailButton
            // 
            this.ClassDetailButton.Location = new System.Drawing.Point(165, 100);
            this.ClassDetailButton.Name = "ClassDetailButton";
            this.ClassDetailButton.Size = new System.Drawing.Size(154, 29);
            this.ClassDetailButton.TabIndex = 6;
            this.ClassDetailButton.Text = "Chi tiết lớp môn học";
            this.ClassDetailButton.UseVisualStyleBackColor = true;
            this.ClassDetailButton.Click += new System.EventHandler(this.ClassDetailButton_Click);
            // 
            // AddClassButton
            // 
            this.AddClassButton.Location = new System.Drawing.Point(8, 100);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(151, 29);
            this.AddClassButton.TabIndex = 5;
            this.AddClassButton.Text = "Thêm lớp môn học";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(813, 351);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(528, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker_OnDateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp môn học:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.RefreshButton);
            this.ReportTab.Controls.Add(this.dataGridView2);
            this.ReportTab.Controls.Add(this.label2);
            this.ReportTab.Controls.Add(this.comboBox2);
            this.ReportTab.Location = new System.Drawing.Point(4, 29);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTab.Size = new System.Drawing.Size(957, 494);
            this.ReportTab.TabIndex = 1;
            this.ReportTab.Text = "Báo cáo";
            this.ReportTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(163, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(786, 441);
            this.dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn lớp môn học:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(63, 79);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(94, 29);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Quản lý điểm danh";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.AttendanceTap.ResumeLayout(false);
            this.AttendanceTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ReportTab.ResumeLayout(false);
            this.ReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage AttendanceTap;
        private TabPage ReportTab;
        private Button ClassDetailButton;
        private Button AddClassButton;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Button AllStudentsButton;
        private Button AttendanceButton;
        private Button SaveButton;
        private CheckBox SelectDayCheckBox;
        private DataGridView dataGridView2;
        private Label label2;
        private ComboBox comboBox2;
        private Button RefreshButton;
    }
}