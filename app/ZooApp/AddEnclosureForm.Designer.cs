namespace ZooApp
{
    partial class AddEnclosureForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtBiome = new System.Windows.Forms.TextBox();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.txtZoneSize = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBiome = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.lblZoneSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBiome
            this.txtBiome.Location = new System.Drawing.Point(140, 30);
            this.txtBiome.Name = "txtBiome";
            this.txtBiome.Size = new System.Drawing.Size(200, 20);
            // 
            // txtZone
            this.txtZone.Location = new System.Drawing.Point(140, 70);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(200, 20);
            // 
            // txtZoneSize
            this.txtZoneSize.Location = new System.Drawing.Point(140, 110);
            this.txtZoneSize.Name = "txtZoneSize";
            this.txtZoneSize.Size = new System.Drawing.Size(200, 20);
            // 
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(80, 160);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(190, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBiome
            this.lblBiome.AutoSize = true;
            this.lblBiome.Location = new System.Drawing.Point(40, 33);
            this.lblBiome.Name = "lblBiome";
            this.lblBiome.Text = "Biome:";
            // 
            // lblZone
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(40, 73);
            this.lblZone.Name = "lblZone";
            this.lblZone.Text = "Zone Name:";
            // 
            // lblZoneSize
            this.lblZoneSize.AutoSize = true;
            this.lblZoneSize.Location = new System.Drawing.Point(40, 113);
            this.lblZoneSize.Name = "lblZoneSize";
            this.lblZoneSize.Text = "Zone Size:";
            // 
            // AddEnclosureForm
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.txtBiome);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.txtZoneSize);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblBiome);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.lblZoneSize);
            this.Name = "AddEnclosureForm";
            this.Text = "Add New Enclosure";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBiome;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.TextBox txtZoneSize;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBiome;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Label lblZoneSize;
    }
}
