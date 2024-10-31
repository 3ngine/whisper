using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whisper
{
    public partial class Form1 : Form
    {

        private CancellationTokenSource cancellationTokenSource;

        private readonly Dictionary<int, string> portServices = new Dictionary<int, string>
        {
            { 21, "FTP" },
            { 22, "SSH" },
            { 23, "Telnet" },
            { 25, "SMTP" },
            { 53, "DNS" },
            { 80, "HTTP" },
            { 110, "POP3" },
            { 143, "IMAP" },
            { 443, "HTTPS" },
            { 3306, "MySQL" },
            { 5432, "PostgreSQL" },
            { 6379, "Redis" },
            { 8080, "HTTP-Alt" }
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            if (!IPAddress.TryParse(txtTarget.Text, out IPAddress targetIP))
            {
                MessageBox.Show("Invalid IP Address format.");
                return;
            }

            if (!int.TryParse(txtStartPort.Text, out int startPort) || !int.TryParse(txtEndPort.Text, out int endPort))
            {
                MessageBox.Show("Invalid port range.");
                return;
            }

            if (!int.TryParse(txtTimeout.Text, out int timeout))
            {
                MessageBox.Show("Invalid timeout.");
                return;
            }

            string scanSpeed = cmbScanSpeed.SelectedItem.ToString();
            int delay = scanSpeed switch
            {
                "Fast" => 50,
                "Normal" => 150,
                "Slow" => 300,
                _ => 150
            };

            cancellationTokenSource = new CancellationTokenSource();
            lstResults.Items.Clear();
            lstOpenPorts.Items.Clear();
            progressBarScan.Maximum = endPort - startPort + 1;

            if (chkUdpScan.Checked)
            {
                await ScanUdpPortsAsync(targetIP, startPort, endPort, timeout, delay, cancellationTokenSource.Token);
            }
            else
            {
                await ScanTcpPortsAsync(targetIP, startPort, endPort, timeout, delay, cancellationTokenSource.Token);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private async Task ScanTcpPortsAsync(IPAddress targetIP, int startPort, int endPort, int timeout, int delay, CancellationToken token)
        {
            for (int port = startPort; port <= endPort; port++)
            {
                if (token.IsCancellationRequested)
                {
                    lstResults.Items.Add("Scan canceled.");
                    break;
                }

                try
                {
                    using TcpClient tcpClient = new TcpClient();
                    var connectTask = tcpClient.ConnectAsync(targetIP, port);
                    if (await Task.WhenAny(connectTask, Task.Delay(timeout)) == connectTask)
                    {
                        string service = portServices.ContainsKey(port) ? portServices[port] : "Unknown";
                        lstResults.Items.Add($"Port {port}: Open (Service: {service})");
                        lstOpenPorts.Items.Add($"Port {port}: Open (Service: {service})");
                    }
                    else
                    {
                        lstResults.Items.Add($"Port {port}: Closed");
                    }
                }
                catch (Exception)
                {
                    lstResults.Items.Add($"Port {port}: Closed");
                }

                progressBarScan.Value = port - startPort + 1;
                await Task.Delay(delay);
            }

            lstResults.Items.Add("TCP scan complete.");
        }

        private async Task ScanUdpPortsAsync(IPAddress targetIP, int startPort, int endPort, int timeout, int delay, CancellationToken token)
        {
            for (int port = startPort; port <= endPort; port++)
            {
                if (token.IsCancellationRequested)
                {
                    lstResults.Items.Add("Scan canceled.");
                    break;
                }

                try
                {
                    using UdpClient udpClient = new UdpClient();
                    udpClient.Client.SendTimeout = timeout;
                    udpClient.Client.ReceiveTimeout = timeout;

                    var sendTask = udpClient.SendAsync(new byte[] { 0 }, 1, new IPEndPoint(targetIP, port));
                    await sendTask;

                    var receiveTask = udpClient.ReceiveAsync();
                    if (await Task.WhenAny(receiveTask, Task.Delay(timeout)) == receiveTask)
                    {
                        string service = portServices.ContainsKey(port) ? portServices[port] : "Unknown";
                        lstResults.Items.Add($"Port {port}: Open (Service: {service})");
                        lstOpenPorts.Items.Add($"Port {port}: Open (Service: {service})");
                    }
                    else
                    {
                        lstResults.Items.Add($"Port {port}: Closed");
                    }
                }
                catch (SocketException)
                {
                    lstResults.Items.Add($"Port {port}: Closed");
                }

                progressBarScan.Value = port - startPort + 1;
                await Task.Delay(delay);
            }

            lstResults.Items.Add("UDP scan complete.");
        }
    }
}
