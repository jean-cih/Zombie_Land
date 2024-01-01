namespace ZombieGame
{
    partial class zombieForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelKill = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.scoreKills = new System.Windows.Forms.Label();
            this.scoreUsedAmmo = new System.Windows.Forms.Label();
            this.stageBox = new System.Windows.Forms.PictureBox();
            this.scoreBoard = new System.Windows.Forms.PictureBox();
            this.settingsSpace = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.PictureBox();
            this.controlBoard = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.settingsBack = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.PictureBox();
            this.pauseStart = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.menuBox = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.stageCount = new System.Windows.Forms.Label();
            this.lightning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightning)).BeginInit();
            this.SuspendLayout();
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(1285, 26);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(192, 35);
            this.healthBar.TabIndex = 0;
            this.healthBar.Value = 100;
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.BackColor = System.Drawing.Color.Transparent;
            this.labelAmmo.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmmo.ForeColor = System.Drawing.Color.White;
            this.labelAmmo.Location = new System.Drawing.Point(25, 26);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(113, 35);
            this.labelAmmo.TabIndex = 1;
            this.labelAmmo.Text = "Ammo: 0";
            // 
            // labelKill
            // 
            this.labelKill.AutoSize = true;
            this.labelKill.BackColor = System.Drawing.Color.Transparent;
            this.labelKill.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKill.ForeColor = System.Drawing.Color.White;
            this.labelKill.Location = new System.Drawing.Point(702, 26);
            this.labelKill.Name = "labelKill";
            this.labelKill.Size = new System.Drawing.Size(90, 35);
            this.labelKill.TabIndex = 2;
            this.labelKill.Text = "Kills: 0";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHealth.ForeColor = System.Drawing.Color.White;
            this.labelHealth.Location = new System.Drawing.Point(1189, 26);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(90, 35);
            this.labelHealth.TabIndex = 3;
            this.labelHealth.Text = "Health";
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // scoreKills
            // 
            this.scoreKills.AutoSize = true;
            this.scoreKills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(57)))), ((int)(((byte)(35)))));
            this.scoreKills.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreKills.ForeColor = System.Drawing.Color.White;
            this.scoreKills.Location = new System.Drawing.Point(341, 294);
            this.scoreKills.Name = "scoreKills";
            this.scoreKills.Size = new System.Drawing.Size(45, 35);
            this.scoreKills.TabIndex = 18;
            this.scoreKills.Text = "50";
            // 
            // scoreUsedAmmo
            // 
            this.scoreUsedAmmo.AutoSize = true;
            this.scoreUsedAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(57)))), ((int)(((byte)(35)))));
            this.scoreUsedAmmo.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreUsedAmmo.ForeColor = System.Drawing.Color.White;
            this.scoreUsedAmmo.Location = new System.Drawing.Point(397, 338);
            this.scoreUsedAmmo.Name = "scoreUsedAmmo";
            this.scoreUsedAmmo.Size = new System.Drawing.Size(53, 35);
            this.scoreUsedAmmo.TabIndex = 19;
            this.scoreUsedAmmo.Text = "124";
            // 
            // stageBox
            // 
            this.stageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.stageBox.Image = global::ZombieGame.Properties.Resources.Stage;
            this.stageBox.Location = new System.Drawing.Point(329, 12);
            this.stageBox.Name = "stageBox";
            this.stageBox.Size = new System.Drawing.Size(220, 76);
            this.stageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stageBox.TabIndex = 20;
            this.stageBox.TabStop = false;
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.scoreBoard.Image = global::ZombieGame.Properties.Resources.Score;
            this.scoreBoard.Location = new System.Drawing.Point(80, 166);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(469, 329);
            this.scoreBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreBoard.TabIndex = 17;
            this.scoreBoard.TabStop = false;
            // 
            // settingsSpace
            // 
            this.settingsSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.settingsSpace.Image = global::ZombieGame.Properties.Resources.settingsBullet;
            this.settingsSpace.Location = new System.Drawing.Point(419, 37);
            this.settingsSpace.Name = "settingsSpace";
            this.settingsSpace.Size = new System.Drawing.Size(292, 148);
            this.settingsSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsSpace.TabIndex = 16;
            this.settingsSpace.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Image = global::ZombieGame.Properties.Resources.Restart;
            this.restartButton.Location = new System.Drawing.Point(615, 279);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(242, 101);
            this.restartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartButton.TabIndex = 15;
            this.restartButton.TabStop = false;
            this.restartButton.Click += new System.EventHandler(this.RestartGame);
            // 
            // controlBoard
            // 
            this.controlBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.controlBoard.Image = global::ZombieGame.Properties.Resources.Control;
            this.controlBoard.Location = new System.Drawing.Point(730, 26);
            this.controlBoard.Name = "controlBoard";
            this.controlBoard.Size = new System.Drawing.Size(347, 194);
            this.controlBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.controlBoard.TabIndex = 14;
            this.controlBoard.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.Image = global::ZombieGame.Properties.Resources.Back;
            this.backButton.Location = new System.Drawing.Point(31, 668);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(141, 57);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 12;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // settingsBack
            // 
            this.settingsBack.ErrorImage = null;
            this.settingsBack.Image = global::ZombieGame.Properties.Resources.SettingsBack1;
            this.settingsBack.Location = new System.Drawing.Point(0, 0);
            this.settingsBack.Name = "settingsBack";
            this.settingsBack.Size = new System.Drawing.Size(1500, 750);
            this.settingsBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsBack.TabIndex = 11;
            this.settingsBack.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.Image = global::ZombieGame.Properties.Resources.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(31, 26);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 57);
            this.cancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelButton.TabIndex = 13;
            this.cancelButton.TabStop = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsButton.Image = global::ZombieGame.Properties.Resources.Settings;
            this.settingsButton.Location = new System.Drawing.Point(1329, 26);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(141, 57);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsButton.TabIndex = 10;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Image = global::ZombieGame.Properties.Resources.Play;
            this.StartButton.Location = new System.Drawing.Point(593, 244);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(276, 124);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartButton.TabIndex = 6;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.RestartGame);
            // 
            // pauseStart
            // 
            this.pauseStart.BackColor = System.Drawing.Color.Transparent;
            this.pauseStart.Image = global::ZombieGame.Properties.Resources.pauseStart;
            this.pauseStart.Location = new System.Drawing.Point(680, 244);
            this.pauseStart.Name = "pauseStart";
            this.pauseStart.Size = new System.Drawing.Size(138, 179);
            this.pauseStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseStart.TabIndex = 9;
            this.pauseStart.TabStop = false;
            this.pauseStart.Click += new System.EventHandler(this.pauseStart_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::ZombieGame.Properties.Resources.Pause;
            this.pauseButton.Location = new System.Drawing.Point(31, 675);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(120, 50);
            this.pauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseButton.TabIndex = 8;
            this.pauseButton.TabStop = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = global::ZombieGame.Properties.Resources.Menu;
            this.menuButton.Location = new System.Drawing.Point(1350, 675);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 50);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 7;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // menuBox
            // 
            this.menuBox.ErrorImage = null;
            this.menuBox.Image = global::ZombieGame.Properties.Resources.Background;
            this.menuBox.Location = new System.Drawing.Point(0, 0);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(1500, 750);
            this.menuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBox.TabIndex = 5;
            this.menuBox.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::ZombieGame.Properties.Resources.PersonGunUp;
            this.player.Location = new System.Drawing.Point(695, 500);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(70, 105);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // stageCount
            // 
            this.stageCount.AutoSize = true;
            this.stageCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(99)))), ((int)(((byte)(88)))));
            this.stageCount.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageCount.ForeColor = System.Drawing.Color.White;
            this.stageCount.Location = new System.Drawing.Point(373, 37);
            this.stageCount.Name = "stageCount";
            this.stageCount.Size = new System.Drawing.Size(133, 35);
            this.stageCount.TabIndex = 21;
            this.stageCount.Text = "Stage: 150";
            // 
            // lightning
            // 
            this.lightning.BackColor = System.Drawing.Color.Transparent;
            this.lightning.Image = global::ZombieGame.Properties.Resources.lightning;
            this.lightning.Location = new System.Drawing.Point(593, 23);
            this.lightning.Name = "lightning";
            this.lightning.Size = new System.Drawing.Size(38, 49);
            this.lightning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightning.TabIndex = 22;
            this.lightning.TabStop = false;
            // 
            // zombieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.lightning);
            this.Controls.Add(this.stageCount);
            this.Controls.Add(this.stageBox);
            this.Controls.Add(this.scoreUsedAmmo);
            this.Controls.Add(this.scoreKills);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.settingsSpace);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.controlBoard);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.settingsBack);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pauseStart);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelKill);
            this.Controls.Add(this.labelAmmo);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "zombieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombie Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.stageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelKill;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox menuBox;
        private System.Windows.Forms.PictureBox StartButton;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox pauseButton;
        private System.Windows.Forms.PictureBox pauseStart;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox settingsBack;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox cancelButton;
        private System.Windows.Forms.PictureBox controlBoard;
        private System.Windows.Forms.PictureBox restartButton;
        private System.Windows.Forms.PictureBox settingsSpace;
        private System.Windows.Forms.PictureBox scoreBoard;
        private System.Windows.Forms.Label scoreKills;
        private System.Windows.Forms.Label scoreUsedAmmo;
        private System.Windows.Forms.PictureBox stageBox;
        private System.Windows.Forms.Label stageCount;
        private System.Windows.Forms.PictureBox lightning;
    }
}

