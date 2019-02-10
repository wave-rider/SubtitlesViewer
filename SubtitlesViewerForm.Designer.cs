namespace SubtitlesPlayer
{
    partial class SubtitlesViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtitlesViewerForm));
            this._labelSubtitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSubtitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this._buttonClose = new System.Windows.Forms.Button();
            this._buttonHideList = new System.Windows.Forms.Button();
            this._buttonForward = new System.Windows.Forms.Button();
            this._buttonBack = new System.Windows.Forms.Button();
            this._buttonOpenFile = new System.Windows.Forms.Button();
            this._buttonStart = new System.Windows.Forms.Button();
            this._dataGridSubtitles = new SubtitlesPlayer.DataGridViewEx();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridSubtitles)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelSubtitle
            // 
            this._labelSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelSubtitle.BackColor = System.Drawing.Color.Gray;
            this._labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSubtitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this._labelSubtitle.Location = new System.Drawing.Point(98, 230);
            this._labelSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelSubtitle.Name = "_labelSubtitle";
            this._labelSubtitle.Size = new System.Drawing.Size(658, 180);
            this._labelSubtitle.TabIndex = 0;
            this._labelSubtitle.Text = "label1";
            this._labelSubtitle.Visible = false;
            this._labelSubtitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this._labelSubtitle_MouseDown);
            this._labelSubtitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this._labelSubtitle_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubtitlesToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 70);
            // 
            // openSubtitlesToolStripMenuItem
            // 
            this.openSubtitlesToolStripMenuItem.Name = "openSubtitlesToolStripMenuItem";
            this.openSubtitlesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openSubtitlesToolStripMenuItem.Text = "Open Subtitles";
            this.openSubtitlesToolStripMenuItem.Click += new System.EventHandler(this.openSubtitlesToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _buttonClose
            // 
            this._buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonClose.BackColor = System.Drawing.SystemColors.Control;
            this._buttonClose.FlatAppearance.BorderSize = 0;
            this._buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buttonClose.Image = global::SubtitlesPlayer.Properties.Resources.close;
            this._buttonClose.Location = new System.Drawing.Point(753, 25);
            this._buttonClose.Name = "_buttonClose";
            this._buttonClose.Size = new System.Drawing.Size(53, 53);
            this._buttonClose.TabIndex = 8;
            this._buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._buttonClose.UseVisualStyleBackColor = false;
            this._buttonClose.Visible = false;
            this._buttonClose.Click += new System.EventHandler(this._buttonClose_Click);
            this._buttonClose.MouseEnter += new System.EventHandler(this._button_MouseEnter);
            this._buttonClose.MouseLeave += new System.EventHandler(this._button_MouseLeave);
            this._buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this._button_MouseMove);
            // 
            // _buttonHideList
            // 
            this._buttonHideList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonHideList.BackColor = System.Drawing.SystemColors.Control;
            this._buttonHideList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._buttonHideList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonHideList.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buttonHideList.Image = global::SubtitlesPlayer.Properties.Resources.List2;
            this._buttonHideList.Location = new System.Drawing.Point(753, 240);
            this._buttonHideList.Margin = new System.Windows.Forms.Padding(2);
            this._buttonHideList.Name = "_buttonHideList";
            this._buttonHideList.Size = new System.Drawing.Size(53, 53);
            this._buttonHideList.TabIndex = 7;
            this._buttonHideList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._buttonHideList.UseVisualStyleBackColor = false;
            this._buttonHideList.Visible = false;
            this._buttonHideList.Click += new System.EventHandler(this._buttonHideList_Click);
            this._buttonHideList.MouseEnter += new System.EventHandler(this._button_MouseEnter);
            this._buttonHideList.MouseLeave += new System.EventHandler(this._button_MouseLeave);
            this._buttonHideList.MouseMove += new System.Windows.Forms.MouseEventHandler(this._button_MouseMove);
            // 
            // _buttonForward
            // 
            this._buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonForward.BackColor = System.Drawing.Color.AntiqueWhite;
            this._buttonForward.FlatAppearance.BorderSize = 0;
            this._buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonForward.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buttonForward.Image = global::SubtitlesPlayer.Properties.Resources.forward;
            this._buttonForward.Location = new System.Drawing.Point(12, 240);
            this._buttonForward.Name = "_buttonForward";
            this._buttonForward.Size = new System.Drawing.Size(53, 53);
            this._buttonForward.TabIndex = 6;
            this._buttonForward.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._buttonForward.UseVisualStyleBackColor = false;
            this._buttonForward.Visible = false;
            this._buttonForward.Click += new System.EventHandler(this._buttonForward_Click);
            this._buttonForward.MouseEnter += new System.EventHandler(this._button_MouseEnter);
            this._buttonForward.MouseLeave += new System.EventHandler(this._button_MouseLeave);
            this._buttonForward.MouseMove += new System.Windows.Forms.MouseEventHandler(this._button_MouseMove);
            // 
            // _buttonBack
            // 
            this._buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this._buttonBack.FlatAppearance.BorderSize = 0;
            this._buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonBack.Image = global::SubtitlesPlayer.Properties.Resources.back;
            this._buttonBack.Location = new System.Drawing.Point(12, 305);
            this._buttonBack.Name = "_buttonBack";
            this._buttonBack.Size = new System.Drawing.Size(53, 53);
            this._buttonBack.TabIndex = 5;
            this._buttonBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._buttonBack.UseVisualStyleBackColor = false;
            this._buttonBack.Visible = false;
            this._buttonBack.Click += new System.EventHandler(this._buttonBack_Click);
            this._buttonBack.MouseEnter += new System.EventHandler(this._button_MouseEnter);
            this._buttonBack.MouseLeave += new System.EventHandler(this._button_MouseLeave);
            this._buttonBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this._button_MouseMove);
            // 
            // _buttonOpenFile
            // 
            this._buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this._buttonOpenFile.FlatAppearance.BorderSize = 0;
            this._buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonOpenFile.Image = global::SubtitlesPlayer.Properties.Resources.load2;
            this._buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._buttonOpenFile.Location = new System.Drawing.Point(753, 303);
            this._buttonOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this._buttonOpenFile.Name = "_buttonOpenFile";
            this._buttonOpenFile.Size = new System.Drawing.Size(53, 53);
            this._buttonOpenFile.TabIndex = 4;
            this._buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._buttonOpenFile.UseVisualStyleBackColor = false;
            this._buttonOpenFile.Click += new System.EventHandler(this.button2_Click);
            this._buttonOpenFile.MouseEnter += new System.EventHandler(this._button_MouseEnter);
            this._buttonOpenFile.MouseLeave += new System.EventHandler(this._button_MouseLeave);
            this._buttonOpenFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this._button_MouseMove);
            // 
            // _buttonStart
            // 
            this._buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonStart.BackColor = System.Drawing.SystemColors.Control;
            this._buttonStart.FlatAppearance.BorderSize = 0;
            this._buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buttonStart.Image = global::SubtitlesPlayer.Properties.Resources.Play2;
            this._buttonStart.Location = new System.Drawing.Point(12, 175);
            this._buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(53, 53);
            this._buttonStart.TabIndex = 2;
            this._buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._buttonStart.UseVisualStyleBackColor = false;
            this._buttonStart.Visible = false;
            this._buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this._buttonStart.Enter += new System.EventHandler(this._buttonStart_Enter);
            this._buttonStart.MouseEnter += new System.EventHandler(this._button_MouseEnter);
            this._buttonStart.MouseLeave += new System.EventHandler(this._button_MouseLeave);
            this._buttonStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this._button_MouseMove);
            // 
            // _dataGridSubtitles
            // 
            this._dataGridSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridSubtitles.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridSubtitles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridSubtitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridSubtitles.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridSubtitles.EnableHeadersVisualStyles = false;
            this._dataGridSubtitles.GridColor = System.Drawing.Color.Gray;
            this._dataGridSubtitles.Location = new System.Drawing.Point(40, 10);
            this._dataGridSubtitles.Margin = new System.Windows.Forms.Padding(2);
            this._dataGridSubtitles.MultiSelect = false;
            this._dataGridSubtitles.Name = "_dataGridSubtitles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridSubtitles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataGridSubtitles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridSubtitles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataGridSubtitles.RowTemplate.Height = 40;
            this._dataGridSubtitles.Size = new System.Drawing.Size(782, 218);
            this._dataGridSubtitles.TabIndex = 3;
            this._dataGridSubtitles.Visible = false;
            this._dataGridSubtitles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this._dataGridSubtitles.MouseMove += new System.Windows.Forms.MouseEventHandler(this._dataGridSubtitles_MouseMove);
            // 
            // SubtitlesViewerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 419);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this._buttonClose);
            this.Controls.Add(this._buttonHideList);
            this.Controls.Add(this._buttonForward);
            this.Controls.Add(this._buttonBack);
            this.Controls.Add(this._buttonOpenFile);
            this.Controls.Add(this._dataGridSubtitles);
            this.Controls.Add(this._buttonStart);
            this.Controls.Add(this._labelSubtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SubtitlesViewerForm";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridSubtitles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelSubtitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openSubtitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Button _buttonStart;
        private DataGridViewEx _dataGridSubtitles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button _buttonOpenFile;
        private System.Windows.Forms.Button _buttonBack;
        private System.Windows.Forms.Button _buttonForward;
        private System.Windows.Forms.Button _buttonHideList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button _buttonClose;
    }
}

