using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{
    public partial class frm_AP_Utilities : Form
    {
        public frm_AP_Utilities()
        {
            InitializeComponent();
        }

        /*CopyFolders - Class used to robocopy folders of image data.  If additional options are provided
         output folders will be compressed withy 7-zip and or the input folder will be deleted. 
       
        public class CopyZipFolders
        {
            public string strInputFolder;
            public string strOutputFolder;
            public void RunRobocopy()
            {
                string strFolderName1 = Path.GetFileName(strInputFolder);
                strOutputFolder = Path.Combine(strOutputFolder, strFolderName1);

                Process.Start("robocopy", string.Format("\"{0}\" \"{1}\" /E /DCOPY:DAT", strInputFolder, strOutputFolder));
                MessageBox.Show("Data Folder copy complete. ");
            }
        } */
        CopyZipFolders RunRobocopy = new CopyZipFolders();
        private void cmb_SelectAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_CopyFolders.Visible = true;
            pnl_TargetAndEqipment.Hide();
            pnl_CopyFolders.Show();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_CopyImageData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SelectInput_Click(object sender, EventArgs e)
        {
            bool bolInputSelected = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
               
                txb_InputFolderPath.Text = folderBrowserDialog1.SelectedPath;
                for (int i = 0; i < drives.Count(); i++)
                {
                    string strtest = drives[i].Name;
                    if (txb_InputFolderPath.Text == drives[i].Name)
                    {
                        string strMsgBoxTitle = "Select a folder for input";
                        string strMsgBoxMsg = "You must choose a folder and not a drive letter." +
                            "\n" +
                            "Please make another selection";
                        MessageBoxButtons btnButtons = MessageBoxButtons.OK;
                        MessageBox.Show(strMsgBoxMsg, strMsgBoxTitle, btnButtons, MessageBoxIcon.Error);
                        txb_InputFolderPath.Text = String.Empty;
                        bolInputSelected = false;
                        break;
                    }
                    
                   
                }
                if (bolInputSelected == true)
                {
                    btn_SelectOutput.Visible = true;
                    txb_OutputFolderPath.Visible = true;
                    RunRobocopy.strInputFolder = folderBrowserDialog1.SelectedPath;
                }

            }
            if (bolInputSelected == true)
            {
                string strFolderName1 = Path.GetFileName(txb_InputFolderPath.Text);
                string strMessage = "Is " +
                    strFolderName1 +
                    " a session target?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(strMessage, "Target Folder?", buttons);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("This is a target folder");
                    pnl_TargetAndEqipment.Show();
                }
            }

        }

        private void btn_SelectOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                RunRobocopy.strOutputFolder = folderBrowserDialog1.SelectedPath;
                txb_OutputFolderPath.Text= folderBrowserDialog1.SelectedPath;
                btn_Submit.Visible = true;
                
            }
                
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            RunRobocopy.RunRobocopy();
            txb_InputFolderPath.Text = String.Empty;
            txb_OutputFolderPath.Text = String.Empty;
            btn_SelectOutput.Visible = false;
            txb_OutputFolderPath.Visible = false;
            btn_Submit.Visible = false;
        }

        private void cmb_MountName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddTarget_Click(object sender, EventArgs e)
        {
            pnl_TargetAndEqipment.Hide();
        }
    }
}
  