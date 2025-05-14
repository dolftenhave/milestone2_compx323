namespace ZooApp
{
    partial class AddVetForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblClinicList;
        private System.Windows.Forms.ListBox lbClinics;
        private System.Windows.Forms.Label lblNewClinic;
        private System.Windows.Forms.TextBox txtNewClinic;
        private System.Windows.Forms.Button btnAddClinic;
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
            this.lblClinicList = new System.Windows.Forms.Label();
            this.lbClinics = new System.Windows.Forms.ListBox();
            this.lblNewClinic = new System.Windows.Forms.Label();
            this.txtNewClinic = new System.Windows.Forms.TextBox();
            this.btnAddClinic = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblClinicList
            // 
            this.lblClinicList.AutoSize = true;
            this.lblClinicList.Location = new System.Drawing.Point(20, 15);
            this.lblClinicList.Name = "lblClinicList";
            this.lblClinicList.Size = new System.Drawing.Size(95, 13);
            this.lblClinicList.Text = "Select Clinic Name:";

            // 
            // lbClinics
            // 
            this.lbClinics.FormattingEnabled = true;
            this.lbClinics.Location = new System.Drawing.Point(23, 35);
            this.lbClinics.Name = "lbClinics";
            this.lbClinics.Size = new System.Drawing.Size(250, 95);

            // 
            // lblNewClinic
            // 
            this.lblNewClinic.AutoSize = true;
            this.lblNewClinic.Location = new System.Drawing.Point(20, 140);
            this.lblNewClinic.Name = "lblNewClinic";
            this.lblNewClinic.Size = new System.Drawing.Size(94, 13);
            this.lblNewClinic.Text = "Or Add New Clinic:";

            // 
            // txtNewClinic
            // 
            this.txtNewClinic.Location = new System.Drawing.Point(23, 160);
            this.txtNewClinic.Name = "txtNewClinic";
            this.txtNewClinic.Size = new System.Drawing.Size(175, 20);

            // 
            // btnAddClinic
            // 
            this.btnAddClinic.Location = new System.Drawing.Point(204, 158);
            this.btnAddClinic.Name = "btnAddClinic";
            this.btnAddClinic.Size = new System.Drawing.Size(69, 23);
            this.btnAddClinic.Text = "Add";
            this.btnAddClinic.UseVisualStyleBackColor = true;
            this.btnAddClinic.Click += new System.EventHandler(this.btnAddClinic_Click);

            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(23, 200);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(173, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // AddVetForm
            // 
            this.ClientSize = new System.Drawing.Size(304, 251);
            this.Controls.Add(this.lblClinicList);
            this.Controls.Add(this.lbClinics);
            this.Controls.Add(this.lblNewClinic);
            this.Controls.Add(this.txtNewClinic);
            this.Controls.Add(this.btnAddClinic);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddVetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Vet Clinic";
            this.Load += new System.EventHandler(this.AddVetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
