using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindwave.UI
{
    public partial class Form1
    {
        private void SetConnectButtonStatus(bool value)
        {
            this.btnConnect.Enabled = value;
        }

        private void SetDisconnectButtonStatus(bool value)
        {
            this.btnDisconnect.Enabled = value;
        }

        private void SetReadButtonStatus(bool value)
        {
            this.btnRead.Enabled = value;
        }

        private void SetComboComStatus(bool value)
        {
            this.comboCom.Enabled = value;
        }

        private void SetComboBaudrateStatus(bool value)
        {
            this.comboBaudrate.Enabled = value;
        }

        private void SetStopButtonStatus(bool value)
        {
            this.btnStopRead.Enabled = value;
        }

        private void SetStartExperimenButtonStatus(bool value)
        {
            this.btnStartExperiment.Enabled = value;
        }

        private void SetStopExperimentButtonStatus(bool value)
        {
            this.btnStopExperiment.Enabled = value;
        }

        private void SetComboExperimentStatus(bool value)
        {
            this.comboExperiment.Enabled = value;
        }

        private void SetHorizontalPictureBoxVisible(bool value)
        {
            this.HorizontalPictureBox.Visible = value;
        }

        private void SetVerticalPictureBox(bool value)
        {
            this.VerticalPictureBox.Visible = value;
        }
    }
}
