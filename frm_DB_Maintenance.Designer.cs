namespace APU___Astrophotorophy_Utilities
{
    partial class frm_DB_Maint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DB_Maint));
            this.lbl_Select_DB_Maint = new System.Windows.Forms.Label();
            this.cmb_Select_DB_Maint = new System.Windows.Forms.ComboBox();
            this.lsb_DB_Backups = new System.Windows.Forms.ListBox();
            this.lbl_DB_Backups = new System.Windows.Forms.Label();
            this.btn_Restore_Db = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Select_DB_Maint
            // 
            this.lbl_Select_DB_Maint.AutoSize = true;
            this.lbl_Select_DB_Maint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Select_DB_Maint.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Select_DB_Maint.Location = new System.Drawing.Point(13, 13);
            this.lbl_Select_DB_Maint.Name = "lbl_Select_DB_Maint";
            this.lbl_Select_DB_Maint.Size = new System.Drawing.Size(168, 16);
            this.lbl_Select_DB_Maint.TabIndex = 0;
            this.lbl_Select_DB_Maint.Text = "Select DB Maintenance";
            // 
            // cmb_Select_DB_Maint
            // 
            this.cmb_Select_DB_Maint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Select_DB_Maint.FormattingEnabled = true;
            this.cmb_Select_DB_Maint.Items.AddRange(new object[] {
            "Restore DB",
            "Add new Equipment",
            "Disable existing Equipment",
            "Modify Existing Target"});
            this.cmb_Select_DB_Maint.Location = new System.Drawing.Point(12, 42);
            this.cmb_Select_DB_Maint.Name = "cmb_Select_DB_Maint";
            this.cmb_Select_DB_Maint.Size = new System.Drawing.Size(322, 24);
            this.cmb_Select_DB_Maint.TabIndex = 1;
            this.cmb_Select_DB_Maint.SelectedIndexChanged += new System.EventHandler(this.cmb_Select_DB_Maint_SelectedIndexChanged);
            // 
            // lsb_DB_Backups
            // 
            this.lsb_DB_Backups.ItemHeight = 16;
            this.lsb_DB_Backups.Location = new System.Drawing.Point(363, 42);
            this.lsb_DB_Backups.Name = "lsb_DB_Backups";
            this.lsb_DB_Backups.Size = new System.Drawing.Size(688, 388);
            this.lsb_DB_Backups.TabIndex = 5;
            this.lsb_DB_Backups.Visible = false;
            this.lsb_DB_Backups.SelectedIndexChanged += new System.EventHandler(this.lsb_DB_Backups_SelectedIndexChanged);
            // 
            // lbl_DB_Backups
            // 
            this.lbl_DB_Backups.AutoSize = true;
            this.lbl_DB_Backups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DB_Backups.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_DB_Backups.Location = new System.Drawing.Point(360, 12);
            this.lbl_DB_Backups.Name = "lbl_DB_Backups";
            this.lbl_DB_Backups.Size = new System.Drawing.Size(182, 16);
            this.lbl_DB_Backups.TabIndex = 3;
            this.lbl_DB_Backups.Text = "Select File to Restore DB";
            this.lbl_DB_Backups.Visible = false;
            // 
            // btn_Restore_Db
            // 
            this.btn_Restore_Db.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore_Db.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Restore_Db.Location = new System.Drawing.Point(363, 453);
            this.btn_Restore_Db.Name = "btn_Restore_Db";
            this.btn_Restore_Db.Size = new System.Drawing.Size(111, 23);
            this.btn_Restore_Db.TabIndex = 4;
            this.btn_Restore_Db.Text = "Restore DB";
            this.btn_Restore_Db.UseVisualStyleBackColor = true;
            this.btn_Restore_Db.Visible = false;
            // 
            // frm_DB_Maint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 528);
            this.Controls.Add(this.btn_Restore_Db);
            this.Controls.Add(this.lbl_DB_Backups);
            this.Controls.Add(this.lsb_DB_Backups);
            this.Controls.Add(this.cmb_Select_DB_Maint);
            this.Controls.Add(this.lbl_Select_DB_Maint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DB_Maint";
            this.Text = "A.P.U. - Astrophotography Utilities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Select_DB_Maint;
        private System.Windows.Forms.ComboBox cmb_Select_DB_Maint;
        private System.Windows.Forms.ListBox lsb_DB_Backups;
        private System.Windows.Forms.Label lbl_DB_Backups;
        private System.Windows.Forms.Button btn_Restore_Db;
    }
}