namespace ZooApp
{
    partial class AddZookeeperForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbSelectZookeeper = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblKeeper = new System.Windows.Forms.Label();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.lbAssignedGroups = new System.Windows.Forms.ListBox();
            this.butAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectZookeeper
            // 
            this.cbSelectZookeeper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectZookeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSelectZookeeper.FormattingEnabled = true;
            this.cbSelectZookeeper.Location = new System.Drawing.Point(157, 25);
            this.cbSelectZookeeper.Name = "cbSelectZookeeper";
            this.cbSelectZookeeper.Size = new System.Drawing.Size(191, 28);
            this.cbSelectZookeeper.TabIndex = 0;
            this.cbSelectZookeeper.SelectedIndexChanged += new System.EventHandler(this.AddZookeeperForm_Load);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(142, 553);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(248, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblKeeper
            // 
            this.lblKeeper.AutoSize = true;
            this.lblKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKeeper.Location = new System.Drawing.Point(12, 28);
            this.lblKeeper.Name = "lblKeeper";
            this.lblKeeper.Size = new System.Drawing.Size(139, 20);
            this.lblKeeper.TabIndex = 6;
            this.lblKeeper.Text = "Select Zookeeper:";
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAssigned.Location = new System.Drawing.Point(12, 64);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(197, 20);
            this.lblAssigned.TabIndex = 8;
            this.lblAssigned.Text = "Assigned Species Groups:";
            // 
            // lbAssignedGroups
            // 
            this.lbAssignedGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAssignedGroups.FormattingEnabled = true;
            this.lbAssignedGroups.ItemHeight = 20;
            this.lbAssignedGroups.Location = new System.Drawing.Point(12, 99);
            this.lbAssignedGroups.Name = "lbAssignedGroups";
            this.lbAssignedGroups.Size = new System.Drawing.Size(336, 404);
            this.lbAssignedGroups.TabIndex = 2;
            // 
            // butAssign
            // 
            this.butAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butAssign.Location = new System.Drawing.Point(142, 512);
            this.butAssign.Name = "butAssign";
            this.butAssign.Size = new System.Drawing.Size(206, 35);
            this.butAssign.TabIndex = 27;
            this.butAssign.Text = "Assign";
            this.butAssign.UseVisualStyleBackColor = true;
            this.butAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // AddZookeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.butAssign);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.lblKeeper);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbAssignedGroups);
            this.Controls.Add(this.cbSelectZookeeper);
            this.Name = "AddZookeeperForm";
            this.Text = "Manage Zookeeper Assignments";
            this.Load += new System.EventHandler(this.AddZookeeperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectZookeeper;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblKeeper;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.ListBox lbAssignedGroups;
        private System.Windows.Forms.Button butAssign;
    }
}
