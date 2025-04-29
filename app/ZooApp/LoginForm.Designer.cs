namespace ZooApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSmallDataset = new System.Windows.Forms.Button();
            this.btnBigDataset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSmallDataset
            // 
            this.btnSmallDataset.Location = new System.Drawing.Point(32, 78);
            this.btnSmallDataset.Name = "btnSmallDataset";
            this.btnSmallDataset.Size = new System.Drawing.Size(250, 50);
            this.btnSmallDataset.TabIndex = 0;
            this.btnSmallDataset.Text = "Small Dataset";
            this.btnSmallDataset.UseVisualStyleBackColor = true;
            this.btnSmallDataset.Click += new System.EventHandler(this.btnSmallDataset_Click_1);
            // 
            // btnBigDataset
            // 
            this.btnBigDataset.Location = new System.Drawing.Point(32, 169);
            this.btnBigDataset.Name = "btnBigDataset";
            this.btnBigDataset.Size = new System.Drawing.Size(250, 50);
            this.btnBigDataset.TabIndex = 1;
            this.btnBigDataset.Text = "Big Dataset";
            this.btnBigDataset.UseVisualStyleBackColor = true;
            this.btnBigDataset.Click += new System.EventHandler(this.btnBigDataset_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 313);
            this.Controls.Add(this.btnBigDataset);
            this.Controls.Add(this.btnSmallDataset);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSmallDataset;
        private System.Windows.Forms.Button btnBigDataset;
    }
}