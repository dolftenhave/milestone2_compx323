namespace ZooApp
{
    partial class VetForm
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
            this.cbVet = new System.Windows.Forms.ComboBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.txtCareType = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.lblVet = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblCareType = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Labels and fields
            this.lblVet.Text = "Vet:";
            this.lblVet.Location = new System.Drawing.Point(20, 20);
            this.cbVet.Location = new System.Drawing.Point(150, 20);
            this.cbVet.Width = 200;

            this.lblAnimal.Text = "Animal:";
            this.lblAnimal.Location = new System.Drawing.Point(20, 60);
            this.cbAnimal.Location = new System.Drawing.Point(150, 60);
            this.cbAnimal.Width = 200;

            this.lblCareType.Text = "Type of Care:";
            this.lblCareType.Location = new System.Drawing.Point(20, 100);
            this.txtCareType.Location = new System.Drawing.Point(150, 100);
            this.txtCareType.Width = 200;

            this.lblNotes.Text = "Notes:";
            this.lblNotes.Location = new System.Drawing.Point(20, 140);
            this.txtNotes.Location = new System.Drawing.Point(150, 140);
            this.txtNotes.Width = 200;
            this.txtNotes.Height = 60;
            this.txtNotes.Multiline = true;

            this.lblDate.Text = "Date:";
            this.lblDate.Location = new System.Drawing.Point(20, 220);
            this.dtpDate.Location = new System.Drawing.Point(150, 220);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblTime.Text = "Time:";
            this.lblTime.Location = new System.Drawing.Point(20, 260);
            this.dtpTime.Location = new System.Drawing.Point(150, 260);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.ShowUpDown = true;

            // Buttons
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(100, 310);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, 310);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form settings
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.lblVet);
            this.Controls.Add(this.cbVet);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.lblCareType);
            this.Controls.Add(this.txtCareType);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "VetForm";
            this.Text = "Record Animal Health Activity";
            this.Load += new System.EventHandler(this.VetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbVet;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.TextBox txtCareType;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblCareType;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}
