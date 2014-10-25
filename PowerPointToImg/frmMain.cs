using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using OfficeCore = Microsoft.Office.Core;
using System.IO;

namespace PowerPointToImg
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtInput.Text = Environment.CurrentDirectory;
            txtOutput.Text = Environment.CurrentDirectory;
        }

        private void cmbBrowseFile_Click(object sender, EventArgs e)
        {
            ofdInput.Filter = "PowerPoint 文件(*.ppt;*.pptx;*.pps;*.pptm;*.ppsx)|*.ppt;*.pptx;*.pps;*.pptm;*.ppsx|全部文件(*.*)|*.*";
            ofdInput.ShowDialog();
            txtInput.Text = ofdInput.FileName;
        }

        private void cmbBrowseFolder_Click(object sender, EventArgs e)
        {
            fbdOutput.ShowDialog();
            txtOutput.Text = fbdOutput.SelectedPath;
        }

        private void cmbOutput_Click(object sender, EventArgs e)
        {
            PowerPoint.Application pptApp;
            PowerPoint.Presentation pptDoc;
            

            pptApp = new PowerPoint.Application();
            pptApp.Visible = OfficeCore.MsoTriState.msoTrue;
            pptDoc = pptApp.Presentations.Open(txtInput.Text, OfficeCore.MsoTriState.msoFalse, OfficeCore.MsoTriState.msoFalse, OfficeCore.MsoTriState.msoFalse);
            if(pptDoc.CreateVideoStatus != PowerPoint.PpMediaTaskStatus.ppMediaTaskStatusInProgress)
                pptDoc.Export(txtOutput.Text, "jpg", Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));

            
            pptDoc.Close();
            System.Threading.Thread.Sleep(1000);
            pptApp.Quit();
            pptDoc = null;
            pptApp = null;

            FileInfo[] dirFile = new DirectoryInfo(txtOutput.Text).GetFiles();
            foreach (FileInfo fioFile in dirFile)
            {
                System.IO.File.Move(fioFile.FullName, fioFile.FullName.Replace(fioFile.Name, fioFile.Name.ToLower().Replace("幻灯片", "image")));
            }
        }
    }
}
