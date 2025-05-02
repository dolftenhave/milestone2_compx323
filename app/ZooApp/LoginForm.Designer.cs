namespace ZooApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbDataset;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCheckTables;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbDataset = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCheckTables = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 25);
            this.lblTitle.Text = "Welcome to the Zoo System";

            // 
            // cbDataset
            // 
            this.cbDataset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataset.FormattingEnabled = true;
            this.cbDataset.Location = new System.Drawing.Point(85, 65);
            this.cbDataset.Name = "cbDataset";
            this.cbDataset.Size = new System.Drawing.Size(200, 21);

            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(85, 100);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 30);
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);

            // 
            // btnCheckTables
            // 
            this.btnCheckTables.Location = new System.Drawing.Point(85, 140);
            this.btnCheckTables.Name = "btnCheckTables";
            this.btnCheckTables.Size = new System.Drawing.Size(200, 25);
            this.btnCheckTables.Text = "Check Accessible Tables";
            this.btnCheckTables.UseVisualStyleBackColor = true;
            this.btnCheckTables.Click += new System.EventHandler(this.btnCheckTables_Click);

            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbDataset);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCheckTables);
            this.Name = "LoginForm";
            this.Text = "ZooApp Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
