namespace QuickSyncPay
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            loginButton = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtClearField = new Label();
            Exit = new Label();
            hidePasswordButton = new PictureBox();
            showPasswordButton = new PictureBox();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePasswordButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordButton).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(96, 159, 224);
            label1.Location = new Point(147, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 216);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(33, 250);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 280);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(33, 315);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 1);
            panel2.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(96, 159, 224);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(33, 386);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(344, 55);
            loginButton.TabIndex = 4;
            loginButton.Text = "LOG IN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(90, 223);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 21);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(90, 287);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 21);
            txtPassword.TabIndex = 5;
            // 
            // txtClearField
            // 
            txtClearField.AutoSize = true;
            txtClearField.ForeColor = Color.FromArgb(96, 159, 224);
            txtClearField.Location = new Point(269, 333);
            txtClearField.Name = "txtClearField";
            txtClearField.Size = new Size(108, 22);
            txtClearField.TabIndex = 6;
            txtClearField.Text = "Clear Field";
            txtClearField.Click += txtClearField_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.ForeColor = Color.FromArgb(96, 159, 224);
            Exit.Location = new Point(183, 464);
            Exit.Name = "Exit";
            Exit.Size = new Size(44, 22);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // hidePasswordButton
            // 
            hidePasswordButton.Image = (Image)resources.GetObject("hidePasswordButton.Image");
            hidePasswordButton.Location = new Point(348, 281);
            hidePasswordButton.Margin = new Padding(4, 3, 4, 3);
            hidePasswordButton.Name = "hidePasswordButton";
            hidePasswordButton.Size = new Size(34, 28);
            hidePasswordButton.SizeMode = PictureBoxSizeMode.StretchImage;
            hidePasswordButton.TabIndex = 2;
            hidePasswordButton.TabStop = false;
            hidePasswordButton.Click += hidePasswordButton_Click;
            hidePasswordButton.MouseHover += hidePasswordButton_MouseHover;
            // 
            // showPasswordButton
            // 
            showPasswordButton.Image = (Image)resources.GetObject("showPasswordButton.Image");
            showPasswordButton.Location = new Point(348, 280);
            showPasswordButton.Margin = new Padding(4, 3, 4, 3);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(34, 28);
            showPasswordButton.SizeMode = PictureBoxSizeMode.StretchImage;
            showPasswordButton.TabIndex = 2;
            showPasswordButton.TabStop = false;
            showPasswordButton.Click += showPasswordButton_Click;
            showPasswordButton.MouseHover += showPasswordButton_MouseHover;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 594);
            Controls.Add(Exit);
            Controls.Add(txtClearField);
            Controls.Add(txtUsername);
            Controls.Add(loginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(showPasswordButton);
            Controls.Add(hidePasswordButton);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePasswordButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button loginButton;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label txtClearField;
        private Label Exit;
        private PictureBox hidePasswordButton;
        private PictureBox showPasswordButton;
        private ToolTip toolTip;
    }
}
