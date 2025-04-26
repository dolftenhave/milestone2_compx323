namespace ZooApp
{
    partial class AddStaffForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbZone = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Labels and TextBoxes

            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.lblFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(150, 20);
            this.txtFirstName.Width = 200;

            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(150, 60);
            this.txtLastName.Width = 200;

            this.lblDOB.Text = "Date of Birth:";
            this.lblDOB.Location = new System.Drawing.Point(20, 100);
            this.lblDOB.AutoSize = true;
            this.dtpDOB.Location = new System.Drawing.Point(150, 100);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(20, 140);
            this.lblPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(150, 140);
            this.txtPhone.Width = 200;

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 180);
            this.lblEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(150, 180);
            this.txtEmail.Width = 200;

            this.lblAddress.Text = "Address:";
            this.lblAddress.Location = new System.Drawing.Point(20, 220);
            this.lblAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(150, 220);
            this.txtAddress.Width = 200;

            this.lblRole.Text = "Role:";
            this.lblRole.Location = new System.Drawing.Point(20, 260);
            this.lblRole.AutoSize = true;
            this.cbRole.Location = new System.Drawing.Point(150, 260);
            this.cbRole.Width = 200;

            this.lblZone.Text = "Assigned Zone:";
            this.lblZone.Location = new System.Drawing.Point(20, 300);
            this.lblZone.AutoSize = true;
            this.cbZone.Location = new System.Drawing.Point(150, 300);
            this.cbZone.Width = 200;

            // Submit and Cancel buttons

            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(100, 350);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, 350);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form settings

            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.cbZone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddStaffForm";
            this.Text = "Add New Staff";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbZone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblZone;
    }
}
