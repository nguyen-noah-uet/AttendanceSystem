using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class AddClassForm : Form
    {
        private readonly User? _user;
        private readonly IClassRepository _classRepository;
        public AddClassForm(User? user, IClassRepository classRepository)
        {
            _user = user;
            _classRepository = classRepository;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
            {
                MessageBox.Show("Dữ liệu vào không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var c = new Class()
                {
                    ClassName = ClassNameTextBox.Text,
                    User = _user,
                    NoOfSessions = int.Parse(NoOfSessionsTextBox.Text)
                };
                _classRepository.InsertClass(c);
                _classRepository.SaveChanges();
                Close();
            }

        }

        private bool CheckValidData()
        {
            if (string.IsNullOrWhiteSpace(ClassNameTextBox.Text))
            {
                return false;
            }

            foreach (var c in NoOfSessionsTextBox.Text)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            int noOfSessions = int.Parse(NoOfSessionsTextBox.Text);
            if (noOfSessions <= 0) return false;
            return true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
