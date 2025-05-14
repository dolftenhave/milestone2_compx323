namespace ZooApp
{
    partial class AddZookeeperForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSpeciesGroups;
        private System.Windows.Forms.CheckedListBox clbSpeciesGroups;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSpeciesGroups = new System.Windows.Forms.Label();
            this.clbSpeciesGroups = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Assign Species Groups (Zoo)";

            // 
            // lblSpeciesGroups
            // 
            this.lblSpeciesGroups.AutoSize = true;
            this.lblSpeciesGroups.Location = new System.Drawing.Point(22, 50);
            this.lblSpeciesGroups.Name = "lblSpeciesGroups";
            this.lblSpeciesGroups.Size = new System.Drawing.Size(89, 13);
            this.lblSpeciesGroups.TabIndex = 1;
            this.lblSpeciesGroups.Text = "Species Groups:";

            // 
            // clbSpeciesGroups
            // 
            this.clbSpeciesGroups.CheckOnClick = true;
            this.clbSpeciesGroups.FormattingEnabled = true;
            this.clbSpeciesGroups.Location = new System.Drawing.Point(25, 70);
            this.clbSpeciesGroups.Name = "clbSpeciesGroups";
            this.clbSpeciesGroups.Size = new System.Drawing.Size(240, 124);
            this.clbSpeciesGroups.TabIndex = 2;

            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(25, 210);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Save";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // AddZookeeperForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSpeciesGroups);
            this.Controls.Add(this.clbSpeciesGroups);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddZookeeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Zookeeper";
            this.Load += new System.EventHandler(this.AddZookeeperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
