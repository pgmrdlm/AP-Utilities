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
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration.Conventions;
using APU___Astrophotorophy_Utilities.APU___Astrophotorophy_Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace APU___Astrophotorophy_Utilities
{
       public partial class frm_AP_Utilities : Form
    {
        public frm_AP_Utilities()
        {
            InitializeComponent();
        }

       
        CopyZipFolders RunRobocopy = new CopyZipFolders();
        //db_ATI_Table ATI_Table = new db_ATI_Table();



        public string parMount;
        public string parICamera;
        public string parGCamera;
        public string parLens;
        public string parGScope;
        public string parFilter;
        public string parLocation;
        public string parBortle;
        public bool bolAddOnly = false;

        private void frm_AP_Utilities_Load(object sender, EventArgs e)
        {

        }
        private void pnl_CopyImageData_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pnl_TargetAndEqipment_Paint(object sender, PaintEventArgs e)
        {

        }
        //
        // Panel 1 - combo box event for when user selects what action to perform.
        //
        private void cmb_SelectAction_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (cmb_SelectAction.SelectedIndex == 0)
            {
                pnl_CopyFolders.Visible = true;
                pnl_CopyFolders.Show();
                pnl_TargetAndEqipment.Visible = false;
                pnl_TargetAndEqipment.Hide();
                pnl_AddNewData.Visible = false;
                pnl_AddNewData.Hide();
                txb_InputFolderPath.Visible = true;
                btn_SelectInput.Visible = true;
            }
            if (cmb_SelectAction.SelectedIndex == 1)
            {
                pnl_AddNewData.Visible = true;
                pnl_AddNewData.Show();

            }
            
        }

        //
        // Panel 1 events
        //
        // Panel 1 select input event
        //


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
            }  else
            {
                return;
            }
            // 
            // Panel 1 - A drive letter was not selected in the folderbrowserDialog which is valid
            //
            if (bolInputSelected == true)
            {
                btn_SelectOutput.Visible = true;
                txb_OutputFolderPath.Visible = true;
                string strFolderName1 = Path.GetFileName(txb_InputFolderPath.Text);
                string strMessage = "Is " +
                    strFolderName1 +
                    " a new Astrophotrophy target?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(strMessage, "Target Folder?", buttons);
                //
                // Panel 1 - It has been determined that the folder selected for input is a 
                // target folder to be processed
                //
                if (result == DialogResult.Yes)
                {
                    strFolderName1 = Path.GetFileName(txb_InputFolderPath.Text);
                    VerifyFolders CheckEquipmentFolders = new VerifyFolders();
                    CheckEquipmentFolders.VerifyEquipmentFolders(txb_InputFolderPath.Text);
                    //
                    // Panel 1 - The input folder that was selected is a target folder and is not
                    // currently recorded on the database.
                    //
                    if (CheckEquipmentFolders.lstEquipment.Count > 0)
                    {
                        db_AE_Table AE_Table = new db_AE_Table();
                        
                        AE_Table.LoadEquipmentForm();
                        //
                        // Garther information to populate panel 2 combo boxes which will be used 
                        // when displaying panel 2
                        //

                        foreach (var strItem in AE_Table.strMount)
                        {
                            cmb_MountName.Items.Add(strItem);
                        }
                        
                        foreach (var strItem in AE_Table.strImageCamera)
                        {
                            cmb_ImageCamera.Items.Add(strItem);
                        }
                        foreach (var strItem in CheckEquipmentFolders.lstEquipment)
                        {
                            cmb_ImageLensTelescope.Items.Add(strItem);
                        }
                        foreach (var strItem in AE_Table.strFilter)
                        {
                            cmb_Filter.Items.Add(strItem);
                        }
                        
                        foreach (var strItem in AE_Table.strGuideCamera)
                        {
                            cmb_GuideCamera.Items.Add(strItem);
                        }
                        
                        foreach (var strItem in AE_Table.strGuideScope)
                        {
                            cmb_GuideScope.Items.Add(strItem);
                        }
                        //
                        // Panel 1 - Thje panel 2 combobox lists have been populated and panel 2
                        // is now displayed instead of panel 1
                        //
                        txb_TargetName.Text = Path.GetFileName(txb_InputFolderPath.Text);
                        pnl_CopyFolders.Enabled = false;    
                        pnl_CopyFolders.Visible = false;    
                        pnl_TargetAndEqipment.Visible = true;
                        pnl_TargetAndEqipment.Enabled = true;
                        return;

                    } else
                    {
                        MessageBox.Show("This target has already been created.  Chose add new data action if this is what you are attempting to do!");

                    }
                    //
                    // Default action to display panel 1 no matter if this is new data or additional
                    // data.
                    //
                    pnl_CopyFolders.Enabled = true;
                    txb_InputFolderPath.Visible = false;
                    txb_InputFolderPath.Clear();
                    btn_SelectInput.Visible = false;
                    txb_OutputFolderPath.Visible = false;
                    btn_SelectOutput.Visible = false;
                    cmb_SelectAction.SelectedIndex = -1;
                    return;
                }
                btn_SelectInput.Visible = true;
            }
        }

        // 
        // Panel 1 - Request to select the output directory for copying files to.
        //
        private void btn_SelectOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                RunRobocopy.strOutputFolder = folderBrowserDialog1.SelectedPath;
                txb_OutputFolderPath.Text= folderBrowserDialog1.SelectedPath;
                btn_Submit.Visible = true;
                
            } 
        }
        //
        // Panel 1 - output directory selected and submit button clicked for copy of files to begin.
        //
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            RunRobocopy.RunRobocopy(txb_InputFolderPath.Text, txb_OutputFolderPath.Text);
            btn_SelectOutput.Visible = false;
            btn_SelectInput.Visible = false;
            btn_Submit.Visible = false;
            cmb_SelectAction.SelectedIndex = -1;
            txb_InputFolderPath.Text = String.Empty;
            txb_OutputFolderPath.Text = String.Empty;
            btn_SelectOutput.Visible = false;
            txb_OutputFolderPath.Visible = false;
            txb_InputFolderPath.Visible = false;
        }
        //
        // Panel 2 - Folloing events are used to check what has been selected from combo boxes in
        // panel 2.
        //
        private void cmb_MountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            parMount = cmb_MountName.Text;
            int i = 4;
            if (parICamera is null)
            {
                i--;
            }
            if (parLens is null)
            {
                i--;
            }
            if (parFilter is null)
            {
                i--;
            }
            if (i ==4)
            {
                grp_GuideEquipment.Visible = true;
            }

        }

        private void btn_AddTarget_Click(object sender, EventArgs e)
        {
            pnl_TargetAndEqipment.Hide();
            btn_SelectOutput.Visible= false;
            btn_SelectInput.Visible = false;
            btn_Submit.Visible= false;
            cmb_SelectAction.SelectedIndex = -1;

            string strTarget = Path.GetFileName(txb_InputFolderPath.Text);
            var strFullPath = txb_InputFolderPath.Text;
            db_New_Target BuildTargetImaged = new db_New_Target();
            //            db_ATI_Table ATI_Table = new db_ATI_Table();

            BuildTargetImaged.BuildNewTarget
                (
                strFullPath, 
                strTarget, 
                parMount, 
                parICamera,
                parLens,
                parFilter,
                parGCamera,
                parGScope,
                parLocation,
                parBortle
                );
            if (bolAddOnly == true)
            {
                pnl_CopyFolders.Show();
                pnl_CopyFolders.Enabled = true;
                btn_SelectOutput.Visible = false;
                btn_SelectInput.Visible = false;
                txb_OutputFolderPath.Visible = false;
                txb_InputFolderPath.Visible = false;
                btn_Submit.Visible = false;
                txb_InputFolderPath.Text = String.Empty;
                txb_OutputFolderPath.Text = String.Empty;
                cmb_SelectAction.SelectedIndex = -1;
                return;
            } else
            {
                pnl_CopyFolders.Show();
                pnl_CopyFolders.Enabled = true;
                btn_SelectOutput.Visible = true;
                btn_SelectInput.Visible = true;
                txb_InputFolderPath.Visible = true;
                btn_SelectOutput.Visible = true;
                txb_OutputFolderPath.Visible = true;
                cmb_SelectAction.Visible = true;
                btn_Submit.Visible = false;
                cmb_SelectAction.SelectedIndex = -1;
                return;
            }
        }

        private void cmb_ImageCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            parICamera = cmb_ImageCamera.Text;

            int i = 4;
            if (parLens is null)
            {
                i--;
            }
            if (parMount is null)
            {
                i--;
            }
            if (parFilter is null)
            {
                i--;
            }
            if (i == 4)
            {
                grp_GuideEquipment.Visible = true;
            }
        }

        private void cmb_ImageLensTelescope_SelectedIndexChanged(object sender, EventArgs e)
        {
            parLens = cmb_ImageLensTelescope.Text;
            
            int i = 4;
            if (parICamera is null)
            {
                i--;
            }
            if (parMount is null)
            {
                i--;
            }
            if (parFilter is null)
            {
                i--;
            }
            if (i == 4)
            {
                grp_GuideEquipment.Visible = true;
            }
        }

        private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            parFilter = cmb_Filter.Text;

            int i = 4;
            if (parICamera is null)
            {
                i--;
            }
            if (parMount is null)
            {
                i--;
            }
            if (parFilter is null)
            {
                i--;
            }
            if (i == 4)
            {
                grp_GuideEquipment.Visible = true;
            }
        }

        private void cmb_GuideCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            parGCamera = cmb_GuideCamera.Text;
            int i = 2;
            if (parGScope is null)
            {
                i--;
            }
            if  (i == 2)
            {
                grb_TypeOfAction.Visible = true;
            }
            
        }

        private void cmb_GuideScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            parGScope = cmb_GuideScope.Text;
            int i = 2;
            if (parGCamera is null)
            {
                i--;
            }
            if (i == 2)
            {
                grb_TypeOfAction.Visible = true;
            }
        }

        private void cmb_Bortel_SelectedIndexChanged(object sender, EventArgs e)
        {
            parBortle = cmb_Bortel.Text;
            int i = 2;
            if (parLocation is null)
            {
                i--;
            }
            if (i == 2)
            {
                grb_CamerasScopesAndFilter.Visible = true;
            }
        }

        private void txb_Location_Validating(object sender, EventArgs e)
        {
            parLocation = txb_Location.Text;
            int i = 2;
            if (parBortle is null)
            {
                i--;
            }
            if (i == 2)
            {
                grb_CamerasScopesAndFilter.Visible = true;
              
            }
        }
        //
        // panel 2 - combo boxes have been populated and user has correctly selected an item from every
        // box.  Now check boxes are displayed to see if this is an add new target only, or add target
        // to database then copy all of the files.
        //
        private void ckb_AddOnly_CheckedChanged(object sender, EventArgs e)
        {
            btn_AddTarget.Visible = true;
            bolAddOnly = true;
        }

        private void ckb_AddAndCopy_CheckedChanged(object sender, EventArgs e)
        {
            btn_AddTarget.Visible = true;
            bolAddOnly = false;

        }

        private void btn_SelectNewDataInput_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("input selecte");
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                txb_NewDataInput.Text = folderBrowserDialog1.SelectedPath;
               
                for (int i = 0; i < drives.Count(); i++)
                {
                    string strtest = drives[i].Name;
                    if (txb_NewDataInput.Text == drives[i].Name)
                    {
                        string strMsgBoxTitle = "Select a folder for input";
                        string strMsgBoxMsg = "You must choose a folder and not a drive letter." +
                               "\n" +
                                "Please make another selection";
                        MessageBoxButtons btnButtons = MessageBoxButtons.OK;
                        MessageBox.Show(strMsgBoxMsg, strMsgBoxTitle, btnButtons, MessageBoxIcon.Error);
                        txb_NewDataInput.Text = String.Empty;
                    }
                }
                
            }

          
        }
        //
        // Panel for new data - Logic to add execute log for any new data for an existing target already on the db
        private void btn_SelectNewDataOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txb_NewDataIOutput.Text = folderBrowserDialog1.SelectedPath;
                btn_AddNewData.Visible = true;
            }
        }

        private void btn_AddNewData_Click(object sender, EventArgs e)
        {
            var strFlag = "y";
            VerifyFolders NewData = new VerifyFolders();
            var strfullPath = txb_NewDataIOutput.Text;
            var strFolderName1 = Path.GetFileName(txb_NewDataIOutput.Text);
            NewData.VerifyDateFolders(txb_NewDataIOutput.Text, strFlag);
            RunRobocopy.RunRobocopy(txb_InputFolderPath.Text, txb_OutputFolderPath.Text);
            btn_SelectOutput.Visible = false;
            btn_SelectInput.Visible = false;
            btn_Submit.Visible = false;
            cmb_SelectAction.SelectedIndex = -1;
            txb_InputFolderPath.Text = String.Empty;
            txb_OutputFolderPath.Text = String.Empty;
            pnl_AddNewData.Visible = false;
            pnl_AddNewData.Hide();
        }
    }
    
}
  