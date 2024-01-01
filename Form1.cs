using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieGame
{
    public partial class zombieForm : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score = 0;
        int zombieSpeed = 3;
        bool pause;
        int flag = 0;
        int quantity;
        int sizeZombie;
        int countRemedy = 0;
        int zoneOne = 0;
        int zoneTwo = 0;
        int allAmmo = 0;
        int stage = 0;
        int countBonus = 0;
        int lightningScore = 0;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        public zombieForm()
        {
            InitializeComponent();
            player.Visible = false;
            menuBox.Visible = true;
            timerGame.Enabled = false;
            pauseButton.Visible = false;
            menuButton.Visible = false;
            pauseStart.Visible = false;
            settingsButton.Visible = true;
            settingsBack.Visible = false;
            cancelButton.Visible = true;
            backButton.Visible = false;
            controlBoard.Visible = false;
            restartButton.Visible = false;
            settingsSpace.Visible = false;
            scoreKills.Visible = false;
            scoreUsedAmmo.Visible = false;
            scoreBoard.Visible = false;
            stageCount.Visible = false;
            stageBox.Visible = false;
            lightning.Visible = false;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if(playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                player.Width = 95;
                player.Height = 60;
                player.Image = Properties.Resources.skillet;
                pause = true;
                pauseButton.Visible = false;
                restartButton.Visible = true;
                gameOver = true;
                scoreKills.Text = score.ToString();
                scoreKills.Visible = true;
                scoreUsedAmmo.Text = allAmmo.ToString();
                scoreUsedAmmo.Visible = true;
                scoreBoard.Visible = true;
                if (player.Bounds.IntersectsWith(restartButton.Bounds) || player.Bounds.IntersectsWith(scoreBoard.Bounds))
                {
                    player.Visible = false;
                }
                timerGame.Stop();
            }

            labelAmmo.Text = "Ammo: " + ammo;
            labelKill.Text = "Kills: " + score;
            stageCount.Text = "Stage: " + stage;

            if (player.Left > 0 && goLeft)
            {
                player.Left -= speed;
            }
            if (player.Left + player.Width < this.ClientSize.Width && goRight)
            {
                player.Left += speed;
            }
            if (player.Top > 70 && goUp)
            {
                player.Top -= speed;
            }
            if (player.Top + player.Height < this.ClientSize.Height - 80 && goDown)
            {
                player.Top += speed;
            }

            if(lightningScore == 5)
            {
                speed = 10;
                lightning.Visible = false;
                lightningScore = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += quantity;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "remedy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        if (100 - playerHealth < 30)
                        {
                            playerHealth += 100 - playerHealth;
                        }
                        else
                        {
                            playerHealth += 30;
                        }
                        countRemedy--;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bonus")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        speed = 15;
                        lightning.Visible = true;
                        countBonus--;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth--;
                    }
                    if (x.Left > player.Left)
                    {    
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.LeftFour;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.FrontFourLeft;   
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.RightFour; 
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.FrontFour_Up;  
                    }
                }

                foreach(Control j in this.Controls)
                {
                    if(j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            if(score % 10 == 0)
                            {
                                stage++;
                            }
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove((PictureBox)x);
                            if(score == 20 || score == 40 || score == 80 || score == 120)
                            {
                                MakeZombies();
                            }
                            if (score == 40 || score == 100)
                            {
                                zombieSpeed++;
                            }
                            MakeZombies();
                            if (lightning.Visible)
                            {
                                lightningScore++;
                            }
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver || pause)
            {
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                player.Width = 95;
                player.Height = 60;
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.PersonGunLeft;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.Width = 95;
                player.Height = 60;
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.PersonGunRight;
            }
            if (e.KeyCode == Keys.Up)
            {
                player.Width = 60;
                player.Height = 95;
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.PersonGunUp;
            }
            if (e.KeyCode == Keys.Down)
            {
                player.Width = 60;
                player.Height = 95;
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.PersonGunDown;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            pause = true;
            pauseStart.Visible = true;
            timerGame.Enabled = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = false;
            StartButton.Visible = true;
            menuBox.Visible = true;
            pauseButton.Visible = false;
            menuButton.Visible = false;
            pauseStart.Visible = false;
            settingsButton.Visible = true;
            cancelButton.Visible = true;
            player.Visible = false;
            restartButton.Visible = false;
            scoreKills.Visible = false;
            scoreUsedAmmo.Visible = false;
            scoreBoard.Visible = false;
            stageCount.Visible = false;
            stageBox.Visible = false;
            lightning.Visible = false;
        }

        private void pauseStart_Click(object sender, EventArgs e)
        {
            pause = false;
            pauseStart.Visible = false;
            timerGame.Enabled = true;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;
            settingsSpace.Visible = true;
            controlBoard.Visible = true;
            settingsBack.Visible = true;
            settingsButton.Visible = false;
            cancelButton.Visible = false;
            StartButton.Visible = false;
            menuBox.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menuBox.Visible = true;
            timerGame.Enabled = false;
            pauseButton.Visible = false;
            menuButton.Visible = false;
            pauseStart.Visible = false;
            settingsButton.Visible = true;
            settingsBack.Visible = false;
            backButton.Visible = false;
            cancelButton.Visible = true;
            StartButton.Visible = true;
            controlBoard.Visible = false;
            settingsSpace.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && !gameOver && !pause)
            {
                ammo--;
                allAmmo++;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
                if(playerHealth < 50 && countRemedy < 1)
                {
                    DropRemedy();
                }
                if(score % 14 == 0 && score > 0 && countBonus < 1)
                {
                    DropBonus();
                }
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            player.Width = 60;
            player.Height = 95;
            player.Left = 540;
            player.Top = 430;
            restartButton.Visible = false;
            StartButton.Visible = false;
            menuBox.Visible = false;
            timerGame.Enabled = true;
            pauseButton.Visible = true;
            menuButton.Visible = true;
            settingsButton.Visible = false;
            backButton.Visible = false;
            cancelButton.Visible = false;
            player.Visible = true;
            gameOver = false;
            pause = false;
            scoreKills.Visible = false;
            scoreUsedAmmo.Visible = false;
            scoreBoard.Visible = false;
            stageCount.Visible = true;
            stageBox.Visible = true;

            player.Image = Properties.Resources.PersonGunUp;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && ((string)j.Tag == "ammo" || (string)j.Tag == "remedy"))
                {   
                    ((PictureBox)j).Dispose();
                }
            }
            
            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;
            countRemedy = 0;
            allAmmo = 0;

            facing = "up";

            timerGame.Start();
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            if (facing == "up" || facing == "left")
            {
                shootBullet.bulletLeft = player.Left + (player.Width / 2 + 10);
                shootBullet.bulletTop = player.Top + (player.Height / 4 - 3);
            }
            else
            {
                shootBullet.bulletLeft = player.Left + (player.Width / 4 - 3);
                shootBullet.bulletTop = player.Top + (player.Height - 30);
            }
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            sizeZombie = randNum.Next(40, 80);
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Size = new Size(sizeZombie, sizeZombie);
            zombie.Image = Properties.Resources.FrontFour;
            zoneOne = randNum.Next(0, 1000);
            zoneTwo = randNum.Next(200, 700);
            if(zoneOne < 250)
            {
                zoneOne -= 250;
            }
            else if(zoneOne < 500)
            {
                zoneOne -= 500;
            }
            else if(zoneOne > 500 && zoneOne < 750)
            {
                zoneOne += 500;
            }
            else
            {
                zoneOne += 250;
            }
            if(zoneTwo < 300)
            {
                zoneTwo -= 300;
            }
            else if(zoneTwo < 500)
            {
                zoneTwo -= 500; 
            }
            else
            {
                zoneTwo += 200;
            }
            zombie.Left = zoneOne;
            zombie.Top = zoneTwo;
            zombie.SizeMode = PictureBoxSizeMode.StretchImage;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            flag = randNum.Next(0, 10);
            if (flag % 2 == 0)
            {
                ammo.Image = Properties.Resources.bullets5;
                quantity = 5;
            }
            else
            {
                ammo.Image = Properties.Resources.bullets10;
                quantity = 10;
            }
            ammo.Size = new Size(50, 50);
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(50, this.ClientSize.Height - ammo.Height - 50);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            player.BringToFront();
        }

        private void DropRemedy()
        {
            PictureBox remedy = new PictureBox();
            remedy.Image = Properties.Resources.Remedy;
            remedy.Size = new Size(50, 50);
            remedy.SizeMode = PictureBoxSizeMode.StretchImage;
            remedy.Left = randNum.Next(10, this.ClientSize.Width - remedy.Width);
            remedy.Top = randNum.Next(50, this.ClientSize.Height - remedy.Height - 50);
            remedy.Tag = "remedy";
            this.Controls.Add(remedy);
            player.BringToFront();
            countRemedy++;
        }

        private void DropBonus()
        {
            PictureBox bonus = new PictureBox();
            bonus.Image = Properties.Resources.batary;
            bonus.Size = new Size(20, 40);
            bonus.SizeMode = PictureBoxSizeMode.StretchImage;
            bonus.Left = randNum.Next(10, this.ClientSize.Width - bonus.Width);
            bonus.Top = randNum.Next(50, this.ClientSize.Height - bonus.Height - 50);
            bonus.Tag = "bonus";
            this.Controls.Add(bonus);
            player.BringToFront();
            countBonus++;
        }
    }
}
