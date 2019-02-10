using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SubtitlesPlayer
{
    public partial class SubtitlesViewerForm : Form
    {
        private Color _transparencyColor = Color.Gray;
        private Color _intitialFormColor;
        private List<ControlButton> _controlButtons = new List<ControlButton>();
        private ControlButton _activeButton;
        private Point _dragStartOffset;
        public SubtitlesViewerForm()
        {
            InitializeComponent();
            _intitialFormColor = this.BackColor;
            SwitchOnTransparency();
            _subtitlesProvider.SubtitleChanged += _subtitlesProvider_SubtitleChanged;
            _subtitlesProvider.PlayStateChanged += _subtitlesProvider_PlayStateChanged;
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
            _timerShowToolTip.Interval = 1000;  //in milliseconds
            _timerShowToolTip.Tick += _timerShowToolTip_Tick; ;
            _timerHideButtons.Interval = 5000;
            _timerHideButtons.Tick += _timerHideButtons_Tick;
            _playControl = new ControlButton { Button = _buttonStart, Text = "Play" };
            _controlButtons.Add(_playControl);
            _controlButtons.Add(new ControlButton { Button = _buttonForward, Text = "Forward" });
            _controlButtons.Add(new ControlButton { Button = _buttonBack, Text= "Back" });
            _showListControl = new ControlButton { Button = _buttonHideList, Text = "Show" };
            _controlButtons.Add(_showListControl);
            _controlButtons.Add(new ControlButton { Button = _buttonOpenFile, Text = "Open" });
            _controlButtons.Add(new ControlButton { Button = _buttonClose, Text = "Close" });
            _labelSubtitle.ForeColor = Properties.Settings.Default.Color;
            _labelSubtitle.Font = Properties.Settings.Default.Font;
            _dataGridSubtitles.ForeColor = Properties.Settings.Default.Color;
            UpdateButtonColors();
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (e.Mode == PowerModes.Suspend)
            {
                Properties.Settings.Default.ApplicationState = ApplicationState.Hibernated.ToString();
                _subtitlesProvider.StartStop(true);
            }
            if (e.Mode == PowerModes.Resume)
            {
                if (Properties.Settings.Default.ApplicationState == ApplicationState.Hibernated.ToString())
                {
                    Properties.Settings.Default.ApplicationState = "";
                }
            }
        }

        private void _subtitlesProvider_PlayStateChanged(object sender, EventArgs e)
        {
            
            if (_subtitlesProvider.Playing)
            {
                _playControl.Text = "Stop";
                _buttonStart.Image = Properties.Resources.Stopped2;
            }
            else
            {
                _playControl.Text = "Play";
                _buttonStart.Image = Properties.Resources.Play2;
            }
        }

        private void _subtitlesProvider_SubtitleChanged(SubtitleEventArgs e)
        {
            string text = string.Empty;
            if (e.Item != null)
            {
                text = string.IsNullOrEmpty(e.Item.SubTitle()) ? "" : e.Item.StartTimeFormatted() + ":" + e.Item.SubTitle();
                _dataGridSubtitles.Rows[e.RowIndex].Selected = true;
                if (!_dataGridSubtitles.IsUserScrolling)
                    _dataGridSubtitles.CurrentCell = _dataGridSubtitles.Rows[e.RowIndex].Cells[0];
            }

            _labelSubtitle.Text = text;
        }

        private SubtitlesProvider _subtitlesProvider = new SubtitlesProvider();

        private void openSubtitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void Open()
        {
            _timerHideButtons.Stop();
            _timerShowToolTip.Stop();
            _subtitlesProvider.FileLoaded = false;

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _dataGridSubtitles.Columns.Clear();
                _dataGridSubtitles.AutoGenerateColumns = false;
                var column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "StartTimeFormatted";
                column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                _dataGridSubtitles.Columns.Add(column1);

                var column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "SubTitle";
                column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                _dataGridSubtitles.Columns.Add(column2);

                _dataGridSubtitles.DataSource = _subtitlesProvider.ReadFromFile(this.openFileDialog1.FileName);

                foreach (DataGridViewColumn col in _dataGridSubtitles.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.Transparent;
                    col.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                }

                _labelSubtitle.Visible = true;
                UpdateButtons();
                _subtitlesProvider.SetSubTitle(0);
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StartPlaying();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(_transparencyColor), e.ClipRectangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void StartHideButtonsTimer()
        {
            _timerHideButtons.Start();
        }

        private void StartPlaying()
        {
            int index = _dataGridSubtitles.CurrentCell.RowIndex;
            if (index >= 0)
            {
                _subtitlesProvider.SetSubTitle(index);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_subtitlesProvider.Playing)
            {
                _subtitlesProvider.StartStop(true);
                
            }
            else
            {
                StartPlaying();
            }

            _playControl.Button.Text = _playControl.Text;
        }

        private void _buttonBack_Click(object sender, EventArgs e)
        {
            _subtitlesProvider.Back();
        }

        private void _buttonForward_Click(object sender, EventArgs e)
        {
            _subtitlesProvider.Forward();
        }

        Timer _timerShowToolTip = new Timer();
        
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Color = colorDialog1.Color;
                Properties.Settings.Default.Save();
                this._labelSubtitle.ForeColor = colorDialog1.Color;
                _dataGridSubtitles.ForeColor = colorDialog1.Color;
                UpdateButtonColors();
                Refresh();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Font = fontDialog1.Font;
                Properties.Settings.Default.Save();
                _labelSubtitle.Font = fontDialog1.Font;
            }
        }

        
        private void _timerShowToolTip_Tick(object sender, EventArgs e)
        {
            if (_activeButton!=null)
                _activeButton.Button.Text = _activeButton.Text;
            _timerShowToolTip.Stop();
        }

        Timer _timerHideButtons = new Timer();
        private void _timerHideButtons_Tick(object sender, EventArgs e)
        {
            foreach (var button in _controlButtons)
            {
                if (button != _activeButton)
                    button.Button.Visible = false;
            }

            _timerHideButtons.Stop();
        }

        private void _buttonOpenFile_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_subtitlesProvider.FileLoaded)
                return;

            StartHideButtonsTimer();
            ShowControlButtons(e);
        }

        private int _mouseX;
        private int _mouseY;
        private ControlButton _playControl;
        private ControlButton _showListControl;

        private void _labelSubtitle_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"MouseMove: {e.X} {e.Y}");


            ShowControlButtons(e);
        }

        private void ShowControlButtons(MouseEventArgs e)
        {
            // Did the mouse actually move?
            if (_mouseX == e.X && _mouseY == e.Y)
                return;

            _mouseX = e.X;
            _mouseY = e.Y;

            Debug.WriteLine("ShowControlButtons...");
            if (!_subtitlesProvider.FileLoaded)
                return;

            StartHideButtonsTimer();
            UpdateButtons();

        }

        private void UpdateButtons()
        {
            foreach (var button in _controlButtons)
            {
                if (!button.Button.Visible)
                    button.Button.Visible = true;
                button.Button.BackColor = Properties.Settings.Default.Color;
            }
        }

        private void UpdateButtonColors()
        {
            foreach (var button in _controlButtons)
            {
                button.Button.BackColor = Properties.Settings.Default.Color;
            }
        }

        private void _dataGridSubtitles_MouseMove(object sender, MouseEventArgs e)
        {
            ShowControlButtons(e);
        }

        private void _button_MouseLeave(object sender, EventArgs e)
        {
        
            
            if (_subtitlesProvider.FileLoaded)
            {
                _activeButton.Button.Text = "";
                StartHideButtonsTimer();
                _activeButton = null;
            }
        }

        private void _button_MouseEnter(object sender, EventArgs e)
        {
            SetActiveControl(sender);
            _timerShowToolTip.Start();
            _timerHideButtons.Stop();
        }

        private void SetActiveControl(object sender)
        {
            _activeButton = _controlButtons.Where(x => x.Button == (Button)sender).Single();
        }

        private void _button_MouseMove(object sender, MouseEventArgs e)
        {
            ShowControlButtons(e);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            SwitchOffTransparency();
            Refresh();
           
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Move;
            SwitchOnTransparency();
            var point = new Point(e.X, e.Y);
            _labelSubtitle.Top = point.Y -  _dragStartOffset.Y;
            _labelSubtitle.Left = point.X -  _dragStartOffset.X;
            Refresh();
        }

        private void SwitchOnTransparency()
        {
            BackColor = _transparencyColor;
            TransparencyKey = _transparencyColor;
        }

        private void _labelSubtitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragStartOffset = e.Location;
                DoDragDrop(_labelSubtitle.Text, DragDropEffects.Move);
            }

        }

        private void SwitchOffTransparency()
        {
            BackColor = _intitialFormColor;
            TransparencyKey = _intitialFormColor;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"Form1_MouseMove: {e.X} {e.Y}");
           
        }

        private void _buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _buttonHideList_Click(object sender, EventArgs e)
        {
            var visible = _dataGridSubtitles.Visible;
            if (visible)
            {
                _showListControl.Text = "Show";
            }
            else
            {
                _showListControl.Text = "Hide";
            }

            _dataGridSubtitles.Visible = !_dataGridSubtitles.Visible;
            _showListControl.Button.Text = _showListControl.Text;
        }

        private void _buttonStart_Enter(object sender, EventArgs e)
        {
            SetActiveControl(sender);
        }
    }
}
