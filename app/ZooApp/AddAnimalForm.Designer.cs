namespace ZooApp
{
    partial class AddAnimalForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbEnclosure = new System.Windows.Forms.ComboBox();
            this.txtFeedingInterval = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEnclosure = new System.Windows.Forms.Label();
            this.lblFeedingInterval = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(150, 20);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(200, 20);
            this.txtAnimalName.TabIndex = 0;
            // 
            // cbSpecies
            // 
            this.cbSpecies.Location = new System.Drawing.Point(150, 60);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(200, 21);
            this.cbSpecies.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(150, 100);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 2;
            // 
            // cbSex
            // 
            this.cbSex.Location = new System.Drawing.Point(150, 140);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(200, 21);
            this.cbSex.TabIndex = 3;
            // 
            // cbEnclosure
            // 
            this.cbEnclosure.Location = new System.Drawing.Point(150, 180);
            this.cbEnclosure.Name = "cbEnclosure";
            this.cbEnclosure.Size = new System.Drawing.Size(200, 21);
            this.cbEnclosure.TabIndex = 4;
            // 
            // txtFeedingInterval
            // 
            this.txtFeedingInterval.Location = new System.Drawing.Point(150, 220);
            this.txtFeedingInterval.Name = "txtFeedingInterval";
            this.txtFeedingInterval.Size = new System.Drawing.Size(200, 20);
            this.txtFeedingInterval.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(150, 260);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(200, 20);
            this.txtWeight.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(150, 300);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(90, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Add Animal";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Labels
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(20, 20);
            this.lblAnimalName.Text = "Animal Name:";
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(20, 60);
            this.lblSpecies.Text = "Species (Latin):";
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 100);
            this.lblDOB.Text = "Date of Birth:";
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(20, 140);
            this.lblSex.Text = "Sex:";
            this.lblEnclosure.AutoSize = true;
            this.lblEnclosure.Location = new System.Drawing.Point(20, 180);
            this.lblEnclosure.Text = "Enclosure:";
            this.lblFeedingInterval.AutoSize = true;
            this.lblFeedingInterval.Location = new System.Drawing.Point(20, 220);
            this.lblFeedingInterval.Text = "Feeding Interval:";
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 260);
            this.lblWeight.Text = "Weight (kg):";
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 300);
            this.lblCountry.Text = "Country of Origin (3-letter):";

            // 
            // AddAnimalForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.txtAnimalName);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cbSpecies);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.lblEnclosure);
            this.Controls.Add(this.cbEnclosure);
            this.Controls.Add(this.lblFeedingInterval);
            this.Controls.Add(this.txtFeedingInterval);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddAnimalForm";
            this.Text = "Add New Animal";
            this.Load += new System.EventHandler(this.AddAnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbEnclosure;
        private System.Windows.Forms.TextBox txtFeedingInterval;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblEnclosure;
        private System.Windows.Forms.Label lblFeedingInterval;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCountry;
    }
}
