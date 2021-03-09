using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderFormatter.Interfaces
{
    public interface IEventLogger
    {
        void AppendEvent(System.Windows.Forms.RichTextBox eventLogTxt, string eventMeggase);
        void Clear(System.Windows.Forms.RichTextBox eventLogTxt);
    }
}
