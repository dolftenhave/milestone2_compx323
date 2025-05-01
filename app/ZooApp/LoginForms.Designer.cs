namespace ZooApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnSmallDataset = new System.Windows.Forms.Button();
            this.btnBigDataset = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTitle.Text = "Welcome to the Zoo System";

            // 
            // btnSmallDataset
            // 
            this.btnSmallDataset.Location = new System.Drawing.Point(85, 70);
            this.btnSmallDataset.Name = "btnSmallDataset";
            this.btnSmallDataset.Size = new System.Drawing.Size(180, 40);
            this.btnSmallDataset.Text = "Connect to Small Dataset";
            this.btnSmallDataset.UseVisualStyleBackColor = true;
            this.btnSmallDataset.Click += new System.EventHandler(this.btnSmallDataset_Click);

            // 
            // btnBigDataset
            // 
            this.btnBigDataset.Location = new System.Drawing.Point(85, 130);
            this.btnBigDataset.Name = "btnBigDataset";
            this.btnBigDataset.Size = new System.Drawing.Size(180, 40);
            this.btnBigDataset.Text = "Connect to Big Dataset";
            this.btnBigDataset.UseVisualStyleBackColor = true;
            this.btnBigDataset.Click += new System.EventHandler(this.btnBigDataset_Click);

            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSmallDataset);
            this.Controls.Add(this.btnBigDataset);
            this.Name = "LoginForm";
            this.Text = "ZooApp Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSmallDataset;
        private System.Windows.Forms.Button btnBigDataset;
        private System.Windows.Forms.Label lblTitle;
    }
}
