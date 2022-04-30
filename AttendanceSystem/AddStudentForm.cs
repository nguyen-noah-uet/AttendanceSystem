using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class AddStudentForm : Form
    {
        private readonly IStudentRepository _studentRepository;
        public AddStudentForm(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentNameTextBox.Text)
                || !maleRatioButton.Checked && !femaleRadioButton.Checked)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var sex = maleRatioButton.Checked ? "Nam" : "Nữ";
            var s = new Student() { StudentName = StudentNameTextBox.Text, Sex = sex };
            _studentRepository.AddStudent(s);
            _studentRepository.SaveChanges();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
