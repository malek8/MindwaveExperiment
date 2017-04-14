using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Mindwave.Controller;

namespace Mindwave.UI
{
    public partial class Form1
    {
        string filePath { get { return Environment.CurrentDirectory + $@"\{_sessionFileName}.csv"; } }

        private void MonitorWaves()
        {
            do
            {
                var brainWaves = Connector.ReadWaves();

                UpdateChart(brainWaves);

                if (_allowExperiment)
                {
                    WriteToFile(brainWaves);
                }

                Thread.Sleep(150);
            }
            while (Connector.Connected && Connector.CanRead && _monitorWaves);
        }

        private void UpdateChart(BrainWaves waves)
        {
            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["Low Alpha"].Points.Add(waves.Alpha1); });
            //WriteToLog($"Low-Alpha: {waves.LowAlpha}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["High Alpha"].Points.Add(waves.Alpha2); });
            //WriteToLog($"High-Alpha: {waves.HighAlpha}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["Delta"].Points.Add(waves.Delta); });
            //WriteToLog($"Delta: {waves.Delta}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["Theta"].Points.Add(waves.Theta); });
            //WriteToLog($"Theta: {waves.Theta}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["Low Beta"].Points.Add(waves.Beta1); });
            //WriteToLog($"Low-Beta: {waves.LowBeta}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["High Beta"].Points.Add(waves.Beta2); });
            //WriteToLog($"High-Beta: {waves.HighBeta}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["Low Gamma"].Points.Add(waves.Gamma1); });
            //WriteToLog($"Low-Gamma: {waves.LowGamma}\n");

            this.Invoke((MethodInvoker)delegate { this.WavesChart.Series["High Gamma"].Points.Add(waves.Gamma2); });
            //WriteToLog($"High-Gamma: {waves.HighGamma}\n");
        }

        private void PrepareFile()
        {
            if (!File.Exists(filePath))
            {
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"ID, Time, Raw, Signal, Attention, Meditation, Delta, Theta, Alpha1, Alpha2, Beta1, Beta2, Gamma1, Gamma2, Experiment, Color, Move, Name, AgeGroup");
                }
            }
        }

        private void WriteToFile(BrainWaves waves)
        {
            PrepareFile();
            using (var writer = new StreamWriter(filePath, true))
            {
                if (_id == null) _id = new Guid();
                writer.WriteLine($"{_id}, {DateTime.Now.ToString("HH:mm:ss.ffffff")}, {waves.Raw}, {waves.Signal}, {waves.Attention}, {waves.Meditation}, {waves.Delta}, {waves.Theta}, {waves.Alpha1}, {waves.Alpha2}, {waves.Beta1}, {waves.Beta2}, {waves.Gamma1}, {waves.Gamma2}, {_currentExperiment}, {_currentColor}, {_currentMove}, {_participantName}, {_ageGroup}");
            }
        }
    }
}
