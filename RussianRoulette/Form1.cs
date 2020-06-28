using RussianRoulette.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        LogicClass Logic = new LogicClass();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootHead.Enabled = false;
            ShootAway.Enabled = false;
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Logic.Load();
            Load.Enabled = false;
            Spin.Enabled = true;
            ShootHead.Enabled = false;
            ShootAway.Enabled = false;
            PlayAgain.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resources.Load);
            player.Play();
        }

        private void ShootHead_Click(object sender, EventArgs e)
        {
            Logic.ShootAtHead();
            PlayAgain.Enabled = true;
            textBox1.Text = Logic.Point + "";
            SoundPlayer player = new SoundPlayer(Resources.GunShoot);
            player.Play();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            Logic.Spin();
            Logic.Load();
            Load.Enabled = false;
            Spin.Enabled = false;
            ShootHead.Enabled = true;
            ShootAway.Enabled = true;
            PlayAgain.Enabled = false;
            SoundPlayer player = new SoundPlayer(Resources.Spin);
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Logic.ShootingAwayChances == 0)
            {
                ShootAway.Enabled = false;
                ShootHead.Enabled = false;
                PlayAgain.Enabled = true;
            }
            Logic.ShootAway();
            textBox1.Text = Logic.Point + "";
            SoundPlayer player = new SoundPlayer(Resources.GunShoot);
            player.Play();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Logic.Load();
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootHead.Enabled = false;
            ShootAway.Enabled = false;
           
        }
    }
}
