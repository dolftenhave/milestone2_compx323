namespace ZooApp
{
    partial class AddAnimalForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtFeeding = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbEnclosure = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblFeedingInterval = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEnclosure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.btnDeleteSpecies = new System.Windows.Forms.Button();
            this.btnUpdateSpecies = new System.Windows.Forms.Button();
            this.btnNewSpecies = new System.Windows.Forms.Button();
            this.lblSpeciesCommon = new System.Windows.Forms.Label();
            this.txtCommonName = new System.Windows.Forms.TextBox();
            this.lblSpeciesLatin = new System.Windows.Forms.Label();
            this.txtLatinName = new System.Windows.Forms.TextBox();
            this.lblBiome = new System.Windows.Forms.Label();
            this.txtRequiredBiome = new System.Windows.Forms.TextBox();
            this.lblGroupCommon = new System.Windows.Forms.Label();
            this.txtGroupCommon = new System.Windows.Forms.TextBox();
            this.lblGroupLatin = new System.Windows.Forms.Label();
            this.txtGroupLatin = new System.Windows.Forms.TextBox();
            this.btnDeleteSpeciesGroup = new System.Windows.Forms.Button();
            this.btnUpdateSpeciesGroup = new System.Windows.Forms.Button();
            this.btnNewSpeciesGroup = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 20);
            this.txtName.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(120, 138);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(308, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(120, 164);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(308, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(120, 190);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(308, 20);
            this.txtOrigin.TabIndex = 7;
            // 
            // txtFeeding
            // 
            this.txtFeeding.Location = new System.Drawing.Point(120, 216);
            this.txtFeeding.Name = "txtFeeding";
            this.txtFeeding.Size = new System.Drawing.Size(308, 20);
            this.txtFeeding.TabIndex = 9;
            // 
            // cbSex
            // 
            this.cbSex.Location = new System.Drawing.Point(120, 242);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(308, 21);
            this.cbSex.TabIndex = 11;
            // 
            // cbEnclosure
            // 
            this.cbEnclosure.Location = new System.Drawing.Point(120, 269);
            this.cbEnclosure.Name = "cbEnclosure";
            this.cbEnclosure.Size = new System.Drawing.Size(308, 21);
            this.cbEnclosure.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 538);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 538);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.Location = new System.Drawing.Point(14, 112);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(100, 23);
            this.lblAnimalName.TabIndex = 0;
            this.lblAnimalName.Text = "Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.Location = new System.Drawing.Point(14, 138);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 23);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(14, 164);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(100, 23);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight (kg):";
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(14, 190);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 23);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Origin Country:";
            // 
            // lblFeedingInterval
            // 
            this.lblFeedingInterval.Location = new System.Drawing.Point(14, 216);
            this.lblFeedingInterval.Name = "lblFeedingInterval";
            this.lblFeedingInterval.Size = new System.Drawing.Size(100, 23);
            this.lblFeedingInterval.TabIndex = 8;
            this.lblFeedingInterval.Text = "Feeding Interval:";
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(14, 242);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 23);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Sex:";
            // 
            // lblEnclosure
            // 
            this.lblEnclosure.Location = new System.Drawing.Point(14, 269);
            this.lblEnclosure.Name = "lblEnclosure";
            this.lblEnclosure.Size = new System.Drawing.Size(100, 23);
            this.lblEnclosure.TabIndex = 12;
            this.lblEnclosure.Text = "Enclosure:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Species:";
            // 
            // cbSpecies
            // 
            this.cbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecies.Location = new System.Drawing.Point(120, 296);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(308, 21);
            this.cbSpecies.TabIndex = 15;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // btnDeleteSpecies
            // 
            this.btnDeleteSpecies.Location = new System.Drawing.Point(120, 323);
            this.btnDeleteSpecies.Name = "btnDeleteSpecies";
            this.btnDeleteSpecies.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteSpecies.TabIndex = 16;
            this.btnDeleteSpecies.Text = "Delete";
            this.btnDeleteSpecies.Click += new System.EventHandler(this.btnEditSpecies_Click);
            // 
            // btnUpdateSpecies
            // 
            this.btnUpdateSpecies.Location = new System.Drawing.Point(222, 323);
            this.btnUpdateSpecies.Name = "btnUpdateSpecies";
            this.btnUpdateSpecies.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateSpecies.TabIndex = 17;
            this.btnUpdateSpecies.Text = "Update";
            this.btnUpdateSpecies.Click += new System.EventHandler(this.btnUpdateSpecies_Click);
            // 
            // btnNewSpecies
            // 
            this.btnNewSpecies.Location = new System.Drawing.Point(328, 323);
            this.btnNewSpecies.Name = "btnNewSpecies";
            this.btnNewSpecies.Size = new System.Drawing.Size(100, 23);
            this.btnNewSpecies.TabIndex = 18;
            this.btnNewSpecies.Text = "Add New";
            this.btnNewSpecies.Click += new System.EventHandler(this.btnNewSpecies_Click);
            // 
            // lblSpeciesCommon
            // 
            this.lblSpeciesCommon.Location = new System.Drawing.Point(12, 349);
            this.lblSpeciesCommon.Name = "lblSpeciesCommon";
            this.lblSpeciesCommon.Size = new System.Drawing.Size(100, 23);
            this.lblSpeciesCommon.TabIndex = 19;
            this.lblSpeciesCommon.Text = "Common Name:";
            // 
            // txtCommonName
            // 
            this.txtCommonName.Location = new System.Drawing.Point(120, 352);
            this.txtCommonName.Name = "txtCommonName";
            this.txtCommonName.ReadOnly = true;
            this.txtCommonName.Size = new System.Drawing.Size(308, 20);
            this.txtCommonName.TabIndex = 20;
            // 
            // lblSpeciesLatin
            // 
            this.lblSpeciesLatin.Location = new System.Drawing.Point(12, 375);
            this.lblSpeciesLatin.Name = "lblSpeciesLatin";
            this.lblSpeciesLatin.Size = new System.Drawing.Size(100, 23);
            this.lblSpeciesLatin.TabIndex = 21;
            this.lblSpeciesLatin.Text = "Latin Name:";
            // 
            // txtLatinName
            // 
            this.txtLatinName.Location = new System.Drawing.Point(120, 378);
            this.txtLatinName.Name = "txtLatinName";
            this.txtLatinName.ReadOnly = true;
            this.txtLatinName.Size = new System.Drawing.Size(308, 20);
            this.txtLatinName.TabIndex = 22;
            // 
            // lblBiome
            // 
            this.lblBiome.Location = new System.Drawing.Point(12, 401);
            this.lblBiome.Name = "lblBiome";
            this.lblBiome.Size = new System.Drawing.Size(100, 23);
            this.lblBiome.TabIndex = 23;
            this.lblBiome.Text = "Required Biome:";
            // 
            // txtRequiredBiome
            // 
            this.txtRequiredBiome.Location = new System.Drawing.Point(120, 404);
            this.txtRequiredBiome.Name = "txtRequiredBiome";
            this.txtRequiredBiome.ReadOnly = true;
            this.txtRequiredBiome.Size = new System.Drawing.Size(308, 20);
            this.txtRequiredBiome.TabIndex = 24;
            // 
            // lblGroupCommon
            // 
            this.lblGroupCommon.Location = new System.Drawing.Point(12, 486);
            this.lblGroupCommon.Name = "lblGroupCommon";
            this.lblGroupCommon.Size = new System.Drawing.Size(100, 23);
            this.lblGroupCommon.TabIndex = 25;
            this.lblGroupCommon.Text = "Group Common:";
            // 
            // txtGroupCommon
            // 
            this.txtGroupCommon.Location = new System.Drawing.Point(120, 486);
            this.txtGroupCommon.Name = "txtGroupCommon";
            this.txtGroupCommon.ReadOnly = true;
            this.txtGroupCommon.Size = new System.Drawing.Size(308, 20);
            this.txtGroupCommon.TabIndex = 26;
            // 
            // lblGroupLatin
            // 
            this.lblGroupLatin.Location = new System.Drawing.Point(12, 509);
            this.lblGroupLatin.Name = "lblGroupLatin";
            this.lblGroupLatin.Size = new System.Drawing.Size(100, 23);
            this.lblGroupLatin.TabIndex = 27;
            this.lblGroupLatin.Text = "Group Latin:";
            // 
            // txtGroupLatin
            // 
            this.txtGroupLatin.Location = new System.Drawing.Point(120, 512);
            this.txtGroupLatin.Name = "txtGroupLatin";
            this.txtGroupLatin.ReadOnly = true;
            this.txtGroupLatin.Size = new System.Drawing.Size(308, 20);
            this.txtGroupLatin.TabIndex = 28;
            // 
            // btnDeleteSpeciesGroup
            // 
            this.btnDeleteSpeciesGroup.Location = new System.Drawing.Point(120, 457);
            this.btnDeleteSpeciesGroup.Name = "btnDeleteSpeciesGroup";
            this.btnDeleteSpeciesGroup.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteSpeciesGroup.TabIndex = 29;
            this.btnDeleteSpeciesGroup.Text = "Delete";
            this.btnDeleteSpeciesGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // btnUpdateSpeciesGroup
            // 
            this.btnUpdateSpeciesGroup.Location = new System.Drawing.Point(222, 457);
            this.btnUpdateSpeciesGroup.Name = "btnUpdateSpeciesGroup";
            this.btnUpdateSpeciesGroup.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateSpeciesGroup.TabIndex = 30;
            this.btnUpdateSpeciesGroup.Text = "Update";
            this.btnUpdateSpeciesGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // btnNewSpeciesGroup
            // 
            this.btnNewSpeciesGroup.Location = new System.Drawing.Point(328, 457);
            this.btnNewSpeciesGroup.Name = "btnNewSpeciesGroup";
            this.btnNewSpeciesGroup.Size = new System.Drawing.Size(100, 23);
            this.btnNewSpeciesGroup.TabIndex = 31;
            this.btnNewSpeciesGroup.Text = "Add New";
            this.btnNewSpeciesGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(120, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Species Group:";
            // 
            // AddAnimalForm
            // 
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.lblFeedingInterval);
            this.Controls.Add(this.txtFeeding);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.lblEnclosure);
            this.Controls.Add(this.cbEnclosure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSpecies);
            this.Controls.Add(this.btnDeleteSpecies);
            this.Controls.Add(this.btnUpdateSpecies);
            this.Controls.Add(this.btnNewSpecies);
            this.Controls.Add(this.lblSpeciesCommon);
            this.Controls.Add(this.txtCommonName);
            this.Controls.Add(this.lblSpeciesLatin);
            this.Controls.Add(this.txtLatinName);
            this.Controls.Add(this.lblBiome);
            this.Controls.Add(this.txtRequiredBiome);
            this.Controls.Add(this.lblGroupCommon);
            this.Controls.Add(this.txtGroupCommon);
            this.Controls.Add(this.lblGroupLatin);
            this.Controls.Add(this.txtGroupLatin);
            this.Controls.Add(this.btnDeleteSpeciesGroup);
            this.Controls.Add(this.btnUpdateSpeciesGroup);
            this.Controls.Add(this.btnNewSpeciesGroup);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddAnimalForm";
            this.Text = "Add or Edit Animal";
            this.Load += new System.EventHandler(this.AddAnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtFeeding;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbEnclosure;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblFeedingInterval;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblEnclosure;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.Button btnDeleteSpecies;
        private System.Windows.Forms.Button btnUpdateSpecies;
        private System.Windows.Forms.Button btnNewSpecies;
        private System.Windows.Forms.Label lblSpeciesCommon;
        private System.Windows.Forms.TextBox txtCommonName;
        private System.Windows.Forms.Label lblSpeciesLatin;
        private System.Windows.Forms.TextBox txtLatinName;
        private System.Windows.Forms.Label lblBiome;
        private System.Windows.Forms.TextBox txtRequiredBiome;

        private System.Windows.Forms.Label lblGroupCommon;
        private System.Windows.Forms.TextBox txtGroupCommon;
        private System.Windows.Forms.Label lblGroupLatin;
        private System.Windows.Forms.TextBox txtGroupLatin;
        private System.Windows.Forms.Button btnDeleteSpeciesGroup;
        private System.Windows.Forms.Button btnUpdateSpeciesGroup;
        private System.Windows.Forms.Button btnNewSpeciesGroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}
