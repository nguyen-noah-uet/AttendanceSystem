using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class ModifyStudentForm : Form
    {
        private readonly IStudentRepository _studentRepository;
        private readonly int _studentId;
        private Student _student;

        public ModifyStudentForm(IStudentRepository studentRepository, int studentId)
        {
            _studentRepository = studentRepository;
            _studentId = studentId;
            _student = _studentRepository.GetStudentById(_studentId);
            InitializeComponent();
        }
        private void ModifyStudentForm_Load(object sender, EventArgs e)
        {
            StudentIdLabel.Text = _studentId.ToString();
            StudentNameTextBox.Text = _student.StudentName;
            maleRadioButton.Checked = (_student.Sex == "Nam");
            femaleRadioButton.Checked = (_student.Sex == "Nữ");
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var sex = maleRadioButton.Checked ? "Nam" : "Nữ";
            var studentInDb = _studentRepository.GetStudentById(_studentId);
            studentInDb.StudentName = StudentNameTextBox.Text;
            studentInDb.Sex = sex;
            _studentRepository.UpdateStudent(studentInDb);
            _studentRepository.SaveChanges();
            Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
