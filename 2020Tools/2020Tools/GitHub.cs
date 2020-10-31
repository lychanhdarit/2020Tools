using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020Tools
{
    public partial class GitHub : Form
    {
        public GitHub()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunGit(txtPath.Text);
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            txtCommand.Text = "Auto commit: " + DateTime.Now;
        }

        private void GitHub_Load(object sender, EventArgs e)
        {
            txtCommand.Text = "Auto commit: " + DateTime.Now;
        }
        public void RunGit(string directoryProject)
        {
            try
            {
                string filename = @"C:\Program Files\Git\git-bash.exe";
                ExecuteGitBashCommand(filename, "git pull", directoryProject);
                ExecuteGitBashCommand(filename, "git add *", directoryProject);
                ExecuteGitBashCommand(filename, "git commit -m '" + txtCommand.Text + "'", directoryProject);
                ExecuteGitBashCommand(filename, "git push", directoryProject);
                txtRS.Text = DateTime.Now + ": Done!";
            }
            catch (Exception ex)
            {
                txtRS.Text = DateTime.Now + ": " + ex.Message;
            }
        }
        public static void ExecuteGitBashCommand(string fileName, string command, string workingDir)
        {

            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, "-c \" " + command + " \"")
            {
                WorkingDirectory = workingDir,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(processStartInfo);
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            var exitCode = process.ExitCode;
            process.Close();
        }
    }
}
