

using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    partial class FrmBattle
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
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnStrength_Up = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.lblPlayerMagicFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.lblbattletime = new System.Windows.Forms.Label();
            this.tmrbattle_time = new System.Windows.Forms.Timer(this.components);
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStrength_Up
            // 
            this.btnStrength_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrength_Up.Location = new System.Drawing.Point(133, 643);
            this.btnStrength_Up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStrength_Up.Name = "btnStrength_Up";
            this.btnStrength_Up.Size = new System.Drawing.Size(240, 53);
            this.btnStrength_Up.TabIndex = 2;
            this.btnStrength_Up.Text = "Strenth Up (10MP)";
            this.btnStrength_Up.UseVisualStyleBackColor = true;
            this.btnStrength_Up.Click += new System.EventHandler(this.btnStrength_Up_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(133, 520);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(240, 53);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(133, 581);
            this.btnHeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(240, 53);
            this.btnHeal.TabIndex = 2;
            this.btnHeal.Text = "Heal (5MP)";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Red;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(95, 37);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(301, 24);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // lblPlayerMagicFull
            // 
            this.lblPlayerMagicFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerMagicFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMagicFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerMagicFull.Location = new System.Drawing.Point(95, 74);
            this.lblPlayerMagicFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerMagicFull.Name = "lblPlayerMagicFull";
            this.lblPlayerMagicFull.Size = new System.Drawing.Size(301, 24);
            this.lblPlayerMagicFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 28);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(687, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 28);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Red;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(688, 37);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(301, 24);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(97, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 24);
            this.label3.TabIndex = 8;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(1040, 693);
            this.picBossBattle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(40, 35);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(687, 120);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(304, 328);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(93, 120);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(304, 328);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picVictory
            // 
            this.picVictory.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Victory_image;
            this.picVictory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVictory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picVictory.Location = new System.Drawing.Point(1443, 1061);
            this.picVictory.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(509, 393);
            this.picVictory.TabIndex = 7;
            this.picVictory.TabStop = false;
            this.picVictory.Visible = false;
            // 
            // lblbattletime
            // 
            this.lblbattletime.AutoSize = true;
            this.lblbattletime.BackColor = System.Drawing.Color.Red;
            this.lblbattletime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbattletime.ForeColor = System.Drawing.Color.White;
            this.lblbattletime.Location = new System.Drawing.Point(537, 31);
            this.lblbattletime.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lblbattletime.Name = "lblbattletime";
            this.lblbattletime.Size = new System.Drawing.Size(60, 24);
            this.lblbattletime.TabIndex = 2;
            this.lblbattletime.Text = "label2";
            // 
            // tmrbattle_time
            // 
            this.tmrbattle_time.Enabled = true;
            this.tmrbattle_time.Interval = 500;
            this.tmrbattle_time.Tick += new System.EventHandler(this.battle_time_Tick);
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 735);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.lblPlayerMagicFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnStrength_Up);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picVictory);
            this.Controls.Add(this.lblbattletime);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox picVictory;
        private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.Timer tmrbattle_time;
        private System.Windows.Forms.Label lblbattletime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerMagicFull;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnStrength_Up;
    }
}
