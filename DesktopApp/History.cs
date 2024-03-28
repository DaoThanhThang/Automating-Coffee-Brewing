/**
 * @file History.cs
 * @brief Contains the History class which represents the form for displaying coffee brewing history.
 */

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
    /**
     * @brief Represents the form for displaying coffee brewing history.
     */
    public partial class History : Form
    {
        /**
         * @brief Initializes a new instance of the History class.
         */
        public History()
        {
            InitializeComponent();
        }

        /**
         * @brief Adds a new record to the history.
         * @param recipe The recipe of the coffee.
         * @param numberOfService The number of servings.
         * @param sugar The amount of sugar.
         * @param milk The amount of milk.
         * @param strengthOfCoffee The strength of the coffee.
         */
        public void AddRecord(string recipe, string numberOfService, string sugar, string milk, string strengthOfCoffee)
        {
            // Add a new row to the DataGridView
            DateTime currentDateTime = DateTime.Now;

            int rowIndex = dataGridView1.Rows.Add();
            // Assign the values of the parameters to cells in column 1
            dataGridView1.Rows[rowIndex].Cells["dayTime"].Value = currentDateTime;
            dataGridView1.Rows[rowIndex].Cells["Recipe"].Value = recipe;
            dataGridView1.Rows[rowIndex].Cells["numberOfService"].Value = numberOfService;
            dataGridView1.Rows[rowIndex].Cells["sugar"].Value = sugar + "%";
            dataGridView1.Rows[rowIndex].Cells["milk"].Value = milk + "%";
            dataGridView1.Rows[rowIndex].Cells["strengthOfCoffee"].Value = strengthOfCoffee + "%";
            dataGridView1.Refresh();
        }
    }
}
