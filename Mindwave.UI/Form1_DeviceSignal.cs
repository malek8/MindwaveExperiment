using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Mindwave.Controller;
using System.Windows.Forms;
using System.Drawing;

namespace Mindwave.UI
{
    public partial class Form1
    {
        private void MonitorSignal()
        {
            var attention = 0;
            var meditation = 0;
            do
            {
                var signal = Connector.Signal();

                if (Connector.CanRead)
                {
                    attention = Connector.Attention();
                    meditation = Connector.Meditation();
                }

                this.Invoke((MethodInvoker)delegate { SetSignalLabel(signal); });
                this.Invoke((MethodInvoker)delegate { SetAttentionLevel(attention); });
                this.Invoke((MethodInvoker)delegate { SetMeditationLevel(meditation); });

                Thread.Sleep(25);
            }
            while (Connector.Connected && _monitorSignal);

            this.Invoke((MethodInvoker)delegate { SetSignalLabel(200); });
            this.Invoke((MethodInvoker)delegate { SetAttentionLevel(0); });
            this.Invoke((MethodInvoker)delegate { SetMeditationLevel(0); });

            WriteToLog($"No Signal detected.\n");
        }

        private void SetSignalLabel(float poorSignal)
        {
            if (poorSignal == 0)
            {
                this.lblSignal.Text = "Good";
                this.lblSignal.BackColor = Color.Green;
            }
            else if (poorSignal <= 25)
            {
                this.lblSignal.Text = "Average";
                this.lblSignal.BackColor = Color.Yellow;
            }
            else
            {
                this.lblSignal.Text = "Bad";
                this.lblSignal.BackColor = Color.Red;
            }
        }

        private void SetAttentionLevel(int value)
        {
            this.AttentionProgress.Value = value;
            this.AttentionLabel.Text = value.ToString();
        }

        private void SetMeditationLevel(int value)
        {
            this.MeditationProgress.Value = value;
            this.MeditationLabel.Text = value.ToString();
        }
    }
}
