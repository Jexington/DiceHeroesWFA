using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace DiceHeroesWFA
{
    public partial class frmDiceHeroes : Form
    {
        // Init Sounds

        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player5 = new System.Media.SoundPlayer();

        // Init starting variables
        int greenGobiStartHealth = 10;
        int orangeGobiStartHealth = 15;
        int redGobiStartHealth = 20;

        // Init global variables
        int curPlayerDamage;
        int curPlayerHealth = 20;
        int curEnemyHealth;
        int curEnemyDamage;
        int curEnemyType = 0;
        int curTurn;
        int timerCounter;
        bool mainbePressed = false;
        bool radbePressed = true;
        string curEnemy;
        string curClass;


        public frmDiceHeroes()
        {
            InitializeComponent();

            player1.SoundLocation = "Music1Sonic Pi.wav";
            player2.SoundLocation = "Music3SonicPi.wav";
            player3.SoundLocation = "Music2Sonic Pi.wav";
            player4.SoundLocation = "KilledEnemySoundSonicPi.wav";
            player5.SoundLocation = "YouLostSonicPi.wav";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                if (rbtnCrusader.Checked == true)
                {
                    curClass = "Crusader";
                    curPlayerHealth = 20;
                    btnDice1.Text = "1-6 dice";
                    btnDice2.Text = "1 or 6 dice";
                }
                else
                {
                    curClass = "Wizard";
                    curPlayerHealth = 15;
                    btnDice1.Text = "0-7 dice";
                    btnDice2.Text = "0 or 7 dice";
                }

                grpCombat.Enabled = true;
                grpDice.Enabled = true;
                grpEnemyStats.Enabled = true;
                grpPlayerStats.Enabled = true;
                btnStartStop.Text = "Stop";
                populatePlayerStats();
                if (rbtnLevel1.Checked == true)
                {
                    player1.Play();
                }
                else if (rbtnLevel2.Checked == true)
                {
                    player3.Play();
                }
                else if (rbtnLevel3.Checked == true)
                {
                    player2.Play();
                }


                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.sprite_01;

                populatePlayerStartingStats();

                checkApperance();

                populateEnemyStartingStats();

                radbePressed = false;
            }
            else
            {
                if (rbtnCrusader.Checked == true)
                {
                    curClass = "Crusader";
                    curPlayerHealth = 20;
                }
                else
                {
                    curClass = "Wizard";
                    curPlayerHealth = 15;
                }

                grpCombat.Enabled = false;
                grpDice.Enabled = false;
                grpEnemyStats.Enabled = false;
                btnStartStop.Text = "Start";

                radbePressed = true;
                player1.Stop();
                player2.Stop();
                player3.Stop();
            }
        }

        private void btnDice1_Click(object sender, EventArgs e)
        {
            // Basic 1 - 6 dice or 0 - 7 dice, crusader and wizard respectively.
            Random rnd = new Random();
            int roll1 = 0;

            if (curClass == "Wizard")
            {
                roll1 = rnd.Next(0, 8);
            }
            else
            {
                roll1 = rnd.Next(1, 7);
            }

            curPlayerDamage = roll1;
            curEnemyHealth = curEnemyHealth - curPlayerDamage;
            lblStatus.Text = "You dealt: " + curPlayerDamage;
            populateEnemyStats();
            timFlickerWhite.Start();
            curTurn++;
            enemyTurn();
        }

        private void btnDice2_Click(object sender, EventArgs e)
        {
            // Risky, 1 or 6 dice
            Random rnd = new Random();
            int roll1 = rnd.Next(1, 3);

            if (curClass == "Wizard")
            {
                if (roll1 == 1) { curPlayerDamage = 7; }
                else { curPlayerDamage = 0; }
            }
            else
            {
                if (roll1 == 1) { curPlayerDamage = 6; }
                else { curPlayerDamage = 1; }
            }

            curEnemyHealth = curEnemyHealth - curPlayerDamage;
            lblStatus.Text = "You dealt: " + curPlayerDamage;
            populateEnemyStats();
            timFlickerWhite.Start();
            curTurn++;
            enemyTurn();
        }

        private void btnDice3_MouseDown(object sender, MouseEventArgs e)
        {
            // Not risky, 2, 3, 4
            Random rnd = new Random();
            int roll1 = rnd.Next(2, 5);
            curPlayerDamage = roll1;

            curEnemyHealth = curEnemyHealth - curPlayerDamage;
            lblStatus.Text = "You dealt: " + curPlayerDamage;
            populateEnemyStats();
            timFlickerWhite.Start();

            enemyTurn();
        }

        private void populateEnemyStartingStats()
        {
            if (curEnemy == "Green Gobi")
            {
                curEnemyHealth = greenGobiStartHealth;
                lblEnemyHealth.Text = "Health: " + greenGobiStartHealth.ToString();
                lblEnemyDamage.Text = "Damange: 1-3";
            }
            else if (curEnemy == "Orange Gobi")
            {
                curEnemyHealth = orangeGobiStartHealth;
                lblEnemyHealth.Text = "Health: " + orangeGobiStartHealth.ToString();
                lblEnemyDamage.Text = "Damange: 1-5";
            }
            else if (curEnemy == "Red Gobi")
            {
                curEnemyHealth = redGobiStartHealth;
                lblEnemyHealth.Text = "Health: " + redGobiStartHealth.ToString();
                lblEnemyDamage.Text = "Damange: 3-9";
            }
        }

        private void populatePlayerStartingStats()
        {
            lblPlayerHealth.Text = "Health: " + curPlayerHealth.ToString();
        }

        private void populateEnemyStats()
        {
            checkApperance();
            lblEnemyHealth.Text = "Health: " + curEnemyHealth.ToString();
            if (curEnemyHealth <= 0 && curEnemy == "Green Gobi")
            {
                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.dsprite_01;
            }
            else if (curEnemyHealth <= 0 && curEnemy == "Orange Gobi")
            {
                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.Enemy_2_Dead;
            }
            else if (curEnemyHealth <= 0 && curEnemy == "Red Gobi")
            {
                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.Enemy_3_dead;
            }
        }

        private void populatePlayerStats()
        {
            lblPlayerHealth.Text = "Health: " + curPlayerHealth;
        }

        private void initStartingTurn()
        {
            Random rnd = new Random();
            int roll1 = rnd.Next(1, 3);

            if (roll1 == 1) { curTurn = 0; }
            else {
                curTurn = 1;
                enemyTurn();
            }
        }

        private void enemyTurn()
        {

            timTurnDelay.Start();
            Random rnd = new Random();
            int roll1 = 0;

            if (curEnemy == "Green Gobi")
            {
                roll1 = rnd.Next(1, 4);
            }
            else if (curEnemy == "Orange Gobi")
            {
                roll1 = rnd.Next(1, 6);
            }
            else if (curEnemy == "Red Gobi")
            {
                roll1 = rnd.Next(3, 9);
            }

            curEnemyDamage = roll1;

            curPlayerHealth -= curEnemyDamage;

            populatePlayerStats();

            lblStatus.Text = "You dealt " + curPlayerDamage + " damage! But he dealt " + curEnemyDamage + " damage!";

            checkVictory();
        }
        

        private void timFlickerWhite_Tick(object sender, EventArgs e)
        {
            if (timerCounter < 3)
            {
                pbxEnemy.BackColor = Color.White;
                timerCounter++;
            }
            else
            {
                pbxEnemy.BackColor = Color.Black;
                timFlickerWhite.Stop();
                timerCounter = 0;
            }
            
        }

        public void checkVictory()
        {
            mainbePressed = false;
            if (curPlayerHealth <= 0)
            {
                lblStatus.Text = "You lose!";
                grpCombat.Enabled = false;
                grpDice.Enabled = false;
                grpEnemyStats.Enabled = false;
                btnStartStop.Text = "Start";
                player5.Play();
            }
            else if (curEnemyHealth <= 0)
            {
                lblStatus.Text = "You Win!";
                grpCombat.Enabled = false;
                grpDice.Enabled = false;
                grpEnemyStats.Enabled = false;
                btnStartStop.Text = "Start";
                player4.Play();
            }
        }

        private void checkApperance()
        {
            if (rbtnLevel1.Checked == true)
            {
                curEnemy = "Green Gobi";
            }
            else if (rbtnLevel2.Checked == true)
            {
                curEnemy = "Orange Gobi";
            }
            else if (rbtnLevel3.Checked == true)
            {
                curEnemy = "Red Gobi";
            }
            if (curEnemy == "Green Gobi")
            {
                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.sprite_01;
            }
            else if (curEnemy == "Orange Gobi")
            {
                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.Enemy_2_Alive;
            }
            else if (curEnemy == "Red Gobi")
            {
                pbxEnemy.BackgroundImage = DiceHeroesWFA.Properties.Resources.Enemy_3;
            }
        }

    }
}
