using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batutest
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort;
        private bool isConnected;
        private UdpClient udpClient;
        private bool isConnectedudp;
        private const string LED_ON_COMMAND = "ON";
        private const string LED_OFF_COMMAND = "OFF";

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializeUdpClient();
        }
        private void InitializeUdpClient()
        {
            udpClient = new UdpClient();
        }
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {
           
            if (!isConnected)
            {
                try
                {
                    serialPort.PortName = PortsComboBox.SelectedItem.ToString();
                    serialPort.BaudRate = (int)BaudrateComboBox.SelectedItem;
                    serialPort.Parity = (Parity)ParityComboBox.SelectedItem;
                    serialPort.StopBits = (StopBits)StopbitComboBox.SelectedItem;

                    serialPort.Open();
                    isConnected = true;
                    ConnectButton.Text = "Bağlantıyı Kes";
                    COMGroupBox.BackColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    COMGroupBox.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                try
                {
                    serialPort.Close();
                    isConnected = false;
                    ConnectButton.Text = "BAĞLAN";
                    COMGroupBox.BackColor = System.Drawing.Color.White;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı kesme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Seri porttan veri alındığında bu metot çağrılır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////  combobox  içerikleri
            ///

            // Ports (Portlar) ComboBox'ı için mevcut seri portları yükleme
            string[] ports = SerialPort.GetPortNames();
            PortsComboBox.Items.AddRange(ports);
            PortsComboBox.SelectedIndex = 0; // İlk seçeneği seçili olarak ayarla

            // Baudrate (Aktarım Hızı) ComboBox'ı için seçenekleri yükleme
            int[] baudRates = { 9600, 19200, 38400, 57600, 115200 };
            foreach (int baudRate in baudRates)
            {
                BaudrateComboBox.Items.Add(baudRate);
            }
            BaudrateComboBox.SelectedIndex = 0; // İlk seçeneği seçili olarak ayarla

            // Stopbit (Durma Biti) ComboBox'ı için seçenekleri yükleme
            StopbitComboBox.Items.Add(StopBits.One);
            StopbitComboBox.Items.Add(StopBits.Two);
            StopbitComboBox.SelectedIndex = 0; // İlk seçeneği seçili olarak ayarla

            // Parity (Çiftlik Kontrolü) ComboBox'ı için seçenekleri yükleme
            ParityComboBox.Items.Add(Parity.None);
            ParityComboBox.Items.Add(Parity.Odd);
            ParityComboBox.Items.Add(Parity.Even);
            ParityComboBox.Items.Add(Parity.Mark);
            ParityComboBox.Items.Add(Parity.Space);

            ParityComboBox.SelectedIndex = 0; // İlk seçeneği seçili olarak ayarla





            ////////
            /// udpp
            /// 
            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 0));

        }

        private void udpbaglan_Click(object sender, EventArgs e)
        {
            if (!isConnectedudp)
            {
                try
                {
                    int port = Convert.ToInt32(PortTextBox.Text);
                    udpClient.Connect(IPAddress.Any, port);
                    isConnectedudp = true;
                    udpbaglan.Text = "Bağlantıyı Kes";
                    UDPGroupBox.BackColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    udpClient.Close();
                    isConnectedudp = false;
                    udpbaglan.Text = "BAĞLAN";
                    UDPGroupBox.BackColor = System.Drawing.Color.White;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı kesme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void SendCommandToArduino(string command)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine(command);
                }
                else
                {
                    MessageBox.Show("Seri port bağlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Komut gönderme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async  void LedON_Click(object sender, EventArgs e)
        {
            SendCommandToArduino(LED_ON_COMMAND);
            UpdateStatus("Paket Gönderildi", Color.Green);
            await Task.Delay(15000); // 15 saniye bekleyin
            UpdateStatus("Boşta", Color.Red);
        }

        private async void LedOFF_Click(object sender, EventArgs e)
        {
            SendCommandToArduino(LED_OFF_COMMAND);
            UpdateStatus("Paket Gönderildi", Color.Green);
            await Task.Delay(15000); // 15 saniye bekleyin
            UpdateStatus("Boşta", Color.Red);
        }

        private void UpdateStatus(string statusText, Color color)
        {
            StatusLabel.Text = statusText;
            StatusProgressBar.BackColor= color;
        }
    }
}
    

