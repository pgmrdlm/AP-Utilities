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
            this.cmb_SelectAction = new System.Windows.Forms.ComboBox();
            this.pnl_CopyFolders = new System.Windows.Forms.Panel();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_SelectOutput = new System.Windows.Forms.Button();
            this.txb_OutputFolderPath = new System.Windows.Forms.TextBox();
            this.btn_SelectInput = new System.Windows.Forms.Button();
            this.txb_InputFolderPath = new System.Windows.Forms.TextBox();
            this.lbl_SelectAction = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_TargetAndEqipment = new System.Windows.Forms.Panel();
            this.btn_AddTarget = new System.Windows.Forms.Button();
            this.grp_GuideEquipment = new System.Windows.Forms.GroupBox();
            this.lbl_GuideScope = new System.Windows.Forms.Label();
            this.lbl_GuideCamera = new System.Windows.Forms.Label();
            this.cmb_GuideScope = new System.Windows.Forms.ComboBox();
            this.cmb_GuideCamera = new System.Windows.Forms.ComboBox();
            this.grb_CamerasScopesAndFilter = new System.Windows.Forms.GroupBox();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.lbl_LensTelescope = new System.Windows.Forms.Label();
            this.lbl_ImageCamera = new System.Windows.Forms.Label();
            this.cmb_ImageLensTelescope = new System.Windows.Forms.ComboBox();
            this.cmb_ImageCamera = new System.Windows.Forms.ComboBox();
            this.grb_TargetAndMount = new System.Windows.Forms.GroupBox();
            this.lbl_MountName = new System.Windows.Forms.Label();
            this.lbl_Target = new System.Windows.Forms.Label();
            this.cmb_MountName = new System.Windows.Forms.ComboBox();
            this.txb_TargetName = new System.Windows.Forms.TextBox();
            this.pnl_CopyFolders.SuspendLayout();
            this.pnl_TargetAndEqipment.SuspendLayout();
            this.grp_GuideEquipment.SuspendLayout();
            this.grb_CamerasScopesAndFilter.SuspendLayout();
            this.grb_TargetAndMount.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_SelectAction
            // 
            this.cmb_SelectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelectAction.FormattingEnabled = true;
            this.cmb_SelectAction.Items.AddRange(new object[] {
            "Image Folder copy(Lights/Calibration)"});
            this.cmb_SelectAction.Location = new System.Drawing.Point(13, 33);
            this.cmb_SelectAction.Name = "cmb_SelectAction";
            this.cmb_SelectAction.Size = new System.Drawing.Size(264, 24);
            this.cmb_SelectAction.TabIndex = 0;
            this.cmb_SelectAction.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectAction_SelectedIndexChanged);
            // 
            // pnl_CopyFolders
            // 
            this.pnl_CopyFolders.Controls.Add(this.btn_Submit);
            this.pnl_CopyFolders.Controls.Add(this.btn_SelectOutput);
            this.pnl_CopyFolders.Controls.Add(this.txb_OutputFolderPath);
            this.pnl_CopyFolders.Controls.Add(this.btn_SelectInput);
            this.pnl_CopyFolders.Controls.Add(this.txb_InputFolderPath);
            this.pnl_CopyFolders.Location = new System.Drawing.Point(12, 63);
            this.pnl_CopyFolders.Name = "pnl_CopyFolders";
            this.pnl_CopyFolders.Size = new System.Drawing.Size(773, 342);
            this.pnl_CopyFolders.TabIndex = 1;
            this.pnl_CopyFolders.Visible = false;
            this.pnl_CopyFolders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_CopyImageData_Paint);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Submit.Location = new System.Drawing.Point(152, 101);
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
            this.btn_SelectOutput.Location = new System.Drawing.Point(13, 49);
            this.btn_SelectOutput.Name = "btn_SelectOutput";
            this.btn_SelectOutput.Size = new System.Drawing.Size(127, 23);
            this.btn_SelectOutput.TabIndex = 2;
            this.btn_SelectOutput.Text = "Select Output";
            this.btn_SelectOutput.UseVisualStyleBackColor = true;
            this.btn_SelectOutput.Visible = false;
            this.btn_SelectOutput.Click += new System.EventHandler(this.btn_SelectOutput_Click);
            // 
            // txb_OutputFolderPath
            // 
            this.txb_OutputFolderPath.Location = new System.Drawing.Point(152, 47);
            this.txb_OutputFolderPath.Name = "txb_OutputFolderPath";
            this.txb_OutputFolderPath.ReadOnly = true;
            this.txb_OutputFolderPath.Size = new System.Drawing.Size(602, 22);
            this.txb_OutputFolderPath.TabIndex = 1;
            this.txb_OutputFolderPath.Visible = false;
            // 
            // btn_SelectInput
            // 
            this.btn_SelectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectInput.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SelectInput.Location = new System.Drawing.Point(13, 19);
            this.btn_SelectInput.Name = "btn_SelectInput";
            this.btn_SelectInput.Size = new System.Drawing.Size(127, 23);
            this.btn_SelectInput.TabIndex = 0;
            this.btn_SelectInput.Text = "Select Input";
            this.btn_SelectInput.Click += new System.EventHandler(this.btn_SelectInput_Click);
            // 
            // txb_InputFolderPath
            // 
            this.txb_InputFolderPath.Location = new System.Drawing.Point(152, 19);
            this.txb_InputFolderPath.Name = "txb_InputFolderPath";
            this.txb_InputFolderPath.ReadOnly = true;
            this.txb_InputFolderPath.Size = new System.Drawing.Size(602, 22);
            this.txb_InputFolderPath.TabIndex = 1;
            // 
            // lbl_SelectAction
            // 
            this.lbl_SelectAction.AutoSize = true;
            this.lbl_SelectAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectAction.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_SelectAction.Location = new System.Drawing.Point(13, 11);
            this.lbl_SelectAction.Name = "lbl_SelectAction";
            this.lbl_SelectAction.Size = new System.Drawing.Size(94, 16);
            this.lbl_SelectAction.TabIndex = 2;
            this.lbl_SelectAction.Text = "Select Utility";
            // 
            // pnl_TargetAndEqipment
            // 
            this.pnl_TargetAndEqipment.Controls.Add(this.btn_AddTarget);
            this.pnl_TargetAndEqipment.Controls.Add(this.grp_GuideEquipment);
            this.pnl_TargetAndEqipment.Controls.Add(this.grb_CamerasScopesAndFilter);
            this.pnl_TargetAndEqipment.Controls.Add(this.grb_TargetAndMount);
            this.pnl_TargetAndEqipment.Location = new System.Drawing.Point(9, 11);
            this.pnl_TargetAndEqipment.Name = "pnl_TargetAndEqipment";
            this.pnl_TargetAndEqipment.Size = new System.Drawing.Size(773, 427);
            this.pnl_TargetAndEqipment.TabIndex = 3;
            this.pnl_TargetAndEqipment.Visible = false;
            // 
            // btn_AddTarget
            // 
            this.btn_AddTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTarget.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_AddTarget.Location = new System.Drawing.Point(248, 357);
            this.btn_AddTarget.Name = "btn_AddTarget";
            this.btn_AddTarget.Size = new System.Drawing.Size(123, 23);
            this.btn_AddTarget.TabIndex = 3;
            this.btn_AddTarget.Text = "Add Target";
            this.btn_AddTarget.UseVisualStyleBackColor = true;
            this.btn_AddTarget.Click += new System.EventHandler(this.btn_AddTarget_Click);
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
            this.grp_GuideEquipment.Size = new System.Drawing.Size(738, 100);
            this.grp_GuideEquipment.TabIndex = 2;
            this.grp_GuideEquipment.TabStop = false;
            this.grp_GuideEquipment.Text = "Guide Equipment";
            // 
            // lbl_GuideScope
            // 
            this.lbl_GuideScope.AutoSize = true;
            this.lbl_GuideScope.Location = new System.Drawing.Point(283, 22);
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
            this.cmb_GuideScope.FormattingEnabled = true;
            this.cmb_GuideScope.Location = new System.Drawing.Point(283, 47);
            this.cmb_GuideScope.Name = "cmb_GuideScope";
            this.cmb_GuideScope.Size = new System.Drawing.Size(303, 24);
            this.cmb_GuideScope.TabIndex = 1;
            // 
            // cmb_GuideCamera
            // 
            this.cmb_GuideCamera.FormattingEnabled = true;
            this.cmb_GuideCamera.Location = new System.Drawing.Point(13, 47);
            this.cmb_GuideCamera.Name = "cmb_GuideCamera";
            this.cmb_GuideCamera.Size = new System.Drawing.Size(249, 24);
            this.cmb_GuideCamera.TabIndex = 0;
            // 
            // grb_CamerasScopesAndFilter
            // 
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_Filter);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_Filter);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_LensTelescope);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.lbl_ImageCamera);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_ImageLensTelescope);
            this.grb_CamerasScopesAndFilter.Controls.Add(this.cmb_ImageCamera);
            this.grb_CamerasScopesAndFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_CamerasScopesAndFilter.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_CamerasScopesAndFilter.Location = new System.Drawing.Point(16, 101);
            this.grb_CamerasScopesAndFilter.Name = "grb_CamerasScopesAndFilter";
            this.grb_CamerasScopesAndFilter.Size = new System.Drawing.Size(738, 144);
            this.grb_CamerasScopesAndFilter.TabIndex = 1;
            this.grb_CamerasScopesAndFilter.TabStop = false;
            this.grb_CamerasScopesAndFilter.Text = "Cameras Scopes and Filters";
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Location = new System.Drawing.Point(6, 97);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(580, 24);
            this.cmb_Filter.TabIndex = 6;
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
            // lbl_LensTelescope
            // 
            this.lbl_LensTelescope.AutoSize = true;
            this.lbl_LensTelescope.Location = new System.Drawing.Point(280, 25);
            this.lbl_LensTelescope.Name = "lbl_LensTelescope";
            this.lbl_LensTelescope.Size = new System.Drawing.Size(167, 16);
            this.lbl_LensTelescope.TabIndex = 4;
            this.lbl_LensTelescope.Text = "Image Lens/Telescope";
            // 
            // lbl_ImageCamera
            // 
            this.lbl_ImageCamera.AutoSize = true;
            this.lbl_ImageCamera.Location = new System.Drawing.Point(10, 22);
            this.lbl_ImageCamera.Name = "lbl_ImageCamera";
            this.lbl_ImageCamera.Size = new System.Drawing.Size(108, 16);
            this.lbl_ImageCamera.TabIndex = 3;
            this.lbl_ImageCamera.Text = "Image Camera";
            // 
            // cmb_ImageLensTelescope
            // 
            this.cmb_ImageLensTelescope.FormattingEnabled = true;
            this.cmb_ImageLensTelescope.Location = new System.Drawing.Point(280, 48);
            this.cmb_ImageLensTelescope.Name = "cmb_ImageLensTelescope";
            this.cmb_ImageLensTelescope.Size = new System.Drawing.Size(306, 24);
            this.cmb_ImageLensTelescope.TabIndex = 1;
            // 
            // cmb_ImageCamera
            // 
            this.cmb_ImageCamera.FormattingEnabled = true;
            this.cmb_ImageCamera.Location = new System.Drawing.Point(13, 48);
            this.cmb_ImageCamera.Name = "cmb_ImageCamera";
            this.cmb_ImageCamera.Size = new System.Drawing.Size(249, 24);
            this.cmb_ImageCamera.TabIndex = 0;
            // 
            // grb_TargetAndMount
            // 
            this.grb_TargetAndMount.Controls.Add(this.lbl_MountName);
            this.grb_TargetAndMount.Controls.Add(this.lbl_Target);
            this.grb_TargetAndMount.Controls.Add(this.cmb_MountName);
            this.grb_TargetAndMount.Controls.Add(this.txb_TargetName);
            this.grb_TargetAndMount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TargetAndMount.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_TargetAndMount.Location = new System.Drawing.Point(16, 4);
            this.grb_TargetAndMount.Name = "grb_TargetAndMount";
            this.grb_TargetAndMount.Size = new System.Drawing.Size(738, 86);
            this.grb_TargetAndMount.TabIndex = 0;
            this.grb_TargetAndMount.TabStop = false;
            this.grb_TargetAndMount.Text = "Target and Eqipment to Add";
            // 
            // lbl_MountName
            // 
            this.lbl_MountName.AutoSize = true;
            this.lbl_MountName.Location = new System.Drawing.Point(280, 19);
            this.lbl_MountName.Name = "lbl_MountName";
            this.lbl_MountName.Size = new System.Drawing.Size(48, 16);
            this.lbl_MountName.TabIndex = 3;
            this.lbl_MountName.Text = "Mount";
            // 
            // lbl_Target
            // 
            this.lbl_Target.AutoSize = true;
            this.lbl_Target.Location = new System.Drawing.Point(7, 20);
            this.lbl_Target.Name = "lbl_Target";
            this.lbl_Target.Size = new System.Drawing.Size(98, 16);
            this.lbl_Target.TabIndex = 2;
            this.lbl_Target.Text = "Target Name";
            // 
            // cmb_MountName
            // 
            this.cmb_MountName.FormattingEnabled = true;
            this.cmb_MountName.Location = new System.Drawing.Point(280, 39);
            this.cmb_MountName.Name = "cmb_MountName";
            this.cmb_MountName.Size = new System.Drawing.Size(306, 24);
            this.cmb_MountName.TabIndex = 1;
            this.cmb_MountName.SelectedIndexChanged += new System.EventHandler(this.cmb_MountName_SelectedIndexChanged);
            // 
            // txb_TargetName
            // 
            this.txb_TargetName.Location = new System.Drawing.Point(6, 41);
            this.txb_TargetName.Name = "txb_TargetName";
            this.txb_TargetName.ReadOnly = true;
            this.txb_TargetName.Size = new System.Drawing.Size(249, 22);
            this.txb_TargetName.TabIndex = 0;
            // 
            // frm_AP_Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.pnl_TargetAndEqipment);
            this.Controls.Add(this.lbl_SelectAction);
            this.Controls.Add(this.pnl_CopyFolders);
            this.Controls.Add(this.cmb_SelectAction);
            this.Name = "frm_AP_Utilities";
            this.Text = "A.P.U. - Astrophotography Utilities";
            this.pnl_CopyFolders.ResumeLayout(false);
            this.pnl_CopyFolders.PerformLayout();
            this.pnl_TargetAndEqipment.ResumeLayout(false);
            this.grp_GuideEquipment.ResumeLayout(false);
            this.grp_GuideEquipment.PerformLayout();
            this.grb_CamerasScopesAndFilter.ResumeLayout(false);
            this.grb_CamerasScopesAndFilter.PerformLayout();
            this.grb_TargetAndMount.ResumeLayout(false);
            this.grb_TargetAndMount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_SelectAction;
        private System.Windows.Forms.Panel pnl_CopyFolders;
        private System.Windows.Forms.TextBox txb_InputFolderPath;
        private System.Windows.Forms.Label lbl_SelectAction;
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
    }
}

