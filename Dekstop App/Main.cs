using System.Windows.Forms;
using System;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Automating_Coffee_Drewing;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(); // Lay dia chi ip may
            SendAndReceiveData("IP:"+ipAddress);
        }
        private string _recipe;
        private string _numberOfService;
        private string _sugar;
        private string _milk;
        private string _strengthOfCoffee;
        History history = new History();
        private bool IsNullOrEmpty(string _string)
        {
            return string.IsNullOrEmpty(_string);
        }
        private string getDetail()
        {
            this._recipe = recipe.SelectedItem?.ToString() ?? "";
            this. _numberOfService = numberOfService.SelectedItem?.ToString() ?? "";
            this._sugar = sugar.SelectedItem?.ToString() ?? "";
            this._milk = milk.SelectedItem?.ToString() ?? "";
            this._strengthOfCoffee = strengthOfCoffee.SelectedItem?.ToString() ?? "";

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
        private void SendAndReceiveData(string dataToSend)
        {
            try
            {
                // Gửi dữ liệu
                ThreadPool.QueueUserWorkItem(new WaitCallback(SendData), dataToSend);

                // Nhận dữ liệu
                ThreadPool.QueueUserWorkItem(new WaitCallback(ReceiveData));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SendData(object data)
        {
            try
            {
                string dataToSend = (string)data;
                IPAddress esp32IPAddress = new IPAddress(new byte[] { 192, 168, 1, 100 });

                using (TcpClient client = new TcpClient(esp32IPAddress.ToString(), 80))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes(dataToSend);
                        stream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }

        private void ReceiveData(object state)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, 80);
                listener.Start();

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    displaySignal(receivedData);
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving data: " + ex.Message);
            }
        }
        private void displaySignal(String receivedData)
        {
            if(receivedData == "LOW INVENTORY COFFEE")
            {
                status.Text = "LOW INVENTORY COFFEE !";
                MessageBox.Show("LOW INVENTORY COFFEE !");
            }
            if (receivedData == "LOW INVENTORY WATER")
            {
                status.Text = "LOW INVENTORY WATER !";
                MessageBox.Show("LOW INVENTORY WATER !");
            }
            if (receivedData == "LOW INVENTORY SUGAR")
            {
                status.Text = "LOW INVENTORY SUGAR !";
                MessageBox.Show("LOW INVENTORY SUGAR !");
            }
            if (receivedData == "LOW INVENTORY MILK")
            {
                status.Text = "LOW INVENTORY MILK !";
                MessageBox.Show("LOW INVENTORY MILK !");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getDetail()))
            {
                string dataToSend = getDetail();
                SendAndReceiveData(dataToSend);
                history.AddRecord(_recipe, _numberOfService, _sugar, _milk, _strengthOfCoffee);
                MessageBox.Show("Successfully.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status.Text = "Sent to the device successfully !";
            }
            else
            {
                MessageBox.Show("Please check the data before sending.", "Data Not Checked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            history.ShowDialog();
        }
    }
}
