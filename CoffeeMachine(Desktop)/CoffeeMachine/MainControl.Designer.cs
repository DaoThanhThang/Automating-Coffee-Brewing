using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.button1 = new System.Windows.Forms.Button();
            this.milk = new System.Windows.Forms.ComboBox();
            this.sugar = new System.Windows.Forms.ComboBox();
            this.numberOfService = new System.Windows.Forms.ComboBox();
            this.strengthOfCoffee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recipe = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // milk
            // 
            this.milk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.milk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.milk.FormattingEnabled = true;
            this.milk.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "125",
            "150"});
            this.milk.Location = new System.Drawing.Point(434, 110);
            this.milk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(151, 28);
            this.milk.TabIndex = 1;
            // 
            // sugar
            // 
            this.sugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.sugar.FormattingEnabled = true;
            this.sugar.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "125",
            "150"});
            this.sugar.Location = new System.Drawing.Point(434, 78);
            this.sugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sugar.Name = "sugar";
            this.sugar.Size = new System.Drawing.Size(151, 28);
            this.sugar.TabIndex = 1;
            // 
            // numberOfService
            // 
            this.numberOfService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.numberOfService.FormattingEnabled = true;
            this.numberOfService.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.numberOfService.Location = new System.Drawing.Point(434, 46);
            this.numberOfService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfService.Name = "numberOfService";
            this.numberOfService.Size = new System.Drawing.Size(151, 28);
            this.numberOfService.TabIndex = 2;
            // 
            // strengthOfCoffee
            // 
            this.strengthOfCoffee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strengthOfCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.strengthOfCoffee.FormattingEnabled = true;
            this.strengthOfCoffee.Items.AddRange(new object[] {
            "Mild",
            "Regular",
            "Strong"});
            this.strengthOfCoffee.Location = new System.Drawing.Point(434, 142);
            this.strengthOfCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strengthOfCoffee.Name = "strengthOfCoffee";
            this.strengthOfCoffee.Size = new System.Drawing.Size(151, 28);
            this.strengthOfCoffee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sugar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Milk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(49, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Strength of coffee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 400);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 328);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 64);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(199, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "Automating Coffee Brewing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(49, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Coffee Recipe";
            // 
            // recipe
            // 
            this.recipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recipe.FormattingEnabled = true;
            this.recipe.Items.AddRange(new object[] {
            "Black coffee",
            "Espresso",
            "Cappuccino",
            "Latte",
            "Mocha",
            "Café au lait",
            "Macchiato",
            "Americano"});
            this.recipe.Location = new System.Drawing.Point(434, 14);
            this.recipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipe.Name = "recipe";
            this.recipe.Size = new System.Drawing.Size(151, 28);
            this.recipe.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.recipe);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.strengthOfCoffee);
            this.panel3.Controls.Add(this.numberOfService);
            this.panel3.Controls.Add(this.sugar);
            this.panel3.Controls.Add(this.milk);
            this.panel3.Location = new System.Drawing.Point(116, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 282);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.status);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(118, 370);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 67);
            this.panel4.TabIndex = 13;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(110, 23);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 28);
            this.status.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status:";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 442);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainControl";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private ToolTip toolTip1;
        private Panel panel3;
        private Panel panel4;
        private Label status;
        private Label label8;
    }
}
