using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesPlayer
{
    public class SubtitleItem
    {

        //Properties------------------------------------------------------------------

        //StartTime and EndTime times are in milliseconds

        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public List<string> Lines { get; set; }
        public string SubTitle { get { return Lines.Count == 0 ? "" : Lines.Aggregate((i, j) => i + ' ' + j); } }

        public string StartTimeFormatted
        {
            get
            {
                var startTs = new TimeSpan(0, 0, 0, 0, StartTime).ToString(@"hh\:mm\:ss");
                return startTs;
            }
        }
        //Constructors-----------------------------------------------------------------

        /// <summary>
        /// The empty constructor
        /// </summary>
        public SubtitleItem()
        {
            this.Lines = new List<string>();
        }
    }
}
