namespace ZooApp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();

            this.tabAnimals = new System.Windows.Forms.TabPage();
            this.tabEnclosures = new System.Windows.Forms.TabPage();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.tabFeedingCare = new System.Windows.Forms.TabPage();
            this.tabChecklist = new System.Windows.Forms.TabPage();
            this.tabStaffActivity = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabZoneCoverage = new System.Windows.Forms.TabPage();

            // Example for first tab controls:
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.btnRefreshAnimals = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.cbZoneFilter = new System.Windows.Forms.ComboBox();
            this.cbEnclosureFilter = new System.Windows.Forms.ComboBox();

            // Enclosure
            this.dgvEnclosures = new System.Windows.Forms.DataGridView();
            this.btnRefreshEnclosures = new System.Windows.Forms.Button();
            this.cbBiomeFilter = new System.Windows.Forms.ComboBox();

            // Staff
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnRefreshStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.cbStaffRoleFilter = new System.Windows.Forms.ComboBox();

            // Feeding / Care
            this.dgvCareFeeding = new System.Windows.Forms.DataGridView();
            this.btnRecordFeeding = new System.Windows.Forms.Button();
            this.btnRecordCare = new System.Windows.Forms.Button();

            // Checklist Tab
            this.btnOpenChecklist = new System.Windows.Forms.Button();

            // Staff Activity Tab
            this.btnOpenStaffActivity = new System.Windows.Forms.Button();

            // Skills Tab
            this.btnOpenSkills = new System.Windows.Forms.Button();

            // Zone Coverage Tab
            this.btnOpenZoneCoverage = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabAnimals.SuspendLayout();
            this.tabEnclosures.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.tabFeedingCare.SuspendLayout();
            this.tabChecklist.SuspendLayout();
            this.tabStaffActivity.SuspendLayout();
            this.tabSkills.SuspendLayout();
            this.tabZoneCoverage.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnclosures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCareFeeding)).BeginInit();

            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnimals);
            this.tabControl1.Controls.Add(this.tabEnclosures);
            this.tabControl1.Controls.Add(this.tabStaff);
            this.tabControl1.Controls.Add(this.tabFeedingCare);
            this.tabControl1.Controls.Add(this.tabChecklist);
            this.tabControl1.Controls.Add(this.tabStaffActivity);
            this.tabControl1.Controls.Add(this.tabSkills);
            this.tabControl1.Controls.Add(this.tabZoneCoverage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Size = new System.Drawing.Size(860, 500);
            this.tabControl1.TabIndex = 0;

            // ========== Animals Tab ==========
            this.tabAnimals.Controls.Add(this.cbZoneFilter);
            this.tabAnimals.Controls.Add(this.cbEnclosureFilter);
            this.tabAnimals.Controls.Add(this.btnRefreshAnimals);
            this.tabAnimals.Controls.Add(this.btnAddAnimal);
            this.tabAnimals.Controls.Add(this.dgvAnimals);
            this.tabAnimals.Text = "Animals";

            this.cbZoneFilter.Location = new System.Drawing.Point(20, 20);
            this.cbZoneFilter.Width = 120;

            this.cbEnclosureFilter.Location = new System.Drawing.Point(160, 20);
            this.cbEnclosureFilter.Width = 120;

            this.btnRefreshAnimals.Location = new System.Drawing.Point(300, 20);
            this.btnRefreshAnimals.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAnimals.Text = "Refresh";
            this.btnRefreshAnimals.Click += new System.EventHandler(this.btnRefreshAnimals_Click);

            this.btnAddAnimal.Location = new System.Drawing.Point(390, 20);
            this.btnAddAnimal.Size = new System.Drawing.Size(90, 23);
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);

            this.dgvAnimals.Location = new System.Drawing.Point(20, 60);
            this.dgvAnimals.Size = new System.Drawing.Size(800, 380);
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ========== Enclosures Tab ==========
            this.tabEnclosures.Controls.Add(this.cbBiomeFilter);
            this.tabEnclosures.Controls.Add(this.btnRefreshEnclosures);
            this.tabEnclosures.Controls.Add(this.dgvEnclosures);
            this.tabEnclosures.Text = "Enclosures";

            this.cbBiomeFilter.Location = new System.Drawing.Point(20, 20);
            this.cbBiomeFilter.Width = 120;

            this.btnRefreshEnclosures.Location = new System.Drawing.Point(160, 20);
            this.btnRefreshEnclosures.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshEnclosures.Text = "Refresh";
            this.btnRefreshEnclosures.Click += new System.EventHandler(this.btnRefreshEnclosures_Click);

            this.dgvEnclosures.Location = new System.Drawing.Point(20, 60);
            this.dgvEnclosures.Size = new System.Drawing.Size(800, 380);
            this.dgvEnclosures.ReadOnly = true;
            this.dgvEnclosures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ========== Staff Tab ==========
            this.tabStaff.Controls.Add(this.cbStaffRoleFilter);
            this.tabStaff.Controls.Add(this.btnRefreshStaff);
            this.tabStaff.Controls.Add(this.btnAddStaff);
            this.tabStaff.Controls.Add(this.dgvStaff);
            this.tabStaff.Text = "Staff";

            this.cbStaffRoleFilter.Location = new System.Drawing.Point(20, 20);
            this.cbStaffRoleFilter.Width = 120;

            this.btnRefreshStaff.Location = new System.Drawing.Point(160, 20);
            this.btnRefreshStaff.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshStaff.Text = "Refresh";
            this.btnRefreshStaff.Click += new System.EventHandler(this.btnRefreshStaff_Click);

            this.btnAddStaff.Location = new System.Drawing.Point(250, 20);
            this.btnAddStaff.Size = new System.Drawing.Size(90, 23);
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);

            this.dgvStaff.Location = new System.Drawing.Point(20, 60);
            this.dgvStaff.Size = new System.Drawing.Size(800, 380);
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ========== Feeding / Care Tab ==========
            this.tabFeedingCare.Controls.Add(this.btnRecordFeeding);
            this.tabFeedingCare.Controls.Add(this.btnRecordCare);
            this.tabFeedingCare.Controls.Add(this.dgvCareFeeding);
            this.tabFeedingCare.Text = "Feeding / Care";

            this.btnRecordFeeding.Location = new System.Drawing.Point(20, 20);
            this.btnRecordFeeding.Size = new System.Drawing.Size(120, 23);
            this.btnRecordFeeding.Text = "Record Feeding";
            this.btnRecordFeeding.Click += new System.EventHandler(this.btnRecordFeeding_Click);

            this.btnRecordCare.Location = new System.Drawing.Point(160, 20);
            this.btnRecordCare.Size = new System.Drawing.Size(120, 23);
            this.btnRecordCare.Text = "Record Vet Care";
            this.btnRecordCare.Click += new System.EventHandler(this.btnRecordCare_Click);

            this.dgvCareFeeding.Location = new System.Drawing.Point(20, 60);
            this.dgvCareFeeding.Size = new System.Drawing.Size(800, 380);
            this.dgvCareFeeding.ReadOnly = true;
            this.dgvCareFeeding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // ========== Checklist Tab ==========
            this.tabChecklist.Controls.Add(this.btnOpenChecklist);
            this.tabChecklist.Text = "Checklist";

            this.btnOpenChecklist.Location = new System.Drawing.Point(20, 20);
            this.btnOpenChecklist.Size = new System.Drawing.Size(200, 40);
            this.btnOpenChecklist.Text = "Open Daily Checklist";
            this.btnOpenChecklist.Click += new System.EventHandler(this.btnOpenChecklist_Click);

            // ========== Staff Activity Tab ==========
            this.tabStaffActivity.Controls.Add(this.btnOpenStaffActivity);
            this.tabStaffActivity.Text = "Staff Activity";

            this.btnOpenStaffActivity.Location = new System.Drawing.Point(20, 20);
            this.btnOpenStaffActivity.Size = new System.Drawing.Size(200, 40);
            this.btnOpenStaffActivity.Text = "View Staff Activity";
            this.btnOpenStaffActivity.Click += new System.EventHandler(this.btnOpenStaffActivity_Click);

            // ========== Zookeeper Skills Tab ==========
            this.tabSkills.Controls.Add(this.btnOpenSkills);
            this.tabSkills.Text = "Zookeeper Skills";

            this.btnOpenSkills.Location = new System.Drawing.Point(20, 20);
            this.btnOpenSkills.Size = new System.Drawing.Size(200, 40);
            this.btnOpenSkills.Text = "View Skills";
            this.btnOpenSkills.Click += new System.EventHandler(this.btnOpenSkills_Click);

            // ========== Zone Coverage Tab ==========
            this.tabZoneCoverage.Controls.Add(this.btnOpenZoneCoverage);
            this.tabZoneCoverage.Text = "Zone Coverage";

            this.btnOpenZoneCoverage.Location = new System.Drawing.Point(20, 20);
            this.btnOpenZoneCoverage.Size = new System.Drawing.Size(250, 40);
            this.btnOpenZoneCoverage.Text = "Calculate Zone Coverage";
            this.btnOpenZoneCoverage.Click += new System.EventHandler(this.btnOpenZoneCoverage_Click);

            // ========== Final MainForm Settings ==========
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Zoo Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.tabControl1.ResumeLayout(false);
            this.tabAnimals.ResumeLayout(false);
            this.tabEnclosures.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            this.tabFeedingCare.ResumeLayout(false);
            this.tabChecklist.ResumeLayout(false);
            this.tabStaffActivity.ResumeLayout(false);
            this.tabSkills.ResumeLayout(false);
            this.tabZoneCoverage.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnclosures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCareFeeding)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        // Declare controls here

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnimals;
        private System.Windows.Forms.TabPage tabEnclosures;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TabPage tabFeedingCare;
        private System.Windows.Forms.TabPage tabChecklist;
        private System.Windows.Forms.TabPage tabStaffActivity;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabZoneCoverage;

        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Button btnRefreshAnimals;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ComboBox cbZoneFilter;
        private System.Windows.Forms.ComboBox cbEnclosureFilter;

        private System.Windows.Forms.DataGridView dgvEnclosures;
        private System.Windows.Forms.Button btnRefreshEnclosures;
        private System.Windows.Forms.ComboBox cbBiomeFilter;

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnRefreshStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ComboBox cbStaffRoleFilter;

        private System.Windows.Forms.DataGridView dgvCareFeeding;
        private System.Windows.Forms.Button btnRecordFeeding;
        private System.Windows.Forms.Button btnRecordCare;

        private System.Windows.Forms.Button btnOpenChecklist;
        private System.Windows.Forms.Button btnOpenStaffActivity;
        private System.Windows.Forms.Button btnOpenSkills;
        private System.Windows.Forms.Button btnOpenZoneCoverage;
    }
}

