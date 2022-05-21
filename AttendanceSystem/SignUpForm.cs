using AttendanceSystem.Models;
using AttendanceSystem.Repository;

namespace AttendanceSystem
{
    public partial class SignUpForm : Form
    {
        private readonly IUserRepository _userRepository;

        public SignUpForm(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (_userRepository.IsUsernameExisted(UsernameTextBox.Text))
            {
                MessageBox.Show("Tên đăng nhập này đã có người sử dụng", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (PasswordTextBox.Text != RetypePasswordTextBox.Text)
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại mật khẩu", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (PasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải dài ít nhất 8 ký tự", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _userRepository.AddUser(new User() { Username = UsernameTextBox.Text, Password = PasswordTextBox.Text });
            _userRepository.SaveChanges();
            MessageBox.Show("Đăng ký thành công, hãy đăng nhập lại", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}
