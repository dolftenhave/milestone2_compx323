namespace ZooApp
{
    partial class AddAnimalForm
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

            // Labels and TextBoxes

            this.lblAnimalName.Text = "Animal Name:";
            this.lblAnimalName.Location = new System.Drawing.Point(20, 20);
            this.lblAnimalName.AutoSize = true;
            this.txtAnimalName.Location = new System.Drawing.Point(150, 20);
            this.txtAnimalName.Width = 200;

            this.lblSpecies.Text = "Species:";
            this.lblSpecies.Location = new System.Drawing.Point(20, 60);
            this.lblSpecies.AutoSize = true;
            this.cbSpecies.Location = new System.Drawing.Point(150, 60);
            this.cbSpecies.Width = 200;

            this.lblDOB.Text = "Date of Birth:";
            this.lblDOB.Location = new System.Drawing.Point(20, 100);
            this.lblDOB.AutoSize = true;
            this.dtpDOB.Location = new System.Drawing.Point(150, 100);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblSex.Text = "Sex:";
            this.lblSex.Location = new System.Drawing.Point(20, 140);
            this.lblSex.AutoSize = true;
            this.cbSex.Location = new System.Drawing.Point(150, 140);
            this.cbSex.Width = 200;
            this.cbSex.Items.AddRange(new string[] { "Male", "Female" });

            this.lblEnclosure.Text = "Enclosure:";
            this.lblEnclosure.Location = new System.Drawing.Point(20, 180);
            this.lblEnclosure.AutoSize = true;
            this.cbEnclosure.Location = new System.Drawing.Point(150, 180);
            this.cbEnclosure.Width = 200;

            this.lblFeedingInterval.Text = "Feeding Interval (days):";
            this.lblFeedingInterval.Location = new System.Drawing.Point(20, 220);
            this.lblFeedingInterval.AutoSize = true;
            this.txtFeedingInterval.Location = new System.Drawing.Point(150, 220);
            this.txtFeedingInterval.Width = 200;

            this.lblWeight.Text = "Weight (kg):";
            this.lblWeight.Location = new System.Drawing.Point(20, 260);
            this.lblWeight.AutoSize = true;
            this.txtWeight.Location = new System.Drawing.Point(150, 260);
            this.txtWeight.Width = 200;

            this.lblCountry.Text = "Country of Origin:";
            this.lblCountry.Location = new System.Drawing.Point(20, 300);
            this.lblCountry.AutoSize = true;
            this.txtCountry.Location = new System.Drawing.Point(150, 300);
            this.txtCountry.Width = 200;

            // Submit and Cancel buttons

            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(100, 350);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, 350);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form settings

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
