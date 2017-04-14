using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Mindwave.Controller;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mindwave.UI
{
    public partial class Form1 : Form
    {
        bool _monitorWaves;
        bool _monitorSignal;
        bool _allowExperiment;
        string _sessionFileName;

        public Form1()
        {
            InitializeComponent();
            InitChart();

            _sessionFileName = DateTime.Now.ToString("ddMMyy_HHmmss");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            var comPort = ReadComPort();
            var baudRate = ReadBaudrate();

            WriteToLog("Connecting to device..\n");

            if (!string.IsNullOrEmpty(comPort))
            {
                Connector.Connect(comPort);
                if (Connector.Connected)
                {
                    SetConnectButtonStatus(false);
                    SetComboComStatus(false);
                    SetComboBaudrateStatus(false);

                    SetDisconnectButtonStatus(true);
                    SetReadButtonStatus(true);

                    Thread.Sleep(250);

                    EnableRead();

                    _monitorSignal = true;

                    StartMonitorSignal();

                    WriteToLog("Connected to the device.\n");
                }
                else
                {
                    WriteToLog("Failed to connect to the device.\n");
                }
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            WriteToLog("Disconnecting from the device..\n");

            if (Connector.Connected)
            {
                Connector.Disconnect();

                SetConnectButtonStatus(true);
                SetComboComStatus(true);
                SetComboBaudrateStatus(true);

                SetDisconnectButtonStatus(false);
                SetReadButtonStatus(false);
                SetStopButtonStatus(false);

                _monitorWaves = false;
                _monitorSignal = false;

                WriteToLog("Disconnected from the device.\n");
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.txtLog.Invoke((MethodInvoker)delegate { this.txtLog.Clear(); });
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (Connector.Connected)
            {
                Thread.Sleep(150);
                WriteToLog("Started reading from connected device.\n");

                _monitorWaves = true;
                StartMonitorWaves();

                SetReadButtonStatus(false);

                SetStopButtonStatus(true);
            }
        }

        private void btnStopRead_Click(object sender, EventArgs e)
        {
            _monitorWaves = false;

            SetReadButtonStatus(true);

            SetStopButtonStatus(false);
        }

        private void btnStartExperiment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && comboAge.SelectedItem != null && comboExperiment.SelectedItem != null)
            {
                _allowExperiment = true;
                _participantName = txtName.Text;
                _ageGroup = comboAge.SelectedItem.ToString();
                _sessionFileName = _participantName + "_" + DateTime.Now.ToString("ddMMyy_HHmmss");
                _id = Guid.NewGuid();

                SetStopExperimentButtonStatus(true);

                SetStartExperimenButtonStatus(false);
            }

            StartExperiments();
        }

        private void BtnStopExperiment_Click(object sender, EventArgs e)
        {
            StopExperiments();
        }

        private string ReadComPort()
        {
            return comboCom.SelectedItem == null ? string.Empty : comboCom.SelectedItem.ToString();
        }

        private int? ReadBaudrate()
        {
            if (this.comboBaudrate.SelectedItem != null)
            {
                return int.Parse(this.comboBaudrate.SelectedItem.ToString());
            }
            return (int?)null;
        }

        private void WriteToLog(string message)
        {
            this.Invoke((MethodInvoker)delegate { this.txtLog.AppendText(message); });
        }

        private void EnableRead()
        {
            var signalReadThread = new Thread(new ThreadStart(this.EnableReadData));
            signalReadThread.IsBackground = true;
            signalReadThread.Start();
        }

        private void EnableReadData()
        {
            Connector.SetAutoRead();
        }

        private void StartMonitorSignal()
        {
            var monitorThread = new Thread(new ThreadStart(this.MonitorSignal));
            monitorThread.IsBackground = true;
            monitorThread.Start();
        }

        private void StartMonitorWaves()
        {
            var wavesMonitorThread = new Thread(new ThreadStart(MonitorWaves));
            wavesMonitorThread.IsBackground = true;
            wavesMonitorThread.Start();
        }

        private void InitChart()
        {
            string[] allSeries = { "Delta", "Theta", "Low Alpha", "High Alpha", "Low Beta", "High Beta", "Low Gamma", "High Gamma" };
            float[] points = { 0, 0, 0, 0, 0, 0, 0, 0 };

            this.WavesChart.Titles.Clear();
            this.WavesChart.Series.Clear();
            this.WavesChart.Titles.Add("Brain Waves");

            for (int i = 0; i < allSeries.Length; i++)
            {
                Series series = this.WavesChart.Series.Add(allSeries[i]);
                series.ChartType = SeriesChartType.Spline;
                series.Points.Add(points[i]);
            }
        }

        
    }
}
