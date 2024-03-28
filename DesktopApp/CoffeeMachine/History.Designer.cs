using System.Drawing;
using System.Windows.Forms;

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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strengthOfCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 64);
            this.panel2.TabIndex = 10;
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
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "Automating Coffee Brewing";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayTime,
            this.Recipe,
            this.NumberOfService,
            this.sugar,
            this.milk,
            this.strengthOfCoffee});
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 334);
            this.dataGridView1.TabIndex = 11;
            // 
            // dayTime
            // 
            this.dayTime.HeaderText = "Day Time";
            this.dayTime.MinimumWidth = 6;
            this.dayTime.Name = "dayTime";
            this.dayTime.ReadOnly = true;
            this.dayTime.Width = 125;
            // 
            // Recipe
            // 
            this.Recipe.HeaderText = "Recipe";
            this.Recipe.MinimumWidth = 6;
            this.Recipe.Name = "Recipe";
            this.Recipe.ReadOnly = true;
            this.Recipe.Width = 125;
            // 
            // NumberOfService
            // 
            this.NumberOfService.HeaderText = "Number of Service";
            this.NumberOfService.MinimumWidth = 6;
            this.NumberOfService.Name = "NumberOfService";
            this.NumberOfService.ReadOnly = true;
            this.NumberOfService.Width = 125;
            // 
            // sugar
            // 
            this.sugar.HeaderText = "Sugar";
            this.sugar.MinimumWidth = 6;
            this.sugar.Name = "sugar";
            this.sugar.ReadOnly = true;
            this.sugar.Width = 125;
            // 
            // milk
            // 
            this.milk.HeaderText = "Milk";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.ReadOnly = true;
            this.milk.Width = 125;
            // 
            // strengthOfCoffee
            // 
            this.strengthOfCoffee.HeaderText = "Strength of Coffee";
            this.strengthOfCoffee.MinimumWidth = 6;
            this.strengthOfCoffee.Name = "strengthOfCoffee";
            this.strengthOfCoffee.ReadOnly = true;
            this.strengthOfCoffee.Width = 125;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "History";
            this.Text = "History";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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