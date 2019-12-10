namespace LolStats
{
    partial class LoLStatsMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leagueBox = new System.Windows.Forms.ComboBox();
            this.divisionBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.summonerNameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statsBySummonerButton = new System.Windows.Forms.RadioButton();
            this.statsByLeagueButton = new System.Windows.Forms.RadioButton();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.averageGoldBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.averageCSBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.commonRoleBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.commonLaneBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.topChampsBox = new System.Windows.Forms.GroupBox();
            this.topChamp2 = new System.Windows.Forms.TextBox();
            this.jungleChamp2 = new System.Windows.Forms.TextBox();
            this.midChamp2 = new System.Windows.Forms.TextBox();
            this.supportChamp2 = new System.Windows.Forms.TextBox();
            this.carryChamp2 = new System.Windows.Forms.TextBox();
            this.carryChamp1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.supportChamp1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.midChamp1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jungleChamp1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.topChamp1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.top10Summoners = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterKeyHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.progressBarStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.topChampsBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "League";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Division";
            // 
            // leagueBox
            // 
            this.leagueBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leagueBox.FormattingEnabled = true;
            this.leagueBox.Items.AddRange(new object[] {
            "Challenger",
            "GrandMaster",
            "Master",
            "Diamond",
            "Platinum",
            "Gold",
            "Silver",
            "Bronze",
            "Iron"});
            this.leagueBox.Location = new System.Drawing.Point(6, 102);
            this.leagueBox.Name = "leagueBox";
            this.leagueBox.Size = new System.Drawing.Size(121, 21);
            this.leagueBox.TabIndex = 2;
            this.leagueBox.Text = "Challenger";
            // 
            // divisionBox
            // 
            this.divisionBox.FormattingEnabled = true;
            this.divisionBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.divisionBox.Location = new System.Drawing.Point(6, 155);
            this.divisionBox.Name = "divisionBox";
            this.divisionBox.Size = new System.Drawing.Size(121, 21);
            this.divisionBox.TabIndex = 3;
            this.divisionBox.Text = "I";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.summonerNameBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.statsBySummonerButton);
            this.groupBox1.Controls.Add(this.statsByLeagueButton);
            this.groupBox1.Controls.Add(this.regionBox);
            this.groupBox1.Controls.Add(this.leagueBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.divisionBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // summonerNameBox
            // 
            this.summonerNameBox.Enabled = false;
            this.summonerNameBox.Location = new System.Drawing.Point(6, 258);
            this.summonerNameBox.Name = "summonerNameBox";
            this.summonerNameBox.Size = new System.Drawing.Size(121, 20);
            this.summonerNameBox.TabIndex = 9;
            this.summonerNameBox.Text = "Puppetmaster909";
            this.summonerNameBox.TextChanged += new System.EventHandler(this.summonerNameBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Summoner Name";
            // 
            // statsBySummonerButton
            // 
            this.statsBySummonerButton.AutoSize = true;
            this.statsBySummonerButton.Location = new System.Drawing.Point(6, 58);
            this.statsBySummonerButton.Name = "statsBySummonerButton";
            this.statsBySummonerButton.Size = new System.Drawing.Size(116, 17);
            this.statsBySummonerButton.TabIndex = 7;
            this.statsBySummonerButton.Text = "Stats by Summoner";
            this.statsBySummonerButton.UseVisualStyleBackColor = true;
            this.statsBySummonerButton.CheckedChanged += new System.EventHandler(this.statsBySummonerButton_CheckedChanged);
            // 
            // statsByLeagueButton
            // 
            this.statsByLeagueButton.AutoSize = true;
            this.statsByLeagueButton.Checked = true;
            this.statsByLeagueButton.Location = new System.Drawing.Point(6, 30);
            this.statsByLeagueButton.Name = "statsByLeagueButton";
            this.statsByLeagueButton.Size = new System.Drawing.Size(102, 17);
            this.statsByLeagueButton.TabIndex = 6;
            this.statsByLeagueButton.TabStop = true;
            this.statsByLeagueButton.Text = "Stats by League";
            this.statsByLeagueButton.UseVisualStyleBackColor = true;
            this.statsByLeagueButton.CheckedChanged += new System.EventHandler(this.statsByLeagueButton_CheckedChanged);
            // 
            // regionBox
            // 
            this.regionBox.FormattingEnabled = true;
            this.regionBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.regionBox.Items.AddRange(new object[] {
            "NA1",
            "BR",
            "EUNE",
            "EUW",
            "JP",
            "KR",
            "OCE",
            "TR",
            "RU"});
            this.regionBox.Location = new System.Drawing.Point(6, 208);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(121, 21);
            this.regionBox.TabIndex = 5;
            this.regionBox.Text = "NA1";
            this.regionBox.SelectedIndexChanged += new System.EventHandler(this.regionBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Region";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.topChampsBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(190, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 410);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.averageGoldBox);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.averageCSBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.commonRoleBox);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.commonLaneBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(438, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 296);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Popular Data";
            // 
            // averageGoldBox
            // 
            this.averageGoldBox.Location = new System.Drawing.Point(9, 250);
            this.averageGoldBox.Name = "averageGoldBox";
            this.averageGoldBox.ReadOnly = true;
            this.averageGoldBox.Size = new System.Drawing.Size(145, 20);
            this.averageGoldBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Average Ending Gold";
            // 
            // averageCSBox
            // 
            this.averageCSBox.Location = new System.Drawing.Point(9, 173);
            this.averageCSBox.Name = "averageCSBox";
            this.averageCSBox.ReadOnly = true;
            this.averageCSBox.Size = new System.Drawing.Size(145, 20);
            this.averageCSBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Average CS";
            // 
            // commonRoleBox
            // 
            this.commonRoleBox.Location = new System.Drawing.Point(9, 104);
            this.commonRoleBox.Name = "commonRoleBox";
            this.commonRoleBox.ReadOnly = true;
            this.commonRoleBox.Size = new System.Drawing.Size(145, 20);
            this.commonRoleBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Most common Role";
            // 
            // commonLaneBox
            // 
            this.commonLaneBox.Location = new System.Drawing.Point(9, 33);
            this.commonLaneBox.Name = "commonLaneBox";
            this.commonLaneBox.ReadOnly = true;
            this.commonLaneBox.Size = new System.Drawing.Size(145, 20);
            this.commonLaneBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Most Common Lane";
            // 
            // topChampsBox
            // 
            this.topChampsBox.Controls.Add(this.topChamp2);
            this.topChampsBox.Controls.Add(this.jungleChamp2);
            this.topChampsBox.Controls.Add(this.midChamp2);
            this.topChampsBox.Controls.Add(this.supportChamp2);
            this.topChampsBox.Controls.Add(this.carryChamp2);
            this.topChampsBox.Controls.Add(this.carryChamp1);
            this.topChampsBox.Controls.Add(this.label8);
            this.topChampsBox.Controls.Add(this.supportChamp1);
            this.topChampsBox.Controls.Add(this.label7);
            this.topChampsBox.Controls.Add(this.midChamp1);
            this.topChampsBox.Controls.Add(this.label6);
            this.topChampsBox.Controls.Add(this.jungleChamp1);
            this.topChampsBox.Controls.Add(this.label5);
            this.topChampsBox.Controls.Add(this.topChamp1);
            this.topChampsBox.Controls.Add(this.label4);
            this.topChampsBox.Location = new System.Drawing.Point(227, 18);
            this.topChampsBox.Name = "topChampsBox";
            this.topChampsBox.Size = new System.Drawing.Size(188, 382);
            this.topChampsBox.TabIndex = 1;
            this.topChampsBox.TabStop = false;
            this.topChampsBox.Text = "Top Champs by Role";
            // 
            // topChamp2
            // 
            this.topChamp2.Location = new System.Drawing.Point(6, 59);
            this.topChamp2.Name = "topChamp2";
            this.topChamp2.ReadOnly = true;
            this.topChamp2.Size = new System.Drawing.Size(175, 20);
            this.topChamp2.TabIndex = 15;
            // 
            // jungleChamp2
            // 
            this.jungleChamp2.Location = new System.Drawing.Point(7, 130);
            this.jungleChamp2.Name = "jungleChamp2";
            this.jungleChamp2.ReadOnly = true;
            this.jungleChamp2.Size = new System.Drawing.Size(175, 20);
            this.jungleChamp2.TabIndex = 14;
            // 
            // midChamp2
            // 
            this.midChamp2.Location = new System.Drawing.Point(6, 199);
            this.midChamp2.Name = "midChamp2";
            this.midChamp2.ReadOnly = true;
            this.midChamp2.Size = new System.Drawing.Size(175, 20);
            this.midChamp2.TabIndex = 13;
            // 
            // supportChamp2
            // 
            this.supportChamp2.Location = new System.Drawing.Point(6, 276);
            this.supportChamp2.Name = "supportChamp2";
            this.supportChamp2.ReadOnly = true;
            this.supportChamp2.Size = new System.Drawing.Size(175, 20);
            this.supportChamp2.TabIndex = 12;
            // 
            // carryChamp2
            // 
            this.carryChamp2.Location = new System.Drawing.Point(6, 353);
            this.carryChamp2.Name = "carryChamp2";
            this.carryChamp2.ReadOnly = true;
            this.carryChamp2.Size = new System.Drawing.Size(175, 20);
            this.carryChamp2.TabIndex = 11;
            // 
            // carryChamp1
            // 
            this.carryChamp1.Location = new System.Drawing.Point(6, 327);
            this.carryChamp1.Name = "carryChamp1";
            this.carryChamp1.ReadOnly = true;
            this.carryChamp1.Size = new System.Drawing.Size(175, 20);
            this.carryChamp1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ADC";
            // 
            // supportChamp1
            // 
            this.supportChamp1.Location = new System.Drawing.Point(7, 250);
            this.supportChamp1.Name = "supportChamp1";
            this.supportChamp1.ReadOnly = true;
            this.supportChamp1.Size = new System.Drawing.Size(175, 20);
            this.supportChamp1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Support";
            // 
            // midChamp1
            // 
            this.midChamp1.Location = new System.Drawing.Point(6, 173);
            this.midChamp1.Name = "midChamp1";
            this.midChamp1.ReadOnly = true;
            this.midChamp1.Size = new System.Drawing.Size(175, 20);
            this.midChamp1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mid";
            // 
            // jungleChamp1
            // 
            this.jungleChamp1.Location = new System.Drawing.Point(7, 104);
            this.jungleChamp1.Name = "jungleChamp1";
            this.jungleChamp1.ReadOnly = true;
            this.jungleChamp1.Size = new System.Drawing.Size(175, 20);
            this.jungleChamp1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jungle";
            // 
            // topChamp1
            // 
            this.topChamp1.Location = new System.Drawing.Point(7, 33);
            this.topChamp1.Name = "topChamp1";
            this.topChamp1.ReadOnly = true;
            this.topChamp1.Size = new System.Drawing.Size(175, 20);
            this.topChamp1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Top";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.top10Summoners);
            this.groupBox3.Location = new System.Drawing.Point(7, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 382);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Top 10 Summoners";
            // 
            // top10Summoners
            // 
            this.top10Summoners.FormattingEnabled = true;
            this.top10Summoners.Location = new System.Drawing.Point(6, 16);
            this.top10Summoners.Name = "top10Summoners";
            this.top10Summoners.Size = new System.Drawing.Size(186, 355);
            this.top10Summoners.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(19, 334);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(132, 32);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aPIKeyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aPIKeyToolStripMenuItem
            // 
            this.aPIKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterKeyHereToolStripMenuItem});
            this.aPIKeyToolStripMenuItem.Name = "aPIKeyToolStripMenuItem";
            this.aPIKeyToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aPIKeyToolStripMenuItem.Text = "API Key";
            // 
            // enterKeyHereToolStripMenuItem
            // 
            this.enterKeyHereToolStripMenuItem.Name = "enterKeyHereToolStripMenuItem";
            this.enterKeyHereToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.enterKeyHereToolStripMenuItem.Text = "Enter Key Here";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.progressBarStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // progressBarStatusLabel1
            // 
            this.progressBarStatusLabel1.Name = "progressBarStatusLabel1";
            this.progressBarStatusLabel1.Size = new System.Drawing.Size(135, 17);
            this.progressBarStatusLabel1.Text = "progressBarStatusLabel1";
            // 
            // LoLStatsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoLStatsMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.topChampsBox.ResumeLayout(false);
            this.topChampsBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox leagueBox;
        private System.Windows.Forms.ComboBox divisionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox averageGoldBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox averageCSBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox commonRoleBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox commonLaneBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox topChampsBox;
        private System.Windows.Forms.TextBox topChamp2;
        private System.Windows.Forms.TextBox jungleChamp2;
        private System.Windows.Forms.TextBox midChamp2;
        private System.Windows.Forms.TextBox supportChamp2;
        private System.Windows.Forms.TextBox carryChamp2;
        private System.Windows.Forms.TextBox carryChamp1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox supportChamp1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox midChamp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jungleChamp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox topChamp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox top10Summoners;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox summonerNameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton statsBySummonerButton;
        private System.Windows.Forms.RadioButton statsByLeagueButton;
        private System.Windows.Forms.ToolStripMenuItem aPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterKeyHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel progressBarStatusLabel1;
    }
}

