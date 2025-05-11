namespace ZooApp
{
    partial class AddAnimalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtFeedingInterval;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbEnclosure;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectSpecies;
        private System.Windows.Forms.Label lblSelectedSpecies;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblFeedingInterval;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblEnclosure;

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
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtFeedingInterval = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbEnclosure = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectSpecies = new System.Windows.Forms.Button();
            this.lblSelectedSpecies = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblFeedingInterval = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEnclosure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(120, 20);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(287, 20);
            this.txtAnimalName.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(120, 55);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(287, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(120, 90);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(287, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(120, 125);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(287, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // txtFeedingInterval
            // 
            this.txtFeedingInterval.Location = new System.Drawing.Point(120, 160);
            this.txtFeedingInterval.Name = "txtFeedingInterval";
            this.txtFeedingInterval.Size = new System.Drawing.Size(287, 20);
            this.txtFeedingInterval.TabIndex = 9;
            // 
            // cbSex
            // 
            this.cbSex.Location = new System.Drawing.Point(120, 195);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(287, 21);
            this.cbSex.TabIndex = 11;
            // 
            // cbEnclosure
            // 
            this.cbEnclosure.Location = new System.Drawing.Point(120, 230);
            this.cbEnclosure.Name = "cbEnclosure";
            this.cbEnclosure.Size = new System.Drawing.Size(287, 21);
            this.cbEnclosure.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 310);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectSpecies
            // 
            this.btnSelectSpecies.Location = new System.Drawing.Point(120, 265);
            this.btnSelectSpecies.Name = "btnSelectSpecies";
            this.btnSelectSpecies.Size = new System.Drawing.Size(100, 23);
            this.btnSelectSpecies.TabIndex = 14;
            this.btnSelectSpecies.Text = "Select Species";
            this.btnSelectSpecies.Click += new System.EventHandler(this.btnSelectSpecies_Click);
            // 
            // lblSelectedSpecies
            // 
            this.lblSelectedSpecies.AutoSize = true;
            this.lblSelectedSpecies.Location = new System.Drawing.Point(226, 270);
            this.lblSelectedSpecies.Name = "lblSelectedSpecies";
            this.lblSelectedSpecies.Size = new System.Drawing.Size(103, 13);
            this.lblSelectedSpecies.TabIndex = 15;
            this.lblSelectedSpecies.Text = "No species selected";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.Location = new System.Drawing.Point(20, 20);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(100, 23);
            this.lblAnimalName.TabIndex = 0;
            this.lblAnimalName.Text = "Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.Location = new System.Drawing.Point(20, 55);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 23);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(20, 90);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 23);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight (kg):";
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(20, 125);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 23);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Origin Country:";
            // 
            // lblFeedingInterval
            // 
            this.lblFeedingInterval.Location = new System.Drawing.Point(20, 160);
            this.lblFeedingInterval.Name = "lblFeedingInterval";
            this.lblFeedingInterval.Size = new System.Drawing.Size(100, 23);
            this.lblFeedingInterval.TabIndex = 8;
            this.lblFeedingInterval.Text = "Feeding Interval:";
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(20, 195);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 23);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Sex:";
            // 
            // lblEnclosure
            // 
            this.lblEnclosure.Location = new System.Drawing.Point(20, 230);
            this.lblEnclosure.Name = "lblEnclosure";
            this.lblEnclosure.Size = new System.Drawing.Size(100, 23);
            this.lblEnclosure.TabIndex = 12;
            this.lblEnclosure.Text = "Enclosure:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Species:";
            // 
            // AddAnimalForm
            // 
            this.ClientSize = new System.Drawing.Size(419, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.txtAnimalName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblFeedingInterval);
            this.Controls.Add(this.txtFeedingInterval);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.lblEnclosure);
            this.Controls.Add(this.cbEnclosure);
            this.Controls.Add(this.btnSelectSpecies);
            this.Controls.Add(this.lblSelectedSpecies);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddAnimalForm";
            this.Text = "Add or Edit Animal";
            this.Load += new System.EventHandler(this.AddAnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
