using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using Mindwave.Controller;

namespace Mindwave.UI
{
    public partial class Form1
    {
        List<Color> _experimentColors;
        string _participantName;
        string _ageGroup;
        string _currentColor;
        string _currentExperiment;
        string _currentMove;
        bool toForward;
        int _pictureBoxCounter;
        Point pictureBoxOriginalLocation;
        int _counter;
        Guid _id;

        private void StartExperiments()
        {
            if (_allowExperiment)
            {
                switch (this.comboExperiment.SelectedItem)
                {
                    case "Colors":
                        _currentExperiment = "Colors";
                        tabControl2.SelectedIndex = 0;
                        ExperimentTime.Interval = 2000;
                        PrepareColorsExperiment();
                        break;
                    case "Counting":
                        _currentExperiment = "Counting";
                        _counter = 60;
                        tabControl2.SelectedIndex = 1;
                        ExperimentTime.Interval = 1000;
                        break;
                    case "Movements":
                        _currentExperiment = "Movements";
                        pictureBoxOriginalLocation = this.HorizontalPictureBox.Location;
                        tabControl2.SelectedIndex = 2;
                        ExperimentTime.Interval = 300;
                        _pictureBoxCounter = 400;
                        break;
                }

                ExperimentTime.Enabled = true;
            }
        }

        private void StopExperiments()
        {
            ExperimentTime.Enabled = false;
            UpdatePanelColor(Color.Transparent);
            ClearExperimentFields();

            _allowExperiment = false;

            SetStopExperimentButtonStatus(false);

            SetStartExperimenButtonStatus(true);
        }

        private void ClearExperimentFields()
        {
            this.txtName.Text = string.Empty;
            this.comboAge.Text = string.Empty;
            this.comboAge.SelectedItem = null;
            _sessionFileName = string.Empty;
            _participantName = string.Empty;
            _ageGroup = string.Empty;
            _currentColor = string.Empty;
            _currentExperiment = string.Empty;
            _currentMove = string.Empty;
            _id = Guid.NewGuid();
            UpdateCounterLabel("00");
            this.HorizontalPictureBox.Location = pictureBoxOriginalLocation;
        }

        private void PrepareColorsExperiment()
        {
            _experimentColors = new List<Color> { Color.Wheat, Color.Red, Color.Blue, Color.Green };
        }

        private void ExperimentTime_Tick(object sender, EventArgs e)
        {
            if (_allowExperiment)
            {
                switch (comboExperiment.SelectedItem)
                {
                    case "Colors":
                        if (_experimentColors.Count == 4)
                        {
                            UpdatePanelColor(Color.Wheat);
                            _currentColor = Color.Wheat.Name;
                            _experimentColors.RemoveAt(0);

                            ExperimentTime.Interval = 30000;
                        }
                        else if (_experimentColors.Count == 1)
                        {
                            UpdatePanelColor(_experimentColors[0]);
                            _currentColor = _experimentColors[0].Name;

                            _experimentColors.RemoveAt(0);
                        }
                        else if (_experimentColors.Count > 1)
                        {
                            int randomIndex = new Random().Next(0, _experimentColors.Count - 1);
                            UpdatePanelColor(_experimentColors[randomIndex]);
                            _currentColor = _experimentColors[randomIndex].Name;

                            _experimentColors.RemoveAt(randomIndex);
                        }
                        else
                        {
                            StopExperiments();
                        }
                        break;

                    case "Counting":
                        if (_counter > 0)
                        {
                            _counter--;
                            UpdateCounterLabel(_counter.ToString());
                        }
                        else
                        {
                            StopExperiments();
                        }
                        break;

                    case "Movements":
                        if (_pictureBoxCounter >= 201)
                        {
                            SetHorizontalPictureBoxVisible(true);
                            SetVerticalPictureBox(false);
                            _currentMove = "Right";

                            if (!toForward)
                            {
                                MovePictureBoxToRight(20);
                                toForward = true;
                            }
                            else
                            {
                                MovePictureBoxToRight(-20);
                                toForward = false;
                            }
                        }
                        else if (_pictureBoxCounter > 0)
                        {
                            SetHorizontalPictureBoxVisible(false);
                            SetVerticalPictureBox(true);
                            _currentMove = "Up";

                            if (!toForward)
                            {
                                MovePictureBoxToTop(20);
                                toForward = true;
                            }
                            else
                            {
                                MovePictureBoxToTop(-20);
                                toForward = false;
                            }
                        }
                        else
                        {
                            StopExperiments();
                        }
                        _pictureBoxCounter--;
                        break;
                }
            }
        }

        private void UpdatePanelColor(Color color)
        {
            this.Invoke((MethodInvoker)delegate { this.PanelColor.BackColor = color; });
        }

        private void UpdateCounterLabel(string value)
        {
            this.Invoke((MethodInvoker)delegate { this.counterLabel.Text = value; });
        }

        private void MovePictureBoxToRight(int times)
        {
            this.Invoke((MethodInvoker)delegate
            {
                var p = this.HorizontalPictureBox.Location;
                p.X += times;
                this.HorizontalPictureBox.Location = p;
            });
        }

        private void MovePictureBoxToTop(int steps)
        {
            this.Invoke((MethodInvoker)delegate
            {
                var p = this.VerticalPictureBox.Location;
                p.Y += steps;
                this.VerticalPictureBox.Location = p;
            });
        }
    }
}
