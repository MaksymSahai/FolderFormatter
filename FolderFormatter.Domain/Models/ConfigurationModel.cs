using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderFormatter.Domain.Models
{
    public class ConfigurationModel
    {
        public string UserName { get; set; }
        public string TechName { get; set; }
        public char TagSeparator { get; set; }

    }
}
