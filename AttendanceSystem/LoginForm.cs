using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;
        public bool Success { get; private set; } = false;
        public User User { get; private set; }
        public LoginForm(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Success = _userRepository.CheckUsernamePassword(UsernameTextBox.Text, PasswordTextBox.Text);
            if (!Success)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User = _userRepository.GetUserByUsername(UsernameTextBox.Text);
            Close();

        }
    }
}
