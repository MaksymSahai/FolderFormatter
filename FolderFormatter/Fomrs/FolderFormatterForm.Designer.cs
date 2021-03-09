
namespace FolderFormatter
{
    partial class FolderFormatterForm
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
            this.PathToSourceLbl = new System.Windows.Forms.Label();
            this.ConfigurationLbl = new System.Windows.Forms.Label();
            this.EventsLogLbl = new System.Windows.Forms.Label();
            this.PathToSourceTxt = new System.Windows.Forms.TextBox();
            this.ConfigurationDdl = new System.Windows.Forms.ComboBox();
            this.AddConfigurationBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.EventLogTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PathToSourceLbl
            // 
            this.PathToSourceLbl.AutoSize = true;
            this.PathToSourceLbl.Location = new System.Drawing.Point(12, 15);
            this.PathToSourceLbl.Name = "PathToSourceLbl";
            this.PathToSourceLbl.Size = new System.Drawing.Size(99, 17);
            this.PathToSourceLbl.TabIndex = 0;
            this.PathToSourceLbl.Text = "PathToSource";
            // 
            // ConfigurationLbl
            // 
            this.ConfigurationLbl.AutoSize = true;
            this.ConfigurationLbl.Location = new System.Drawing.Point(12, 49);
            this.ConfigurationLbl.Name = "ConfigurationLbl";
            this.ConfigurationLbl.Size = new System.Drawing.Size(92, 17);
            this.ConfigurationLbl.TabIndex = 1;
            this.ConfigurationLbl.Text = "Configuration";
            // 
            // EventsLogLbl
            // 
            this.EventsLogLbl.AutoSize = true;
            this.EventsLogLbl.Location = new System.Drawing.Point(556, 15);
            this.EventsLogLbl.Name = "EventsLogLbl";
            this.EventsLogLbl.Size = new System.Drawing.Size(79, 17);
            this.EventsLogLbl.TabIndex = 2;
            this.EventsLogLbl.Text = "Events Log";
            // 
            // PathToSourceTxt
            // 
            this.PathToSourceTxt.Location = new System.Drawing.Point(115, 10);
            this.PathToSourceTxt.Name = "PathToSourceTxt";
            this.PathToSourceTxt.Size = new System.Drawing.Size(387, 22);
            this.PathToSourceTxt.TabIndex = 3;
            // 
            // ConfigurationDdl
            // 
            this.ConfigurationDdl.FormattingEnabled = true;
            this.ConfigurationDdl.Location = new System.Drawing.Point(115, 46);
            this.ConfigurationDdl.MaxDropDownItems = 20;
            this.ConfigurationDdl.Name = "ConfigurationDdl";
            this.ConfigurationDdl.Size = new System.Drawing.Size(219, 24);
            this.ConfigurationDdl.TabIndex = 5;
            this.ConfigurationDdl.SelectedIndexChanged += new System.EventHandler(this.ConfigurationDdl_SelectedIndexChanged);
            // 
            // AddConfigurationBtn
            // 
            this.AddConfigurationBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddConfigurationBtn.BackgroundImage = global::FolderFormatter.Properties.Resources._1872610;
            this.AddConfigurationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddConfigurationBtn.Location = new System.Drawing.Point(340, 46);
            this.AddConfigurationBtn.Name = "AddConfigurationBtn";
            this.AddConfigurationBtn.Size = new System.Drawing.Size(38, 28);
            this.AddConfigurationBtn.TabIndex = 6;
            this.AddConfigurationBtn.UseVisualStyleBackColor = false;
            this.AddConfigurationBtn.Click += new System.EventHandler(this.AddConfigurationBtn_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(427, 99);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(75, 23);
            this.RunBtn.TabIndex = 7;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RuBtn_Click);
            // 
            // EventLogTxt
            // 
            this.EventLogTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventLogTxt.Location = new System.Drawing.Point(559, 46);
            this.EventLogTxt.Name = "EventLogTxt";
            this.EventLogTxt.ReadOnly = true;
            this.EventLogTxt.Size = new System.Drawing.Size(372, 592);
            this.EventLogTxt.TabIndex = 8;
            this.EventLogTxt.Text = "";
            // 
            // FolderFormatterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 650);
            this.Controls.Add(this.EventLogTxt);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.AddConfigurationBtn);
            this.Controls.Add(this.ConfigurationDdl);
            this.Controls.Add(this.PathToSourceTxt);
            this.Controls.Add(this.EventsLogLbl);
            this.Controls.Add(this.ConfigurationLbl);
            this.Controls.Add(this.PathToSourceLbl);
            this.Name = "FolderFormatterForm";
            this.Text = "Folder Formatter";
            this.Load += new System.EventHandler(this.FolderFormatter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathToSourceLbl;
        private System.Windows.Forms.Label ConfigurationLbl;
        private System.Windows.Forms.Label EventsLogLbl;
        private System.Windows.Forms.TextBox PathToSourceTxt;
        private System.Windows.Forms.ComboBox ConfigurationDdl;
        private System.Windows.Forms.Button AddConfigurationBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.RichTextBox EventLogTxt;
    }
}

