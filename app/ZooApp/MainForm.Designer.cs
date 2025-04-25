namespace ZooApp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Animals = new System.Windows.Forms.TabPage();
            this.Enclosures = new System.Windows.Forms.TabPage();
            this.Staff = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Animals);
            this.tabControl1.Controls.Add(this.Enclosures);
            this.tabControl1.Controls.Add(this.Staff);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // Animals
            // 
            this.Animals.Location = new System.Drawing.Point(4, 22);
            this.Animals.Name = "Animals";
            this.Animals.Padding = new System.Windows.Forms.Padding(3);
            this.Animals.Size = new System.Drawing.Size(350, 74);
            this.Animals.TabIndex = 0;
            this.Animals.Text = "Animals";
            this.Animals.UseVisualStyleBackColor = true;
            // 
            // Enclosures
            // 
            this.Enclosures.Location = new System.Drawing.Point(4, 22);
            this.Enclosures.Name = "Enclosures";
            this.Enclosures.Padding = new System.Windows.Forms.Padding(3);
            this.Enclosures.Size = new System.Drawing.Size(350, 74);
            this.Enclosures.TabIndex = 1;
            this.Enclosures.Text = "Enclosures";
            this.Enclosures.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(4, 22);
            this.Staff.Name = "Staff";
            this.Staff.Padding = new System.Windows.Forms.Padding(3);
            this.Staff.Size = new System.Drawing.Size(350, 74);
            this.Staff.TabIndex = 2;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(350, 74);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Animals;
        private System.Windows.Forms.TabPage Enclosures;
        private System.Windows.Forms.TabPage Staff;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

