﻿namespace WinFormsApp1
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            button1 = new Button();
            milk = new ComboBox();
            sugar = new ComboBox();
            numberOfService = new ComboBox();
            strengthOfCoffee = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            recipe = new ComboBox();
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            status = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 228);
            button1.Name = "button1";
            button1.Size = new Size(299, 66);
            button1.TabIndex = 0;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // milk
            // 
            milk.DropDownStyle = ComboBoxStyle.DropDownList;
            milk.Font = new Font("Microsoft Sans Serif", 10.2F);
            milk.FormattingEnabled = true;
            milk.Items.AddRange(new object[] { "50", "75", "100", "125", "150" });
            milk.Location = new Point(434, 137);
            milk.Name = "milk";
            milk.Size = new Size(151, 28);
            milk.TabIndex = 1;
            // 
            // sugar
            // 
            sugar.DropDownStyle = ComboBoxStyle.DropDownList;
            sugar.Font = new Font("Microsoft Sans Serif", 10.2F);
            sugar.FormattingEnabled = true;
            sugar.Items.AddRange(new object[] { "50", "75", "100", "125", "150" });
            sugar.Location = new Point(434, 97);
            sugar.Name = "sugar";
            sugar.Size = new Size(151, 28);
            sugar.TabIndex = 1;
            // 
            // numberOfService
            // 
            numberOfService.DropDownStyle = ComboBoxStyle.DropDownList;
            numberOfService.Font = new Font("Microsoft Sans Serif", 10.2F);
            numberOfService.FormattingEnabled = true;
            numberOfService.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            numberOfService.Location = new Point(434, 57);
            numberOfService.Name = "numberOfService";
            numberOfService.Size = new Size(151, 28);
            numberOfService.TabIndex = 2;
            // 
            // strengthOfCoffee
            // 
            strengthOfCoffee.DropDownStyle = ComboBoxStyle.DropDownList;
            strengthOfCoffee.Font = new Font("Microsoft Sans Serif", 10.2F);
            strengthOfCoffee.FormattingEnabled = true;
            strengthOfCoffee.Items.AddRange(new object[] { "Mild", "Regular", "Strong" });
            strengthOfCoffee.Location = new Point(434, 177);
            strengthOfCoffee.Name = "strengthOfCoffee";
            strengthOfCoffee.Size = new Size(151, 28);
            strengthOfCoffee.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(49, 57);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 4;
            label1.Text = "Number of Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(49, 97);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Sugar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(49, 137);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Milk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(49, 177);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 7;
            label4.Text = "Strength of coffee";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 500);
            panel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(0, 79);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 13;
            label7.Text = "Oder History";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 410);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 80);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(720, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(199, 23);
            label5.Name = "label5";
            label5.Size = new Size(414, 41);
            label5.TabIndex = 10;
            label5.Text = "Automating Coffee Brewing";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(49, 17);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 11;
            label6.Text = "Coffee Recipe";
            // 
            // recipe
            // 
            recipe.DropDownStyle = ComboBoxStyle.DropDownList;
            recipe.Font = new Font("Microsoft Sans Serif", 10.2F);
            recipe.FormattingEnabled = true;
            recipe.Items.AddRange(new object[] { "Black coffee", "Espresso", "Cappuccino", "Latte", "Mocha", "Café au lait", "Macchiato", "Americano" });
            recipe.Location = new Point(434, 17);
            recipe.Name = "recipe";
            recipe.Size = new Size(151, 28);
            recipe.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(recipe);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(strengthOfCoffee);
            panel3.Controls.Add(numberOfService);
            panel3.Controls.Add(sugar);
            panel3.Controls.Add(milk);
            panel3.Location = new Point(116, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 353);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(status);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(118, 462);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 84);
            panel4.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 29);
            label8.Name = "label8";
            label8.Size = new Size(69, 28);
            label8.TabIndex = 0;
            label8.Text = "Status:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.Location = new Point(110, 29);
            status.Name = "status";
            status.Size = new Size(0, 28);
            status.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox milk;
        private ComboBox sugar;
        private ComboBox numberOfService;
        private ComboBox strengthOfCoffee;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private ComboBox recipe;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label7;
        private ToolTip toolTip1;
        private Panel panel3;
        private Panel panel4;
        private Label status;
        private Label label8;
    }
}
