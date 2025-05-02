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
            this.tabZoneCoverage = new System.Windows.Forms.TabPage();
            this.btnOpenZoneCoverage = new System.Windows.Forms.Button();
            this.tabChecklist = new System.Windows.Forms.TabPage();
            this.btnOpenChecklist = new System.Windows.Forms.Button();
            this.tabFeedingCare = new System.Windows.Forms.TabPage();
            this.btnRecordCare = new System.Windows.Forms.Button();
            this.btnRecordFeeding = new System.Windows.Forms.Button();
            this.feedingDataGridView = new System.Windows.Forms.DataGridView();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnRefreshStaff = new System.Windows.Forms.Button();
            this.cbStaffRoleFilter = new System.Windows.Forms.ComboBox();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.tabEnclosures = new System.Windows.Forms.TabPage();
            this.btnRefreshEnclosures = new System.Windows.Forms.Button();
            this.cbBiomeFilter = new System.Windows.Forms.ComboBox();
            this.enclosuresDataGridView = new System.Windows.Forms.DataGridView();
            this.btnEditEnclosure = new System.Windows.Forms.Button();
            this.btnAddEnclosure_Click = new System.Windows.Forms.Button();
            this.tabAnimals = new System.Windows.Forms.TabPage();
            this.btnRefreshAnimals = new System.Windows.Forms.Button();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.txtAnimalSearch = new System.Windows.Forms.TextBox();
            this.btnEditAnimal = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabZoneCoverage.SuspendLayout();
            this.tabChecklist.SuspendLayout();
            this.tabFeedingCare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedingDataGridView)).BeginInit();
            this.tabStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.tabEnclosures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enclosuresDataGridView)).BeginInit();
            this.tabAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabZoneCoverage
            // 
            this.tabZoneCoverage.Controls.Add(this.btnOpenZoneCoverage);
            this.tabZoneCoverage.Location = new System.Drawing.Point(4, 22);
            this.tabZoneCoverage.Name = "tabZoneCoverage";
            this.tabZoneCoverage.Size = new System.Drawing.Size(852, 474);
            this.tabZoneCoverage.TabIndex = 7;
            this.tabZoneCoverage.Text = "Zone Coverage";
            // 
            // btnOpenZoneCoverage
            // 
            this.btnOpenZoneCoverage.Location = new System.Drawing.Point(20, 20);
            this.btnOpenZoneCoverage.Name = "btnOpenZoneCoverage";
            this.btnOpenZoneCoverage.Size = new System.Drawing.Size(250, 40);
            this.btnOpenZoneCoverage.TabIndex = 0;
            this.btnOpenZoneCoverage.Text = "Calculate Zone Coverage";
            // 
            // tabChecklist
            // 
            this.tabChecklist.Controls.Add(this.btnOpenChecklist);
            this.tabChecklist.Location = new System.Drawing.Point(4, 22);
            this.tabChecklist.Name = "tabChecklist";
            this.tabChecklist.Size = new System.Drawing.Size(852, 474);
            this.tabChecklist.TabIndex = 4;
            this.tabChecklist.Text = "Checklist";
            // 
            // btnOpenChecklist
            // 
            this.btnOpenChecklist.Location = new System.Drawing.Point(20, 20);
            this.btnOpenChecklist.Name = "btnOpenChecklist";
            this.btnOpenChecklist.Size = new System.Drawing.Size(200, 40);
            this.btnOpenChecklist.TabIndex = 0;
            this.btnOpenChecklist.Text = "Open Daily Checklist";
            // 
            // tabFeedingCare
            // 
            this.tabFeedingCare.Controls.Add(this.feedingDataGridView);
            this.tabFeedingCare.Controls.Add(this.btnRecordFeeding);
            this.tabFeedingCare.Controls.Add(this.btnRecordCare);
            this.tabFeedingCare.Location = new System.Drawing.Point(4, 22);
            this.tabFeedingCare.Name = "tabFeedingCare";
            this.tabFeedingCare.Size = new System.Drawing.Size(852, 474);
            this.tabFeedingCare.TabIndex = 3;
            this.tabFeedingCare.Text = "Feeding / Care";
            // 
            // btnRecordCare
            // 
            this.btnRecordCare.Location = new System.Drawing.Point(160, 20);
            this.btnRecordCare.Name = "btnRecordCare";
            this.btnRecordCare.Size = new System.Drawing.Size(120, 23);
            this.btnRecordCare.TabIndex = 2;
            this.btnRecordCare.Text = "Record Vet Care";
            this.btnRecordCare.Click += new System.EventHandler(this.btnRecordCare_Click);
            // 
            // btnRecordFeeding
            // 
            this.btnRecordFeeding.Location = new System.Drawing.Point(20, 20);
            this.btnRecordFeeding.Name = "btnRecordFeeding";
            this.btnRecordFeeding.Size = new System.Drawing.Size(120, 23);
            this.btnRecordFeeding.TabIndex = 1;
            this.btnRecordFeeding.Text = "Record Feeding";
            this.btnRecordFeeding.Click += new System.EventHandler(this.btnRecordFeeding_Click);
            // 
            // feedingDataGridView
            // 
            this.feedingDataGridView.Location = new System.Drawing.Point(20, 60);
            this.feedingDataGridView.Name = "feedingDataGridView";
            this.feedingDataGridView.Size = new System.Drawing.Size(800, 400);
            this.feedingDataGridView.TabIndex = 0;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.btnEditStaff);
            this.tabStaff.Controls.Add(this.txtStaffSearch);
            this.tabStaff.Controls.Add(this.btnSearchStaff);
            this.tabStaff.Controls.Add(this.staffDataGridView);
            this.tabStaff.Controls.Add(this.cbStaffRoleFilter);
            this.tabStaff.Controls.Add(this.btnRefreshStaff);
            this.tabStaff.Controls.Add(this.btnAddStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Size = new System.Drawing.Size(852, 474);
            this.tabStaff.TabIndex = 2;
            this.tabStaff.Text = "Staff";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(730, 31);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(90, 23);
            this.btnAddStaff.TabIndex = 3;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnRefreshStaff
            // 
            this.btnRefreshStaff.Location = new System.Drawing.Point(411, 25);
            this.btnRefreshStaff.Name = "btnRefreshStaff";
            this.btnRefreshStaff.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshStaff.TabIndex = 2;
            this.btnRefreshStaff.Text = "Refresh";
            // 
            // cbStaffRoleFilter
            // 
            this.cbStaffRoleFilter.Location = new System.Drawing.Point(285, 25);
            this.cbStaffRoleFilter.Name = "cbStaffRoleFilter";
            this.cbStaffRoleFilter.Size = new System.Drawing.Size(120, 21);
            this.cbStaffRoleFilter.TabIndex = 1;
            this.cbStaffRoleFilter.Text = "Role Filter";
            this.cbStaffRoleFilter.SelectedIndexChanged += new System.EventHandler(this.cbStaffRoleFilter_SelectedIndexChanged);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.Location = new System.Drawing.Point(20, 60);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(800, 400);
            this.staffDataGridView.TabIndex = 0;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(204, 23);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStaff.TabIndex = 4;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Location = new System.Drawing.Point(20, 23);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(178, 20);
            this.txtStaffSearch.TabIndex = 5;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Location = new System.Drawing.Point(649, 31);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(75, 23);
            this.btnEditStaff.TabIndex = 6;
            this.btnEditStaff.Text = "Edit Staff";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // tabEnclosures
            // 
            this.tabEnclosures.Controls.Add(this.btnAddEnclosure_Click);
            this.tabEnclosures.Controls.Add(this.btnEditEnclosure);
            this.tabEnclosures.Controls.Add(this.enclosuresDataGridView);
            this.tabEnclosures.Controls.Add(this.cbBiomeFilter);
            this.tabEnclosures.Controls.Add(this.btnRefreshEnclosures);
            this.tabEnclosures.Location = new System.Drawing.Point(4, 22);
            this.tabEnclosures.Name = "tabEnclosures";
            this.tabEnclosures.Size = new System.Drawing.Size(852, 474);
            this.tabEnclosures.TabIndex = 1;
            this.tabEnclosures.Text = "Enclosures";
            // 
            // btnRefreshEnclosures
            // 
            this.btnRefreshEnclosures.Location = new System.Drawing.Point(160, 20);
            this.btnRefreshEnclosures.Name = "btnRefreshEnclosures";
            this.btnRefreshEnclosures.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshEnclosures.TabIndex = 2;
            this.btnRefreshEnclosures.Text = "Refresh";
            // 
            // cbBiomeFilter
            // 
            this.cbBiomeFilter.Location = new System.Drawing.Point(20, 20);
            this.cbBiomeFilter.Name = "cbBiomeFilter";
            this.cbBiomeFilter.Size = new System.Drawing.Size(120, 21);
            this.cbBiomeFilter.TabIndex = 1;
            // 
            // enclosuresDataGridView
            // 
            this.enclosuresDataGridView.Location = new System.Drawing.Point(20, 60);
            this.enclosuresDataGridView.Name = "enclosuresDataGridView";
            this.enclosuresDataGridView.Size = new System.Drawing.Size(800, 400);
            this.enclosuresDataGridView.TabIndex = 0;
            // 
            // btnEditEnclosure
            // 
            this.btnEditEnclosure.Location = new System.Drawing.Point(636, 31);
            this.btnEditEnclosure.Name = "btnEditEnclosure";
            this.btnEditEnclosure.Size = new System.Drawing.Size(89, 23);
            this.btnEditEnclosure.TabIndex = 3;
            this.btnEditEnclosure.Text = "Edit Enclosure";
            this.btnEditEnclosure.UseVisualStyleBackColor = true;
            this.btnEditEnclosure.Click += new System.EventHandler(this.btnEditEnclosure_Click);
            // 
            // btnAddEnclosure_Click
            // 
            this.btnAddEnclosure_Click.Location = new System.Drawing.Point(731, 31);
            this.btnAddEnclosure_Click.Name = "btnAddEnclosure_Click";
            this.btnAddEnclosure_Click.Size = new System.Drawing.Size(89, 23);
            this.btnAddEnclosure_Click.TabIndex = 4;
            this.btnAddEnclosure_Click.Text = "Add Enclosure";
            this.btnAddEnclosure_Click.UseVisualStyleBackColor = true;
            this.btnAddEnclosure_Click.Click += new System.EventHandler(this.btnAddEnclosure_Click_Click);
            // 
            // tabAnimals
            // 
            this.tabAnimals.Controls.Add(this.btnEditAnimal);
            this.tabAnimals.Controls.Add(this.txtAnimalSearch);
            this.tabAnimals.Controls.Add(this.btnAddAnimal);
            this.tabAnimals.Controls.Add(this.btnSearchAnimal);
            this.tabAnimals.Controls.Add(this.animalsDataGridView);
            this.tabAnimals.Controls.Add(this.btnRefreshAnimals);
            this.tabAnimals.Location = new System.Drawing.Point(4, 22);
            this.tabAnimals.Name = "tabAnimals";
            this.tabAnimals.Size = new System.Drawing.Size(852, 474);
            this.tabAnimals.TabIndex = 0;
            this.tabAnimals.Text = "Animals";
            // 
            // btnRefreshAnimals
            // 
            this.btnRefreshAnimals.Location = new System.Drawing.Point(267, 17);
            this.btnRefreshAnimals.Name = "btnRefreshAnimals";
            this.btnRefreshAnimals.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAnimals.TabIndex = 3;
            this.btnRefreshAnimals.Text = "Refresh";
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.Location = new System.Drawing.Point(20, 60);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.Size = new System.Drawing.Size(800, 400);
            this.animalsDataGridView.TabIndex = 0;
            // 
            // btnSearchAnimal
            // 
            this.btnSearchAnimal.Location = new System.Drawing.Point(186, 17);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAnimal.TabIndex = 5;
            this.btnSearchAnimal.Text = "Search";
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(730, 18);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(90, 23);
            this.btnAddAnimal.TabIndex = 4;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // txtAnimalSearch
            // 
            this.txtAnimalSearch.Location = new System.Drawing.Point(20, 19);
            this.txtAnimalSearch.Name = "txtAnimalSearch";
            this.txtAnimalSearch.Size = new System.Drawing.Size(160, 20);
            this.txtAnimalSearch.TabIndex = 0;
            this.txtAnimalSearch.Text = "Search Animal here";
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.Location = new System.Drawing.Point(649, 19);
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnEditAnimal.TabIndex = 6;
            this.btnEditAnimal.Text = "Edit Animal";
            this.btnEditAnimal.UseVisualStyleBackColor = true;
            this.btnEditAnimal.Click += new System.EventHandler(this.btnEditAnimal_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAnimals);
            this.tabMain.Controls.Add(this.tabEnclosures);
            this.tabMain.Controls.Add(this.tabStaff);
            this.tabMain.Controls.Add(this.tabFeedingCare);
            this.tabMain.Controls.Add(this.tabChecklist);
            this.tabMain.Controls.Add(this.tabZoneCoverage);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(860, 500);
            this.tabMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Text = "Zoo Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabZoneCoverage.ResumeLayout(false);
            this.tabChecklist.ResumeLayout(false);
            this.tabFeedingCare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedingDataGridView)).EndInit();
            this.tabStaff.ResumeLayout(false);
            this.tabStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.tabEnclosures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enclosuresDataGridView)).EndInit();
            this.tabAnimals.ResumeLayout(false);
            this.tabAnimals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEnclosure;
        private System.Windows.Forms.TabPage tabZoneCoverage;
        private System.Windows.Forms.Button btnOpenZoneCoverage;
        private System.Windows.Forms.TabPage tabChecklist;
        private System.Windows.Forms.Button btnOpenChecklist;
        private System.Windows.Forms.TabPage tabFeedingCare;
        private System.Windows.Forms.DataGridView feedingDataGridView;
        private System.Windows.Forms.Button btnRecordFeeding;
        private System.Windows.Forms.Button btnRecordCare;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.ComboBox cbStaffRoleFilter;
        private System.Windows.Forms.Button btnRefreshStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TabPage tabEnclosures;
        private System.Windows.Forms.Button btnAddEnclosure_Click;
        private System.Windows.Forms.Button btnEditEnclosure;
        private System.Windows.Forms.DataGridView enclosuresDataGridView;
        private System.Windows.Forms.ComboBox cbBiomeFilter;
        private System.Windows.Forms.Button btnRefreshEnclosures;
        private System.Windows.Forms.TabPage tabAnimals;
        private System.Windows.Forms.Button btnEditAnimal;
        private System.Windows.Forms.TextBox txtAnimalSearch;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.Button btnRefreshAnimals;
        private System.Windows.Forms.TabControl tabMain;
    }
}
