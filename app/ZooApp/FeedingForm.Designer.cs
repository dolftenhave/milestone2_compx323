namespace ZooApp
{
    partial class FeedingForm
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
            this.cbZookeeper = new System.Windows.Forms.ComboBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.lblZookeeper = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Labels and fields
            this.lblZookeeper.Text = "Zookeeper:";
            this.lblZookeeper.Location = new System.Drawing.Point(20, 20);
            this.cbZookeeper.Location = new System.Drawing.Point(150, 20);
            this.cbZookeeper.Width = 200;

            this.lblAnimal.Text = "Animal:";
            this.lblAnimal.Location = new System.Drawing.Point(20, 60);
            this.cbAnimal.Location = new System.Drawing.Point(150, 60);
            this.cbAnimal.Width = 200;

            this.lblFoodType.Text = "Food Type:";
            this.lblFoodType.Location = new System.Drawing.Point(20, 100);
            this.txtFoodType.Location = new System.Drawing.Point(150, 100);
            this.txtFoodType.Width = 200;

            this.lblAmount.Text = "Amount (kg):";
            this.lblAmount.Location = new System.Drawing.Point(20, 140);
            this.txtAmount.Location = new System.Drawing.Point(150, 140);
            this.txtAmount.Width = 200;

            this.lblDate.Text = "Date:";
            this.lblDate.Location = new System.Drawing.Point(20, 180);
            this.dtpDate.Location = new System.Drawing.Point(150, 180);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblTime.Text = "Time:";
            this.lblTime.Location = new System.Drawing.Point(20, 220);
            this.dtpTime.Location = new System.Drawing.Point(150, 220);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.ShowUpDown = true;

            // Buttons
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(100, 270);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, 270);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblZookeeper);
            this.Controls.Add(this.cbZookeeper);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.txtFoodType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "FeedingForm";
            this.Text = "Record Feeding";
            this.Load += new System.EventHandler(this.FeedingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbZookeeper;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblZookeeper;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}
