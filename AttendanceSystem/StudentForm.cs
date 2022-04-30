using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class StudentForm : Form
    {
        private readonly IStudentRepository _studentRepository;

        public StudentForm(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        private void LoadData()
        {
            dataGridView1.DataSource = _studentRepository.GetAll().ToList();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _studentRepository.SaveChanges();
            Close();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm(_studentRepository);
            addStudentForm.ShowDialog();
            LoadData();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            var modifyStudentForm = new ModifyStudentForm(_studentRepository, (int)dataGridView1.CurrentCell.Value);
            modifyStudentForm.ShowDialog();
            LoadData();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            _studentRepository.DeleteStudent((int)dataGridView1.CurrentCell.Value);
            _studentRepository.SaveChanges();
            LoadData();
        }

        private void OnSelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                ModifyButton.Enabled = true;
                DeleteStudentButton.Enabled = true;
            }
            else
            {
                ModifyButton.Enabled = false;
                DeleteStudentButton.Enabled = false;
            }
        }
    }
}
