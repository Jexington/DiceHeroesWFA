namespace DiceHeroesWFA
{
    partial class frmDiceHeroes
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
            this.components = new System.ComponentModel.Container();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.rbtnWizard = new System.Windows.Forms.RadioButton();
            this.rbtnCrusader = new System.Windows.Forms.RadioButton();
            this.grpEnemySelect = new System.Windows.Forms.GroupBox();
            this.rbtnLevel3 = new System.Windows.Forms.RadioButton();
            this.rbtnLevel1 = new System.Windows.Forms.RadioButton();
            this.rbtnLevel2 = new System.Windows.Forms.RadioButton();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.grpDice = new System.Windows.Forms.GroupBox();
            this.lblRollYourDice = new System.Windows.Forms.Label();
            this.grpPlayerStats = new System.Windows.Forms.GroupBox();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.btnDice3 = new System.Windows.Forms.Button();
            this.btnDice2 = new System.Windows.Forms.Button();
            this.btnDice1 = new System.Windows.Forms.Button();
            this.grpCombat = new System.Windows.Forms.GroupBox();
            this.grpEnemyStats = new System.Windows.Forms.GroupBox();
            this.lblEnemyDamage = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            this.lblCreators = new System.Windows.Forms.Label();
            this.timFlickerWhite = new System.Windows.Forms.Timer(this.components);
            this.timTurnDelay = new System.Windows.Forms.Timer(this.components);
            this.grpSelect.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.grpEnemySelect.SuspendLayout();
            this.grpDice.SuspendLayout();
            this.grpPlayerStats.SuspendLayout();
            this.grpCombat.SuspendLayout();
            this.grpEnemyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.BackColor = System.Drawing.Color.MediumPurple;
            this.grpSelect.Controls.Add(this.grpClass);
            this.grpSelect.Controls.Add(this.grpEnemySelect);
            this.grpSelect.Controls.Add(this.btnStartStop);
            this.grpSelect.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelect.Location = new System.Drawing.Point(588, 13);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(200, 333);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Menu";
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.rbtnWizard);
            this.grpClass.Controls.Add(this.rbtnCrusader);
            this.grpClass.Location = new System.Drawing.Point(10, 158);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(175, 91);
            this.grpClass.TabIndex = 4;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Choose Your Class";
            // 
            // rbtnWizard
            // 
            this.rbtnWizard.AutoSize = true;
            this.rbtnWizard.Location = new System.Drawing.Point(7, 51);
            this.rbtnWizard.Name = "rbtnWizard";
            this.rbtnWizard.Size = new System.Drawing.Size(56, 20);
            this.rbtnWizard.TabIndex = 1;
            this.rbtnWizard.Text = "Wizard";
            this.rbtnWizard.UseVisualStyleBackColor = true;
            // 
            // rbtnCrusader
            // 
            this.rbtnCrusader.AutoSize = true;
            this.rbtnCrusader.Checked = true;
            this.rbtnCrusader.Location = new System.Drawing.Point(7, 24);
            this.rbtnCrusader.Name = "rbtnCrusader";
            this.rbtnCrusader.Size = new System.Drawing.Size(66, 20);
            this.rbtnCrusader.TabIndex = 0;
            this.rbtnCrusader.TabStop = true;
            this.rbtnCrusader.Text = "Crusader";
            this.rbtnCrusader.UseVisualStyleBackColor = true;
            // 
            // grpEnemySelect
            // 
            this.grpEnemySelect.Controls.Add(this.rbtnLevel3);
            this.grpEnemySelect.Controls.Add(this.rbtnLevel1);
            this.grpEnemySelect.Controls.Add(this.rbtnLevel2);
            this.grpEnemySelect.Location = new System.Drawing.Point(10, 19);
            this.grpEnemySelect.Name = "grpEnemySelect";
            this.grpEnemySelect.Size = new System.Drawing.Size(175, 132);
            this.grpEnemySelect.TabIndex = 3;
            this.grpEnemySelect.TabStop = false;
            this.grpEnemySelect.Text = "Choose Your Enemy";
            // 
            // rbtnLevel3
            // 
            this.rbtnLevel3.AutoSize = true;
            this.rbtnLevel3.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLevel3.Location = new System.Drawing.Point(6, 94);
            this.rbtnLevel3.Name = "rbtnLevel3";
            this.rbtnLevel3.Size = new System.Drawing.Size(70, 28);
            this.rbtnLevel3.TabIndex = 4;
            this.rbtnLevel3.TabStop = true;
            this.rbtnLevel3.Text = "Level 3";
            this.rbtnLevel3.UseVisualStyleBackColor = true;
            // 
            // rbtnLevel1
            // 
            this.rbtnLevel1.AutoSize = true;
            this.rbtnLevel1.Checked = true;
            this.rbtnLevel1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLevel1.Location = new System.Drawing.Point(5, 24);
            this.rbtnLevel1.Name = "rbtnLevel1";
            this.rbtnLevel1.Size = new System.Drawing.Size(67, 28);
            this.rbtnLevel1.TabIndex = 1;
            this.rbtnLevel1.TabStop = true;
            this.rbtnLevel1.Text = "Level 1";
            this.rbtnLevel1.UseVisualStyleBackColor = true;
            // 
            // rbtnLevel2
            // 
            this.rbtnLevel2.AutoSize = true;
            this.rbtnLevel2.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLevel2.Location = new System.Drawing.Point(5, 60);
            this.rbtnLevel2.Name = "rbtnLevel2";
            this.rbtnLevel2.Size = new System.Drawing.Size(70, 28);
            this.rbtnLevel2.TabIndex = 2;
            this.rbtnLevel2.TabStop = true;
            this.rbtnLevel2.Text = "Level 2";
            this.rbtnLevel2.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(38, 275);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(118, 46);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // grpDice
            // 
            this.grpDice.BackColor = System.Drawing.Color.Turquoise;
            this.grpDice.Controls.Add(this.lblRollYourDice);
            this.grpDice.Controls.Add(this.grpPlayerStats);
            this.grpDice.Controls.Add(this.btnDice3);
            this.grpDice.Controls.Add(this.btnDice2);
            this.grpDice.Controls.Add(this.btnDice1);
            this.grpDice.Enabled = false;
            this.grpDice.Location = new System.Drawing.Point(12, 352);
            this.grpDice.Name = "grpDice";
            this.grpDice.Size = new System.Drawing.Size(776, 135);
            this.grpDice.TabIndex = 1;
            this.grpDice.TabStop = false;
            this.grpDice.Text = "Dice Menu";
            // 
            // lblRollYourDice
            // 
            this.lblRollYourDice.AutoSize = true;
            this.lblRollYourDice.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollYourDice.Location = new System.Drawing.Point(229, 17);
            this.lblRollYourDice.Name = "lblRollYourDice";
            this.lblRollYourDice.Size = new System.Drawing.Size(129, 31);
            this.lblRollYourDice.TabIndex = 4;
            this.lblRollYourDice.Text = "Roll Your Dice!";
            // 
            // grpPlayerStats
            // 
            this.grpPlayerStats.Controls.Add(this.lblPlayerHealth);
            this.grpPlayerStats.Enabled = false;
            this.grpPlayerStats.Location = new System.Drawing.Point(576, 17);
            this.grpPlayerStats.Name = "grpPlayerStats";
            this.grpPlayerStats.Size = new System.Drawing.Size(194, 112);
            this.grpPlayerStats.TabIndex = 3;
            this.grpPlayerStats.TabStop = false;
            this.grpPlayerStats.Text = "Player Stats";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.Location = new System.Drawing.Point(7, 24);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(64, 28);
            this.lblPlayerHealth.TabIndex = 0;
            this.lblPlayerHealth.Text = "Health:";
            // 
            // btnDice3
            // 
            this.btnDice3.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDice3.Location = new System.Drawing.Point(420, 51);
            this.btnDice3.Name = "btnDice3";
            this.btnDice3.Size = new System.Drawing.Size(124, 61);
            this.btnDice3.TabIndex = 2;
            this.btnDice3.Text = "2-4 Dice";
            this.btnDice3.UseVisualStyleBackColor = true;
            this.btnDice3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDice3_MouseDown);
            // 
            // btnDice2
            // 
            this.btnDice2.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDice2.Location = new System.Drawing.Point(232, 51);
            this.btnDice2.Name = "btnDice2";
            this.btnDice2.Size = new System.Drawing.Size(126, 61);
            this.btnDice2.TabIndex = 1;
            this.btnDice2.Text = "1 or 6 Dice";
            this.btnDice2.UseVisualStyleBackColor = true;
            this.btnDice2.Click += new System.EventHandler(this.btnDice2_Click);
            // 
            // btnDice1
            // 
            this.btnDice1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDice1.Location = new System.Drawing.Point(25, 51);
            this.btnDice1.Name = "btnDice1";
            this.btnDice1.Size = new System.Drawing.Size(128, 61);
            this.btnDice1.TabIndex = 0;
            this.btnDice1.Text = "1-6 Dice";
            this.btnDice1.UseVisualStyleBackColor = true;
            this.btnDice1.Click += new System.EventHandler(this.btnDice1_Click);
            // 
            // grpCombat
            // 
            this.grpCombat.BackColor = System.Drawing.Color.IndianRed;
            this.grpCombat.Controls.Add(this.grpEnemyStats);
            this.grpCombat.Controls.Add(this.lblStatus);
            this.grpCombat.Controls.Add(this.pbxEnemy);
            this.grpCombat.Enabled = false;
            this.grpCombat.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCombat.Location = new System.Drawing.Point(13, 13);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(569, 333);
            this.grpCombat.TabIndex = 2;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Enemy Box";
            // 
            // grpEnemyStats
            // 
            this.grpEnemyStats.Controls.Add(this.lblEnemyDamage);
            this.grpEnemyStats.Controls.Add(this.lblEnemyHealth);
            this.grpEnemyStats.Enabled = false;
            this.grpEnemyStats.Location = new System.Drawing.Point(242, 19);
            this.grpEnemyStats.Name = "grpEnemyStats";
            this.grpEnemyStats.Size = new System.Drawing.Size(138, 230);
            this.grpEnemyStats.TabIndex = 2;
            this.grpEnemyStats.TabStop = false;
            this.grpEnemyStats.Text = "Enemy Stats";
            // 
            // lblEnemyDamage
            // 
            this.lblEnemyDamage.AutoSize = true;
            this.lblEnemyDamage.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDamage.Location = new System.Drawing.Point(7, 60);
            this.lblEnemyDamage.Name = "lblEnemyDamage";
            this.lblEnemyDamage.Size = new System.Drawing.Size(77, 28);
            this.lblEnemyDamage.TabIndex = 1;
            this.lblEnemyDamage.Text = "Damage:";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.Location = new System.Drawing.Point(7, 24);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(64, 28);
            this.lblEnemyHealth.TabIndex = 0;
            this.lblEnemyHealth.Text = "Health:";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 269);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(556, 52);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.BackColor = System.Drawing.Color.Black;
            this.pbxEnemy.BackgroundImage = global::DiceHeroesWFA.Properties.Resources.sprite_01;
            this.pbxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxEnemy.Location = new System.Drawing.Point(6, 19);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(230, 230);
            this.pbxEnemy.TabIndex = 0;
            this.pbxEnemy.TabStop = false;
            // 
            // lblCreators
            // 
            this.lblCreators.AutoSize = true;
            this.lblCreators.Location = new System.Drawing.Point(13, 494);
            this.lblCreators.Name = "lblCreators";
            this.lblCreators.Size = new System.Drawing.Size(313, 13);
            this.lblCreators.TabIndex = 3;
            this.lblCreators.Text = "Created by Derek Sneddon, Kelsie Schwager and Spener Duffin.";
            // 
            // timFlickerWhite
            // 
            this.timFlickerWhite.Interval = 1;
            this.timFlickerWhite.Tick += new System.EventHandler(this.timFlickerWhite_Tick);
            // 
            // frmDiceHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 511);
            this.Controls.Add(this.lblCreators);
            this.Controls.Add(this.grpCombat);
            this.Controls.Add(this.grpDice);
            this.Controls.Add(this.grpSelect);
            this.Name = "frmDiceHeroes";
            this.Text = "Dice Heroes";
            this.grpSelect.ResumeLayout(false);
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.grpEnemySelect.ResumeLayout(false);
            this.grpEnemySelect.PerformLayout();
            this.grpDice.ResumeLayout(false);
            this.grpDice.PerformLayout();
            this.grpPlayerStats.ResumeLayout(false);
            this.grpPlayerStats.PerformLayout();
            this.grpCombat.ResumeLayout(false);
            this.grpEnemyStats.ResumeLayout(false);
            this.grpEnemyStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.GroupBox grpDice;
        private System.Windows.Forms.GroupBox grpCombat;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnDice3;
        private System.Windows.Forms.Button btnDice2;
        private System.Windows.Forms.Button btnDice1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pbxEnemy;
        private System.Windows.Forms.Label lblCreators;
        private System.Windows.Forms.GroupBox grpEnemyStats;
        private System.Windows.Forms.Label lblEnemyDamage;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.GroupBox grpPlayerStats;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Timer timFlickerWhite;
        private System.Windows.Forms.Timer timTurnDelay;
        private System.Windows.Forms.Label lblRollYourDice;
        private System.Windows.Forms.RadioButton rbtnLevel2;
        private System.Windows.Forms.RadioButton rbtnLevel1;
        private System.Windows.Forms.GroupBox grpEnemySelect;
        private System.Windows.Forms.RadioButton rbtnLevel3;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.RadioButton rbtnWizard;
        private System.Windows.Forms.RadioButton rbtnCrusader;
    }
}

