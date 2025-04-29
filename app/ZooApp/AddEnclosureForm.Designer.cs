namespace ZooApp
{
    partial class AddEnclosureForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBiome;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.ComboBox cbZone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBiome;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblZone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBiome = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cbZone = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBiome = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBiome
            this.txtBiome.Location = new System.Drawing.Point(150, 20);
            this.txtBiome.Size = new System.Drawing.Size(180, 20);
            // 
            // txtSize
            this.txtSize.Location = new System.Drawing.Point(150, 60);
            this.txtSize.Size = new System.Drawing.Size(180, 20);
            // 
            // cbZone
            this.cbZone.Location = new System.Drawing.Point(150, 100);
            this.cbZone.Size = new System.Drawing.Size(180, 21);
            // 
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(90, 140);
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.Text = "Add";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(190, 140);
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBiome
            this.lblBiome.Text = "Biome:";
            this.lblBiome.Location = new System.Drawing.Point(20, 20);
            // 
            // lblSize
            this.lblSize.Text = "Size:";
            this.lblSize.Location = new System.Drawing.Point(20, 60);
            // 
            // lblZone
            this.lblZone.Text = "Zone:";
            this.lblZone.Location = new System.Drawing.Point(20, 100);

            // AddEnclosureForm
            this.ClientSize = new System.Drawing.Size(370, 190);
            this.Controls.Add(this.txtBiome);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cbZone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblBiome);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblZone);
            this.Text = "Add New Enclosure";
            this.Load += new System.EventHandler(this.AddEnclosureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
