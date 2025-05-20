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
            this.groupBoxTODO = new System.Windows.Forms.GroupBox();
            this.panel_home_feeding5 = new System.Windows.Forms.Panel();
            this.lbl_home_timeSinceFeed5 = new System.Windows.Forms.Label();
            this.lbl_home_f5 = new System.Windows.Forms.Label();
            this.lbl_home_animalSpecies5 = new System.Windows.Forms.Label();
            this.lbl_home_animalName5 = new System.Windows.Forms.Label();
            this.btn_home_feed5 = new System.Windows.Forms.Button();
            this.panel_home_feeding4 = new System.Windows.Forms.Panel();
            this.lbl_home_timeSinceFeed4 = new System.Windows.Forms.Label();
            this.lbl_home_f4 = new System.Windows.Forms.Label();
            this.lbl_home_animalSpecies4 = new System.Windows.Forms.Label();
            this.lbl_home_animalName4 = new System.Windows.Forms.Label();
            this.btn_home_feed4 = new System.Windows.Forms.Button();
            this.panel_home_feeding3 = new System.Windows.Forms.Panel();
            this.lbl_home_timeSinceFeed3 = new System.Windows.Forms.Label();
            this.lbl_home_f3 = new System.Windows.Forms.Label();
            this.lbl_home_animalSpecies3 = new System.Windows.Forms.Label();
            this.lbl_home_animalName3 = new System.Windows.Forms.Label();
            this.btn_home_feed3 = new System.Windows.Forms.Button();
            this.panel_home_feeding2 = new System.Windows.Forms.Panel();
            this.lbl_home_timeSinceFeed2 = new System.Windows.Forms.Label();
            this.lbl_home_f2 = new System.Windows.Forms.Label();
            this.lbl_home_animalSpecies2 = new System.Windows.Forms.Label();
            this.lbl_home_animalName2 = new System.Windows.Forms.Label();
            this.btn_home_feed2 = new System.Windows.Forms.Button();
            this.panel_home_feeding1 = new System.Windows.Forms.Panel();
            this.lbl_home_timeSinceFeed1 = new System.Windows.Forms.Label();
            this.lbl_home_f1 = new System.Windows.Forms.Label();
            this.lbl_home_animalSpecies1 = new System.Windows.Forms.Label();
            this.lbl_home_animalName1 = new System.Windows.Forms.Label();
            this.btn_home_feed1 = new System.Windows.Forms.Button();
            this.panel_home_feeding0 = new System.Windows.Forms.Panel();
            this.lbl_home_timeSinceFeed0 = new System.Windows.Forms.Label();
            this.lbl_home_f0 = new System.Windows.Forms.Label();
            this.lbl_home_animalSpecies0 = new System.Windows.Forms.Label();
            this.lbl_home_animalName0 = new System.Windows.Forms.Label();
            this.btn_home_feed0 = new System.Windows.Forms.Button();
            this.lblStaffNameWelcome = new System.Windows.Forms.Label();
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
            this.tabPageEnclosure = new System.Windows.Forms.TabPage();
            this.label_Enclosure_Output = new System.Windows.Forms.Label();
            this.button_Enclosure_Search = new System.Windows.Forms.Button();
            this.comboBox_Enclosure_Search = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Enclosure_Search = new System.Windows.Forms.TextBox();
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
            this.groupBoxTODO.SuspendLayout();
            this.panel_home_feeding5.SuspendLayout();
            this.panel_home_feeding4.SuspendLayout();
            this.panel_home_feeding3.SuspendLayout();
            this.panel_home_feeding2.SuspendLayout();
            this.panel_home_feeding1.SuspendLayout();
            this.panel_home_feeding0.SuspendLayout();
            this.tabAnimal.SuspendLayout();
            this.tabPageEnclosure.SuspendLayout();
            this.tabZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabHome);
            this.tabControlMain.Controls.Add(this.tabAnimal);
            this.tabControlMain.Controls.Add(this.tabPageEnclosure);
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
            this.tabHome.Controls.Add(this.groupBoxTODO);
            this.tabHome.Controls.Add(this.lblStaffNameWelcome);
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
            this.lblStaffName.Location = new System.Drawing.Point(6, 3);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(330, 30);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Welcome, [Staff Name]";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxTODO
            // 
            this.groupBoxTODO.Controls.Add(this.panel_home_feeding5);
            this.groupBoxTODO.Controls.Add(this.panel_home_feeding4);
            this.groupBoxTODO.Controls.Add(this.panel_home_feeding3);
            this.groupBoxTODO.Controls.Add(this.panel_home_feeding2);
            this.groupBoxTODO.Controls.Add(this.panel_home_feeding1);
            this.groupBoxTODO.Controls.Add(this.panel_home_feeding0);
            this.groupBoxTODO.Location = new System.Drawing.Point(3, 36);
            this.groupBoxTODO.Name = "groupBoxTODO";
            this.groupBoxTODO.Size = new System.Drawing.Size(341, 570);
            this.groupBoxTODO.TabIndex = 1;
            this.groupBoxTODO.TabStop = false;
            this.groupBoxTODO.Text = "TODO";
            // 
            // panel_home_feeding5
            // 
            this.panel_home_feeding5.Controls.Add(this.lbl_home_timeSinceFeed5);
            this.panel_home_feeding5.Controls.Add(this.lbl_home_f5);
            this.panel_home_feeding5.Controls.Add(this.lbl_home_animalSpecies5);
            this.panel_home_feeding5.Controls.Add(this.lbl_home_animalName5);
            this.panel_home_feeding5.Controls.Add(this.btn_home_feed5);
            this.panel_home_feeding5.Location = new System.Drawing.Point(6, 471);
            this.panel_home_feeding5.Name = "panel_home_feeding5";
            this.panel_home_feeding5.Size = new System.Drawing.Size(325, 85);
            this.panel_home_feeding5.TabIndex = 6;
            // 
            // lbl_home_timeSinceFeed5
            // 
            this.lbl_home_timeSinceFeed5.AutoSize = true;
            this.lbl_home_timeSinceFeed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed5.Location = new System.Drawing.Point(97, 42);
            this.lbl_home_timeSinceFeed5.Name = "lbl_home_timeSinceFeed5";
            this.lbl_home_timeSinceFeed5.Size = new System.Drawing.Size(87, 31);
            this.lbl_home_timeSinceFeed5.TabIndex = 5;
            this.lbl_home_timeSinceFeed5.Text = "24Hrs";
            this.lbl_home_timeSinceFeed5.Visible = false;
            // 
            // lbl_home_f5
            // 
            this.lbl_home_f5.AutoSize = true;
            this.lbl_home_f5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f5.Location = new System.Drawing.Point(3, 42);
            this.lbl_home_f5.Name = "lbl_home_f5";
            this.lbl_home_f5.Size = new System.Drawing.Size(76, 20);
            this.lbl_home_f5.TabIndex = 4;
            this.lbl_home_f5.Text = "Last Fed:";
            this.lbl_home_f5.Visible = false;
            // 
            // lbl_home_animalSpecies5
            // 
            this.lbl_home_animalSpecies5.AutoSize = true;
            this.lbl_home_animalSpecies5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies5.Location = new System.Drawing.Point(3, 24);
            this.lbl_home_animalSpecies5.Name = "lbl_home_animalSpecies5";
            this.lbl_home_animalSpecies5.Size = new System.Drawing.Size(248, 18);
            this.lbl_home_animalSpecies5.TabIndex = 2;
            this.lbl_home_animalSpecies5.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies5.Visible = false;
            // 
            // lbl_home_animalName5
            // 
            this.lbl_home_animalName5.AutoSize = true;
            this.lbl_home_animalName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName5.Location = new System.Drawing.Point(-2, 4);
            this.lbl_home_animalName5.Name = "lbl_home_animalName5";
            this.lbl_home_animalName5.Size = new System.Drawing.Size(309, 20);
            this.lbl_home_animalName5.TabIndex = 1;
            this.lbl_home_animalName5.Text = "123456789123456789123456789123";
            this.lbl_home_animalName5.Visible = false;
            // 
            // btn_home_feed5
            // 
            this.btn_home_feed5.Location = new System.Drawing.Point(246, 27);
            this.btn_home_feed5.Name = "btn_home_feed5";
            this.btn_home_feed5.Size = new System.Drawing.Size(76, 55);
            this.btn_home_feed5.TabIndex = 0;
            this.btn_home_feed5.Text = "Feed";
            this.btn_home_feed5.UseVisualStyleBackColor = true;
            this.btn_home_feed5.Visible = false;
            // 
            // panel_home_feeding4
            // 
            this.panel_home_feeding4.Controls.Add(this.lbl_home_timeSinceFeed4);
            this.panel_home_feeding4.Controls.Add(this.lbl_home_f4);
            this.panel_home_feeding4.Controls.Add(this.lbl_home_animalSpecies4);
            this.panel_home_feeding4.Controls.Add(this.lbl_home_animalName4);
            this.panel_home_feeding4.Controls.Add(this.btn_home_feed4);
            this.panel_home_feeding4.Location = new System.Drawing.Point(5, 380);
            this.panel_home_feeding4.Name = "panel_home_feeding4";
            this.panel_home_feeding4.Size = new System.Drawing.Size(325, 85);
            this.panel_home_feeding4.TabIndex = 5;
            // 
            // lbl_home_timeSinceFeed4
            // 
            this.lbl_home_timeSinceFeed4.AutoSize = true;
            this.lbl_home_timeSinceFeed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed4.Location = new System.Drawing.Point(98, 42);
            this.lbl_home_timeSinceFeed4.Name = "lbl_home_timeSinceFeed4";
            this.lbl_home_timeSinceFeed4.Size = new System.Drawing.Size(87, 31);
            this.lbl_home_timeSinceFeed4.TabIndex = 5;
            this.lbl_home_timeSinceFeed4.Text = "24Hrs";
            this.lbl_home_timeSinceFeed4.Visible = false;
            // 
            // lbl_home_f4
            // 
            this.lbl_home_f4.AutoSize = true;
            this.lbl_home_f4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f4.Location = new System.Drawing.Point(5, 42);
            this.lbl_home_f4.Name = "lbl_home_f4";
            this.lbl_home_f4.Size = new System.Drawing.Size(76, 20);
            this.lbl_home_f4.TabIndex = 4;
            this.lbl_home_f4.Text = "Last Fed:";
            this.lbl_home_f4.Visible = false;
            // 
            // lbl_home_animalSpecies4
            // 
            this.lbl_home_animalSpecies4.AutoSize = true;
            this.lbl_home_animalSpecies4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies4.Location = new System.Drawing.Point(3, 24);
            this.lbl_home_animalSpecies4.Name = "lbl_home_animalSpecies4";
            this.lbl_home_animalSpecies4.Size = new System.Drawing.Size(248, 18);
            this.lbl_home_animalSpecies4.TabIndex = 2;
            this.lbl_home_animalSpecies4.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies4.Visible = false;
            // 
            // lbl_home_animalName4
            // 
            this.lbl_home_animalName4.AutoSize = true;
            this.lbl_home_animalName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName4.Location = new System.Drawing.Point(-2, 4);
            this.lbl_home_animalName4.Name = "lbl_home_animalName4";
            this.lbl_home_animalName4.Size = new System.Drawing.Size(309, 20);
            this.lbl_home_animalName4.TabIndex = 1;
            this.lbl_home_animalName4.Text = "123456789123456789123456789123";
            this.lbl_home_animalName4.Visible = false;
            // 
            // btn_home_feed4
            // 
            this.btn_home_feed4.Location = new System.Drawing.Point(246, 27);
            this.btn_home_feed4.Name = "btn_home_feed4";
            this.btn_home_feed4.Size = new System.Drawing.Size(76, 55);
            this.btn_home_feed4.TabIndex = 0;
            this.btn_home_feed4.Text = "Feed";
            this.btn_home_feed4.UseVisualStyleBackColor = true;
            this.btn_home_feed4.Visible = false;
            // 
            // panel_home_feeding3
            // 
            this.panel_home_feeding3.Controls.Add(this.lbl_home_timeSinceFeed3);
            this.panel_home_feeding3.Controls.Add(this.lbl_home_f3);
            this.panel_home_feeding3.Controls.Add(this.lbl_home_animalSpecies3);
            this.panel_home_feeding3.Controls.Add(this.lbl_home_animalName3);
            this.panel_home_feeding3.Controls.Add(this.btn_home_feed3);
            this.panel_home_feeding3.Location = new System.Drawing.Point(6, 289);
            this.panel_home_feeding3.Name = "panel_home_feeding3";
            this.panel_home_feeding3.Size = new System.Drawing.Size(325, 85);
            this.panel_home_feeding3.TabIndex = 4;
            // 
            // lbl_home_timeSinceFeed3
            // 
            this.lbl_home_timeSinceFeed3.AutoSize = true;
            this.lbl_home_timeSinceFeed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed3.Location = new System.Drawing.Point(97, 42);
            this.lbl_home_timeSinceFeed3.Name = "lbl_home_timeSinceFeed3";
            this.lbl_home_timeSinceFeed3.Size = new System.Drawing.Size(87, 31);
            this.lbl_home_timeSinceFeed3.TabIndex = 5;
            this.lbl_home_timeSinceFeed3.Text = "24Hrs";
            this.lbl_home_timeSinceFeed3.Visible = false;
            // 
            // lbl_home_f3
            // 
            this.lbl_home_f3.AutoSize = true;
            this.lbl_home_f3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f3.Location = new System.Drawing.Point(5, 42);
            this.lbl_home_f3.Name = "lbl_home_f3";
            this.lbl_home_f3.Size = new System.Drawing.Size(76, 20);
            this.lbl_home_f3.TabIndex = 4;
            this.lbl_home_f3.Text = "Last Fed:";
            this.lbl_home_f3.Visible = false;
            // 
            // lbl_home_animalSpecies3
            // 
            this.lbl_home_animalSpecies3.AutoSize = true;
            this.lbl_home_animalSpecies3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies3.Location = new System.Drawing.Point(3, 24);
            this.lbl_home_animalSpecies3.Name = "lbl_home_animalSpecies3";
            this.lbl_home_animalSpecies3.Size = new System.Drawing.Size(248, 18);
            this.lbl_home_animalSpecies3.TabIndex = 2;
            this.lbl_home_animalSpecies3.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies3.Visible = false;
            // 
            // lbl_home_animalName3
            // 
            this.lbl_home_animalName3.AutoSize = true;
            this.lbl_home_animalName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName3.Location = new System.Drawing.Point(-2, 4);
            this.lbl_home_animalName3.Name = "lbl_home_animalName3";
            this.lbl_home_animalName3.Size = new System.Drawing.Size(309, 20);
            this.lbl_home_animalName3.TabIndex = 1;
            this.lbl_home_animalName3.Text = "123456789123456789123456789123";
            this.lbl_home_animalName3.Visible = false;
            // 
            // btn_home_feed3
            // 
            this.btn_home_feed3.Location = new System.Drawing.Point(246, 27);
            this.btn_home_feed3.Name = "btn_home_feed3";
            this.btn_home_feed3.Size = new System.Drawing.Size(76, 55);
            this.btn_home_feed3.TabIndex = 0;
            this.btn_home_feed3.Text = "Feed";
            this.btn_home_feed3.UseVisualStyleBackColor = true;
            this.btn_home_feed3.Visible = false;
            // 
            // panel_home_feeding2
            // 
            this.panel_home_feeding2.Controls.Add(this.lbl_home_timeSinceFeed2);
            this.panel_home_feeding2.Controls.Add(this.lbl_home_f2);
            this.panel_home_feeding2.Controls.Add(this.lbl_home_animalSpecies2);
            this.panel_home_feeding2.Controls.Add(this.lbl_home_animalName2);
            this.panel_home_feeding2.Controls.Add(this.btn_home_feed2);
            this.panel_home_feeding2.Location = new System.Drawing.Point(6, 198);
            this.panel_home_feeding2.Name = "panel_home_feeding2";
            this.panel_home_feeding2.Size = new System.Drawing.Size(325, 85);
            this.panel_home_feeding2.TabIndex = 3;
            // 
            // lbl_home_timeSinceFeed2
            // 
            this.lbl_home_timeSinceFeed2.AutoSize = true;
            this.lbl_home_timeSinceFeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed2.Location = new System.Drawing.Point(97, 42);
            this.lbl_home_timeSinceFeed2.Name = "lbl_home_timeSinceFeed2";
            this.lbl_home_timeSinceFeed2.Size = new System.Drawing.Size(87, 31);
            this.lbl_home_timeSinceFeed2.TabIndex = 5;
            this.lbl_home_timeSinceFeed2.Text = "24Hrs";
            this.lbl_home_timeSinceFeed2.Visible = false;
            // 
            // lbl_home_f2
            // 
            this.lbl_home_f2.AutoSize = true;
            this.lbl_home_f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f2.Location = new System.Drawing.Point(5, 42);
            this.lbl_home_f2.Name = "lbl_home_f2";
            this.lbl_home_f2.Size = new System.Drawing.Size(76, 20);
            this.lbl_home_f2.TabIndex = 4;
            this.lbl_home_f2.Text = "Last Fed:";
            this.lbl_home_f2.Visible = false;
            // 
            // lbl_home_animalSpecies2
            // 
            this.lbl_home_animalSpecies2.AutoSize = true;
            this.lbl_home_animalSpecies2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies2.Location = new System.Drawing.Point(3, 24);
            this.lbl_home_animalSpecies2.Name = "lbl_home_animalSpecies2";
            this.lbl_home_animalSpecies2.Size = new System.Drawing.Size(248, 18);
            this.lbl_home_animalSpecies2.TabIndex = 2;
            this.lbl_home_animalSpecies2.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies2.Visible = false;
            // 
            // lbl_home_animalName2
            // 
            this.lbl_home_animalName2.AutoSize = true;
            this.lbl_home_animalName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName2.Location = new System.Drawing.Point(-2, 4);
            this.lbl_home_animalName2.Name = "lbl_home_animalName2";
            this.lbl_home_animalName2.Size = new System.Drawing.Size(309, 20);
            this.lbl_home_animalName2.TabIndex = 1;
            this.lbl_home_animalName2.Text = "123456789123456789123456789123";
            this.lbl_home_animalName2.Visible = false;
            // 
            // btn_home_feed2
            // 
            this.btn_home_feed2.Location = new System.Drawing.Point(246, 27);
            this.btn_home_feed2.Name = "btn_home_feed2";
            this.btn_home_feed2.Size = new System.Drawing.Size(76, 55);
            this.btn_home_feed2.TabIndex = 0;
            this.btn_home_feed2.Text = "Feed";
            this.btn_home_feed2.UseVisualStyleBackColor = true;
            this.btn_home_feed2.Visible = false;
            // 
            // panel_home_feeding1
            // 
            this.panel_home_feeding1.Controls.Add(this.lbl_home_timeSinceFeed1);
            this.panel_home_feeding1.Controls.Add(this.lbl_home_f1);
            this.panel_home_feeding1.Controls.Add(this.lbl_home_animalSpecies1);
            this.panel_home_feeding1.Controls.Add(this.lbl_home_animalName1);
            this.panel_home_feeding1.Controls.Add(this.btn_home_feed1);
            this.panel_home_feeding1.Location = new System.Drawing.Point(6, 110);
            this.panel_home_feeding1.Name = "panel_home_feeding1";
            this.panel_home_feeding1.Size = new System.Drawing.Size(325, 85);
            this.panel_home_feeding1.TabIndex = 2;
            // 
            // lbl_home_timeSinceFeed1
            // 
            this.lbl_home_timeSinceFeed1.AutoSize = true;
            this.lbl_home_timeSinceFeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed1.Location = new System.Drawing.Point(97, 43);
            this.lbl_home_timeSinceFeed1.Name = "lbl_home_timeSinceFeed1";
            this.lbl_home_timeSinceFeed1.Size = new System.Drawing.Size(87, 31);
            this.lbl_home_timeSinceFeed1.TabIndex = 5;
            this.lbl_home_timeSinceFeed1.Text = "24Hrs";
            this.lbl_home_timeSinceFeed1.Visible = false;
            // 
            // lbl_home_f1
            // 
            this.lbl_home_f1.AutoSize = true;
            this.lbl_home_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f1.Location = new System.Drawing.Point(5, 43);
            this.lbl_home_f1.Name = "lbl_home_f1";
            this.lbl_home_f1.Size = new System.Drawing.Size(76, 20);
            this.lbl_home_f1.TabIndex = 4;
            this.lbl_home_f1.Text = "Last Fed:";
            this.lbl_home_f1.Visible = false;
            // 
            // lbl_home_animalSpecies1
            // 
            this.lbl_home_animalSpecies1.AutoSize = true;
            this.lbl_home_animalSpecies1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies1.Location = new System.Drawing.Point(3, 24);
            this.lbl_home_animalSpecies1.Name = "lbl_home_animalSpecies1";
            this.lbl_home_animalSpecies1.Size = new System.Drawing.Size(248, 18);
            this.lbl_home_animalSpecies1.TabIndex = 2;
            this.lbl_home_animalSpecies1.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies1.Visible = false;
            // 
            // lbl_home_animalName1
            // 
            this.lbl_home_animalName1.AutoSize = true;
            this.lbl_home_animalName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName1.Location = new System.Drawing.Point(-2, 4);
            this.lbl_home_animalName1.Name = "lbl_home_animalName1";
            this.lbl_home_animalName1.Size = new System.Drawing.Size(309, 20);
            this.lbl_home_animalName1.TabIndex = 1;
            this.lbl_home_animalName1.Text = "123456789123456789123456789123";
            this.lbl_home_animalName1.Visible = false;
            // 
            // btn_home_feed1
            // 
            this.btn_home_feed1.Location = new System.Drawing.Point(246, 27);
            this.btn_home_feed1.Name = "btn_home_feed1";
            this.btn_home_feed1.Size = new System.Drawing.Size(76, 55);
            this.btn_home_feed1.TabIndex = 0;
            this.btn_home_feed1.Text = "Feed";
            this.btn_home_feed1.UseVisualStyleBackColor = true;
            this.btn_home_feed1.Visible = false;
            // 
            // panel_home_feeding0
            // 
            this.panel_home_feeding0.Controls.Add(this.lbl_home_timeSinceFeed0);
            this.panel_home_feeding0.Controls.Add(this.lbl_home_f0);
            this.panel_home_feeding0.Controls.Add(this.lbl_home_animalSpecies0);
            this.panel_home_feeding0.Controls.Add(this.lbl_home_animalName0);
            this.panel_home_feeding0.Controls.Add(this.btn_home_feed0);
            this.panel_home_feeding0.Location = new System.Drawing.Point(6, 19);
            this.panel_home_feeding0.Name = "panel_home_feeding0";
            this.panel_home_feeding0.Size = new System.Drawing.Size(325, 85);
            this.panel_home_feeding0.TabIndex = 1;
            // 
            // lbl_home_timeSinceFeed0
            // 
            this.lbl_home_timeSinceFeed0.AutoSize = true;
            this.lbl_home_timeSinceFeed0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed0.Location = new System.Drawing.Point(97, 42);
            this.lbl_home_timeSinceFeed0.Name = "lbl_home_timeSinceFeed0";
            this.lbl_home_timeSinceFeed0.Size = new System.Drawing.Size(87, 31);
            this.lbl_home_timeSinceFeed0.TabIndex = 5;
            this.lbl_home_timeSinceFeed0.Text = "24Hrs";
            this.lbl_home_timeSinceFeed0.Visible = false;
            // 
            // lbl_home_f0
            // 
            this.lbl_home_f0.AutoSize = true;
            this.lbl_home_f0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f0.Location = new System.Drawing.Point(5, 42);
            this.lbl_home_f0.Name = "lbl_home_f0";
            this.lbl_home_f0.Size = new System.Drawing.Size(76, 20);
            this.lbl_home_f0.TabIndex = 4;
            this.lbl_home_f0.Text = "Last Fed:";
            this.lbl_home_f0.Visible = false;
            // 
            // lbl_home_animalSpecies0
            // 
            this.lbl_home_animalSpecies0.AutoSize = true;
            this.lbl_home_animalSpecies0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies0.Location = new System.Drawing.Point(3, 24);
            this.lbl_home_animalSpecies0.Name = "lbl_home_animalSpecies0";
            this.lbl_home_animalSpecies0.Size = new System.Drawing.Size(248, 18);
            this.lbl_home_animalSpecies0.TabIndex = 2;
            this.lbl_home_animalSpecies0.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies0.Visible = false;
            // 
            // lbl_home_animalName0
            // 
            this.lbl_home_animalName0.AutoSize = true;
            this.lbl_home_animalName0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName0.Location = new System.Drawing.Point(-2, 4);
            this.lbl_home_animalName0.Name = "lbl_home_animalName0";
            this.lbl_home_animalName0.Size = new System.Drawing.Size(309, 20);
            this.lbl_home_animalName0.TabIndex = 1;
            this.lbl_home_animalName0.Text = "123456789123456789123456789123";
            this.lbl_home_animalName0.Visible = false;
            // 
            // btn_home_feed0
            // 
            this.btn_home_feed0.Location = new System.Drawing.Point(246, 27);
            this.btn_home_feed0.Name = "btn_home_feed0";
            this.btn_home_feed0.Size = new System.Drawing.Size(76, 55);
            this.btn_home_feed0.TabIndex = 0;
            this.btn_home_feed0.Text = "Feed";
            this.btn_home_feed0.UseVisualStyleBackColor = true;
            this.btn_home_feed0.Visible = false;
            // 
            // lblStaffNameWelcome
            // 
            this.lblStaffNameWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblStaffNameWelcome.Name = "lblStaffNameWelcome";
            this.lblStaffNameWelcome.Size = new System.Drawing.Size(100, 23);
            this.lblStaffNameWelcome.TabIndex = 7;
            // 
            // tabAnimal
            // 
            this.tabAnimal.Controls.Add(this.txtFeedingInterval);
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
            this.lblInterval.Size = new System.Drawing.Size(130, 23);
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
            // tabPageEnclosure
            // 
            this.tabPageEnclosure.Controls.Add(this.label_Enclosure_Output);
            this.tabPageEnclosure.Controls.Add(this.button_Enclosure_Search);
            this.tabPageEnclosure.Controls.Add(this.comboBox_Enclosure_Search);
            this.tabPageEnclosure.Controls.Add(this.label2);
            this.tabPageEnclosure.Controls.Add(this.textBox_Enclosure_Search);
            this.tabPageEnclosure.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnclosure.Name = "tabPageEnclosure";
            this.tabPageEnclosure.Size = new System.Drawing.Size(352, 614);
            this.tabPageEnclosure.TabIndex = 3;
            this.tabPageEnclosure.Text = "Enclosure";
            this.tabPageEnclosure.UseVisualStyleBackColor = true;
            // 
            // label_Enclosure_Output
            // 
            this.label_Enclosure_Output.AutoSize = true;
            this.label_Enclosure_Output.Location = new System.Drawing.Point(12, 101);
            this.label_Enclosure_Output.Name = "label_Enclosure_Output";
            this.label_Enclosure_Output.Size = new System.Drawing.Size(80, 13);
            this.label_Enclosure_Output.TabIndex = 4;
            this.label_Enclosure_Output.Text = "Enclosure Data";
            // 
            // button_Enclosure_Search
            // 
            this.button_Enclosure_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enclosure_Search.Location = new System.Drawing.Point(275, 34);
            this.button_Enclosure_Search.Name = "button_Enclosure_Search";
            this.button_Enclosure_Search.Size = new System.Drawing.Size(68, 26);
            this.button_Enclosure_Search.TabIndex = 3;
            this.button_Enclosure_Search.Text = "Find";
            this.button_Enclosure_Search.UseVisualStyleBackColor = true;
            // 
            // comboBox_Enclosure_Search
            // 
            this.comboBox_Enclosure_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Enclosure_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Enclosure_Search.FormattingEnabled = true;
            this.comboBox_Enclosure_Search.Location = new System.Drawing.Point(8, 66);
            this.comboBox_Enclosure_Search.Name = "comboBox_Enclosure_Search";
            this.comboBox_Enclosure_Search.Size = new System.Drawing.Size(335, 28);
            this.comboBox_Enclosure_Search.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find An Enclosure:";
            // 
            // textBox_Enclosure_Search
            // 
            this.textBox_Enclosure_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Enclosure_Search.Location = new System.Drawing.Point(8, 34);
            this.textBox_Enclosure_Search.Name = "textBox_Enclosure_Search";
            this.textBox_Enclosure_Search.Size = new System.Drawing.Size(260, 26);
            this.textBox_Enclosure_Search.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.groupBoxTODO.ResumeLayout(false);
            this.panel_home_feeding5.ResumeLayout(false);
            this.panel_home_feeding5.PerformLayout();
            this.panel_home_feeding4.ResumeLayout(false);
            this.panel_home_feeding4.PerformLayout();
            this.panel_home_feeding3.ResumeLayout(false);
            this.panel_home_feeding3.PerformLayout();
            this.panel_home_feeding2.ResumeLayout(false);
            this.panel_home_feeding2.PerformLayout();
            this.panel_home_feeding1.ResumeLayout(false);
            this.panel_home_feeding1.PerformLayout();
            this.panel_home_feeding0.ResumeLayout(false);
            this.panel_home_feeding0.PerformLayout();
            this.tabAnimal.ResumeLayout(false);
            this.tabAnimal.PerformLayout();
            this.tabPageEnclosure.ResumeLayout(false);
            this.tabPageEnclosure.PerformLayout();
            this.tabZone.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAnimal;
        private System.Windows.Forms.TabPage tabZone;

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
        private TabPage tabHome;
        private Label lblStaffName;
        private GroupBox groupBoxTODO;
        private Label lblStaffNameWelcome;
        private Panel panel_home_feeding0;
        private Label lbl_home_f0;
        private Label lbl_home_animalSpecies0;
        private Label lbl_home_animalName0;
        private Button btn_home_feed0;
        private Label lbl_home_timeSinceFeed0;
        private Panel panel_home_feeding5;
        private Label lbl_home_timeSinceFeed5;
        private Label lbl_home_f5;
        private Label lbl_home_animalSpecies5;
        private Label lbl_home_animalName5;
        private Button btn_home_feed5;
        private Panel panel_home_feeding4;
        private Label lbl_home_timeSinceFeed4;
        private Label lbl_home_f4;
        private Label lbl_home_animalSpecies4;
        private Label lbl_home_animalName4;
        private Button btn_home_feed4;
        private Panel panel_home_feeding3;
        private Label lbl_home_timeSinceFeed3;
        private Label lbl_home_f3;
        private Label lbl_home_animalSpecies3;
        private Label lbl_home_animalName3;
        private Button btn_home_feed3;
        private Panel panel_home_feeding2;
        private Label lbl_home_timeSinceFeed2;
        private Label lbl_home_f2;
        private Label lbl_home_animalSpecies2;
        private Label lbl_home_animalName2;
        private Button btn_home_feed2;
        private Panel panel_home_feeding1;
        private Label lbl_home_timeSinceFeed1;
        private Label lbl_home_f1;
        private Label lbl_home_animalSpecies1;
        private Label lbl_home_animalName1;
        private Button btn_home_feed1;
        private TabPage tabPageEnclosure;
        private Label label_Enclosure_Output;
        private Button button_Enclosure_Search;
        private ComboBox comboBox_Enclosure_Search;
        private Label label2;
        private TextBox textBox_Enclosure_Search;
    }
}
