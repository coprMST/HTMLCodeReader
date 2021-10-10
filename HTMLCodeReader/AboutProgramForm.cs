using System;
using System.Windows.Forms;

namespace VolgaIT_Kochetkov
{
    public partial class AboutProgramForm : Form
    {
        public AboutProgramForm()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
        }

        private void myVK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myGitHub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/coprMST");
        }
    }
}
