/**
 * @file MainControl.cs
 * @brief Contains the MainControl class which represents the main form of the coffee brewing application.
 */

using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;
using System.Net;
using Automating_Coffee_Drewing;
using System.Linq;
using System.Threading;

namespace WinFormsApp1
{
    /**
     * @brief Represents the main form of the coffee brewing application.
     */
    public partial class MainControl : Form
    {
        private string _recipe; /**< The selected recipe. */
        private string _numberOfService; /**< The selected number of service. */
        private string _sugar; /**< The selected amount of sugar. */
        private string _milk; /**< The selected amount of milk. */
        private string _strengthOfCoffee; /**< The selected strength of coffee. */
        private History history = new History(); /**< Instance of the history class. */

        /**
         * @brief Initializes a new instance of the MainControl class.
         */
        public MainControl()
        {
            InitializeComponent();
            string ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(); // Lay dia chi ip may
            SendAndReceiveData("IP:" + ipAddress);
        }

        /**
         * @brief Checks if a string is null or empty.
         * @param _string The string to be checked.
         * @return True if the string is null or empty, otherwise false.
         */
        private bool IsNullOrEmpty(string _string)
        {
            return string.IsNullOrEmpty(_string);
        }

        /**
         * @brief Gets the details of the coffee order.
         * @return A string containing the details of the coffee order.
         */
        private string getDetail()
        {
            this._recipe = recipe.SelectedItem?.ToString() ?? "";
            this._numberOfService = numberOfService.SelectedItem?.ToString() ?? "";
            this._sugar = sugar.SelectedItem?.ToString() ?? "";
            this._milk = milk.SelectedItem?.ToString() ?? "";
            this._strengthOfCoffee = strengthOfCoffee.SelectedItem?.ToString() ?? "";

            // Check each combobox
            if (IsNullOrEmpty(_recipe))
            {
                MessageBox.Show("Recipe is null, please select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_numberOfService))
            {
                MessageBox.Show("Number of service choice is null, please select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_sugar))
            {
                MessageBox.Show("Sugar choice is null, please select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_milk))
            {
                MessageBox.Show("Milk choice is null, please select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (IsNullOrEmpty(_strengthOfCoffee))
            {
                MessageBox.Show("Strength of coffee choice is null, please select", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            if (_strengthOfCoffee == "Mild") _strengthOfCoffee = "75";
            if (_strengthOfCoffee == "Regular") _strengthOfCoffee = "100";
            if (_strengthOfCoffee == "Strong") _strengthOfCoffee = "150";
            // Return Result
            return _recipe + "," + _numberOfService + "," + _sugar + "," + _milk + "," + _strengthOfCoffee;
        }

        /**
         * @brief Sends and receives data to and from the device.
         * @param dataToSend The data to be sent to the device.
         */
        private void SendAndReceiveData(string dataToSend)
        {
            try
            {
                // Send data
                ThreadPool.QueueUserWorkItem(new WaitCallback(SendData), dataToSend);

                // Receive data
                ThreadPool.QueueUserWorkItem(new WaitCallback(ReceiveData));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /**
         * @brief Sends data to the device.
         * @param data The data to be sent.
         */
        private void SendData(object data)
        {
            try
            {
                string dataToSend = (string)data;

                using (TcpClient client = new TcpClient())
                {
                    client.Connect("192.168.3.100", 8000);

                    if (client.Connected)
                    {
                        using (NetworkStream stream = client.GetStream())
                        {
                            byte[] buffer = Encoding.ASCII.GetBytes(dataToSend);
                            stream.Write(buffer, 0, buffer.Length);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed to establish connection.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        /**
         * @brief Receives data from the device.
         * @param state The state object.
         */
        private void ReceiveData(object state)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, 12345);
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

        /**
         * @brief Displays the signal based on the received data.
         * @param receivedData The received data.
         */
        private void displaySignal(String receivedData)
        {
            if (receivedData == "LOW INVENTORY COFFEE")
            {
                status.Text = "LOW INVENTORY COFFEE!";
                MessageBox.Show("LOW INVENTORY COFFEE!");
            }
            if (receivedData == "LOW INVENTORY WATER")
            {
                status.Text = "LOW INVENTORY WATER!";
                MessageBox.Show("LOW INVENTORY WATER!");
            }
            if (receivedData == "LOW INVENTORY SUGAR")
            {
                status.Text = "LOW INVENTORY SUGAR!";
                MessageBox.Show("LOW INVENTORY SUGAR!");
            }
            if (receivedData == "LOW INVENTORY MILK")
            {
                status.Text = "LOW INVENTORY MILK!";
                MessageBox.Show("LOW INVENTORY MILK!");
            }
        }

        /**
         * @brief Handles the click event of the send button.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getDetail()))
            {
                string dataToSend = getDetail();
                SendAndReceiveData(dataToSend);
                history.AddRecord(_recipe, _numberOfService, _sugar, _milk, _strengthOfCoffee);
            }
            else
            {
                MessageBox.Show("Please check the data before sending.", "Data Not Checked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * @brief Handles the click event of the history button.
         * @param sender The object that raised the event.
         * @param e The event arguments.
         */
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            history.ShowDialog();
        }
        /**
    * @brief Handles the click event of the support button.
    * @param sender The object that raised the event.
    * @param e The event arguments.
    */
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowSupportMessage();
        }
        /**
    * @brief Display the support message
    */
        private void ShowSupportMessage()
        {
            // Message content
            string message = "If you need support, please contact us via email: thang.techcareers@gmail.com\nThe software is provided by DaoThanhThang.";

            // Display support message
            MessageBox.Show(message, "Support", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
