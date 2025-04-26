
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

            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.dgvEnclosures = new System.Windows.Forms.DataGridView();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.dgvCareFeeding = new System.Windows.Forms.DataGridView();

            this.lblZone = new System.Windows.Forms.Label();
            this.cbZoneFilter = new System.Windows.Forms.ComboBox();
            this.lblEnclosure = new System.Windows.Forms.Label();
            this.cbEnclosureFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshAnimals = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();

            this.lblBiome = new System.Windows.Forms.Label();
            this.cbBiomeFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshEnclosures = new System.Windows.Forms.Button();

            this.lblStaffRole = new System.Windows.Forms.Label();
            this.cbStaffRoleFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();

            this.btnRecordCare = new System.Windows.Forms.Button();
            this.btnRecordFeeding = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabAnimals.SuspendLayout();
            this.tabEnclosures.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.tabFeedingCare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnclosures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCareFeeding)).BeginInit();
            this.SuspendLayout();

            this.tabControl1.Controls.Add(this.tabAnimals);
            this.tabControl1.Controls.Add(this.tabEnclosures);
            this.tabControl1.Controls.Add(this.tabStaff);
            this.tabControl1.Controls.Add(this.tabFeedingCare);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Size = new System.Drawing.Size(860, 500);
            this.tabControl1.TabIndex = 0;

            this.tabAnimals.Controls.Add(this.lblZone);
            this.tabAnimals.Controls.Add(this.cbZoneFilter);
            this.tabAnimals.Controls.Add(this.lblEnclosure);
            this.tabAnimals.Controls.Add(this.cbEnclosureFilter);
            this.tabAnimals.Controls.Add(this.btnRefreshAnimals);
            this.tabAnimals.Controls.Add(this.btnAddAnimal);
            this.tabAnimals.Controls.Add(this.dgvAnimals);
            this.tabAnimals.Text = "Animals";

            this.tabEnclosures.Controls.Add(this.lblBiome);
            this.tabEnclosures.Controls.Add(this.cbBiomeFilter);
            this.tabEnclosures.Controls.Add(this.btnRefreshEnclosures);
            this.tabEnclosures.Controls.Add(this.dgvEnclosures);
            this.tabEnclosures.Text = "Enclosures";

            this.tabStaff.Controls.Add(this.lblStaffRole);
            this.tabStaff.Controls.Add(this.cbStaffRoleFilter);
            this.tabStaff.Controls.Add(this.btnRefreshStaff);
            this.tabStaff.Controls.Add(this.btnAddStaff);
            this.tabStaff.Controls.Add(this.dgvStaff);
            this.tabStaff.Text = "Staff";

            this.tabFeedingCare.Controls.Add(this.btnRecordFeeding);
            this.tabFeedingCare.Controls.Add(this.btnRecordCare);
            this.tabFeedingCare.Controls.Add(this.dgvCareFeeding);
            this.tabFeedingCare.Text = "Feeding / Care";

            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimals.Location = new System.Drawing.Point(20, 60);
            this.dgvAnimals.Size = new System.Drawing.Size(800, 380);
            this.dgvAnimals.ReadOnly = true;

            this.dgvEnclosures.AllowUserToAddRows = false;
            this.dgvEnclosures.AllowUserToDeleteRows = false;
            this.dgvEnclosures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnclosures.Location = new System.Drawing.Point(20, 60);
            this.dgvEnclosures.Size = new System.Drawing.Size(800, 380);
            this.dgvEnclosures.ReadOnly = true;

            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(20, 60);
            this.dgvStaff.Size = new System.Drawing.Size(800, 380);
            this.dgvStaff.ReadOnly = true;

            this.dgvCareFeeding.AllowUserToAddRows = false;
            this.dgvCareFeeding.AllowUserToDeleteRows = false;
            this.dgvCareFeeding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCareFeeding.Location = new System.Drawing.Point(20, 70);
            this.dgvCareFeeding.Size = new System.Drawing.Size(800, 370);
            this.dgvCareFeeding.ReadOnly = true;

            this.lblZone.Text = "Filter by Zone:";
            this.lblZone.Location = new System.Drawing.Point(20, 20);

            this.cbZoneFilter.Location = new System.Drawing.Point(120, 17);
            this.cbZoneFilter.Width = 150;

            this.lblEnclosure.Text = "Filter by Enclosure:";
            this.lblEnclosure.Location = new System.Drawing.Point(300, 20);

            this.cbEnclosureFilter.Location = new System.Drawing.Point(400, 17);
            this.cbEnclosureFilter.Width = 150;

            this.btnRefreshAnimals.Text = "Refresh";
            this.btnRefreshAnimals.Location = new System.Drawing.Point(570, 15);
            this.btnRefreshAnimals.Click += new System.EventHandler(this.btnRefreshAnimals_Click);

            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.Location = new System.Drawing.Point(670, 15);
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);

            this.lblBiome.Text = "Filter by Biome:";
            this.lblBiome.Location = new System.Drawing.Point(20, 20);

            this.cbBiomeFilter.Location = new System.Drawing.Point(120, 17);
            this.cbBiomeFilter.Width = 150;

            this.btnRefreshEnclosures.Text = "Refresh";
            this.btnRefreshEnclosures.Location = new System.Drawing.Point(300, 15);
            this.btnRefreshEnclosures.Click += new System.EventHandler(this.btnRefreshEnclosures_Click);

            this.lblStaffRole.Text = "Filter by Role:";
            this.lblStaffRole.Location = new System.Drawing.Point(20, 20);

            this.cbStaffRoleFilter.Location = new System.Drawing.Point(120, 17);
            this.cbStaffRoleFilter.Width = 150;

            this.btnRefreshStaff.Text = "Refresh";
            this.btnRefreshStaff.Location = new System.Drawing.Point(300, 17);
            this.btnRefreshStaff.Click += new System.EventHandler(this.btnRefreshStaff_Click);

            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.Location = new System.Drawing.Point(670, 17);
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);

            this.btnRecordFeeding.Text = "Record Feeding";
            this.btnRecordFeeding.Location = new System.Drawing.Point(450, 20);
            this.btnRecordFeeding.Size = new System.Drawing.Size(120, 30);
            this.btnRecordFeeding.Click += new System.EventHandler(this.btnRecordFeeding_Click);

            this.btnRecordCare.Text = "Record Vet Care";
            this.btnRecordCare.Location = new System.Drawing.Point(600, 20);
            this.btnRecordCare.Size = new System.Drawing.Size(120, 30);
            this.btnRecordCare.Click += new System.EventHandler(this.btnRecordCare_Click);

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

            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnclosures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCareFeeding)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnimals;
        private System.Windows.Forms.TabPage tabEnclosures;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TabPage tabFeedingCare;

        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.DataGridView dgvEnclosures;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridView dgvCareFeeding;

        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.ComboBox cbZoneFilter;
        private System.Windows.Forms.Label lblEnclosure;
        private System.Windows.Forms.ComboBox cbEnclosureFilter;
        private System.Windows.Forms.Button btnRefreshAnimals;
        private System.Windows.Forms.Button btnAddAnimal;

        private System.Windows.Forms.Label lblBiome;
        private System.Windows.Forms.ComboBox cbBiomeFilter;
        private System.Windows.Forms.Button btnRefreshEnclosures;

        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.ComboBox cbStaffRoleFilter;
        private System.Windows.Forms.Button btnRefreshStaff;
        private System.Windows.Forms.Button btnAddStaff;

        private System.Windows.Forms.Button btnRecordCare;
        private System.Windows.Forms.Button btnRecordFeeding;
    }
}
