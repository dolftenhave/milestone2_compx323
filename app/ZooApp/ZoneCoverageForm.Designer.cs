namespace ZooApp
{
    partial class ZoneCoverageForm
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

        private void InitializeComponent()
        {
            this.txtCoverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCoverage
            // 
            this.txtCoverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCoverage.Multiline = true;
            this.txtCoverage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCoverage.ReadOnly = true;
            this.txtCoverage.Font = new System.Drawing.Font("Consolas", 10);
            this.txtCoverage.BackColor = System.Drawing.Color.White;
            this.txtCoverage.Location = new System.Drawing.Point(0, 0);
            this.txtCoverage.Name = "txtCoverage";
            this.txtCoverage.Size = new System.Drawing.Size(400, 300);
            this.txtCoverage.TabIndex = 0;
            //
            // ZoneCoverageForm
            //
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtCoverage);
            this.Name = "ZoneCoverageForm";
            this.Text = "Zone Coverage Report";
            this.Load += new System.EventHandler(this.ZoneCoverageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txtCoverage;
    }
}
