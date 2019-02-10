using System;
using System.Drawing;
using System.Windows.Forms;

namespace SubtitlesPlayer
{
    public class DataGridViewEx : DataGridView
    {
        public bool IsUserScrolling { get; private set; }

        private const int WM_HSCROLL = 0x0114;
        private const int WM_VSCROLL = 0x0115;
        private const int SB_ENDSCROLL = 8;
        Timer _timer = new Timer();

        public event EventHandler UserScrollComplete;
        
        public DataGridViewEx():base()
        {
            _timer.Interval = 5000;  //in milliseconds
            _timer.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            IsUserScrolling = false;

            OnUserScrollComplete();
            _timer.Stop();
        }



        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            graphics.FillRectangle(new SolidBrush(Color.Gray), gridBounds);
            base.PaintBackground(graphics, clipBounds, gridBounds);
            

            /*SetCellsTransparent();*/
        }


        public void SetCellsTransparent()
        {
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Transparent;
            this.RowHeadersDefaultCellStyle.BackColor = Color.Transparent;


            foreach (DataGridViewColumn col in this.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.Transparent;
                col.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            }
        }

        protected virtual void OnUserScrollComplete()
        {
            EventHandler handler = UserScrollComplete;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected override void WndProc(ref Message m)
        {
            // http://msdn.microsoft.com/en-us/library/windows/desktop/bb787575(v=vs.85).aspx
            // http://msdn.microsoft.com/en-us/library/windows/desktop/bb787577(v=vs.85).aspx
            if ((m.Msg == WM_HSCROLL) ||
                (m.Msg == WM_VSCROLL))
            {

                short loword = (short)(m.WParam.ToInt32() & 0xFFFF);

                if (loword == SB_ENDSCROLL)
                {
                    _timer.Start();
                    
                }
                else
                {
                    _timer.Start();
                    IsUserScrolling = true;
                }
            }
            base.WndProc(ref m);
        }
    }
}
