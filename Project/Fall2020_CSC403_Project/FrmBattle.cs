using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;
      player.HealEvent += PlayerMagic;
      player.Strength_UpEvent += PlayerMagic;
      
      // show health
      UpdateHealthBars();

      // show magic
      UpdateMagicBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void UpdateMagicBars() {
      float playerMagicPer = player.Magic / (float)player.MaxMagic;

      const int MAX_MAGICBAR_WIDTH = 226;
      lblPlayerMagicFull.Width = (int)(MAX_MAGICBAR_WIDTH * playerMagicPer);

      lblPlayerMagicFull.Text = player.Magic.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      if (player.Strength == 2) {
        player.OnAttack(-4);
      }

      if (player.Strength == 5) {
        player.OnAttack(-3); 
      }

      if (enemy.Health > 0) {
        enemy.OnEnemyAttack(-2);
      }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        player.ChangeStrengthBack();
        instance = null;
        Close();
      }
    }

    private void btnHeal_Click(object sender, EventArgs e) {
        if (player.Health < 20 && player.Magic >= 5 && enemy.Health > 0) {
          player.OnHeal(-5);
        } 
    }

    private void btnStrength_Up_Click(object sender, EventArgs e) {
        if (player.Strength == 2 && player.Magic >= 10 && enemy.Health > 0) {
          player.OnStrength_Up(-10);
          player.AlterStrength(3);
        }
            
        UpdateMagicBars();
    }

      private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void PlayerMagic(int amount) {
      player.AlterMagic(amount);
      for (int i=1; i<11; i++) {
          if (player.Health < 20) {
              player.AlterHealth(1);
              UpdateHealthBars();
          }
          i++;
      }
      UpdateMagicBars();
    }

    private void PlayerStrength(int amount) {
      player.AlterStrength(3);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
