using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace RussianRoulette
{
    class LogicClass
    {
        //this is the bullet
        public int Bullet;
        public int Point = 0;
        public int ShootingAwayChances = 2;


        // this function loads the bullet
        public void Load()
        {
            Bullet = 0;
        }
        // this function spin the bullet
        public void Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
        }
        // this function shoot at head
        public void ShootAtHead()
        {
            if (Bullet == 5)
            {
                MessageBox.Show("you die");
                Point = Point - 5;
            }
            else
            {
                MessageBox.Show("Continue playing");
                Bullet++;
            }
        }
        // this function shoot away
        public void ShootAway()
        {
            ShootingAwayChances--;
            if (ShootingAwayChances == 0)
            {
                MessageBox.Show("You do not have any other  chance");
            }
            else
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("You survive");
                    Point = Point + 10;

                }
                else
                {
                    MessageBox.Show("Continue Playing");
                    Bullet++;
                }
            }
        }
    }
}
        
