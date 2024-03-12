using System.Windows.Forms;
using System;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WinFormsApp1
{
    public  partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private bool IsNullOrEmpty(string _string)
        {
            return string.IsNullOrEmpty(_string);
        }
        private string getDetail()
        {
            string _recipe = recipe.SelectedItem?.ToString() ?? "";
            string _numberOfService = numberOfService.SelectedItem?.ToString() ?? "";
            string _sugar = sugar.SelectedItem?.ToString() ?? "";
            string _milk = milk.SelectedItem?.ToString() ?? "";
            string _strengthOfCoffee = strengthOfCoffee.SelectedItem?.ToString() ?? "";

            // Check each combobox
            if (IsNullOrEmpty(_recipe))
            {
                MessageBox.Show("Recipe is null,plese select ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_numberOfService))
            {
                MessageBox.Show("number of service choice is null,plese select ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_sugar))
            {
                MessageBox.Show("sugar choice is null,plese select ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_milk))
            {
                MessageBox.Show("Milk choice is null,plese select ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_strengthOfCoffee))
            {
                MessageBox.Show("Streng of coffee choice is null,plese select ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            if (_strengthOfCoffee == "Mild") _strengthOfCoffee = "75";
            if (_strengthOfCoffee == "Regular") _strengthOfCoffee = "100";
            if (_strengthOfCoffee == "Strong") _strengthOfCoffee = "150";
            // Return Result
            return _recipe + "," + _numberOfService + "," + _sugar + "," + _milk + "," + _strengthOfCoffee;

        }
        private void SendData(string data)
        {
            IPAddress esp32IPAddress = new IPAddress(new byte[] { 192, 168, 1, 100 });
            try
            {
                // Sử dụng địa chỉ IP này khi tạo TcpClient
                using (TcpClient client = new TcpClient(esp32IPAddress.ToString(), 80))  
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes(data);
                        stream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsNullOrEmpty(getDetail())) {
            string dataToSend = getDetail();
            SendData(dataToSend);
                MessageBox.Show("Successfully.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please check the data before sending.", "Data Not Checked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
