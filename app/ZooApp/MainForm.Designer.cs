using System.Windows.Forms;

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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lvQualifiedSpecies = new System.Windows.Forms.ListView();
            this.lvCaredAnimals = new System.Windows.Forms.ListView();
            this.lvFeedRecords = new System.Windows.Forms.ListView();
            this.lvCareRecords = new System.Windows.Forms.ListView();
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.btnAddCare = new System.Windows.Forms.Button();
            this.tabAnimal = new System.Windows.Forms.TabPage();
            this.lblAnimalTitle = new System.Windows.Forms.Label();
            this.lblSelectAnimal = new System.Windows.Forms.Label();
            this.cbSelectAnimal = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblAGE = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblEnclosure = new System.Windows.Forms.Label();
            this.txtEnclosure = new System.Windows.Forms.TextBox();
            this.lblZone = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.lblLastFed = new System.Windows.Forms.Label();
            this.txtLastFed = new System.Windows.Forms.TextBox();
            this.lblLastCare = new System.Windows.Forms.Label();
            this.txtLastCare = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtFeedingInterval = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.tabZone = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblZonez = new System.Windows.Forms.Label();
            this.lblEnclosurez = new System.Windows.Forms.Label();
            this.btnAddZone = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabAnimal.SuspendLayout();
            this.tabZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabHome);
            this.tabControlMain.Controls.Add(this.tabAnimal);
            this.tabControlMain.Controls.Add(this.tabZone);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(360, 640);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblStaffName);
            this.tabHome.Controls.Add(this.lvQualifiedSpecies);
            this.tabHome.Controls.Add(this.lvCaredAnimals);
            this.tabHome.Controls.Add(this.lvFeedRecords);
            this.tabHome.Controls.Add(this.lvCareRecords);
            this.tabHome.Controls.Add(this.btnAddFeed);
            this.tabHome.Controls.Add(this.btnAddCare);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(352, 614);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStaffName.Location = new System.Drawing.Point(10, 10);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(330, 30);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Welcome, [Staff Name]";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvQualifiedSpecies
            // 
            this.lvQualifiedSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvQualifiedSpecies.HideSelection = false;
            this.lvQualifiedSpecies.Location = new System.Drawing.Point(10, 50);
            this.lvQualifiedSpecies.Name = "lvQualifiedSpecies";
            this.lvQualifiedSpecies.Size = new System.Drawing.Size(330, 120);
            this.lvQualifiedSpecies.TabIndex = 1;
            this.lvQualifiedSpecies.UseCompatibleStateImageBehavior = false;
            this.lvQualifiedSpecies.View = System.Windows.Forms.View.Details;
            // 
            // lvCaredAnimals
            // 
            this.lvCaredAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCaredAnimals.HideSelection = false;
            this.lvCaredAnimals.Location = new System.Drawing.Point(10, 50);
            this.lvCaredAnimals.Name = "lvCaredAnimals";
            this.lvCaredAnimals.Size = new System.Drawing.Size(330, 120);
            this.lvCaredAnimals.TabIndex = 2;
            this.lvCaredAnimals.UseCompatibleStateImageBehavior = false;
            this.lvCaredAnimals.View = System.Windows.Forms.View.Details;
            // 
            // lvFeedRecords
            // 
            this.lvFeedRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFeedRecords.FullRowSelect = true;
            this.lvFeedRecords.HideSelection = false;
            this.lvFeedRecords.Location = new System.Drawing.Point(10, 180);
            this.lvFeedRecords.Name = "lvFeedRecords";
            this.lvFeedRecords.Size = new System.Drawing.Size(330, 200);
            this.lvFeedRecords.TabIndex = 3;
            this.lvFeedRecords.UseCompatibleStateImageBehavior = false;
            this.lvFeedRecords.View = System.Windows.Forms.View.Details;
            // 
            // lvCareRecords
            // 
            this.lvCareRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCareRecords.FullRowSelect = true;
            this.lvCareRecords.HideSelection = false;
            this.lvCareRecords.Location = new System.Drawing.Point(10, 180);
            this.lvCareRecords.Name = "lvCareRecords";
            this.lvCareRecords.Size = new System.Drawing.Size(330, 200);
            this.lvCareRecords.TabIndex = 4;
            this.lvCareRecords.UseCompatibleStateImageBehavior = false;
            this.lvCareRecords.View = System.Windows.Forms.View.Details;
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFeed.Location = new System.Drawing.Point(10, 390);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(150, 30);
            this.btnAddFeed.TabIndex = 5;
            this.btnAddFeed.Text = "Add New Feed";
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // btnAddCare
            // 
            this.btnAddCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCare.Location = new System.Drawing.Point(10, 390);
            this.btnAddCare.Name = "btnAddCare";
            this.btnAddCare.Size = new System.Drawing.Size(150, 30);
            this.btnAddCare.TabIndex = 6;
            this.btnAddCare.Text = "Add New Care";
            this.btnAddCare.Click += new System.EventHandler(this.btnAddCare_Click);
            // 
            // tabAnimal
            // 
            this.tabAnimal.Controls.Add(this.lblAnimalTitle);
            this.tabAnimal.Controls.Add(this.lblSelectAnimal);
            this.tabAnimal.Controls.Add(this.cbSelectAnimal);
            this.tabAnimal.Controls.Add(this.lblSpecies);
            this.tabAnimal.Controls.Add(this.txtSpecies);
            this.tabAnimal.Controls.Add(this.lblAGE);
            this.tabAnimal.Controls.Add(this.txtAge);
            this.tabAnimal.Controls.Add(this.lblSex);
            this.tabAnimal.Controls.Add(this.txtSex);
            this.tabAnimal.Controls.Add(this.lblEnclosure);
            this.tabAnimal.Controls.Add(this.txtEnclosure);
            this.tabAnimal.Controls.Add(this.lblZone);
            this.tabAnimal.Controls.Add(this.txtZone);
            this.tabAnimal.Controls.Add(this.lblLastFed);
            this.tabAnimal.Controls.Add(this.txtLastFed);
            this.tabAnimal.Controls.Add(this.lblLastCare);
            this.tabAnimal.Controls.Add(this.txtLastCare);
            this.tabAnimal.Controls.Add(this.lblInterval);
            this.tabAnimal.Controls.Add(this.txtFeedingInterval);
            this.tabAnimal.Controls.Add(this.btnAddAnimal);
            this.tabAnimal.Location = new System.Drawing.Point(4, 22);
            this.tabAnimal.Name = "tabAnimal";
            this.tabAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimal.Size = new System.Drawing.Size(352, 614);
            this.tabAnimal.TabIndex = 1;
            this.tabAnimal.Text = "Animal";
            this.tabAnimal.UseVisualStyleBackColor = true;
            // 
            // lblAnimalTitle
            // 
            this.lblAnimalTitle.AutoSize = true;
            this.lblAnimalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAnimalTitle.Location = new System.Drawing.Point(87, 10);
            this.lblAnimalTitle.Name = "lblAnimalTitle";
            this.lblAnimalTitle.Size = new System.Drawing.Size(187, 25);
            this.lblAnimalTitle.TabIndex = 0;
            this.lblAnimalTitle.Text = "Animal Information";
            // 
            // lblSelectAnimal
            // 
            this.lblSelectAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAnimal.Location = new System.Drawing.Point(8, 53);
            this.lblSelectAnimal.Name = "lblSelectAnimal";
            this.lblSelectAnimal.Size = new System.Drawing.Size(100, 23);
            this.lblSelectAnimal.TabIndex = 1;
            this.lblSelectAnimal.Text = "Select Animal:";
            // 
            // cbSelectAnimal
            // 
            this.cbSelectAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAnimal.Location = new System.Drawing.Point(130, 48);
            this.cbSelectAnimal.Name = "cbSelectAnimal";
            this.cbSelectAnimal.Size = new System.Drawing.Size(200, 28);
            this.cbSelectAnimal.TabIndex = 2;
            this.cbSelectAnimal.SelectedIndexChanged += new System.EventHandler(this.cbSelectAnimal_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(6, 93);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(100, 23);
            this.lblSpecies.TabIndex = 3;
            this.lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(130, 90);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.ReadOnly = true;
            this.txtSpecies.Size = new System.Drawing.Size(200, 26);
            this.txtSpecies.TabIndex = 4;
            // 
            // lblAGE
            // 
            this.lblAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGE.Location = new System.Drawing.Point(6, 120);
            this.lblAGE.Name = "lblAGE";
            this.lblAGE.Size = new System.Drawing.Size(114, 23);
            this.lblAGE.TabIndex = 5;
            this.lblAGE.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(130, 120);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(200, 26);
            this.txtAge.TabIndex = 6;
            // 
            // lblSex
            // 
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(6, 153);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 23);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex:";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(130, 150);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(200, 26);
            this.txtSex.TabIndex = 8;
            // 
            // lblEnclosure
            // 
            this.lblEnclosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnclosure.Location = new System.Drawing.Point(6, 186);
            this.lblEnclosure.Name = "lblEnclosure";
            this.lblEnclosure.Size = new System.Drawing.Size(80, 20);
            this.lblEnclosure.TabIndex = 9;
            this.lblEnclosure.Text = "Enclosure:";
            // 
            // txtEnclosure
            // 
            this.txtEnclosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnclosure.Location = new System.Drawing.Point(130, 180);
            this.txtEnclosure.Name = "txtEnclosure";
            this.txtEnclosure.ReadOnly = true;
            this.txtEnclosure.Size = new System.Drawing.Size(200, 26);
            this.txtEnclosure.TabIndex = 10;
            // 
            // lblZone
            // 
            this.lblZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(6, 216);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(80, 20);
            this.lblZone.TabIndex = 11;
            this.lblZone.Text = "Zone:";
            // 
            // txtZone
            // 
            this.txtZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZone.Location = new System.Drawing.Point(130, 210);
            this.txtZone.Name = "txtZone";
            this.txtZone.ReadOnly = true;
            this.txtZone.Size = new System.Drawing.Size(200, 26);
            this.txtZone.TabIndex = 12;
            // 
            // lblLastFed
            // 
            this.lblLastFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFed.Location = new System.Drawing.Point(6, 243);
            this.lblLastFed.Name = "lblLastFed";
            this.lblLastFed.Size = new System.Drawing.Size(100, 23);
            this.lblLastFed.TabIndex = 13;
            this.lblLastFed.Text = "Last Fed:";
            // 
            // txtLastFed
            // 
            this.txtLastFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastFed.Location = new System.Drawing.Point(130, 240);
            this.txtLastFed.Name = "txtLastFed";
            this.txtLastFed.ReadOnly = true;
            this.txtLastFed.Size = new System.Drawing.Size(200, 26);
            this.txtLastFed.TabIndex = 14;
            // 
            // lblLastCare
            // 
            this.lblLastCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCare.Location = new System.Drawing.Point(6, 273);
            this.lblLastCare.Name = "lblLastCare";
            this.lblLastCare.Size = new System.Drawing.Size(100, 23);
            this.lblLastCare.TabIndex = 15;
            this.lblLastCare.Text = "Last Cared:";
            // 
            // txtLastCare
            // 
            this.txtLastCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastCare.Location = new System.Drawing.Point(130, 270);
            this.txtLastCare.Name = "txtLastCare";
            this.txtLastCare.ReadOnly = true;
            this.txtLastCare.Size = new System.Drawing.Size(200, 26);
            this.txtLastCare.TabIndex = 16;
            // 
            // lblInterval
            // 
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(6, 303);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(100, 23);
            this.lblInterval.TabIndex = 17;
            this.lblInterval.Text = "Feeding Interval:";
            // 
            // txtFeedingInterval
            // 
            this.txtFeedingInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedingInterval.Location = new System.Drawing.Point(130, 300);
            this.txtFeedingInterval.Name = "txtFeedingInterval";
            this.txtFeedingInterval.ReadOnly = true;
            this.txtFeedingInterval.Size = new System.Drawing.Size(200, 26);
            this.txtFeedingInterval.TabIndex = 18;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(130, 346);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(200, 35);
            this.btnAddAnimal.TabIndex = 19;
            this.btnAddAnimal.Text = "Add New Animal";
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // tabZone
            // 
            this.tabZone.Controls.Add(this.label1);
            this.tabZone.Controls.Add(this.listView3);
            this.tabZone.Controls.Add(this.listView2);
            this.tabZone.Controls.Add(this.listView1);
            this.tabZone.Controls.Add(this.lblZonez);
            this.tabZone.Controls.Add(this.lblEnclosurez);
            this.tabZone.Controls.Add(this.btnAddZone);
            this.tabZone.Location = new System.Drawing.Point(4, 22);
            this.tabZone.Name = "tabZone";
            this.tabZone.Padding = new System.Windows.Forms.Padding(3);
            this.tabZone.Size = new System.Drawing.Size(352, 614);
            this.tabZone.TabIndex = 2;
            this.tabZone.Text = "Zone";
            this.tabZone.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Animal :";
            // 
            // listView3
            // 
            this.listView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(8, 291);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(338, 256);
            this.listView3.TabIndex = 18;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 39);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(340, 97);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 165);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 97);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblZonez
            // 
            this.lblZonez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonez.Location = new System.Drawing.Point(6, 12);
            this.lblZonez.Name = "lblZonez";
            this.lblZonez.Size = new System.Drawing.Size(78, 23);
            this.lblZonez.TabIndex = 11;
            this.lblZonez.Text = "Zone:";
            // 
            // lblEnclosurez
            // 
            this.lblEnclosurez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnclosurez.Location = new System.Drawing.Point(8, 139);
            this.lblEnclosurez.Name = "lblEnclosurez";
            this.lblEnclosurez.Size = new System.Drawing.Size(100, 23);
            this.lblEnclosurez.TabIndex = 9;
            this.lblEnclosurez.Text = "Enclosure:";
            // 
            // btnAddZone
            // 
            this.btnAddZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddZone.Location = new System.Drawing.Point(28, 571);
            this.btnAddZone.Name = "btnAddZone";
            this.btnAddZone.Size = new System.Drawing.Size(280, 35);
            this.btnAddZone.TabIndex = 15;
            this.btnAddZone.Text = "Add New Zone";
            this.btnAddZone.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "ZOO APP";
            this.tabControlMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabAnimal.ResumeLayout(false);
            this.tabAnimal.PerformLayout();
            this.tabZone.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAnimal;
        private System.Windows.Forms.TabPage tabZone;

        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.ListView lvQualifiedSpecies;
        private System.Windows.Forms.ListView lvCaredAnimals;
        private System.Windows.Forms.ListView lvFeedRecords;
        private System.Windows.Forms.ListView lvCareRecords;
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.Button btnAddCare;

        private System.Windows.Forms.Label lblAnimalTitle;
        private System.Windows.Forms.Label lblSelectAnimal;
        private System.Windows.Forms.ComboBox cbSelectAnimal;

        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblAGE;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblEnclosure;
        private System.Windows.Forms.TextBox txtEnclosure;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label lblLastFed;
        private System.Windows.Forms.TextBox txtLastFed;
        private System.Windows.Forms.Label lblLastCare;
        private System.Windows.Forms.TextBox txtLastCare;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtFeedingInterval;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Label lblZonez;
        private System.Windows.Forms.Label lblEnclosurez;
        private System.Windows.Forms.Button btnAddZone;
        private ListView listView3;
        private ListView listView2;
        private ListView listView1;
        private Label label1;
    }
}
