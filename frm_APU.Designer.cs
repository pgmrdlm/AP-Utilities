namespace APU___Astrophotorophy_Utilities
{
    partial class frm_AP_Utilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AP_Utilities));
            this.pnl_CopyFolders = new System.Windows.Forms.Panel();
            this.grb_AddNewData = new System.Windows.Forms.GroupBox();
            this.btn_AddNewData = new System.Windows.Forms.Button();
            this.txb_NewDataIOutput = new System.Windows.Forms.TextBox();
            this.btn_SelectNewDataOutput = new System.Windows.Forms.Button();
            this.txb_NewDataInput = new System.Windows.Forms.TextBox();
            this.btn_SelectNewDataInput = new System.Windows.Forms.Button();
            this.grb_AddAndCopy = new System.Windows.Forms.GroupBox();
            this.txb_InputFolderPath = new System.Windows.Forms.TextBox();
            this.btn_SelectInput = new System.Windows.Forms.Button();
            this.txb_OutputFolderPath = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_SelectOutput = new System.Windows.Forms.Button();
            this.grb_ZipFolders = new System.Windows.Forms.GroupBox();
            this.txb_FolderToZip = new System.Windows.Forms.TextBox();
            this.btn_SelectFolderToZip = new System.Windows.Forms.Button();
            this.txb_FolderToZipTo = new System.Windows.Forms.TextBox();
            this.btn_SubmitZip = new System.Windows.Forms.Button();
            this.btn_OutPutZipTo = new System.Windows.Forms.Button();
            this.lbl_SelectAction = new System.Windows.Forms.Label();
            this.cmb_SelectAction = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_TargetAndEqipment = new System.Windows.Forms.Panel();
            this.grb_TargetAndMount = new System.Windows.Forms.GroupBox();
            this.lbl_Bortle = new System.Windows.Forms.Label();
            this.cmb_Bortel = new System.Windows.Forms.ComboBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.txb_Location = new System.Windows.Forms.TextBox();
            this.lbl_Target = new System.Windows.Forms.Label();
            this.txb_TargetName = new System.Windows.Forms.TextBox();
            this.grb_TypeOfAction = new System.Windows.Forms.GroupBox();
            this.ckb_AddAndCopy = new System.Windows.Forms.CheckBox();
            this.btn_AddTarget = new System.Windows.Forms.Button();
            this.ckb_AddOnly = new System.Windows.Forms.CheckBox();
            this.grp_GuideEquipment = new System.Windows.Forms.GroupBox();
            this.lbl_GuideScope = new System.Windows.Forms.Label();
            this.lbl_GuideCamera = new System.Windows.Forms.Label();
            this.cmb_GuideScope = new System.Windows.Forms.ComboBox();
            this.cmb_GuideCamera = new System.Windows.Forms.ComboBox();
            this.grb_CamerasScopesAndFilter = new System.Windows.Forms.GroupBox();
            this.lbl_MountName = new System.Windows.Forms.Label();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.cmb_MountName = new System.Windows.Forms.ComboBox();
            this.lbl_LensTelescope = new System.Windows.Forms.Label();
            this.lbl_ImageCamera = new System.Windows.Forms.Label();
            this.cmb_ImageLensTelescope = new System.Windows.Forms.ComboBox();
            this.cmb_ImageCamera = new System.Windows.Forms.ComboBox();
            this.pnl_CopyFolders.SuspendLayout();
            this.grb_AddNewData.SuspendLayout();
            this.grb_AddAndCopy.SuspendLayout();
            this.grb_ZipFolders.SuspendLayout();
            this.pnl_TargetAndEqipment.SuspendLayout();
            this.grb_TargetAndMount.SuspendLayout();
            this.grb_TypeOfAction.SuspendLayout();
            this.grp_GuideEquipment.SuspendLayout();
            this.grb_CamerasScopesAndFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_CopyFolders
            // 
            this.pnl_CopyFolders.Controls.Add(this.grb_ZipFolders);
            this.pnl_CopyFolders.Controls.Add(this.grb_AddNewData);
            this.pnl_CopyFolders.Controls.Add(this.grb_AddAndCopy);
            this.pnl_CopyFolders.Controls.Add(this.lbl_SelectAction);
            this.pnl_CopyFolders.Controls.Add(this.cmb_SelectAction);
            this.pnl_CopyFolders.Location = new System.Drawing.Point(12, 11);
            this.pnl_CopyFolders.Name = "pnl_CopyFolders";
            this.pnl_CopyFolders.Size = new System.Drawing.Size(1160, 501);
            this.pnl_CopyFolders.TabIndex = 1;
            this.pnl_CopyFolders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_CopyImageData_Paint);
            // 
            // grb_AddNewData
            // 
            this.grb_AddNewData.Controls.Add(this.btn_AddNewData);
            this.grb_AddNewData.Controls.Add(this.txb_NewDataIOutput);
            this.grb_AddNewData.Controls.Add(this.btn_SelectNewDataOutput);
            this.grb_AddNewData.Controls.Add(this.txb_NewDataInput);
            this.grb_AddNewData.Controls.Add(this.btn_SelectNewDataInput);
            this.grb_AddNewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_AddNewData.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_AddNewData.Location = new System.Drawing.Point(20, 81);
            this.grb_AddNewData.Name = "grb_AddNewData";
            this.grb_AddNewData.Size = new System.Drawing.Size(1025, 245);
            this.grb_AddNewData.TabIndex = 0;
            this.grb_AddNewData.TabStop = false;
            this.grb_AddNewData.Text = "Add new Data to Existing Target";
            this.grb_AddNewData.Visible = false;
            // 
            // btn_AddNewData
            // 
            this.btn_AddNewData.Location = new System.Drawing.Point(138, 109);
            this.btn_AddNewData.Name = "btn_AddNewData";
            this.btn_AddNewData.Size = new System.Drawing.Size(100, 23);
            this.btn_AddNewData.TabIndex = 2;
            this.btn_AddNewData.Text = "Add Data";
            this.btn_AddNewData.UseVisualStyleBackColor = true;
            this.btn_AddNewData.Visible = false;
            this.btn_AddNewData.Click += new System.EventHandler(this.btn_AddNewData_Click);
            // 
            // txb_NewDataIOutput
            // 
            this.txb_NewDataIOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NewDataIOutput.Location = new System.Drawing.Point(138, 67);
            this.txb_NewDataIOutput.Name = "txb_NewDataIOutput";
            this.txb_NewDataIOutput.ReadOnly = true;
            this.txb_NewDataIOutput.Size = new System.Drawing.Size(851, 22);
            this.txb_NewDataIOutput.TabIndex = 1;
            this.txb_NewDataIOutput.Visible = false;
            // 
            // btn_SelectNewDataOutput
            // 
            this.btn_SelectNewDataOutput.Location = new System.Drawing.Point(7, 67);
            this.btn_SelectNewDataOutput.Name = "btn_SelectNewDataOutput";
            this.btn_SelectNewDataOutput.Size = new System.Drawing.Size(108, 23);
            this.btn_SelectNewDataOutput.TabIndex = 0;
            this.btn_SelectNewDataOutput.Text = "Select Output";
            this.btn_SelectNewDataOutput.UseVisualStyleBackColor = true;
            this.btn_SelectNewDataOutput.Visible = false;
            this.btn_SelectNewDataOutput.Click += new System.EventHandler(this.btn_SelectNewDataOutput_Click);
            // 
            // txb_NewDataInput
            // 
            this.txb_NewDataInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NewDataInput.Location = new System.Drawing.Point(138, 35);
            this.txb_NewDataInput.Name = "txb_NewDataInput";
            this.txb_NewDataInput.ReadOnly = true;
            this.txb_NewDataInput.Size = new System.Drawing.Size(851, 22);
            this.txb_NewDataInput.TabIndex = 1;
            this.txb_NewDataInput.TextChanged += new System.EventHandler(this.txb_NewDataInput_TextChanged);
            // 
            // btn_SelectNewDataInput
            // 
            this.btn_SelectNewDataInput.Location = new System.Drawing.Point(7, 35);
            this.btn_SelectNewDataInput.Name = "btn_SelectNewDataInput";
            this.btn_SelectNewDataInput.Size = new System.Drawing.Size(108, 23);
            this.btn_SelectNewDataInput.TabIndex = 0;
            this.btn_SelectNewDataInput.Text = "Select Data Folder";
            this.btn_SelectNewDataInput.UseVisualStyleBackColor = true;
            this.btn_SelectNewDataInput.Click += new System.EventHandler(this.btn_SelectNewDataInput_Click);
            // 
            // grb_AddAndCopy
            // 
            this.grb_AddAndCopy.Controls.Add(this.txb_InputFolderPath);
            this.grb_AddAndCopy.Controls.Add(this.btn_SelectInput);
            this.grb_AddAndCopy.Controls.Add(this.txb_OutputFolderPath);
            this.grb_AddAndCopy.Controls.Add(this.btn_Submit);
            this.grb_AddAndCopy.Controls.Add(this.btn_SelectOutput);
            this.grb_AddAndCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_AddAndCopy.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_AddAndCopy.Location = new System.Drawing.Point(26, 86);
            this.grb_AddAndCopy.Name = "grb_AddAndCopy";
            this.grb_AddAndCopy.Size = new System.Drawing.Size(887, 187);
            this.grb_AddAndCopy.TabIndex = 6;
            this.grb_AddAndCopy.TabStop = false;
            this.grb_AddAndCopy.Text = "Copy Folders or Select New Target";
            this.grb_AddAndCopy.Visible = false;
            // 
            // txb_InputFolderPath
            // 
            this.txb_InputFolderPath.Location = new System.Drawing.Point(193, 23);
            this.txb_InputFolderPath.Name = "txb_InputFolderPath";
            this.txb_InputFolderPath.ReadOnly = true;
            this.txb_InputFolderPath.Size = new System.Drawing.Size(602, 22);
            this.txb_InputFolderPath.TabIndex = 1;
            // 
            // btn_SelectInput
            // 
            this.btn_SelectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectInput.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SelectInput.Location = new System.Drawing.Point(54, 23);
            this.btn_SelectInput.Name = "btn_SelectInput";
            this.btn_SelectInput.Size = new System.Drawing.Size(127, 23);
            this.btn_SelectInput.TabIndex = 0;
            this.btn_SelectInput.Text = "Select Input";
            this.btn_SelectInput.Click += new System.EventHandler(this.btn_SelectInput_Click);
            // 
            // txb_OutputFolderPath
            // 
            this.txb_OutputFolderPath.Location = new System.Drawing.Point(193, 51);
            this.txb_OutputFolderPath.Name = "txb_OutputFolderPath";
            this.txb_OutputFolderPath.ReadOnly = true;
            this.txb_OutputFolderPath.Size = new System.Drawing.Size(602, 22);
            this.txb_OutputFolderPath.TabIndex = 1;
            this.txb_OutputFolderPath.Visible = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Submit.Location = new System.Drawing.Point(193, 105);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_SelectOutput
            // 
            this.btn_SelectOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectOutput.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SelectOutput.Location = new System.Drawing.Point(54, 53);
            this.btn_SelectOutput.Name = "btn_SelectOutput";
            this.btn_SelectOutput.Size = new System.Drawing.Size(127, 23);
            this.btn_SelectOutput.TabIndex = 2;
            this.btn_SelectOutput.Text = "Select Output";
            this.btn_SelectOutput.UseVisualStyleBackColor = true;
            this.btn_SelectOutput.Visible = false;
            this.btn_SelectOutput.Click += new System.EventHandler(this.btn_SelectOutput_Click);
            // 
            // grb_ZipFolders
            // 
            this.grb_ZipFolders.Controls.Add(this.txb_FolderToZip);
            this.grb_ZipFolders.Controls.Add(this.btn_SelectFolderToZip);
            this.grb_ZipFolders.Controls.Add(this.txb_FolderToZipTo);
            this.grb_ZipFolders.Controls.Add(this.btn_SubmitZip);
            this.grb_ZipFolders.Controls.Add(this.btn_OutPutZipTo);
            this.grb_ZipFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ZipFolders.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_ZipFolders.Location = new System.Drawing.Point(26, 74);
            this.grb_ZipFolders.Name = "grb_ZipFolders";
            this.grb_ZipFolders.Size = new System.Drawing.Size(887, 148);
            this.grb_ZipFolders.TabIndex = 7;
            this.grb_ZipFolders.TabStop = false;
            this.grb_ZipFolders.Text = "Archive Data Folders";
            this.grb_ZipFolders.Visible = false;
            // 
            // txb_FolderToZip
            // 
            this.txb_FolderToZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FolderToZip.Location = new System.Drawing.Point(193, 23);
            this.txb_FolderToZip.Name = "txb_FolderToZip";
            this.txb_FolderToZip.ReadOnly = true;
            this.txb_FolderToZip.Size = new System.Drawing.Size(602, 22);
            this.txb_FolderToZip.TabIndex = 1;
            // 
            // btn_SelectFolderToZip
            // 
            this.btn_SelectFolderToZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFolderToZip.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SelectFolderToZip.Location = new System.Drawing.Point(54, 23);
            this.btn_SelectFolderToZip.Name = "btn_SelectFolderToZip";
            this.btn_SelectFolderToZip.Size = new System.Drawing.Size(127, 23);
            this.btn_SelectFolderToZip.TabIndex = 0;
            this.btn_SelectFolderToZip.Text = "Select Input";
            this.btn_SelectFolderToZip.Click += new System.EventHandler(this.btn_SelectFolderToZip_Click);
            // 
            // txb_FolderToZipTo
            // 
            this.txb_FolderToZipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FolderToZipTo.Location = new System.Drawing.Point(193, 51);
            this.txb_FolderToZipTo.Name = "txb_FolderToZipTo";
            this.txb_FolderToZipTo.ReadOnly = true;
            this.txb_FolderToZipTo.Size = new System.Drawing.Size(602, 22);
            this.txb_FolderToZipTo.TabIndex = 1;
            this.txb_FolderToZipTo.Visible = false;
            // 
            // btn_SubmitZip
            // 
            this.btn_SubmitZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitZip.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SubmitZip.Location = new System.Drawing.Point(193, 94);
            this.btn_SubmitZip.Name = "btn_SubmitZip";
            this.btn_SubmitZip.Size = new System.Drawing.Size(107, 23);
            this.btn_SubmitZip.TabIndex = 3;
            this.btn_SubmitZip.Text = "Archive";
            this.btn_SubmitZip.UseVisualStyleBackColor = true;
            this.btn_SubmitZip.Visible = false;
            this.btn_SubmitZip.Click += new System.EventHandler(this.btn_SubmitZip_Click);
            // 
            // btn_OutPutZipTo
            // 
            this.btn_OutPutZipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutPutZipTo.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_OutPutZipTo.Location = new System.Drawing.Point(54, 53);
            this.btn_OutPutZipTo.Name = "btn_OutPutZipTo";
            this.btn_OutPutZipTo.Size = new System.Drawing.Size(127, 23);
            this.btn_OutPutZipTo.TabIndex = 2;
            this.btn_OutPutZipTo.Text = "Select Output";
            this.btn_OutPutZipTo.UseVisualStyleBackColor = true;
            this.btn_OutPutZipTo.Visible = false;
            this.btn_OutPutZipTo.Click += new System.EventHandler(this.btn_OutPutZipTo_Click);
            // 
            // lbl_SelectAction
            // 
            this.lbl_SelectAction.AutoSize = true;
            this.lbl_SelectAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectAction.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_SelectAction.Location = new System.Drawing.Point(23, 22);
            this.lbl_SelectAction.Name = "lbl_SelectAction";
            this.lbl_SelectAction.Size = new System.Drawing.Size(94, 16);
            this.lbl_SelectAction.TabIndex = 5;
            this.lbl_SelectAction.Text = "Select Utility";
            // 
            // cmb_SelectAction
            // 
            this.cmb_SelectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelectAction.FormattingEnabled = true;
            this.cmb_SelectAction.Items.AddRange(new object[] {
            "New Target to add to db and/or copy",
            "Add additional Data for existing target",
            "Archive Data Folders",
            "DB Maintenance",
            "Generate Reports"});
            this.cmb_SelectAction.Location = new System.Drawing.Point(23, 44);
            this.cmb_SelectAction.Name = "cmb_SelectAction";
            this.cmb_SelectAction.Size = new System.Drawing.Size(264, 24);
            this.cmb_SelectAction.TabIndex = 4;
            this.cmb_SelectAction.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectAction_SelectedIndexChanged_1);
            // 
            // pnl_TargetAndEqipment
            // 
            this.pnl_TargetAndEqipment.Controls.Add(this.grb_TargetAndMount);
            this.pnl_TargetAndEqipment.Controls.Add(this.grb_TypeOfAction);
            this.pnl_TargetAndEqipment.Controls.Add(this.grp_GuideEquipment);
            this.pnl_TargetAndEqipment.Controls.Add(this.grb_CamerasScopesAndFilter);
            this.pnl_TargetAndEqipment.Location = new System.Drawing.Point(3, 1);
            this.pnl_TargetAndEqipment.Name = "pnl_TargetAndEqipment";
            this.pnl_TargetAndEqipment.Size = new System.Drawing.Size(1072, 492);
            this.pnl_TargetAndEqipment.TabIndex = 3;
            this.pnl_TargetAndEqipment.Visible = false;
            this.pnl_TargetAndEqipment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_TargetAndEqipment_Paint);
            // 
            // grb_TargetAndMount
            // 
            this.grb_TargetAndMount.Controls.Add(this.lbl_Bortle);
            this.grb_TargetAndMount.Controls.Add(this.cmb_Bortel);
            this.grb_TargetAndMount.Controls.Add(this.lbl_Location);
            this.grb_TargetAndMount.Controls.Add(this.txb_Location);
            this.grb_TargetAndMount.Controls.Add(this.lbl_Target);
            this.grb_TargetAndMount.Controls.Add(this.txb_TargetName);
            this.grb_TargetAndMount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TargetAndMount.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_TargetAndMount.Location = new System.Drawing.Point(16, 13);
            this.grb_TargetAndMount.Name = "grb_TargetAndMount";
            this.grb_TargetAndMount.Size = new System.Drawing.Size(982, 86);
            this.grb_TargetAndMount.TabIndex = 0;
            this.grb_TargetAndMount.TabStop = false;
            this.grb_TargetAndMount.Text = "Target and Eqipment to Add";
            // 
            // lbl_Bortle
            // 
            this.lbl_Bortle.AutoSize = true;
            this.lbl_Bortle.Location = new System.Drawing.Point(816, 21);
            this.lbl_Bortle.Name = "lbl_Bortle";
            this.lbl_Bortle.Size = new System.Drawing.Size(90, 16);
            this.lbl_Bortle.TabIndex = 6;
            this.lbl_Bortle.Text = "Bortel Level";
            // 
            // cmb_Bortel
            // 
            this.cmb_Bortel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bortel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bortel.FormattingEnabled = true;
            this.cmb_Bortel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmb_Bortel.Location = new System.Drawing.Point(816, 42);
            this.cmb_Bortel.Name = "cmb_Bortel";
            this.cmb_Bortel.Size = new System.Drawing.Size(121, 24);
            this.cmb_Bortel.TabIndex = 5;
            this.cmb_Bortel.SelectedIndexChanged += new System.EventHandler(this.cmb_Bortel_SelectedIndexChanged);
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(280, 21);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(113, 16);
            this.lbl_Location.TabIndex = 4;
            this.lbl_Location.Text = "Image Location";
            // 
            // txb_Location
            // 
            this.txb_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Location.Location = new System.Drawing.Point(283, 43);
            this.txb_Location.Name = "txb_Location";
            this.txb_Location.Size = new System.Drawing.Size(498, 22);
            this.txb_Location.TabIndex = 3;
            this.txb_Location.Validated += new System.EventHandler(this.txb_Location_Validating);
            // 
            // lbl_Target
            // 
            this.lbl_Target.AutoSize = true;
            this.lbl_Target.Location = new System.Drawing.Point(7, 24);
            this.lbl_Target.Name = "lbl_Target";
            this.lbl_Target.Size = new System.Drawing.Size(98, 16);
            this.lbl_Target.TabIndex = 2;
            this.lbl_Target.Text = "Target Name";
            // 
            // txb_TargetName
            // 
            this.txb_TargetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TargetName.Location = new System.Drawing.Point(6, 45);
            this.txb_TargetName.Name = "txb_TargetName";
            this.txb_TargetName.ReadOnly = true;
            this.txb_TargetName.Size = new System.Drawing.Size(249, 22);
            this.txb_TargetName.TabIndex = 0;
            // 
            // grb_TypeOfAction
            // 
            this.grb_TypeOfAction.Controls.Add(this.ckb_AddAndCopy);
            this.grb_TypeOfAction.Controls.Add(this.btn_AddTarget);
            this.grb_TypeOfAction.Controls.Add(this.ckb_AddOnly);
            this.grb_TypeOfAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TypeOfAction.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_TypeOfAction.Location = new System.Drawing.Point(330, 371);
            this.grb_TypeOfAction.Name = "grb_TypeOfAction";
            this.grb_TypeOfAction.Size = new System.Drawing.Size(327, 104);
            this.grb_TypeOfAction.TabIndex = 4;
            this.grb_TypeOfAction.TabStop = false;
            this.grb_TypeOfAction.Text = "Type of Action";
            this.grb_TypeOfAction.Visible = false;
            // 
            // ckb_AddAndCopy
            // 
            this.ckb_AddAndCopy.AutoSize = true;
            this.ckb_AddAndCopy.Location = new System.Drawing.Point(6, 56);
            this.ckb_AddAndCopy.Name = "ckb_AddAndCopy";
            this.ckb_AddAndCopy.Size = new System.Drawing.Size(169, 20);
            this.ckb_AddAndCopy.TabIndex = 1;
            this.ckb_AddAndCopy.Text = "Add to DB and Copy";
            this.ckb_AddAndCopy.UseVisualStyleBackColor = true;
            this.ckb_AddAndCopy.CheckedChanged += new System.EventHandler(this.ckb_AddAndCopy_CheckedChanged);
            // 
            // btn_AddTarget
            // 
            this.btn_AddTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTarget.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_AddTarget.Location = new System.Drawing.Point(198, 53);
            this.btn_AddTarget.Name = "btn_AddTarget";
            this.btn_AddTarget.Size = new System.Drawing.Size(123, 23);
            this.btn_AddTarget.TabIndex = 3;
            this.btn_AddTarget.Text = "Add Target";
            this.btn_AddTarget.UseVisualStyleBackColor = true;
            this.btn_AddTarget.Visible = false;
            this.btn_AddTarget.Click += new System.EventHandler(this.btn_AddTarget_Click);
            // 
            // ckb_AddOnly
            // 
            this.ckb_AddOnly.AutoSize = true;
            this.ckb_AddOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_AddOnly.Location = new System.Drawing.Point(6, 30);
            this.ckb_AddOnly.Name = "ckb_AddOnly";
            this.ckb_AddOnly.Size = new System.Drawing.Size(134, 20);
            this.ckb_AddOnly.TabIndex = 0;
            this.ckb_AddOnly.Text = "Add to DB Only";
            this.ckb_AddOnly.UseVisualStyleBackColor = true;
            this.ckb_AddOnly.CheckedChanged += new System.EventHandler(this.ckb_AddOnly_CheckedChanged);
            // 
            // grp_GuideEquipment
            // 
            this.grp_GuideEquipment.Controls.Add(this.lbl_GuideScope);
            this.grp_GuideEquipment.Controls.Add(this.lbl_GuideCamera);
            this.grp_GuideEquipment.Controls.Add(this.cmb_GuideScope);
            this.grp_GuideEquipment.Controls.Add(this.cmb_GuideCamera);
            this.grp_GuideEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_GuideEquipment.ForeColor = System.Drawing.Color.DarkRed;
            this.grp_GuideEquipment.Location = new System.Drawing.Point(16, 251);
            this.grp_GuideEquipment.Name = "grp_GuideEquipment";
            this.grp_GuideEquipment.Size = new System.Drawing.Size(982, 100);
            this.grp_GuideEquipment.TabIndex = 2;
            this.grp_GuideEquipment.TabStop = false;
            this.grp_GuideEquipment.Text = "Guide Equipment";
            this.grp_GuideEquipment.Visible = false;
            // 
            // lbl_GuideScope
            // 
            this.lbl_GuideScope.AutoSize = true;
            this.lbl_GuideScope.Location = new System.Drawing.Point(314, 22);
            this.lbl_GuideScope.Name = "lbl_GuideScope";
            this.lbl_GuideScope.Size = new System.Drawing.Size(97, 16);
            this.lbl_GuideScope.TabIndex = 3;
            this.lbl_GuideScope.Text = "Guide Scope";
            // 
            // lbl_GuideCamera
            // 
            this.lbl_GuideCamera.AutoSize = true;
            this.lbl_GuideCamera.Location = new System.Drawing.Point(13, 22);
            this.lbl_GuideCamera.Name = "lbl_GuideCamera";
            this.lbl_GuideCamera.Size = new System.Drawing.Size(106, 16);
            this.lbl_GuideCamera.TabIndex = 2;
            this.lbl_GuideCamera.Text = "Guide Camera";
            // 
            // cmb_GuideScope
            // 
            this.cmb_GuideScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GuideScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GuideScope.FormattingEnabled = true;
            this.cmb_GuideScope.Location = new System.Drawing.Point(314, 47);
            this.cmb_GuideScope.Name = "cmb_GuideScope";
            this.cmb_GuideScope.Size = new System.Drawing.Size(303, 24);
            this.cmb_GuideScope.TabIndex = 1;
            this.cmb_GuideScope.SelectedIndexChanged += new System.EventHandler(this.cmb_GuideScope_SelectedIndexChanged);
            // 
            // cmb_GuideCamera
            // 
            this.cmb_GuideCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GuideCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GuideCamera.FormattingEnabled = true;
            this.cmb_GuideCamera.Location = new System.Drawing.Point(13, 47);
            this.cmb_GuideCamera.Name = "cmb_GuideCamera";
            this.cmb_GuideCamera.Size = new System.Drawing.Size(249, 24);
            this.cmb_GuideCamera.TabIndex = 0;
            this.cmb_GuideCamera.SelectedIndexChanged += new System.EventHandler(this.cmb_GuideCamera_SelectedIndexChanged);
            // 
            // grb_CamerasScopesAndFilter
            // 
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_MountName);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_Filter);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_Filter);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_MountName);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_LensTelescope);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_ImageCamera);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_ImageLensTelescope);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_ImageCamera);
            this.grb_CamerasScopesAndFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CamerasScopesAndFilter.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_CamerasScopesAndFilter.Location = new System.Drawing.Point(16, 101);
            this.grb_CamerasScopesAndFilter.Name = "grb_CamerasScopesAndFilter";
            this.grb_CamerasScopesAndFilter.Size = new System.Drawing.Size(982, 144);
            this.grb_CamerasScopesAndFilter.TabIndex = 1;
            this.grb_CamerasScopesAndFilter.TabStop = false;
            this.grb_CamerasScopesAndFilter.Text = "Cameras Scopes and Filters";
            this.grb_CamerasScopesAndFilter.Visible = false;
            // 
            // lbl_MountName
            // 
            this.lbl_MountName.AutoSize = true;
            this.lbl_MountName.Location = new System.Drawing.Point(13, 26);
            this.lbl_MountName.Name = "lbl_MountName";
            this.lbl_MountName.Size = new System.Drawing.Size(48, 16);
            this.lbl_MountName.TabIndex = 3;
            this.lbl_MountName.Text = "Mount";
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Location = new System.Drawing.Point(6, 97);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(953, 24);
            this.cmb_Filter.TabIndex = 6;
            this.cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter_SelectedIndexChanged);
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Location = new System.Drawing.Point(6, 78);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(42, 16);
            this.lbl_Filter.TabIndex = 5;
            this.lbl_Filter.Text = "Filter";
            // 
            // cmb_MountName
            // 
            this.cmb_MountName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MountName.FormattingEnabled = true;
            this.cmb_MountName.Location = new System.Drawing.Point(13, 46);
            this.cmb_MountName.Name = "cmb_MountName";
            this.cmb_MountName.Size = new System.Drawing.Size(306, 24);
            this.cmb_MountName.TabIndex = 1;
            this.cmb_MountName.SelectedIndexChanged += new System.EventHandler(this.cmb_MountName_SelectedIndexChanged);
            // 
            // lbl_LensTelescope
            // 
            this.lbl_LensTelescope.AutoSize = true;
            this.lbl_LensTelescope.Location = new System.Drawing.Point(653, 23);
            this.lbl_LensTelescope.Name = "lbl_LensTelescope";
            this.lbl_LensTelescope.Size = new System.Drawing.Size(167, 16);
            this.lbl_LensTelescope.TabIndex = 4;
            this.lbl_LensTelescope.Text = "Image Lens/Telescope";
            // 
            // lbl_ImageCamera
            // 
            this.lbl_ImageCamera.AutoSize = true;
            this.lbl_ImageCamera.Location = new System.Drawing.Point(365, 20);
            this.lbl_ImageCamera.Name = "lbl_ImageCamera";
            this.lbl_ImageCamera.Size = new System.Drawing.Size(108, 16);
            this.lbl_ImageCamera.TabIndex = 3;
            this.lbl_ImageCamera.Text = "Image Camera";
            // 
            // cmb_ImageLensTelescope
            // 
            this.cmb_ImageLensTelescope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ImageLensTelescope.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ImageLensTelescope.FormattingEnabled = true;
            this.cmb_ImageLensTelescope.Location = new System.Drawing.Point(653, 46);
            this.cmb_ImageLensTelescope.Name = "cmb_ImageLensTelescope";
            this.cmb_ImageLensTelescope.Size = new System.Drawing.Size(306, 24);
            this.cmb_ImageLensTelescope.TabIndex = 1;
            this.cmb_ImageLensTelescope.SelectedIndexChanged += new System.EventHandler(this.cmb_ImageLensTelescope_SelectedIndexChanged);
            // 
            // cmb_ImageCamera
            // 
            this.cmb_ImageCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ImageCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ImageCamera.FormattingEnabled = true;
            this.cmb_ImageCamera.Location = new System.Drawing.Point(368, 46);
            this.cmb_ImageCamera.Name = "cmb_ImageCamera";
            this.cmb_ImageCamera.Size = new System.Drawing.Size(249, 24);
            this.cmb_ImageCamera.TabIndex = 0;
            this.cmb_ImageCamera.SelectedIndexChanged += new System.EventHandler(this.cmb_ImageCamera_SelectedIndexChanged);
            // 
            // frm_AP_Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 613);
            this.Controls.Add(this.pnl_CopyFolders);
            this.Controls.Add(this.pnl_TargetAndEqipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AP_Utilities";
            this.Text = "A.P.U. - Astrophotography Utilities";
            this.Load += new System.EventHandler(this.frm_AP_Utilities_Load);
            this.pnl_CopyFolders.ResumeLayout(false);
            this.pnl_CopyFolders.PerformLayout();
            this.grb_AddNewData.ResumeLayout(false);
            this.grb_AddNewData.PerformLayout();
            this.grb_AddAndCopy.ResumeLayout(false);
            this.grb_AddAndCopy.PerformLayout();
            this.grb_ZipFolders.ResumeLayout(false);
            this.grb_ZipFolders.PerformLayout();
            this.pnl_TargetAndEqipment.ResumeLayout(false);
            this.grb_TargetAndMount.ResumeLayout(false);
            this.grb_TargetAndMount.PerformLayout();
            this.grb_TypeOfAction.ResumeLayout(false);
            this.grb_TypeOfAction.PerformLayout();
            this.grp_GuideEquipment.ResumeLayout(false);
            this.grp_GuideEquipment.PerformLayout();
            this.grb_CamerasScopesAndFilter.ResumeLayout(false);
            this.grb_CamerasScopesAndFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_CopyFolders;
        private System.Windows.Forms.TextBox txb_InputFolderPath;
        private System.Windows.Forms.Button btn_SelectInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_SelectOutput;
        private System.Windows.Forms.TextBox txb_OutputFolderPath;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Panel pnl_TargetAndEqipment;
        private System.Windows.Forms.GroupBox grb_TargetAndMount;
        private System.Windows.Forms.Label lbl_Target;
        private System.Windows.Forms.ComboBox cmb_MountName;
        private System.Windows.Forms.TextBox txb_TargetName;
        private System.Windows.Forms.Label lbl_MountName;
        private System.Windows.Forms.GroupBox grb_CamerasScopesAndFilter;
        private System.Windows.Forms.ComboBox cmb_ImageCamera;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.Label lbl_LensTelescope;
        private System.Windows.Forms.Label lbl_ImageCamera;
        private System.Windows.Forms.ComboBox cmb_ImageLensTelescope;
        private System.Windows.Forms.ComboBox cmb_Filter;
        private System.Windows.Forms.GroupBox grp_GuideEquipment;
        private System.Windows.Forms.ComboBox cmb_GuideCamera;
        private System.Windows.Forms.Button btn_AddTarget;
        private System.Windows.Forms.Label lbl_GuideScope;
        private System.Windows.Forms.Label lbl_GuideCamera;
        private System.Windows.Forms.ComboBox cmb_GuideScope;
        private System.Windows.Forms.ComboBox cmb_Bortel;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txb_Location;
        private System.Windows.Forms.Label lbl_Bortle;
        private System.Windows.Forms.GroupBox grb_TypeOfAction;
        private System.Windows.Forms.CheckBox ckb_AddAndCopy;
        private System.Windows.Forms.CheckBox ckb_AddOnly;
        private System.Windows.Forms.Label lbl_SelectAction;
        private System.Windows.Forms.ComboBox cmb_SelectAction;
        private System.Windows.Forms.GroupBox grb_AddNewData;
        private System.Windows.Forms.TextBox txb_NewDataInput;
        private System.Windows.Forms.Button btn_SelectNewDataInput;
        private System.Windows.Forms.TextBox txb_NewDataIOutput;
        private System.Windows.Forms.Button btn_SelectNewDataOutput;
        private System.Windows.Forms.Button btn_AddNewData;
        private System.Windows.Forms.GroupBox grb_AddAndCopy;
        private System.Windows.Forms.GroupBox grb_ZipFolders;
        private System.Windows.Forms.TextBox txb_FolderToZip;
        private System.Windows.Forms.Button btn_SelectFolderToZip;
        private System.Windows.Forms.TextBox txb_FolderToZipTo;
        private System.Windows.Forms.Button btn_SubmitZip;
        private System.Windows.Forms.Button btn_OutPutZipTo;
    }
}

