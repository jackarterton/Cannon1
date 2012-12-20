namespace Cannon1
{
    partial class Form1
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Projectile = new System.Windows.Forms.PictureBox();
            this.Target = new System.Windows.Forms.PictureBox();
            this.GameUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.LivesDisplay = new System.Windows.Forms.PictureBox();
            this.TitleScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = false;
            this.Player.Location = new System.Drawing.Point(303, 408);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(32, 32);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Projectile
            // 
            this.Projectile.Enabled = false;
            this.Projectile.Location = new System.Drawing.Point(234, 374);
            this.Projectile.Name = "Projectile";
            this.Projectile.Size = new System.Drawing.Size(8, 8);
            this.Projectile.TabIndex = 1;
            this.Projectile.TabStop = false;
            // 
            // Target
            // 
            this.Target.Enabled = false;
            this.Target.Location = new System.Drawing.Point(427, 51);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(32, 32);
            this.Target.TabIndex = 2;
            this.Target.TabStop = false;
            // 
            // GameUpdateTimer
            // 
            this.GameUpdateTimer.Enabled = true;
            this.GameUpdateTimer.Interval = 16;
            this.GameUpdateTimer.Tick += new System.EventHandler(this.GameUpdateTimer_Tick);
            // 
            // LivesDisplay
            // 
            this.LivesDisplay.Location = new System.Drawing.Point(4, 4);
            this.LivesDisplay.Name = "LivesDisplay";
            this.LivesDisplay.Size = new System.Drawing.Size(48, 16);
            this.LivesDisplay.TabIndex = 3;
            this.LivesDisplay.TabStop = false;
            // 
            // TitleScreen
            // 
            this.TitleScreen.Enabled = false;
            this.TitleScreen.Location = new System.Drawing.Point(267, 201);
            this.TitleScreen.Name = "TitleScreen";
            this.TitleScreen.Size = new System.Drawing.Size(100, 50);
            this.TitleScreen.TabIndex = 5;
            this.TitleScreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 452);
            this.Controls.Add(this.TitleScreen);
            this.Controls.Add(this.LivesDisplay);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Projectile);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cannon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Projectile;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Timer GameUpdateTimer;
        private System.Windows.Forms.PictureBox LivesDisplay;
        private System.Windows.Forms.PictureBox TitleScreen;
    }
}

