/**
 * @file LoginForm.cs
 * @brief Contains the LoginForm class which represents the login form of the application.
 */

using WinFormsApp1;
using System;
using System.Windows.Forms;

namespace QuickSyncPay
{
    /**
     * @brief Represents the login form of the application.
     */
    public partial class LoginForm : Form
    {
        private String userName = "admin"; /**< The default username. */
        private String password = "admin"; /**< The default password. */

        /**
         * @brief Initializes a new instance of the LoginForm class.
         */
        public LoginForm()
        {
            InitializeComponent();
        }

        /**
         * @brief Loads the LoginForm asynchronously.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private async void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        /**
         * @brief Handles the click event of the login button.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == userName && txtPassword.Text == password)
            {
                MainControl main = new MainControl();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, please try again!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        /**
         * @brief Displays a tooltip when the hide password button is hovered over.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void hidePasswordButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(showPasswordButton, "Hide Password");
        }

        /**
         * @brief Handles the click event of the hide password button.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void hidePasswordButton_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            showPasswordButton.Visible = true;
            hidePasswordButton.Visible = false;
        }

        /**
         * @brief Displays a tooltip when the show password button is hovered over.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void showPasswordButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(showPasswordButton, "Show Password");
        }

        /**
         * @brief Handles the click event of the show password button.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            showPasswordButton.Visible = false;
            hidePasswordButton.Visible = true;
        }

        /**
         * @brief Clears the text fields.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void txtClearField_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }

        /**
         * @brief Handles the click event of the exit button.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void Exit_Click(object sender, EventArgs e)
        {
            // Display a dialog with Yes and No options
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Handle the result
            if (result == DialogResult.Yes)
            {
                // User chooses Yes
                Application.Exit();
            }
        }
    }
}
