using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class AddStudentToSubjectClassForm : Form
    {
        private readonly IClass_StudentRepository _classStudentRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly Class _currentClass;

        public AddStudentToSubjectClassForm(IClass_StudentRepository classStudentRepository, IStudentRepository studentRepository, Class currentClass)
        {
            _classStudentRepository = classStudentRepository;
            _studentRepository = studentRepository;
            _currentClass = currentClass;
            InitializeComponent();
        }
        private void AddStudentToClassForm_Load(object sender, EventArgs e)
        {
            // DataGridView
            dataGridView1.DataSource = _studentRepository.GetStudentsByClassId(_currentClass.Id).ToList();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            //dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Visible = false;
            // DataGridView2
            dataGridView2.DataSource = _studentRepository.GetAll().ToList();
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns[0].HeaderText = "Mã sinh viên";
            //dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[1].HeaderText = "Họ và tên";
            dataGridView2.Columns[1].Width = 250;
            dataGridView2.Columns[2].Visible = false;
            // AddButton

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            int studentId = (int)dataGridView2.CurrentCell.Value;
            int classId = _currentClass.Id;
            var success = _classStudentRepository.AddStudentToClass(classId, studentId);
            if (!success)
            {
                MessageBox.Show("Sinh viên đã ở trong lớp học", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _classStudentRepository.SaveChanges();
            Reload();
        }

        private void Reload()
        {
            dataGridView1.DataSource = _studentRepository.GetStudentsByClassId(_currentClass.Id).ToList();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


        private void dataGridView2_OnSelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 0)
            {
                AddButton.Enabled = true;
            }
            else
            {
                AddButton.Enabled = false;
            }
        }
    }
}
