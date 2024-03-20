namespace Automating_Coffee_Drewing
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            dayTime = new DataGridViewTextBoxColumn();
            Recipe = new DataGridViewTextBoxColumn();
            NumberOfService = new DataGridViewTextBoxColumn();
            sugar = new DataGridViewTextBoxColumn();
            milk = new DataGridViewTextBoxColumn();
            strengthOfCoffee = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 80);
            panel2.TabIndex = 10;
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
            label5.ForeColor = Color.White;
            label5.Location = new Point(214, 23);
            label5.Name = "label5";
            label5.Size = new Size(414, 41);
            label5.TabIndex = 10;
            label5.Text = "Automating Coffee Brewing";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dayTime, Recipe, NumberOfService, sugar, milk, strengthOfCoffee });
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 417);
            dataGridView1.TabIndex = 11;
            // 
            // dayTime
            // 
            dayTime.HeaderText = "Day Time";
            dayTime.MinimumWidth = 6;
            dayTime.Name = "dayTime";
            dayTime.ReadOnly = true;
            dayTime.Width = 125;
            // 
            // Recipe
            // 
            Recipe.HeaderText = "Recipe";
            Recipe.MinimumWidth = 6;
            Recipe.Name = "Recipe";
            Recipe.ReadOnly = true;
            Recipe.Width = 125;
            // 
            // NumberOfService
            // 
            NumberOfService.HeaderText = "Number of Service";
            NumberOfService.MinimumWidth = 6;
            NumberOfService.Name = "NumberOfService";
            NumberOfService.ReadOnly = true;
            NumberOfService.Width = 125;
            // 
            // sugar
            // 
            sugar.HeaderText = "Sugar";
            sugar.MinimumWidth = 6;
            sugar.Name = "sugar";
            sugar.ReadOnly = true;
            sugar.Width = 125;
            // 
            // milk
            // 
            milk.HeaderText = "Milk";
            milk.MinimumWidth = 6;
            milk.Name = "milk";
            milk.ReadOnly = true;
            milk.Width = 125;
            // 
            // strengthOfCoffee
            // 
            strengthOfCoffee.HeaderText = "Strength of Coffee";
            strengthOfCoffee.MinimumWidth = 6;
            strengthOfCoffee.Name = "strengthOfCoffee";
            strengthOfCoffee.ReadOnly = true;
            strengthOfCoffee.Width = 125;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 495);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "History";
            Text = "History";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dayTime;
        private DataGridViewTextBoxColumn Recipe;
        private DataGridViewTextBoxColumn NumberOfService;
        private DataGridViewTextBoxColumn sugar;
        private DataGridViewTextBoxColumn milk;
        private DataGridViewTextBoxColumn strengthOfCoffee;
    }
}