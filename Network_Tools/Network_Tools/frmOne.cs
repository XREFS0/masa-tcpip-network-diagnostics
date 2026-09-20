using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace Network_Tools
{
    public partial class frmOne : DevComponents.DotNetBar.Office2007Form
    {
        public frmOne()
        {
            InitializeComponent();
        }

        
        private void OutputData(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string newLine = e.Data.Trim() + Environment.NewLine;
                MethodInvoker append = () => txtResult.Text += newLine;
                txtResult.BeginInvoke(append);
            }
        }

        private void frmOne_Load(object sender, EventArgs e)
        {
            cboCommand.Items.Add("ipconfig");
            cboCommand.Items.Add("nslookup");
            cboCommand.Items.Add("netstat");
            cboCommand.Items.Add("ping");
            cboCommand.Items.Add("tracert"); 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void cboCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCommand.SelectedItem.ToString() == "ipconfig")
            {
                txtResult.Clear();
                txtResult.Focus();
                txtArgument.Clear();

                string command = "/c ipconfig";
                ProcessStartInfo process = new ProcessStartInfo("CMD", command);
                process.CreateNoWindow = true;
                process.RedirectStandardOutput = true;
                process.UseShellExecute = false;
                Process p = Process.Start(process);
                p.OutputDataReceived += new DataReceivedEventHandler(OutputData);
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.CancelOutputRead();
                p.Close();
            }

            else if (cboCommand.SelectedItem.ToString() == "nslookup")
            {
                txtResult.Clear();
                txtResult.Focus();
                txtArgument.Clear();

                string commandArg = "/c nslookup";
                ProcessStartInfo process = new ProcessStartInfo("CMD", commandArg);
                process.CreateNoWindow = true;
                process.RedirectStandardOutput = true;
                process.UseShellExecute = false;
                Process p = Process.Start(process);
                p.OutputDataReceived += new DataReceivedEventHandler(OutputData);
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.CancelOutputRead();
                p.Close();
            }

            else if (cboCommand.SelectedItem.ToString() == "netstat")
            {
                txtResult.Clear();
                txtResult.Focus();
                txtArgument.Clear();

                string commandArg = "/c netstat";
                ProcessStartInfo process = new ProcessStartInfo("CMD", commandArg);
                process.CreateNoWindow = true;
                process.RedirectStandardOutput = true;
                process.UseShellExecute = false;
                Process p = Process.Start(process);
                p.OutputDataReceived += new DataReceivedEventHandler(OutputData);
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.CancelOutputRead();
                p.Close();
            }

            else if (cboCommand.SelectedItem.ToString() == "ping")
            {
                if (txtArgument.Text == "")
                {
                    MessageBox.Show("Enter the IP Address or Domain Name");
                    txtArgument.Focus();
                }

                else
                {
                    txtResult.Clear();
                    txtResult.Focus();

                    string commandArg = "/c ping " + txtArgument.Text;
                    ProcessStartInfo process = new ProcessStartInfo("CMD", commandArg);
                    process.CreateNoWindow = true;
                    process.RedirectStandardOutput = true;
                    process.UseShellExecute = false;
                    Process p = Process.Start(process);
                    p.OutputDataReceived += new DataReceivedEventHandler(OutputData);
                    p.BeginOutputReadLine();
                    p.WaitForExit();
                    p.CancelOutputRead();
                    p.Close();
                }
            }

            else if (cboCommand.SelectedItem.ToString() == "tracert")
            {
                if (txtArgument.Text == "")
                {
                    MessageBox.Show("Enter the IP Address or Domain Name");
                    txtArgument.Focus();
                }

                else
                {
                    txtResult.Clear();
                    txtResult.Focus();

                    string commandArg = "/c tracert " + txtArgument.Text;
                    ProcessStartInfo process = new ProcessStartInfo("CMD", commandArg);
                    process.CreateNoWindow = true;
                    process.RedirectStandardOutput = true;
                    process.UseShellExecute = false;
                    Process p = Process.Start(process);
                    p.OutputDataReceived += new DataReceivedEventHandler(OutputData);
                    p.BeginOutputReadLine();
                    p.WaitForExit();
                    p.CancelOutputRead();
                    p.Close();
                }
            }
        }

    }
}
