using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieGame
{
    internal class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int bulletSpeed = 20;
        public PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.Size = new Size(5, 10);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Image = Properties.Resources.bullet;
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = bulletSpeed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e) 
        {
            if(direction == "left")
            {
                bullet.Left -= bulletSpeed;
            }
            if (direction == "right")
            {
                bullet.Left += bulletSpeed;
            }
            if (direction == "up")
            {
                bullet.Top -= bulletSpeed;
            }
            if (direction == "down")
            {
                bullet.Top += bulletSpeed;
            }

            if(bullet.Left < 10 || bullet.Left > 1440 || bullet.Top < 10 || bullet.Top > 710)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
