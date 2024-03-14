using WinFormsApp1;

namespace QuickSyncPay
{
    public partial class LoginForm : Form
    {
        private String userName = "admin";
        private String password = "admin";

        public LoginForm()
        {
            InitializeComponent();

        }
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == userName && txtPassword.Text == password)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, please try again! ");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }
        private void hidePasswordButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(showPasswordButton, "Hide Password");
        }

        private void hidePasswordButton_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            showPasswordButton.Visible = true;
            hidePasswordButton.Visible = false;
        }
        //Button show password
        private void showPasswordButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(showPasswordButton, "Show Password");
        }
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            showPasswordButton.Visible = false;
            hidePasswordButton.Visible = true;
        }

        private void txtClearField_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            // Hiển thị dialog với lựa chọn Yes và No
            DialogResult result = MessageBox.Show("Are you want to exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                // Người dùng chọn Yes
                Application.Exit();
            }

        }
    }
}
