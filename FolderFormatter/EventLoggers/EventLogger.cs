using FolderFormatter.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderFormatter.EventLoggers
{
    public class EventLogger
    {
        public void AppendEvent(System.Windows.Forms.RichTextBox eventLogTxt, string eventMeggase)
        {
            eventLogTxt.SelectedRtf = eventMeggase;
            eventLogTxt.ScrollToCaret();
            NewLine(eventLogTxt);
        }

        public void Clear(System.Windows.Forms.RichTextBox eventLogTxt)
        {
            eventLogTxt.Clear();
        }

        private void NewLine(System.Windows.Forms.RichTextBox eventLogTxt)
        {
            eventLogTxt.AppendText("\r\n");
        }
    }
}
