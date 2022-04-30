using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class SubjectClassDetail : Form
    {
        private readonly Class _currentClass;
        private readonly IStudentRepository _studentRepository;
        private readonly IClass_StudentRepository _classStudentRepository;

        public SubjectClassDetail(Class currentClass, IStudentRepository studentRepository, IClass_StudentRepository classStudentRepository)
        {
            _currentClass = currentClass;
            _studentRepository = studentRepository;
            _classStudentRepository = classStudentRepository;
            _studentRepository.GetStudentsByClassId(_currentClass.Id).ToList();
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            ClassNameLabel.Text = _currentClass.ClassName;
            ClassIdLabel.Text = _currentClass.Id.ToString();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView1.DataSource = _studentRepository.GetStudentsByClassId(_currentClass.Id).ToList();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _studentRepository.SaveChanges();
            this.Close();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentToSubjectClassForm(_classStudentRepository, _studentRepository, _currentClass);
            addStudentForm.ShowDialog();
            LoadStudents();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int studentId = (int)dataGridView1.CurrentCell.Value;
            var modifyStudentForm = new ModifyStudentForm(_studentRepository, studentId);
            modifyStudentForm.ShowDialog();
            LoadStudents();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int studentId = (int)dataGridView1.CurrentCell.Value;
            var student = _studentRepository.GetStudentById(studentId);
            var answer = MessageBox.Show(
                $"Bạn muốn xóa {student.StudentName} mã sinh viên '{studentId}' khỏi lớp {_currentClass.ClassName} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (answer == DialogResult.Yes)
            {
                _classStudentRepository.RemoveStudentFormClass(_currentClass.Id, studentId);
                _classStudentRepository.SaveChanges();
                LoadStudents();
            }
        }

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }
    }
}
