namespace ZooApp
{
    partial class AddEnclosureForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBiome = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cbZoneName = new System.Windows.Forms.ComboBox();
            this.lblBiome = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtBiome
            this.txtBiome.Location = new System.Drawing.Point(130, 20);
            this.txtBiome.Name = "txtBiome";
            this.txtBiome.Size = new System.Drawing.Size(200, 22);

            // txtSize
            this.txtSize.Location = new System.Drawing.Point(130, 60);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 22);

            // cbZoneName
            this.cbZoneName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoneName.FormattingEnabled = true;
            this.cbZoneName.Location = new System.Drawing.Point(130, 100);
            this.cbZoneName.Name = "cbZoneName";
            this.cbZoneName.Size = new System.Drawing.Size(200, 24);

            // lblBiome
            this.lblBiome.AutoSize = true;
            this.lblBiome.Location = new System.Drawing.Point(30, 23);
            this.lblBiome.Name = "lblBiome";
            this.lblBiome.Size = new System.Drawing.Size(50, 17);
            this.lblBiome.Text = "Biome:";

            // lblSize
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(30, 63);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(74, 17);
            this.lblSize.Text = "Zone Size:";

            // lblZone
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(30, 103);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(82, 17);
            this.lblZone.Text = "Zone Name:";

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(80, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddEnclosureForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.txtBiome);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cbZoneName);
            this.Controls.Add(this.lblBiome);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddEnclosureForm";
            this.Text = "Add/Edit Enclosure";
            this.Load += new System.EventHandler(this.AddEnclosureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBiome;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.ComboBox cbZoneName;
        private System.Windows.Forms.Label lblBiome;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
