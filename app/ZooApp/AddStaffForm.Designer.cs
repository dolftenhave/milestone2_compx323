namespace ZooApp
{
    partial class AddStaffForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtClinic = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblClinic = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(150, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(150, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(150, 80);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(206, 20);
            this.dtpDOB.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(150, 170);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(206, 20);
            this.txtStreetNumber.TabIndex = 11;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(150, 200);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(206, 20);
            this.txtStreetName.TabIndex = 13;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(150, 230);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(206, 20);
            this.txtSuburb.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(150, 260);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(206, 20);
            this.txtCity.TabIndex = 17;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(150, 290);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(206, 20);
            this.txtPostCode.TabIndex = 19;
            // 
            // txtClinic
            // 
            this.txtClinic.Location = new System.Drawing.Point(150, 320);
            this.txtClinic.Name = "txtClinic";
            this.txtClinic.Size = new System.Drawing.Size(206, 20);
            this.txtClinic.TabIndex = 21;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(150, 350);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(206, 21);
            this.cbSex.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(150, 419);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(20, 50);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.Location = new System.Drawing.Point(20, 80);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 23);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.Location = new System.Drawing.Point(20, 170);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(100, 23);
            this.lblStreetNumber.TabIndex = 10;
            this.lblStreetNumber.Text = "Street Number:";
            // 
            // lblStreetName
            // 
            this.lblStreetName.Location = new System.Drawing.Point(20, 200);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(100, 23);
            this.lblStreetName.TabIndex = 12;
            this.lblStreetName.Text = "Street Name:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.Location = new System.Drawing.Point(20, 230);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(100, 23);
            this.lblSuburb.TabIndex = 14;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(20, 260);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(100, 23);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.Location = new System.Drawing.Point(20, 290);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(100, 23);
            this.lblPostCode.TabIndex = 18;
            this.lblPostCode.Text = "Post Code:";
            // 
            // lblClinic
            // 
            this.lblClinic.Location = new System.Drawing.Point(20, 320);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(100, 23);
            this.lblClinic.TabIndex = 20;
            this.lblClinic.Text = "Clinic:";
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(20, 350);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 23);
            this.lblSex.TabIndex = 22;
            this.lblSex.Text = "Sex:";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Items.AddRange(new object[] {"Zookeeper","Vet"});
            this.cbRole.Location = new System.Drawing.Point(150, 380);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(206, 21);
            this.cbRole.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(20, 378);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(100, 23);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role:";
            // 
            // AddStaffForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 478);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblRole);
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
            this.Controls.Add(this.lblStreetNumber);
            this.Controls.Add(this.txtStreetNumber);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.lblClinic);
            this.Controls.Add(this.txtClinic);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbSex);
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
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtClinic;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbRole;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblClinic;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblRole;

    }
}
