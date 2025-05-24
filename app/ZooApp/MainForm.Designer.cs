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
            this.components = new System.ComponentModel.Container();
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
            this.txtFeedingInterval = new System.Windows.Forms.TextBox();
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.tabPageEnclosure = new System.Windows.Forms.TabPage();
            this.vScrollBar_Enclosure = new System.Windows.Forms.VScrollBar();
            this.panel_Enclosure_Animals = new System.Windows.Forms.Panel();
            this.button_Enclosure_Search = new System.Windows.Forms.Button();
            this.comboBox_Enclosure_Search = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Enclosure_Search = new System.Windows.Forms.TextBox();
            this.tabZone = new System.Windows.Forms.TabPage();
            this.panelZone6 = new System.Windows.Forms.Panel();
            this.labelZoneAnimalsAttention6 = new System.Windows.Forms.Label();
            this.buttonSelectZone6 = new System.Windows.Forms.Button();
            this.labelZoneName6 = new System.Windows.Forms.Label();
            this.panelZone5 = new System.Windows.Forms.Panel();
            this.labelZoneAnimalsAttention5 = new System.Windows.Forms.Label();
            this.buttonSelectZone5 = new System.Windows.Forms.Button();
            this.labelZoneName5 = new System.Windows.Forms.Label();
            this.panelZone4 = new System.Windows.Forms.Panel();
            this.labelZoneAnimalsAttention4 = new System.Windows.Forms.Label();
            this.buttonSelectZone4 = new System.Windows.Forms.Button();
            this.labelZoneName4 = new System.Windows.Forms.Label();
            this.panelZone3 = new System.Windows.Forms.Panel();
            this.labelZoneAnimalsAttention3 = new System.Windows.Forms.Label();
            this.buttonSelectZone3 = new System.Windows.Forms.Button();
            this.labelZoneName3 = new System.Windows.Forms.Label();
            this.panelZone2 = new System.Windows.Forms.Panel();
            this.labelZoneAnimalsAttention2 = new System.Windows.Forms.Label();
            this.buttonSelectZone2 = new System.Windows.Forms.Button();
            this.labelZoneName2 = new System.Windows.Forms.Label();
            this.labelZonePage = new System.Windows.Forms.Label();
            this.numericUpDownZonePage = new System.Windows.Forms.NumericUpDown();
            this.buttonZoneSearch = new System.Windows.Forms.Button();
            this.labelZoneSearch = new System.Windows.Forms.Label();
            this.textBoxZoneSearch = new System.Windows.Forms.TextBox();
            this.panelZone1 = new System.Windows.Forms.Panel();
            this.labelZoneAnimalsAttention1 = new System.Windows.Forms.Label();
            this.buttonSelectZone1 = new System.Windows.Forms.Button();
            this.labelZoneName1 = new System.Windows.Forms.Label();
            this.btnAddZone = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_feedGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_selectAllFeed = new System.Windows.Forms.Button();
            this.button_selectNoneFeed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panelZone6.SuspendLayout();
            this.panelZone5.SuspendLayout();
            this.panelZone4.SuspendLayout();
            this.panelZone3.SuspendLayout();
            this.panelZone2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZonePage)).BeginInit();
            this.panelZone1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(480, 788);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblStaffName);
            this.tabHome.Controls.Add(this.groupBoxTODO);
            this.tabHome.Controls.Add(this.lblStaffNameWelcome);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHome.Size = new System.Drawing.Size(472, 759);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStaffName.Location = new System.Drawing.Point(8, 4);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(440, 37);
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
            this.groupBoxTODO.Location = new System.Drawing.Point(4, 44);
            this.groupBoxTODO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTODO.Name = "groupBoxTODO";
            this.groupBoxTODO.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTODO.Size = new System.Drawing.Size(455, 702);
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
            this.panel_home_feeding5.Location = new System.Drawing.Point(8, 580);
            this.panel_home_feeding5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_home_feeding5.Name = "panel_home_feeding5";
            this.panel_home_feeding5.Size = new System.Drawing.Size(433, 105);
            this.panel_home_feeding5.TabIndex = 6;
            // 
            // lbl_home_timeSinceFeed5
            // 
            this.lbl_home_timeSinceFeed5.AutoSize = true;
            this.lbl_home_timeSinceFeed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed5.Location = new System.Drawing.Point(129, 52);
            this.lbl_home_timeSinceFeed5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_timeSinceFeed5.Name = "lbl_home_timeSinceFeed5";
            this.lbl_home_timeSinceFeed5.Size = new System.Drawing.Size(108, 39);
            this.lbl_home_timeSinceFeed5.TabIndex = 5;
            this.lbl_home_timeSinceFeed5.Text = "24Hrs";
            this.lbl_home_timeSinceFeed5.Visible = false;
            // 
            // lbl_home_f5
            // 
            this.lbl_home_f5.AutoSize = true;
            this.lbl_home_f5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f5.Location = new System.Drawing.Point(4, 52);
            this.lbl_home_f5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_f5.Name = "lbl_home_f5";
            this.lbl_home_f5.Size = new System.Drawing.Size(94, 25);
            this.lbl_home_f5.TabIndex = 4;
            this.lbl_home_f5.Text = "Last Fed:";
            this.lbl_home_f5.Visible = false;
            // 
            // lbl_home_animalSpecies5
            // 
            this.lbl_home_animalSpecies5.AutoSize = true;
            this.lbl_home_animalSpecies5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies5.Location = new System.Drawing.Point(4, 30);
            this.lbl_home_animalSpecies5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalSpecies5.Name = "lbl_home_animalSpecies5";
            this.lbl_home_animalSpecies5.Size = new System.Drawing.Size(310, 24);
            this.lbl_home_animalSpecies5.TabIndex = 2;
            this.lbl_home_animalSpecies5.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies5.Visible = false;
            // 
            // lbl_home_animalName5
            // 
            this.lbl_home_animalName5.AutoSize = true;
            this.lbl_home_animalName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName5.Location = new System.Drawing.Point(-3, 5);
            this.lbl_home_animalName5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalName5.Name = "lbl_home_animalName5";
            this.lbl_home_animalName5.Size = new System.Drawing.Size(372, 25);
            this.lbl_home_animalName5.TabIndex = 1;
            this.lbl_home_animalName5.Text = "123456789123456789123456789123";
            this.lbl_home_animalName5.Visible = false;
            // 
            // btn_home_feed5
            // 
            this.btn_home_feed5.Location = new System.Drawing.Point(328, 33);
            this.btn_home_feed5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home_feed5.Name = "btn_home_feed5";
            this.btn_home_feed5.Size = new System.Drawing.Size(101, 68);
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
            this.panel_home_feeding4.Location = new System.Drawing.Point(7, 468);
            this.panel_home_feeding4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_home_feeding4.Name = "panel_home_feeding4";
            this.panel_home_feeding4.Size = new System.Drawing.Size(433, 105);
            this.panel_home_feeding4.TabIndex = 5;
            // 
            // lbl_home_timeSinceFeed4
            // 
            this.lbl_home_timeSinceFeed4.AutoSize = true;
            this.lbl_home_timeSinceFeed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed4.Location = new System.Drawing.Point(131, 52);
            this.lbl_home_timeSinceFeed4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_timeSinceFeed4.Name = "lbl_home_timeSinceFeed4";
            this.lbl_home_timeSinceFeed4.Size = new System.Drawing.Size(108, 39);
            this.lbl_home_timeSinceFeed4.TabIndex = 5;
            this.lbl_home_timeSinceFeed4.Text = "24Hrs";
            this.lbl_home_timeSinceFeed4.Visible = false;
            // 
            // lbl_home_f4
            // 
            this.lbl_home_f4.AutoSize = true;
            this.lbl_home_f4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f4.Location = new System.Drawing.Point(7, 52);
            this.lbl_home_f4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_f4.Name = "lbl_home_f4";
            this.lbl_home_f4.Size = new System.Drawing.Size(94, 25);
            this.lbl_home_f4.TabIndex = 4;
            this.lbl_home_f4.Text = "Last Fed:";
            this.lbl_home_f4.Visible = false;
            // 
            // lbl_home_animalSpecies4
            // 
            this.lbl_home_animalSpecies4.AutoSize = true;
            this.lbl_home_animalSpecies4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies4.Location = new System.Drawing.Point(4, 30);
            this.lbl_home_animalSpecies4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalSpecies4.Name = "lbl_home_animalSpecies4";
            this.lbl_home_animalSpecies4.Size = new System.Drawing.Size(310, 24);
            this.lbl_home_animalSpecies4.TabIndex = 2;
            this.lbl_home_animalSpecies4.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies4.Visible = false;
            // 
            // lbl_home_animalName4
            // 
            this.lbl_home_animalName4.AutoSize = true;
            this.lbl_home_animalName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName4.Location = new System.Drawing.Point(-3, 5);
            this.lbl_home_animalName4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalName4.Name = "lbl_home_animalName4";
            this.lbl_home_animalName4.Size = new System.Drawing.Size(372, 25);
            this.lbl_home_animalName4.TabIndex = 1;
            this.lbl_home_animalName4.Text = "123456789123456789123456789123";
            this.lbl_home_animalName4.Visible = false;
            // 
            // btn_home_feed4
            // 
            this.btn_home_feed4.Location = new System.Drawing.Point(328, 33);
            this.btn_home_feed4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home_feed4.Name = "btn_home_feed4";
            this.btn_home_feed4.Size = new System.Drawing.Size(101, 68);
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
            this.panel_home_feeding3.Location = new System.Drawing.Point(8, 356);
            this.panel_home_feeding3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_home_feeding3.Name = "panel_home_feeding3";
            this.panel_home_feeding3.Size = new System.Drawing.Size(433, 105);
            this.panel_home_feeding3.TabIndex = 4;
            // 
            // lbl_home_timeSinceFeed3
            // 
            this.lbl_home_timeSinceFeed3.AutoSize = true;
            this.lbl_home_timeSinceFeed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed3.Location = new System.Drawing.Point(129, 52);
            this.lbl_home_timeSinceFeed3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_timeSinceFeed3.Name = "lbl_home_timeSinceFeed3";
            this.lbl_home_timeSinceFeed3.Size = new System.Drawing.Size(108, 39);
            this.lbl_home_timeSinceFeed3.TabIndex = 5;
            this.lbl_home_timeSinceFeed3.Text = "24Hrs";
            this.lbl_home_timeSinceFeed3.Visible = false;
            // 
            // lbl_home_f3
            // 
            this.lbl_home_f3.AutoSize = true;
            this.lbl_home_f3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f3.Location = new System.Drawing.Point(7, 52);
            this.lbl_home_f3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_f3.Name = "lbl_home_f3";
            this.lbl_home_f3.Size = new System.Drawing.Size(94, 25);
            this.lbl_home_f3.TabIndex = 4;
            this.lbl_home_f3.Text = "Last Fed:";
            this.lbl_home_f3.Visible = false;
            // 
            // lbl_home_animalSpecies3
            // 
            this.lbl_home_animalSpecies3.AutoSize = true;
            this.lbl_home_animalSpecies3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies3.Location = new System.Drawing.Point(4, 30);
            this.lbl_home_animalSpecies3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalSpecies3.Name = "lbl_home_animalSpecies3";
            this.lbl_home_animalSpecies3.Size = new System.Drawing.Size(310, 24);
            this.lbl_home_animalSpecies3.TabIndex = 2;
            this.lbl_home_animalSpecies3.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies3.Visible = false;
            // 
            // lbl_home_animalName3
            // 
            this.lbl_home_animalName3.AutoSize = true;
            this.lbl_home_animalName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName3.Location = new System.Drawing.Point(-3, 5);
            this.lbl_home_animalName3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalName3.Name = "lbl_home_animalName3";
            this.lbl_home_animalName3.Size = new System.Drawing.Size(372, 25);
            this.lbl_home_animalName3.TabIndex = 1;
            this.lbl_home_animalName3.Text = "123456789123456789123456789123";
            this.lbl_home_animalName3.Visible = false;
            // 
            // btn_home_feed3
            // 
            this.btn_home_feed3.Location = new System.Drawing.Point(328, 33);
            this.btn_home_feed3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home_feed3.Name = "btn_home_feed3";
            this.btn_home_feed3.Size = new System.Drawing.Size(101, 68);
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
            this.panel_home_feeding2.Location = new System.Drawing.Point(8, 244);
            this.panel_home_feeding2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_home_feeding2.Name = "panel_home_feeding2";
            this.panel_home_feeding2.Size = new System.Drawing.Size(433, 105);
            this.panel_home_feeding2.TabIndex = 3;
            // 
            // lbl_home_timeSinceFeed2
            // 
            this.lbl_home_timeSinceFeed2.AutoSize = true;
            this.lbl_home_timeSinceFeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed2.Location = new System.Drawing.Point(129, 52);
            this.lbl_home_timeSinceFeed2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_timeSinceFeed2.Name = "lbl_home_timeSinceFeed2";
            this.lbl_home_timeSinceFeed2.Size = new System.Drawing.Size(108, 39);
            this.lbl_home_timeSinceFeed2.TabIndex = 5;
            this.lbl_home_timeSinceFeed2.Text = "24Hrs";
            this.lbl_home_timeSinceFeed2.Visible = false;
            // 
            // lbl_home_f2
            // 
            this.lbl_home_f2.AutoSize = true;
            this.lbl_home_f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f2.Location = new System.Drawing.Point(7, 52);
            this.lbl_home_f2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_f2.Name = "lbl_home_f2";
            this.lbl_home_f2.Size = new System.Drawing.Size(94, 25);
            this.lbl_home_f2.TabIndex = 4;
            this.lbl_home_f2.Text = "Last Fed:";
            this.lbl_home_f2.Visible = false;
            // 
            // lbl_home_animalSpecies2
            // 
            this.lbl_home_animalSpecies2.AutoSize = true;
            this.lbl_home_animalSpecies2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies2.Location = new System.Drawing.Point(4, 30);
            this.lbl_home_animalSpecies2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalSpecies2.Name = "lbl_home_animalSpecies2";
            this.lbl_home_animalSpecies2.Size = new System.Drawing.Size(310, 24);
            this.lbl_home_animalSpecies2.TabIndex = 2;
            this.lbl_home_animalSpecies2.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies2.Visible = false;
            // 
            // lbl_home_animalName2
            // 
            this.lbl_home_animalName2.AutoSize = true;
            this.lbl_home_animalName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName2.Location = new System.Drawing.Point(-3, 5);
            this.lbl_home_animalName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalName2.Name = "lbl_home_animalName2";
            this.lbl_home_animalName2.Size = new System.Drawing.Size(372, 25);
            this.lbl_home_animalName2.TabIndex = 1;
            this.lbl_home_animalName2.Text = "123456789123456789123456789123";
            this.lbl_home_animalName2.Visible = false;
            // 
            // btn_home_feed2
            // 
            this.btn_home_feed2.Location = new System.Drawing.Point(328, 33);
            this.btn_home_feed2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home_feed2.Name = "btn_home_feed2";
            this.btn_home_feed2.Size = new System.Drawing.Size(101, 68);
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
            this.panel_home_feeding1.Location = new System.Drawing.Point(8, 135);
            this.panel_home_feeding1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_home_feeding1.Name = "panel_home_feeding1";
            this.panel_home_feeding1.Size = new System.Drawing.Size(433, 105);
            this.panel_home_feeding1.TabIndex = 2;
            // 
            // lbl_home_timeSinceFeed1
            // 
            this.lbl_home_timeSinceFeed1.AutoSize = true;
            this.lbl_home_timeSinceFeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed1.Location = new System.Drawing.Point(129, 53);
            this.lbl_home_timeSinceFeed1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_timeSinceFeed1.Name = "lbl_home_timeSinceFeed1";
            this.lbl_home_timeSinceFeed1.Size = new System.Drawing.Size(108, 39);
            this.lbl_home_timeSinceFeed1.TabIndex = 5;
            this.lbl_home_timeSinceFeed1.Text = "24Hrs";
            this.lbl_home_timeSinceFeed1.Visible = false;
            // 
            // lbl_home_f1
            // 
            this.lbl_home_f1.AutoSize = true;
            this.lbl_home_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f1.Location = new System.Drawing.Point(7, 53);
            this.lbl_home_f1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_f1.Name = "lbl_home_f1";
            this.lbl_home_f1.Size = new System.Drawing.Size(94, 25);
            this.lbl_home_f1.TabIndex = 4;
            this.lbl_home_f1.Text = "Last Fed:";
            this.lbl_home_f1.Visible = false;
            // 
            // lbl_home_animalSpecies1
            // 
            this.lbl_home_animalSpecies1.AutoSize = true;
            this.lbl_home_animalSpecies1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies1.Location = new System.Drawing.Point(4, 30);
            this.lbl_home_animalSpecies1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalSpecies1.Name = "lbl_home_animalSpecies1";
            this.lbl_home_animalSpecies1.Size = new System.Drawing.Size(310, 24);
            this.lbl_home_animalSpecies1.TabIndex = 2;
            this.lbl_home_animalSpecies1.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies1.Visible = false;
            // 
            // lbl_home_animalName1
            // 
            this.lbl_home_animalName1.AutoSize = true;
            this.lbl_home_animalName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName1.Location = new System.Drawing.Point(-3, 5);
            this.lbl_home_animalName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalName1.Name = "lbl_home_animalName1";
            this.lbl_home_animalName1.Size = new System.Drawing.Size(372, 25);
            this.lbl_home_animalName1.TabIndex = 1;
            this.lbl_home_animalName1.Text = "123456789123456789123456789123";
            this.lbl_home_animalName1.Visible = false;
            // 
            // btn_home_feed1
            // 
            this.btn_home_feed1.Location = new System.Drawing.Point(328, 33);
            this.btn_home_feed1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home_feed1.Name = "btn_home_feed1";
            this.btn_home_feed1.Size = new System.Drawing.Size(101, 68);
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
            this.panel_home_feeding0.Location = new System.Drawing.Point(8, 23);
            this.panel_home_feeding0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_home_feeding0.Name = "panel_home_feeding0";
            this.panel_home_feeding0.Size = new System.Drawing.Size(433, 105);
            this.panel_home_feeding0.TabIndex = 1;
            // 
            // lbl_home_timeSinceFeed0
            // 
            this.lbl_home_timeSinceFeed0.AutoSize = true;
            this.lbl_home_timeSinceFeed0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_timeSinceFeed0.Location = new System.Drawing.Point(129, 52);
            this.lbl_home_timeSinceFeed0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_timeSinceFeed0.Name = "lbl_home_timeSinceFeed0";
            this.lbl_home_timeSinceFeed0.Size = new System.Drawing.Size(108, 39);
            this.lbl_home_timeSinceFeed0.TabIndex = 5;
            this.lbl_home_timeSinceFeed0.Text = "24Hrs";
            this.lbl_home_timeSinceFeed0.Visible = false;
            // 
            // lbl_home_f0
            // 
            this.lbl_home_f0.AutoSize = true;
            this.lbl_home_f0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_f0.Location = new System.Drawing.Point(7, 52);
            this.lbl_home_f0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_f0.Name = "lbl_home_f0";
            this.lbl_home_f0.Size = new System.Drawing.Size(94, 25);
            this.lbl_home_f0.TabIndex = 4;
            this.lbl_home_f0.Text = "Last Fed:";
            this.lbl_home_f0.Visible = false;
            // 
            // lbl_home_animalSpecies0
            // 
            this.lbl_home_animalSpecies0.AutoSize = true;
            this.lbl_home_animalSpecies0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalSpecies0.Location = new System.Drawing.Point(4, 30);
            this.lbl_home_animalSpecies0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalSpecies0.Name = "lbl_home_animalSpecies0";
            this.lbl_home_animalSpecies0.Size = new System.Drawing.Size(310, 24);
            this.lbl_home_animalSpecies0.TabIndex = 2;
            this.lbl_home_animalSpecies0.Text = "123456789123456789123456789123";
            this.lbl_home_animalSpecies0.Visible = false;
            // 
            // lbl_home_animalName0
            // 
            this.lbl_home_animalName0.AutoSize = true;
            this.lbl_home_animalName0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_animalName0.Location = new System.Drawing.Point(-3, 5);
            this.lbl_home_animalName0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_animalName0.Name = "lbl_home_animalName0";
            this.lbl_home_animalName0.Size = new System.Drawing.Size(372, 25);
            this.lbl_home_animalName0.TabIndex = 1;
            this.lbl_home_animalName0.Text = "123456789123456789123456789123";
            this.lbl_home_animalName0.Visible = false;
            // 
            // btn_home_feed0
            // 
            this.btn_home_feed0.Location = new System.Drawing.Point(328, 33);
            this.btn_home_feed0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_home_feed0.Name = "btn_home_feed0";
            this.btn_home_feed0.Size = new System.Drawing.Size(101, 68);
            this.btn_home_feed0.TabIndex = 0;
            this.btn_home_feed0.Tag = "";
            this.btn_home_feed0.Text = "Feed";
            this.btn_home_feed0.UseVisualStyleBackColor = true;
            this.btn_home_feed0.Visible = false;
            // 
            // lblStaffNameWelcome
            // 
            this.lblStaffNameWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblStaffNameWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffNameWelcome.Name = "lblStaffNameWelcome";
            this.lblStaffNameWelcome.Size = new System.Drawing.Size(133, 28);
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
            this.tabAnimal.Location = new System.Drawing.Point(4, 25);
            this.tabAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAnimal.Name = "tabAnimal";
            this.tabAnimal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAnimal.Size = new System.Drawing.Size(472, 759);
            this.tabAnimal.TabIndex = 1;
            this.tabAnimal.Text = "Animal";
            this.tabAnimal.UseVisualStyleBackColor = true;
            // 
            // txtFeedingInterval
            // 
            this.txtFeedingInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedingInterval.Location = new System.Drawing.Point(173, 369);
            this.txtFeedingInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFeedingInterval.Name = "txtFeedingInterval";
            this.txtFeedingInterval.ReadOnly = true;
            this.txtFeedingInterval.Size = new System.Drawing.Size(265, 30);
            this.txtFeedingInterval.TabIndex = 18;
            // 
            // lblAnimalTitle
            // 
            this.lblAnimalTitle.AutoSize = true;
            this.lblAnimalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAnimalTitle.Location = new System.Drawing.Point(116, 12);
            this.lblAnimalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalTitle.Name = "lblAnimalTitle";
            this.lblAnimalTitle.Size = new System.Drawing.Size(240, 32);
            this.lblAnimalTitle.TabIndex = 0;
            this.lblAnimalTitle.Text = "Animal Information";
            // 
            // lblSelectAnimal
            // 
            this.lblSelectAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAnimal.Location = new System.Drawing.Point(11, 65);
            this.lblSelectAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectAnimal.Name = "lblSelectAnimal";
            this.lblSelectAnimal.Size = new System.Drawing.Size(133, 28);
            this.lblSelectAnimal.TabIndex = 1;
            this.lblSelectAnimal.Text = "Select Animal:";
            // 
            // cbSelectAnimal
            // 
            this.cbSelectAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAnimal.Location = new System.Drawing.Point(173, 59);
            this.cbSelectAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelectAnimal.Name = "cbSelectAnimal";
            this.cbSelectAnimal.Size = new System.Drawing.Size(265, 33);
            this.cbSelectAnimal.TabIndex = 2;
            this.cbSelectAnimal.SelectedIndexChanged += new System.EventHandler(this.cbSelectAnimal_SelectedIndexChanged);
            // 
            // lblSpecies
            // 
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(8, 114);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(133, 28);
            this.lblSpecies.TabIndex = 3;
            this.lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(173, 111);
            this.txtSpecies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.ReadOnly = true;
            this.txtSpecies.Size = new System.Drawing.Size(265, 30);
            this.txtSpecies.TabIndex = 4;
            // 
            // lblAGE
            // 
            this.lblAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAGE.Location = new System.Drawing.Point(8, 148);
            this.lblAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAGE.Name = "lblAGE";
            this.lblAGE.Size = new System.Drawing.Size(152, 28);
            this.lblAGE.TabIndex = 5;
            this.lblAGE.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(173, 148);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(265, 30);
            this.txtAge.TabIndex = 6;
            // 
            // lblSex
            // 
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(8, 188);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(133, 28);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex:";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(173, 185);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(265, 30);
            this.txtSex.TabIndex = 8;
            // 
            // lblEnclosure
            // 
            this.lblEnclosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnclosure.Location = new System.Drawing.Point(8, 229);
            this.lblEnclosure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnclosure.Name = "lblEnclosure";
            this.lblEnclosure.Size = new System.Drawing.Size(107, 25);
            this.lblEnclosure.TabIndex = 9;
            this.lblEnclosure.Text = "Enclosure:";
            // 
            // txtEnclosure
            // 
            this.txtEnclosure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnclosure.Location = new System.Drawing.Point(173, 222);
            this.txtEnclosure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnclosure.Name = "txtEnclosure";
            this.txtEnclosure.ReadOnly = true;
            this.txtEnclosure.Size = new System.Drawing.Size(265, 30);
            this.txtEnclosure.TabIndex = 10;
            // 
            // lblZone
            // 
            this.lblZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(8, 266);
            this.lblZone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(107, 25);
            this.lblZone.TabIndex = 11;
            this.lblZone.Text = "Zone:";
            // 
            // txtZone
            // 
            this.txtZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZone.Location = new System.Drawing.Point(173, 258);
            this.txtZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZone.Name = "txtZone";
            this.txtZone.ReadOnly = true;
            this.txtZone.Size = new System.Drawing.Size(265, 30);
            this.txtZone.TabIndex = 12;
            // 
            // lblLastFed
            // 
            this.lblLastFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFed.Location = new System.Drawing.Point(8, 299);
            this.lblLastFed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastFed.Name = "lblLastFed";
            this.lblLastFed.Size = new System.Drawing.Size(133, 28);
            this.lblLastFed.TabIndex = 13;
            this.lblLastFed.Text = "Last Fed:";
            // 
            // txtLastFed
            // 
            this.txtLastFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastFed.Location = new System.Drawing.Point(173, 295);
            this.txtLastFed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastFed.Name = "txtLastFed";
            this.txtLastFed.ReadOnly = true;
            this.txtLastFed.Size = new System.Drawing.Size(265, 30);
            this.txtLastFed.TabIndex = 14;
            // 
            // lblLastCare
            // 
            this.lblLastCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCare.Location = new System.Drawing.Point(8, 336);
            this.lblLastCare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastCare.Name = "lblLastCare";
            this.lblLastCare.Size = new System.Drawing.Size(133, 28);
            this.lblLastCare.TabIndex = 15;
            this.lblLastCare.Text = "Last Cared:";
            // 
            // txtLastCare
            // 
            this.txtLastCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastCare.Location = new System.Drawing.Point(173, 332);
            this.txtLastCare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastCare.Name = "txtLastCare";
            this.txtLastCare.ReadOnly = true;
            this.txtLastCare.Size = new System.Drawing.Size(265, 30);
            this.txtLastCare.TabIndex = 16;
            // 
            // lblInterval
            // 
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(8, 373);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(173, 28);
            this.lblInterval.TabIndex = 17;
            this.lblInterval.Text = "Feeding Interval:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(173, 426);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(267, 43);
            this.btnAddAnimal.TabIndex = 19;
            this.btnAddAnimal.Text = "Add New Animal";
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // tabPageEnclosure
            // 
            this.tabPageEnclosure.Controls.Add(this.label3);
            this.tabPageEnclosure.Controls.Add(this.button_selectAllFeed);
            this.tabPageEnclosure.Controls.Add(this.button_selectNoneFeed);
            this.tabPageEnclosure.Controls.Add(this.label1);
            this.tabPageEnclosure.Controls.Add(this.button_feedGroup);
            this.tabPageEnclosure.Controls.Add(this.vScrollBar_Enclosure);
            this.tabPageEnclosure.Controls.Add(this.panel_Enclosure_Animals);
            this.tabPageEnclosure.Controls.Add(this.button_Enclosure_Search);
            this.tabPageEnclosure.Controls.Add(this.comboBox_Enclosure_Search);
            this.tabPageEnclosure.Controls.Add(this.label2);
            this.tabPageEnclosure.Controls.Add(this.textBox_Enclosure_Search);
            this.tabPageEnclosure.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnclosure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageEnclosure.Name = "tabPageEnclosure";
            this.tabPageEnclosure.Size = new System.Drawing.Size(472, 759);
            this.tabPageEnclosure.TabIndex = 3;
            this.tabPageEnclosure.Text = "Enclosure";
            this.tabPageEnclosure.UseVisualStyleBackColor = true;
            // 
            // vScrollBar_Enclosure
            // 
            this.vScrollBar_Enclosure.Location = new System.Drawing.Point(429, 162);
            this.vScrollBar_Enclosure.Name = "vScrollBar_Enclosure";
            this.vScrollBar_Enclosure.Size = new System.Drawing.Size(25, 587);
            this.vScrollBar_Enclosure.TabIndex = 6;
            this.vScrollBar_Enclosure.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Enclosure_Scroll);
            // 
            // panel_Enclosure_Animals
            // 
            this.panel_Enclosure_Animals.Location = new System.Drawing.Point(5, 162);
            this.panel_Enclosure_Animals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Enclosure_Animals.Name = "panel_Enclosure_Animals";
            this.panel_Enclosure_Animals.Size = new System.Drawing.Size(420, 590);
            this.panel_Enclosure_Animals.TabIndex = 5;
            this.panel_Enclosure_Animals.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_Enclosure_Animals_ControlAdded);
            this.panel_Enclosure_Animals.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_Enclosure_Animals_ControlRemoved);
            // 
            // button_Enclosure_Search
            // 
            this.button_Enclosure_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enclosure_Search.Location = new System.Drawing.Point(367, 42);
            this.button_Enclosure_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Enclosure_Search.Name = "button_Enclosure_Search";
            this.button_Enclosure_Search.Size = new System.Drawing.Size(91, 32);
            this.button_Enclosure_Search.TabIndex = 3;
            this.button_Enclosure_Search.Text = "Find";
            this.button_Enclosure_Search.UseVisualStyleBackColor = true;
            // 
            // comboBox_Enclosure_Search
            // 
            this.comboBox_Enclosure_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Enclosure_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Enclosure_Search.FormattingEnabled = true;
            this.comboBox_Enclosure_Search.Location = new System.Drawing.Point(11, 81);
            this.comboBox_Enclosure_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Enclosure_Search.Name = "comboBox_Enclosure_Search";
            this.comboBox_Enclosure_Search.Size = new System.Drawing.Size(445, 33);
            this.comboBox_Enclosure_Search.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find An Enclosure:";
            // 
            // textBox_Enclosure_Search
            // 
            this.textBox_Enclosure_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Enclosure_Search.Location = new System.Drawing.Point(11, 42);
            this.textBox_Enclosure_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Enclosure_Search.Name = "textBox_Enclosure_Search";
            this.textBox_Enclosure_Search.Size = new System.Drawing.Size(345, 30);
            this.textBox_Enclosure_Search.TabIndex = 0;
            // 
            // tabZone
            // 
            this.tabZone.Controls.Add(this.panelZone6);
            this.tabZone.Controls.Add(this.panelZone5);
            this.tabZone.Controls.Add(this.panelZone4);
            this.tabZone.Controls.Add(this.panelZone3);
            this.tabZone.Controls.Add(this.panelZone2);
            this.tabZone.Controls.Add(this.labelZonePage);
            this.tabZone.Controls.Add(this.numericUpDownZonePage);
            this.tabZone.Controls.Add(this.buttonZoneSearch);
            this.tabZone.Controls.Add(this.labelZoneSearch);
            this.tabZone.Controls.Add(this.textBoxZoneSearch);
            this.tabZone.Controls.Add(this.panelZone1);
            this.tabZone.Controls.Add(this.btnAddZone);
            this.tabZone.Location = new System.Drawing.Point(4, 25);
            this.tabZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabZone.Name = "tabZone";
            this.tabZone.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabZone.Size = new System.Drawing.Size(472, 759);
            this.tabZone.TabIndex = 2;
            this.tabZone.Text = "Zone";
            this.tabZone.UseVisualStyleBackColor = true;
            // 
            // panelZone6
            // 
            this.panelZone6.Controls.Add(this.labelZoneAnimalsAttention6);
            this.panelZone6.Controls.Add(this.buttonSelectZone6);
            this.panelZone6.Controls.Add(this.labelZoneName6);
            this.panelZone6.Location = new System.Drawing.Point(8, 543);
            this.panelZone6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZone6.Name = "panelZone6";
            this.panelZone6.Size = new System.Drawing.Size(453, 87);
            this.panelZone6.TabIndex = 21;
            // 
            // labelZoneAnimalsAttention6
            // 
            this.labelZoneAnimalsAttention6.AutoSize = true;
            this.labelZoneAnimalsAttention6.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneAnimalsAttention6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneAnimalsAttention6.Location = new System.Drawing.Point(7, 52);
            this.labelZoneAnimalsAttention6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneAnimalsAttention6.Name = "labelZoneAnimalsAttention6";
            this.labelZoneAnimalsAttention6.Size = new System.Drawing.Size(333, 25);
            this.labelZoneAnimalsAttention6.TabIndex = 2;
            this.labelZoneAnimalsAttention6.Text = "X ANIMALS NEEDING ATTENTION";
            // 
            // buttonSelectZone6
            // 
            this.buttonSelectZone6.Location = new System.Drawing.Point(349, 6);
            this.buttonSelectZone6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectZone6.Name = "buttonSelectZone6";
            this.buttonSelectZone6.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectZone6.TabIndex = 1;
            this.buttonSelectZone6.Text = "Select";
            this.buttonSelectZone6.UseVisualStyleBackColor = true;
            this.buttonSelectZone6.Click += new System.EventHandler(this.btnSelectZone_Click);
            // 
            // labelZoneName6
            // 
            this.labelZoneName6.AutoSize = true;
            this.labelZoneName6.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneName6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName6.Location = new System.Drawing.Point(7, 5);
            this.labelZoneName6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneName6.Name = "labelZoneName6";
            this.labelZoneName6.Size = new System.Drawing.Size(157, 29);
            this.labelZoneName6.TabIndex = 0;
            this.labelZoneName6.Text = "ZONENAME";
            // 
            // panelZone5
            // 
            this.panelZone5.Controls.Add(this.labelZoneAnimalsAttention5);
            this.panelZone5.Controls.Add(this.buttonSelectZone5);
            this.panelZone5.Controls.Add(this.labelZoneName5);
            this.panelZone5.Location = new System.Drawing.Point(8, 448);
            this.panelZone5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZone5.Name = "panelZone5";
            this.panelZone5.Size = new System.Drawing.Size(453, 87);
            this.panelZone5.TabIndex = 20;
            // 
            // labelZoneAnimalsAttention5
            // 
            this.labelZoneAnimalsAttention5.AutoSize = true;
            this.labelZoneAnimalsAttention5.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneAnimalsAttention5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneAnimalsAttention5.Location = new System.Drawing.Point(7, 52);
            this.labelZoneAnimalsAttention5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneAnimalsAttention5.Name = "labelZoneAnimalsAttention5";
            this.labelZoneAnimalsAttention5.Size = new System.Drawing.Size(333, 25);
            this.labelZoneAnimalsAttention5.TabIndex = 2;
            this.labelZoneAnimalsAttention5.Text = "X ANIMALS NEEDING ATTENTION";
            // 
            // buttonSelectZone5
            // 
            this.buttonSelectZone5.Location = new System.Drawing.Point(349, 6);
            this.buttonSelectZone5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectZone5.Name = "buttonSelectZone5";
            this.buttonSelectZone5.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectZone5.TabIndex = 1;
            this.buttonSelectZone5.Text = "Select";
            this.buttonSelectZone5.UseVisualStyleBackColor = true;
            this.buttonSelectZone5.Click += new System.EventHandler(this.btnSelectZone_Click);
            // 
            // labelZoneName5
            // 
            this.labelZoneName5.AutoSize = true;
            this.labelZoneName5.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName5.Location = new System.Drawing.Point(7, 5);
            this.labelZoneName5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneName5.Name = "labelZoneName5";
            this.labelZoneName5.Size = new System.Drawing.Size(157, 29);
            this.labelZoneName5.TabIndex = 0;
            this.labelZoneName5.Text = "ZONENAME";
            // 
            // panelZone4
            // 
            this.panelZone4.Controls.Add(this.labelZoneAnimalsAttention4);
            this.panelZone4.Controls.Add(this.buttonSelectZone4);
            this.panelZone4.Controls.Add(this.labelZoneName4);
            this.panelZone4.Location = new System.Drawing.Point(8, 353);
            this.panelZone4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZone4.Name = "panelZone4";
            this.panelZone4.Size = new System.Drawing.Size(453, 87);
            this.panelZone4.TabIndex = 19;
            // 
            // labelZoneAnimalsAttention4
            // 
            this.labelZoneAnimalsAttention4.AutoSize = true;
            this.labelZoneAnimalsAttention4.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneAnimalsAttention4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneAnimalsAttention4.Location = new System.Drawing.Point(7, 52);
            this.labelZoneAnimalsAttention4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneAnimalsAttention4.Name = "labelZoneAnimalsAttention4";
            this.labelZoneAnimalsAttention4.Size = new System.Drawing.Size(333, 25);
            this.labelZoneAnimalsAttention4.TabIndex = 2;
            this.labelZoneAnimalsAttention4.Text = "X ANIMALS NEEDING ATTENTION";
            // 
            // buttonSelectZone4
            // 
            this.buttonSelectZone4.Location = new System.Drawing.Point(349, 6);
            this.buttonSelectZone4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectZone4.Name = "buttonSelectZone4";
            this.buttonSelectZone4.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectZone4.TabIndex = 1;
            this.buttonSelectZone4.Text = "Select";
            this.buttonSelectZone4.UseVisualStyleBackColor = true;
            this.buttonSelectZone4.Click += new System.EventHandler(this.btnSelectZone_Click);
            // 
            // labelZoneName4
            // 
            this.labelZoneName4.AutoSize = true;
            this.labelZoneName4.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName4.Location = new System.Drawing.Point(7, 5);
            this.labelZoneName4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneName4.Name = "labelZoneName4";
            this.labelZoneName4.Size = new System.Drawing.Size(157, 29);
            this.labelZoneName4.TabIndex = 0;
            this.labelZoneName4.Text = "ZONENAME";
            // 
            // panelZone3
            // 
            this.panelZone3.Controls.Add(this.labelZoneAnimalsAttention3);
            this.panelZone3.Controls.Add(this.buttonSelectZone3);
            this.panelZone3.Controls.Add(this.labelZoneName3);
            this.panelZone3.Location = new System.Drawing.Point(8, 258);
            this.panelZone3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZone3.Name = "panelZone3";
            this.panelZone3.Size = new System.Drawing.Size(453, 87);
            this.panelZone3.TabIndex = 18;
            // 
            // labelZoneAnimalsAttention3
            // 
            this.labelZoneAnimalsAttention3.AutoSize = true;
            this.labelZoneAnimalsAttention3.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneAnimalsAttention3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneAnimalsAttention3.Location = new System.Drawing.Point(7, 52);
            this.labelZoneAnimalsAttention3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneAnimalsAttention3.Name = "labelZoneAnimalsAttention3";
            this.labelZoneAnimalsAttention3.Size = new System.Drawing.Size(333, 25);
            this.labelZoneAnimalsAttention3.TabIndex = 2;
            this.labelZoneAnimalsAttention3.Text = "X ANIMALS NEEDING ATTENTION";
            // 
            // buttonSelectZone3
            // 
            this.buttonSelectZone3.Location = new System.Drawing.Point(349, 6);
            this.buttonSelectZone3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectZone3.Name = "buttonSelectZone3";
            this.buttonSelectZone3.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectZone3.TabIndex = 1;
            this.buttonSelectZone3.Text = "Select";
            this.buttonSelectZone3.UseVisualStyleBackColor = true;
            this.buttonSelectZone3.Click += new System.EventHandler(this.btnSelectZone_Click);
            // 
            // labelZoneName3
            // 
            this.labelZoneName3.AutoSize = true;
            this.labelZoneName3.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName3.Location = new System.Drawing.Point(7, 5);
            this.labelZoneName3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneName3.Name = "labelZoneName3";
            this.labelZoneName3.Size = new System.Drawing.Size(157, 29);
            this.labelZoneName3.TabIndex = 0;
            this.labelZoneName3.Text = "ZONENAME";
            // 
            // panelZone2
            // 
            this.panelZone2.Controls.Add(this.labelZoneAnimalsAttention2);
            this.panelZone2.Controls.Add(this.buttonSelectZone2);
            this.panelZone2.Controls.Add(this.labelZoneName2);
            this.panelZone2.Location = new System.Drawing.Point(8, 164);
            this.panelZone2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZone2.Name = "panelZone2";
            this.panelZone2.Size = new System.Drawing.Size(453, 87);
            this.panelZone2.TabIndex = 17;
            // 
            // labelZoneAnimalsAttention2
            // 
            this.labelZoneAnimalsAttention2.AutoSize = true;
            this.labelZoneAnimalsAttention2.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneAnimalsAttention2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneAnimalsAttention2.Location = new System.Drawing.Point(7, 52);
            this.labelZoneAnimalsAttention2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneAnimalsAttention2.Name = "labelZoneAnimalsAttention2";
            this.labelZoneAnimalsAttention2.Size = new System.Drawing.Size(333, 25);
            this.labelZoneAnimalsAttention2.TabIndex = 2;
            this.labelZoneAnimalsAttention2.Text = "X ANIMALS NEEDING ATTENTION";
            // 
            // buttonSelectZone2
            // 
            this.buttonSelectZone2.Location = new System.Drawing.Point(349, 6);
            this.buttonSelectZone2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectZone2.Name = "buttonSelectZone2";
            this.buttonSelectZone2.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectZone2.TabIndex = 1;
            this.buttonSelectZone2.Text = "Select";
            this.buttonSelectZone2.UseVisualStyleBackColor = true;
            this.buttonSelectZone2.Click += new System.EventHandler(this.btnSelectZone_Click);
            // 
            // labelZoneName2
            // 
            this.labelZoneName2.AutoSize = true;
            this.labelZoneName2.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName2.Location = new System.Drawing.Point(7, 5);
            this.labelZoneName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneName2.Name = "labelZoneName2";
            this.labelZoneName2.Size = new System.Drawing.Size(157, 29);
            this.labelZoneName2.TabIndex = 0;
            this.labelZoneName2.Text = "ZONENAME";
            // 
            // labelZonePage
            // 
            this.labelZonePage.AutoSize = true;
            this.labelZonePage.Location = new System.Drawing.Point(16, 39);
            this.labelZonePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZonePage.Name = "labelZonePage";
            this.labelZonePage.Size = new System.Drawing.Size(94, 16);
            this.labelZonePage.TabIndex = 21;
            this.labelZonePage.Text = "Page Number:";
            // 
            // numericUpDownZonePage
            // 
            this.numericUpDownZonePage.Location = new System.Drawing.Point(175, 37);
            this.numericUpDownZonePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownZonePage.Name = "numericUpDownZonePage";
            this.numericUpDownZonePage.Size = new System.Drawing.Size(76, 22);
            this.numericUpDownZonePage.TabIndex = 20;
            // 
            // buttonZoneSearch
            // 
            this.buttonZoneSearch.Location = new System.Drawing.Point(361, 4);
            this.buttonZoneSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZoneSearch.Name = "buttonZoneSearch";
            this.buttonZoneSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonZoneSearch.TabIndex = 19;
            this.buttonZoneSearch.Text = "Search";
            this.buttonZoneSearch.UseVisualStyleBackColor = true;
            // 
            // labelZoneSearch
            // 
            this.labelZoneSearch.AutoSize = true;
            this.labelZoneSearch.Location = new System.Drawing.Point(11, 11);
            this.labelZoneSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneSearch.Name = "labelZoneSearch";
            this.labelZoneSearch.Size = new System.Drawing.Size(145, 16);
            this.labelZoneSearch.TabIndex = 18;
            this.labelZoneSearch.Text = "Search Zone by Name:";
            // 
            // textBoxZoneSearch
            // 
            this.textBoxZoneSearch.Location = new System.Drawing.Point(175, 7);
            this.textBoxZoneSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxZoneSearch.Name = "textBoxZoneSearch";
            this.textBoxZoneSearch.Size = new System.Drawing.Size(132, 22);
            this.textBoxZoneSearch.TabIndex = 17;
            // 
            // panelZone1
            // 
            this.panelZone1.Controls.Add(this.labelZoneAnimalsAttention1);
            this.panelZone1.Controls.Add(this.buttonSelectZone1);
            this.panelZone1.Controls.Add(this.labelZoneName1);
            this.panelZone1.Location = new System.Drawing.Point(8, 69);
            this.panelZone1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZone1.Name = "panelZone1";
            this.panelZone1.Size = new System.Drawing.Size(453, 87);
            this.panelZone1.TabIndex = 16;
            // 
            // labelZoneAnimalsAttention1
            // 
            this.labelZoneAnimalsAttention1.AutoSize = true;
            this.labelZoneAnimalsAttention1.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneAnimalsAttention1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneAnimalsAttention1.Location = new System.Drawing.Point(7, 52);
            this.labelZoneAnimalsAttention1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneAnimalsAttention1.Name = "labelZoneAnimalsAttention1";
            this.labelZoneAnimalsAttention1.Size = new System.Drawing.Size(333, 25);
            this.labelZoneAnimalsAttention1.TabIndex = 2;
            this.labelZoneAnimalsAttention1.Text = "X ANIMALS NEEDING ATTENTION";
            // 
            // buttonSelectZone1
            // 
            this.buttonSelectZone1.Location = new System.Drawing.Point(349, 6);
            this.buttonSelectZone1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectZone1.Name = "buttonSelectZone1";
            this.buttonSelectZone1.Size = new System.Drawing.Size(100, 28);
            this.buttonSelectZone1.TabIndex = 1;
            this.buttonSelectZone1.Text = "Select";
            this.buttonSelectZone1.UseVisualStyleBackColor = true;
            this.buttonSelectZone1.Click += new System.EventHandler(this.btnSelectZone_Click);
            // 
            // labelZoneName1
            // 
            this.labelZoneName1.AutoSize = true;
            this.labelZoneName1.BackColor = System.Drawing.Color.Gainsboro;
            this.labelZoneName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName1.Location = new System.Drawing.Point(7, 5);
            this.labelZoneName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoneName1.Name = "labelZoneName1";
            this.labelZoneName1.Size = new System.Drawing.Size(157, 29);
            this.labelZoneName1.TabIndex = 0;
            this.labelZoneName1.Text = "ZONENAME";
            // 
            // btnAddZone
            // 
            this.btnAddZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddZone.Location = new System.Drawing.Point(37, 703);
            this.btnAddZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddZone.Name = "btnAddZone";
            this.btnAddZone.Size = new System.Drawing.Size(373, 43);
            this.btnAddZone.TabIndex = 15;
            this.btnAddZone.Text = "Add New Zone";
            this.btnAddZone.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button_feedGroup
            // 
            this.button_feedGroup.Enabled = false;
            this.button_feedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_feedGroup.Location = new System.Drawing.Point(363, 126);
            this.button_feedGroup.Margin = new System.Windows.Forms.Padding(4);
            this.button_feedGroup.Name = "button_feedGroup";
            this.button_feedGroup.Size = new System.Drawing.Size(91, 32);
            this.button_feedGroup.TabIndex = 7;
            this.button_feedGroup.Text = "Feed";
            this.button_feedGroup.UseVisualStyleBackColor = true;
            this.button_feedGroup.Click += new System.EventHandler(this.button_feedGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Animals:";
            // 
            // button_selectAllFeed
            // 
            this.button_selectAllFeed.Enabled = false;
            this.button_selectAllFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectAllFeed.Location = new System.Drawing.Point(199, 129);
            this.button_selectAllFeed.Margin = new System.Windows.Forms.Padding(4);
            this.button_selectAllFeed.Name = "button_selectAllFeed";
            this.button_selectAllFeed.Size = new System.Drawing.Size(74, 32);
            this.button_selectAllFeed.TabIndex = 9;
            this.button_selectAllFeed.Text = "All";
            this.button_selectAllFeed.UseVisualStyleBackColor = true;
            this.button_selectAllFeed.Click += new System.EventHandler(this.button_selectAllFeed_Click);
            // 
            // button_selectNoneFeed
            // 
            this.button_selectNoneFeed.Enabled = false;
            this.button_selectNoneFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectNoneFeed.Location = new System.Drawing.Point(281, 129);
            this.button_selectNoneFeed.Margin = new System.Windows.Forms.Padding(4);
            this.button_selectNoneFeed.Name = "button_selectNoneFeed";
            this.button_selectNoneFeed.Size = new System.Drawing.Size(74, 32);
            this.button_selectNoneFeed.TabIndex = 10;
            this.button_selectNoneFeed.Text = "None";
            this.button_selectNoneFeed.UseVisualStyleBackColor = true;
            this.button_selectNoneFeed.Click += new System.EventHandler(this.button_selectNoneFeed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 788);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tabZone.PerformLayout();
            this.panelZone6.ResumeLayout(false);
            this.panelZone6.PerformLayout();
            this.panelZone5.ResumeLayout(false);
            this.panelZone5.PerformLayout();
            this.panelZone4.ResumeLayout(false);
            this.panelZone4.PerformLayout();
            this.panelZone3.ResumeLayout(false);
            this.panelZone3.PerformLayout();
            this.panelZone2.ResumeLayout(false);
            this.panelZone2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZonePage)).EndInit();
            this.panelZone1.ResumeLayout(false);
            this.panelZone1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button btnAddZone;
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
        private Button button_Enclosure_Search;
        private ComboBox comboBox_Enclosure_Search;
        private Label label2;
        private TextBox textBox_Enclosure_Search;
        private Button buttonZoneSearch;
        private Label labelZoneSearch;
        private TextBox textBoxZoneSearch;
        private Label labelZonePage;
        private NumericUpDown numericUpDownZonePage;
        private Panel panelZone1;
        private Label labelZoneAnimalsAttention1;
        private Button buttonSelectZone1;
        private Label labelZoneName1;
        private Panel panelZone6;
        private Label labelZoneAnimalsAttention6;
        private Button buttonSelectZone6;
        private Label labelZoneName6;
        private Panel panelZone5;
        private Label labelZoneAnimalsAttention5;
        private Button buttonSelectZone5;
        private Label labelZoneName5;
        private Panel panelZone4;
        private Label labelZoneAnimalsAttention4;
        private Button buttonSelectZone4;
        private Label labelZoneName4;
        private Panel panelZone3;
        private Label labelZoneAnimalsAttention3;
        private Button buttonSelectZone3;
        private Label labelZoneName3;
        private Panel panelZone2;
        private Label labelZoneAnimalsAttention2;
        private Button buttonSelectZone2;
        private Label labelZoneName2;
        private Panel panel_Enclosure_Animals;
        private VScrollBar vScrollBar_Enclosure;
        private BindingSource bindingSource1;
        private Label label1;
        private Button button_feedGroup;
        private Label label3;
        private Button button_selectAllFeed;
        private Button button_selectNoneFeed;
    }
}
