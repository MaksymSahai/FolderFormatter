using FolderFormatter.Interfaces;
using FolderFormatter.Fomrs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderFormatter.EventLoggers;

namespace FolderFormatter
{
    public partial class FolderFormatterForm : Form
    {
        private readonly IConfiguration _configuration;
        private readonly IEventLogger _eventLogger;

        public FolderFormatterForm()
        {
            _configuration = (IConfiguration)Program.ServiceProvider.GetService(typeof(IConfiguration));
            _eventLogger = (IEventLogger)Program.ServiceProvider.GetService(typeof(IEventLogger));
            InitializeComponent();
        }

        private void FolderFormatter_Load(object sender, EventArgs e)
        {
            var configurationList = _configuration.GetAllConfigurationsNames();
            this.ConfigurationDdl.DataSource = configurationList;
        }

        private void ConfigurationDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _eventLogger.Clear(this.EventLogTxt);
            var eventMessage = new StringBuilder();
            eventMessage.Append(@"{\rtf1\ansi \b ");
            eventMessage.Append(this.ConfigurationDdl.SelectedItem);
            eventMessage.Append(@"\b0 ");
            eventMessage.Append(@" was choosen.}");

            _eventLogger.AppendEvent(this.EventLogTxt, eventMessage.ToString());
        }

        private void AddConfigurationBtn_Click(object sender, EventArgs e)
        {
            var configurationForm = new ConfigurationForm();
            configurationForm.ShowDialog();
        }

        private void RuBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.PathToSourceTxt.Text))
            {
                MessageBox.Show("Path to source files cannot be null or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var eventMessage = new StringBuilder();
            eventMessage.Append(@"{\rtf1\ansi \b Execution Started! \b}");
            _eventLogger.AppendEvent(this.EventLogTxt, eventMessage.ToString());

            this.RunBtn.Enabled = false;
        }
    }
}
