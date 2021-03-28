using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] commands = { "init", "remote add origin https://github.com/kural214/Dummy.git", "add .", "commit -m 'Random Commit'", "push origin master" };

            for (var i = 0; i < commands.Length; i++)
            {
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    FileName = "CMD.exe",
                    Arguments = @"/c cd D:\New folder (5)\Uploader\App_Data && git " + commands[i],
                };

                var process = System.Diagnostics.Process.Start(startInfo);
                textBox1.Text = process.StandardOutput.ReadToEnd();
            }

            //string gitCommand = "git";
            //string gitAddArgument = @"add -A";
            //string gitCommitArgument = @"commit ""explanations_of_changes""";
            //string gitPushArgument = @"push https://github.com/kural214/2.JPG ";

            //Process.Start(gitCommand, gitAddArgument);
            //Process.Start(gitCommand, gitCommitArgument);
            //Process.Start(gitCommand, gitPushArgument);

            //Process test = new Process();
            //test.StartInfo.FileName = "ipconfig";
            //test.StartInfo.UseShellExecute = false;
            //test.StartInfo.Arguments = "/all";
            //test.StartInfo.RedirectStandardOutput = true;
            //test.Start();
            //textBox1.Text = test.StandardOutput.ReadToEnd();
        }
    }
}
