﻿namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyCheetoMove = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyPoisonPacketMove = new System.Windows.Forms.Timer(this.components);
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picEnemyMikeTysonsNugget = new System.Windows.Forms.PictureBox();
            this.picEnemySusNugget = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.armorPickup = new System.Windows.Forms.PictureBox();
            this.UpdateEnemyPic = new System.Windows.Forms.Timer(this.components);
            this.Death = new System.Windows.Forms.GroupBox();
            this.Quit = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyMikeTysonsNugget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemySusNugget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorPickup)).BeginInit();
            this.Death.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(24, 17);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(95, 36);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // tmrEnemyCheetoMove
            // 
            this.tmrEnemyCheetoMove.Enabled = true;
            this.tmrEnemyCheetoMove.Interval = 10;
            this.tmrEnemyCheetoMove.Tick += new System.EventHandler(this.tmrEnemyCheetoMove_Tick);
            // 
            // tmrEnemyPoisonPacketMove
            // 
            this.tmrEnemyPoisonPacketMove.Enabled = true;
            this.tmrEnemyPoisonPacketMove.Interval = 10;
            this.tmrEnemyPoisonPacketMove.Tick += new System.EventHandler(this.tmrEnemyPoisonPacketMove_Tick);
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(1676, 1038);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(128, 206);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(220, 188);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(126, 185);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picEnemyMikeTysonsNugget
            // 
            this.picEnemyMikeTysonsNugget.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyMikeTysonsNugget.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_miketysonsnugget;
            this.picEnemyMikeTysonsNugget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyMikeTysonsNugget.Location = new System.Drawing.Point(1000, 154);
            this.picEnemyMikeTysonsNugget.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picEnemyMikeTysonsNugget.Name = "picEnemyMikeTysonsNugget";
            this.picEnemyMikeTysonsNugget.Size = new System.Drawing.Size(360, 288);
            this.picEnemyMikeTysonsNugget.TabIndex = 18;
            this.picEnemyMikeTysonsNugget.TabStop = false;
            // 
            // picEnemySusNugget
            // 
            this.picEnemySusNugget.BackColor = System.Drawing.Color.Transparent;
            this.picEnemySusNugget.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_susnugget;
            this.picEnemySusNugget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemySusNugget.Location = new System.Drawing.Point(800, 981);
            this.picEnemySusNugget.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picEnemySusNugget.Name = "picEnemySusNugget";
            this.picEnemySusNugget.Size = new System.Drawing.Size(360, 288);
            this.picEnemySusNugget.TabIndex = 19;
            this.picEnemySusNugget.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(4, 746);
            this.picWall3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(716, 129);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(1942, 142);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(386, 373);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(238, 981);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(108, 204);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(4, 1262);
            this.picWall5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(716, 129);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(4, 873);
            this.picWall4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(164, 390);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(1780, 763);
            this.picWall12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(406, 217);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(714, 1262);
            this.picWall6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(716, 129);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(532, 296);
            this.picWall9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(394, 227);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(1306, 171);
            this.picWall10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(456, 312);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(4, 2);
            this.picWall0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(164, 746);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(1428, 1262);
            this.picWall7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(760, 129);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(2186, 527);
            this.picWall8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(164, 863);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(166, 2);
            this.picWall1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(938, 129);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(1102, 2);
            this.picWall2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(938, 129);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(1102, 817);
            this.picWall11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(328, 446);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // armorPickup
            // 
            this.armorPickup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.armorPickup.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Cropped_Shield;
            this.armorPickup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.armorPickup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.armorPickup.Location = new System.Drawing.Point(210, 595);
            this.armorPickup.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.armorPickup.Name = "armorPickup";
            this.armorPickup.Size = new System.Drawing.Size(181, 133);
            this.armorPickup.TabIndex = 1;
            this.armorPickup.TabStop = false;
            // 
            // UpdateEnemyPic
            // 
            this.UpdateEnemyPic.Enabled = true;
            this.UpdateEnemyPic.Tick += new System.EventHandler(this.tmrUpdateEnemyPic_Tick);
            // 
            // Death
            // 
            this.Death.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.You_Died;
            this.Death.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Death.Controls.Add(this.Quit);
            this.Death.Controls.Add(this.Restart);
            this.Death.Location = new System.Drawing.Point(4, 2);
            this.Death.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Death.Name = "Death";
            this.Death.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Death.Size = new System.Drawing.Size(2346, 1421);
            this.Death.TabIndex = 20;
            this.Death.TabStop = false;
            this.Death.Text = "D";
            this.Death.Visible = false;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(1028, 1152);
            this.Quit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(242, 90);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(1028, 979);
            this.Restart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(242, 98);
            this.Restart.TabIndex = 0;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2352, 1396);
            this.Controls.Add(this.Death);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picEnemyMikeTysonsNugget);
            this.Controls.Add(this.picEnemySusNugget);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.armorPickup);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyMikeTysonsNugget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemySusNugget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorPickup)).EndInit();
            this.Death.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

    private System.Windows.Forms.PictureBox armorPickup;
    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.Timer tmrEnemyCheetoMove;
    private System.Windows.Forms.Timer tmrEnemyPoisonPacketMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picEnemyMikeTysonsNugget;
    private System.Windows.Forms.PictureBox picEnemySusNugget;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.Timer UpdateEnemyPic;
        private System.Windows.Forms.GroupBox Death;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Restart;
    }
}

