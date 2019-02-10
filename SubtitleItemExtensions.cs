using SubtitlesParser.Classes;
using System;
using System.Linq;

namespace SubtitlesPlayer
{
    public static class SubTitleItemExtensions
    {
        public static string SubTitle(this SubtitleItem item)
        {
            return item.Lines.Count == 0 ? "" : item.Lines.Aggregate((i, j) => i + ' ' + j); 
        }

        public static string StartTimeFormatted(this SubtitleItem item)
        {
            var startTs = new TimeSpan(0, 0, 0, 0, item.StartTime).ToString(@"hh\:mm\:ss");
            return startTs;
        }
    }
}
