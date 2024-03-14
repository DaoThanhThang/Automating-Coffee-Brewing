using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automating_Coffee_Drewing
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        public void AddRecord(string recipe, string numberOfService, string sugar, string milk, string strengthOfCoffee)
        {
            // Thêm một hàng mới vào DataGridView
            DateTime currentDateTime = DateTime.Now;

            int rowIndex = dataGridView1.Rows.Add();
            // Gán giá trị của tham số vào ô trong cột 1
            dataGridView1.Rows[rowIndex].Cells["dayTime"].Value = currentDateTime;
            dataGridView1.Rows[rowIndex].Cells["Recipe"].Value = recipe;
            dataGridView1.Rows[rowIndex].Cells["numberOfService"].Value = numberOfService;
            dataGridView1.Rows[rowIndex].Cells["sugar"].Value = sugar+"%";
            dataGridView1.Rows[rowIndex].Cells["milk"].Value = milk + "%";
            dataGridView1.Rows[rowIndex].Cells["strengthOfCoffee"].Value = strengthOfCoffee + "%";
            dataGridView1.Refresh();
        }
    }
}
