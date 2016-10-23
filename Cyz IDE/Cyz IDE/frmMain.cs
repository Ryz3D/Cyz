using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cyz_IDE
{
    public partial class frmMain : Form
    {
        private string openFile;

        public frmMain()
        {
            InitializeComponent();
        }

        private void smiOpen_Click(object sender, EventArgs e)
        {
            ofdOpen.ShowDialog();
        }

        private void ofdOpen_FileOk(object sender, CancelEventArgs e)
        {
            openFile = ofdOpen.FileName;
            rtbCode.Lines = File.ReadAllLines(openFile);
        }

        private void smiSave_Click(object sender, EventArgs e)
        {
            if (openFile == null || openFile == "")
            {
                sfdSave.ShowDialog();
                openFile = sfdSave.FileName;
            }
            if (openFile != null && openFile != "") //Checking again in case the User clicked 'Cancel'
                File.WriteAllLines(openFile, rtbCode.Lines);
        }

        private void sfdSave_FileOk(object sender, CancelEventArgs e)
        {
            string[] split = sfdSave.FileName.Split(@"\".ToCharArray()[0]);
            string file = split[split.Length - 1];
            Text = "Cyz - " + file;
        }
    }
}