namespace ZooApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSmallDataset;
        private System.Windows.Forms.Button btnBigDataset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSmallDataset = new System.Windows.Forms.Button();
            this.btnBigDataset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSmallDataset
            // 
            this.btnSmallDataset.Location = new System.Drawing.Point(80, 50);
            this.btnSmallDataset.Name = "btnSmallDataset";
            this.btnSmallDataset.Size = new System.Drawing.Size(180, 50);
            this.btnSmallDataset.TabIndex = 0;
            this.btnSmallDataset.Text = "Connect to Small Dataset";
            this.btnSmallDataset.Click += new System.EventHandler(this.btnSmallDataset_Click);
            // 
            // btnBigDataset
            // 
            this.btnBigDataset.Location = new System.Drawing.Point(80, 120);
            this.btnBigDataset.Name = "btnBigDataset";
            this.btnBigDataset.Size = new System.Drawing.Size(180, 50);
            this.btnBigDataset.TabIndex = 1;
            this.btnBigDataset.Text = "Connect to Big Dataset";
            this.btnBigDataset.Click += new System.EventHandler(this.btnBigDataset_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(340, 230);
            this.Controls.Add(this.btnSmallDataset);
            this.Controls.Add(this.btnBigDataset);
            this.Name = "LoginForm";
            this.Text = "Login - Zoo Management System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }
    }
}
