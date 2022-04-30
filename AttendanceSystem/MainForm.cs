using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class MainForm : Form
    {
        private readonly Context _context;
        private readonly IClassRepository _classRepository;
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClass_StudentRepository _classStudentRepository;
        private User _user = new User();
        private Class _currentClass;
        public MainForm(Context context)
        {
            _context = context;
            _classRepository = new ClassRepository(_context);
            _attendanceRepository = new AttendanceRepository(_context);
            _studentRepository = new StudentRepository(_context);
            _classStudentRepository = new ClassStudentRepository(_context);
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadAttendances();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _currentClass = comboBox1.SelectedItem as Class;

            // Show Login Form
            var loginForm = new LoginForm(new UserRepository(_context));
            loginForm.ShowDialog();
            if (loginForm.Success)
            {
                _user = loginForm.User;
                // Show username
                ShowUsername(loginForm);
                // Load classes
                LoadClasses();
                // Load Attendances
                LoadAttendances();
                // Show report
                ShowReport();
                // Init Button State
                if (dataGridView1.RowCount > 0)
                {
                    AttendanceButton.Enabled = false;
                }
                SaveButton.Enabled = false;
            }
            else
            {
                Close();
            }

        }

        private void ShowReport()
        {
            /*
             select 
               s.Id as 'Mã sinh viên',
               s.StudentName as 'Họ và tên',
               (select count(*) from Attendances a where a.StudentId = s.Id and a.ClassId = 3 and a.Status like '%ng gi%') as 'Đúng giờ',
               (select count(*) from Attendances a where a.StudentId = s.Id and a.ClassId = 3 and a.Status like '%mu%') as 'Muộn',
               (select count(*) from Attendances a where a.StudentId = s.Id and a.ClassId = 3 and a.Status like '%có%') as 'Nghỉ có phép',
               (select count(*) from Attendances a where a.StudentId = s.Id and a.ClassId = 3 and a.Status like '%kh%') as 'Nghỉ không phép'
               from Students s;
             */
            _currentClass = comboBox2.SelectedItem as Class;
            dataGridView2.DataSource = (from s in _context.Students
                                        join cs in _context.ClassStudent on s.Id equals cs.StudentId
                                        where cs.ClassId == _currentClass.Id
                                        select new
                                        {
                                            s.Id,
                                            s.StudentName,
                                            T = _context.Attendances.Count(a => a.ClassId == _currentClass.Id && a.StudentId == s.Id),
                                            D = _context.Attendances.Count(a => a.ClassId == _currentClass.Id && a.StudentId == s.Id && a.Status.Contains("ng gi")),
                                            M = _context.Attendances.Count(a => a.ClassId == _currentClass.Id && a.StudentId == s.Id && a.Status.Contains("mu")),
                                            CP = _context.Attendances.Count(a => a.ClassId == _currentClass.Id && a.StudentId == s.Id && a.Status.Contains("có")),
                                            KP = _context.Attendances.Count(a => a.ClassId == _currentClass.Id && a.StudentId == s.Id && a.Status.Contains("kh")),
                                        })
                                        .OrderBy(s => s.Id)
                                        .ToList();
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView2.Columns[1].HeaderText = "Họ tên";
            dataGridView2.Columns[2].HeaderText = "Tổng sô buổi";
            dataGridView2.Columns[3].HeaderText = "Đúng giờ";
            dataGridView2.Columns[4].HeaderText = "Muộn";
            dataGridView2.Columns[5].HeaderText = "Nghỉ có phép";
            dataGridView2.Columns[6].HeaderText = "Nghỉ không phép";
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.Width = 100;
            }

            dataGridView2.Columns[1].Width = 150;
        }

        private void ShowUsername(LoginForm loginForm)
        {
            label3.Text = $"Tài khoản: {_user.Username}";
        }
        private void LoadClasses()
        {
            comboBox1.DataSource = _classRepository.GetClassesByUser(_user.Id).ToList();
            comboBox1.DisplayMember = "ClassName";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = _classRepository.GetClassesByUser(_user.Id).ToList();
            comboBox2.DisplayMember = "ClassName";
            comboBox2.ValueMember = "Id";
        }
        private void LoadAttendances()
        {
            _currentClass = comboBox1.SelectedItem as Class;
            dataGridView1.DataSource = _attendanceRepository.GetAttendancesByClassIdAndDate(_currentClass.Id, dateTimePicker1.Value.Date).OrderBy(a => a.StudentId).ToList();
            //dataGridView1.DataSource = _attendanceRepository.GetAttendancesByClassId(_currentClass.Id).OrderBy(a => a.Date).ThenBy(a => a.StudentId).ToList();
            dataGridView1.Columns[0].HeaderText = "Mã điểm danh";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Mã lớp";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].HeaderText = "Lớp";
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].HeaderText = "Sinh viên";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].HeaderText = "Ngày";
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].HeaderText = "Trạng thái";
            dataGridView1.Columns[6].ReadOnly = false;
        }

        private void ClassDetailButton_Click(object sender, EventArgs e)
        {
            var currentClass = comboBox1.SelectedItem as Class;
            var studentForm = new SubjectClassDetail(currentClass, _studentRepository, _classStudentRepository);
            studentForm.ShowDialog();
        }

        private void AllStudentsButton_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm(new StudentRepository(_context));
            studentForm.ShowDialog();
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            var students = _studentRepository.GetStudentsByClassId(_currentClass.Id).ToList();
            foreach (var student in students)
            {
                _attendanceRepository.AddAttendance(new Attendance() { ClassId = _currentClass.Id, StudentId = student.Id, Status = "", Date = dateTimePicker1.Value.Date });
            }

            _context.SaveChanges();
            dataGridView1.DataSource = _attendanceRepository.GetAttendancesByClassIdAndDate(_currentClass.Id, dateTimePicker1.Value.Date).OrderBy(a => a.StudentId).ToList();
            dataGridView1.Update();
            dataGridView1.Refresh();
            SaveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            SaveButton.Enabled = false;
        }


        private void DateTimePicker_OnDateChanged(object? sender, EventArgs e)
        {
            dataGridView1.DataSource = _attendanceRepository.GetAttendancesByClassIdAndDate(_currentClass.Id, dateTimePicker1.Value.Date).ToList();
            // if grid already has data
            if (dataGridView1.RowCount > 0)
            {
                AttendanceButton.Enabled = false;
            }
            else
            {
                AttendanceButton.Enabled = true;
            }

        }

        private void SelectDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool currentState = SelectDayCheckBox.Checked;
            if (currentState == false)
            {
                dataGridView1.DataSource = _attendanceRepository
                    .GetAttendancesByClassId(_currentClass.Id).OrderBy(a => a.Date)
                    .ThenBy(a => a.StudentId)
                    .ToList();
                //dataGridView1.DataSource = _attendanceRepository
                //    .GetAttendancesByClassIdAndDate(_currentClass.Id, dateTimePicker1.Value.Date)
                //    .ToList();
                dateTimePicker1.Enabled = false;
                AttendanceButton.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = _attendanceRepository
                    .GetAttendancesByClassIdAndDate(_currentClass.Id, dateTimePicker1.Value.Date)
                    .ToList();
                dateTimePicker1.Enabled = true;
                AttendanceButton.Enabled = true;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ShowReport();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
    }
}