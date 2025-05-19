namespace ZooApp
{
    partial class AddVetForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbSelectVet = new System.Windows.Forms.ComboBox();
            this.lbClinics = new System.Windows.Forms.ListBox();
            this.txtClinicName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSelectVet = new System.Windows.Forms.Label();
            this.lblClinics = new System.Windows.Forms.Label();
            this.lblNewClinic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSelectVet
            // 
            this.cbSelectVet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectVet.Location = new System.Drawing.Point(130, 46);
            this.cbSelectVet.Name = "cbSelectVet";
            this.cbSelectVet.Size = new System.Drawing.Size(220, 28);
            this.cbSelectVet.TabIndex = 0;
            // 
            // lbClinics
            // 
            this.lbClinics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClinics.ItemHeight = 20;
            this.lbClinics.Location = new System.Drawing.Point(130, 93);
            this.lbClinics.Name = "lbClinics";
            this.lbClinics.Size = new System.Drawing.Size(220, 304);
            this.lbClinics.TabIndex = 1;
            this.lbClinics.SelectedIndexChanged += new System.EventHandler(this.lbClinics_SelectedIndexChanged);
            // 
            // txtClinicName
            // 
            this.txtClinicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicName.Location = new System.Drawing.Point(12, 482);
            this.txtClinicName.Name = "txtClinicName";
            this.txtClinicName.Size = new System.Drawing.Size(336, 26);
            this.txtClinicName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(180, 514);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(130, 403);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(218, 35);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Clinc to Vet";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 514);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 553);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(180, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSelectVet
            // 
            this.lblSelectVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVet.Location = new System.Drawing.Point(12, 51);
            this.lblSelectVet.Name = "lblSelectVet";
            this.lblSelectVet.Size = new System.Drawing.Size(100, 23);
            this.lblSelectVet.TabIndex = 8;
            this.lblSelectVet.Text = "Select Vet:";
            // 
            // lblClinics
            // 
            this.lblClinics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinics.Location = new System.Drawing.Point(12, 93);
            this.lblClinics.Name = "lblClinics";
            this.lblClinics.Size = new System.Drawing.Size(100, 23);
            this.lblClinics.TabIndex = 9;
            this.lblClinics.Text = "Clinic List:";
            // 
            // lblNewClinic
            // 
            this.lblNewClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewClinic.Location = new System.Drawing.Point(12, 456);
            this.lblNewClinic.Name = "lblNewClinic";
            this.lblNewClinic.Size = new System.Drawing.Size(151, 23);
            this.lblNewClinic.TabIndex = 10;
            this.lblNewClinic.Text = "Add/Update Clinic:";
            // 
            // AddVetForm
            // 
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.cbSelectVet);
            this.Controls.Add(this.lbClinics);
            this.Controls.Add(this.txtClinicName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSelectVet);
            this.Controls.Add(this.lblClinics);
            this.Controls.Add(this.lblNewClinic);
            this.Name = "AddVetForm";
            this.Text = "Add/Edit Vet Clinic";
            this.Load += new System.EventHandler(this.AddVetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectVet;
        private System.Windows.Forms.ListBox lbClinics;
        private System.Windows.Forms.TextBox txtClinicName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSelectVet;
        private System.Windows.Forms.Label lblClinics;
        private System.Windows.Forms.Label lblNewClinic;
    }
}
