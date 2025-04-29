namespace ZooApp
{
    partial class MainForm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAnimals = new System.Windows.Forms.TabPage();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.cbZoneFilter = new System.Windows.Forms.ComboBox();
            this.cbEnclosureFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshAnimals = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.tabEnclosures = new System.Windows.Forms.TabPage();
            this.enclosuresDataGridView = new System.Windows.Forms.DataGridView();
            this.cbBiomeFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshEnclosures = new System.Windows.Forms.Button();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.cbStaffRoleFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.tabFeedingCare = new System.Windows.Forms.TabPage();
            this.feedingDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRecordFeeding = new System.Windows.Forms.Button();
            this.btnRecordCare = new System.Windows.Forms.Button();
            this.tabChecklist = new System.Windows.Forms.TabPage();
            this.btnOpenChecklist = new System.Windows.Forms.Button();
            this.tabStaffActivity = new System.Windows.Forms.TabPage();
            this.btnOpenStaffActivity = new System.Windows.Forms.Button();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.btnOpenSkills = new System.Windows.Forms.Button();
            this.tabZoneCoverage = new System.Windows.Forms.TabPage();
            this.btnOpenZoneCoverage = new System.Windows.Forms.Button();

            // TabControl
            this.tabMain.Controls.Add(this.tabAnimals);
            this.tabMain.Controls.Add(this.tabEnclosures);
            this.tabMain.Controls.Add(this.tabStaff);
            this.tabMain.Controls.Add(this.tabFeedingCare);
            this.tabMain.Controls.Add(this.tabChecklist);
            this.tabMain.Controls.Add(this.tabStaffActivity);
            this.tabMain.Controls.Add(this.tabSkills);
            this.tabMain.Controls.Add(this.tabZoneCoverage);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(860, 500);

            // tabAnimals
            this.tabAnimals.Controls.Add(this.animalsDataGridView);
            this.tabAnimals.Controls.Add(this.cbZoneFilter);
            this.tabAnimals.Controls.Add(this.cbEnclosureFilter);
            this.tabAnimals.Controls.Add(this.btnRefreshAnimals);
            this.tabAnimals.Controls.Add(this.btnAddAnimal);
            this.tabAnimals.Text = "Animals";

            // animalsDataGridView
            this.animalsDataGridView.Location = new System.Drawing.Point(20, 60);
            this.animalsDataGridView.Size = new System.Drawing.Size(800, 400);
            this.animalsDataGridView.Name = "animalsDataGridView";

            // cbZoneFilter
            this.cbZoneFilter.Location = new System.Drawing.Point(20, 20);
            this.cbZoneFilter.Size = new System.Drawing.Size(120, 21);

            // cbEnclosureFilter
            this.cbEnclosureFilter.Location = new System.Drawing.Point(160, 20);
            this.cbEnclosureFilter.Size = new System.Drawing.Size(120, 21);

            // btnRefreshAnimals
            this.btnRefreshAnimals.Location = new System.Drawing.Point(300, 20);
            this.btnRefreshAnimals.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAnimals.Text = "Refresh";

            // btnAddAnimal
            this.btnAddAnimal.Location = new System.Drawing.Point(390, 20);
            this.btnAddAnimal.Size = new System.Drawing.Size(90, 23);
            this.btnAddAnimal.Text = "Add Animal";

            // tabEnclosures
            this.tabEnclosures.Controls.Add(this.enclosuresDataGridView);
            this.tabEnclosures.Controls.Add(this.cbBiomeFilter);
            this.tabEnclosures.Controls.Add(this.btnRefreshEnclosures);
            this.tabEnclosures.Text = "Enclosures";

            // enclosuresDataGridView
            this.enclosuresDataGridView.Location = new System.Drawing.Point(20, 60);
            this.enclosuresDataGridView.Size = new System.Drawing.Size(800, 400);
            this.enclosuresDataGridView.Name = "enclosuresDataGridView";

            // cbBiomeFilter
            this.cbBiomeFilter.Location = new System.Drawing.Point(20, 20);
            this.cbBiomeFilter.Size = new System.Drawing.Size(120, 21);

            // btnRefreshEnclosures
            this.btnRefreshEnclosures.Location = new System.Drawing.Point(160, 20);
            this.btnRefreshEnclosures.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshEnclosures.Text = "Refresh";

            // tabStaff
            this.tabStaff.Controls.Add(this.staffDataGridView);
            this.tabStaff.Controls.Add(this.cbStaffRoleFilter);
            this.tabStaff.Controls.Add(this.btnRefreshStaff);
            this.tabStaff.Controls.Add(this.btnAddStaff);
            this.tabStaff.Text = "Staff";

            // staffDataGridView
            this.staffDataGridView.Location = new System.Drawing.Point(20, 60);
            this.staffDataGridView.Size = new System.Drawing.Size(800, 400);
            this.staffDataGridView.Name = "staffDataGridView";

            // cbStaffRoleFilter
            this.cbStaffRoleFilter.Location = new System.Drawing.Point(20, 20);
            this.cbStaffRoleFilter.Size = new System.Drawing.Size(120, 21);

            // btnRefreshStaff
            this.btnRefreshStaff.Location = new System.Drawing.Point(160, 20);
            this.btnRefreshStaff.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshStaff.Text = "Refresh";

            // btnAddStaff
            this.btnAddStaff.Location = new System.Drawing.Point(250, 20);
            this.btnAddStaff.Size = new System.Drawing.Size(90, 23);
            this.btnAddStaff.Text = "Add Staff";

            // tabFeedingCare
            this.tabFeedingCare.Controls.Add(this.feedingDataGridView);
            this.tabFeedingCare.Controls.Add(this.btnRecordFeeding);
            this.tabFeedingCare.Controls.Add(this.btnRecordCare);
            this.tabFeedingCare.Text = "Feeding / Care";

            // feedingDataGridView
            this.feedingDataGridView.Location = new System.Drawing.Point(20, 60);
            this.feedingDataGridView.Size = new System.Drawing.Size(800, 400);
            this.feedingDataGridView.Name = "feedingDataGridView";

            // btnRecordFeeding
            this.btnRecordFeeding.Location = new System.Drawing.Point(20, 20);
            this.btnRecordFeeding.Size = new System.Drawing.Size(120, 23);
            this.btnRecordFeeding.Text = "Record Feeding";

            // btnRecordCare
            this.btnRecordCare.Location = new System.Drawing.Point(160, 20);
            this.btnRecordCare.Size = new System.Drawing.Size(120, 23);
            this.btnRecordCare.Text = "Record Vet Care";

            // tabChecklist
            this.tabChecklist.Controls.Add(this.btnOpenChecklist);
            this.tabChecklist.Text = "Checklist";

            // btnOpenChecklist
            this.btnOpenChecklist.Location = new System.Drawing.Point(20, 20);
            this.btnOpenChecklist.Size = new System.Drawing.Size(200, 40);
            this.btnOpenChecklist.Text = "Open Daily Checklist";

            // tabStaffActivity
            this.tabStaffActivity.Controls.Add(this.btnOpenStaffActivity);
            this.tabStaffActivity.Text = "Staff Activity";

            // btnOpenStaffActivity
            this.btnOpenStaffActivity.Location = new System.Drawing.Point(20, 20);
            this.btnOpenStaffActivity.Size = new System.Drawing.Size(200, 40);
            this.btnOpenStaffActivity.Text = "View Staff Activity";

            // tabSkills
            this.tabSkills.Controls.Add(this.btnOpenSkills);
            this.tabSkills.Text = "Zookeeper Skills";

            // btnOpenSkills
            this.btnOpenSkills.Location = new System.Drawing.Point(20, 20);
            this.btnOpenSkills.Size = new System.Drawing.Size(200, 40);
            this.btnOpenSkills.Text = "View Skills";

            // tabZoneCoverage
            this.tabZoneCoverage.Controls.Add(this.btnOpenZoneCoverage);
            this.tabZoneCoverage.Text = "Zone Coverage";

            // btnOpenZoneCoverage
            this.btnOpenZoneCoverage.Location = new System.Drawing.Point(20, 20);
            this.btnOpenZoneCoverage.Size = new System.Drawing.Size(250, 40);
            this.btnOpenZoneCoverage.Text = "Calculate Zone Coverage";

            // MainForm
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Text = "Zoo Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.tabMain.ResumeLayout(false);
            this.tabAnimals.ResumeLayout(false);
            this.tabEnclosures.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            this.tabFeedingCare.ResumeLayout(false);
            this.tabChecklist.ResumeLayout(false);
            this.tabStaffActivity.ResumeLayout(false);
            this.tabSkills.ResumeLayout(false);
            this.tabZoneCoverage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enclosuresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAnimals;
        private System.Windows.Forms.TabPage tabEnclosures;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TabPage tabFeedingCare;
        private System.Windows.Forms.TabPage tabChecklist;
        private System.Windows.Forms.TabPage tabStaffActivity;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabZoneCoverage;

        private System.Windows.Forms.Button btnRefreshAnimals;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ComboBox cbZoneFilter;
        private System.Windows.Forms.ComboBox cbEnclosureFilter;

        private System.Windows.Forms.Button btnRefreshEnclosures;
        private System.Windows.Forms.ComboBox cbBiomeFilter;

        private System.Windows.Forms.Button btnRefreshStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ComboBox cbStaffRoleFilter;

        private System.Windows.Forms.Button btnRecordFeeding;
        private System.Windows.Forms.Button btnRecordCare;

        private System.Windows.Forms.Button btnOpenChecklist;
        private System.Windows.Forms.Button btnOpenStaffActivity;
        private System.Windows.Forms.Button btnOpenSkills;
        private System.Windows.Forms.Button btnOpenZoneCoverage;

        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.DataGridView enclosuresDataGridView;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridView feedingDataGridView;
    }
}
