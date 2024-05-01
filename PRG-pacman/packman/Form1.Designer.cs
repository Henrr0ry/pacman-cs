namespace pacman
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.CoinLabel = new System.Windows.Forms.Label();
            this.GhostSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.BoostSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.ghostFearTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateFrameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.EndScoreLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EndBtn = new System.Windows.Forms.Button();
            this.ControlBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.playGround = new System.Windows.Forms.PictureBox();
            this.GameOverPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGround)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 500;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // CoinLabel
            // 
            this.CoinLabel.AutoSize = true;
            this.CoinLabel.BackColor = System.Drawing.Color.Black;
            this.CoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CoinLabel.ForeColor = System.Drawing.Color.Gold;
            this.CoinLabel.Location = new System.Drawing.Point(-5, 0);
            this.CoinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoinLabel.Name = "CoinLabel";
            this.CoinLabel.Size = new System.Drawing.Size(102, 29);
            this.CoinLabel.TabIndex = 1;
            this.CoinLabel.Text = "Score: 0";
            // 
            // GhostSpawnTimer
            // 
            this.GhostSpawnTimer.Interval = 40000;
            this.GhostSpawnTimer.Tick += new System.EventHandler(this.GhostSpawnTimer_Tick);
            // 
            // BoostSpawnTimer
            // 
            this.BoostSpawnTimer.Interval = 30000;
            this.BoostSpawnTimer.Tick += new System.EventHandler(this.BoostSpawnTimer_Tick);
            // 
            // ghostFearTimer
            // 
            this.ghostFearTimer.Interval = 20000;
            this.ghostFearTimer.Tick += new System.EventHandler(this.ghostFearTimer_Tick);
            // 
            // UpdateFrameTimer
            // 
            this.UpdateFrameTimer.Interval = 31;
            this.UpdateFrameTimer.Tick += new System.EventHandler(this.updateFrameTimer_Tick);
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.BackColor = System.Drawing.Color.DimGray;
            this.GameOverPanel.BackgroundImage = global::pacman.Properties.Resources.panel;
            this.GameOverPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOverPanel.Controls.Add(this.EndScoreLabel);
            this.GameOverPanel.Controls.Add(this.EndLabel);
            this.GameOverPanel.Controls.Add(this.MenuBtn);
            this.GameOverPanel.Location = new System.Drawing.Point(176, 160);
            this.GameOverPanel.Margin = new System.Windows.Forms.Padding(4);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(333, 308);
            this.GameOverPanel.TabIndex = 4;
            this.GameOverPanel.Visible = false;
            // 
            // EndScoreLabel
            // 
            this.EndScoreLabel.AutoSize = true;
            this.EndScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndScoreLabel.ForeColor = System.Drawing.Color.Gold;
            this.EndScoreLabel.Location = new System.Drawing.Point(81, 150);
            this.EndScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndScoreLabel.Name = "EndScoreLabel";
            this.EndScoreLabel.Size = new System.Drawing.Size(102, 29);
            this.EndScoreLabel.TabIndex = 5;
            this.EndScoreLabel.Text = "Score: 0";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndLabel.ForeColor = System.Drawing.Color.Yellow;
            this.EndLabel.Location = new System.Drawing.Point(57, 84);
            this.EndLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(182, 46);
            this.EndLabel.TabIndex = 4;
            this.EndLabel.Text = "You Win!";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackgroundImage = global::pacman.Properties.Resources.btn;
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.Location = new System.Drawing.Point(107, 244);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(129, 43);
            this.MenuBtn.TabIndex = 4;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            this.MenuBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.MenuBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.DimGray;
            this.ControlPanel.BackgroundImage = global::pacman.Properties.Resources.panel;
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlPanel.Controls.Add(this.label2);
            this.ControlPanel.Controls.Add(this.pictureBox1);
            this.ControlPanel.Controls.Add(this.BackBtn);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.label3);
            this.ControlPanel.Location = new System.Drawing.Point(176, 160);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(333, 308);
            this.ControlPanel.TabIndex = 3;
            this.ControlPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rules";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::pacman.Properties.Resources.movement;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(204, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 69);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::pacman.Properties.Resources.btn;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(108, 244);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(129, 43);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.BackBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controls";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 120);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your goal is to\r\nget biggest score,\r\nyou have to grab\r\ncoins, don\'t let ghosts\r\nc" +
    "atch you and when you\r\ngrab boost, you can catch ghosts.";
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.Color.DimGray;
            this.StartPanel.BackgroundImage = global::pacman.Properties.Resources.panel;
            this.StartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartPanel.Controls.Add(this.pictureBox2);
            this.StartPanel.Controls.Add(this.EndBtn);
            this.StartPanel.Controls.Add(this.ControlBtn);
            this.StartPanel.Controls.Add(this.StartBtn);
            this.StartPanel.Location = new System.Drawing.Point(176, 160);
            this.StartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(333, 308);
            this.StartPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::pacman.Properties.Resources.pacman_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(19, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 84);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // EndBtn
            // 
            this.EndBtn.BackgroundImage = global::pacman.Properties.Resources.btn;
            this.EndBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EndBtn.FlatAppearance.BorderSize = 0;
            this.EndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndBtn.ForeColor = System.Drawing.Color.White;
            this.EndBtn.Location = new System.Drawing.Point(109, 244);
            this.EndBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(129, 43);
            this.EndBtn.TabIndex = 2;
            this.EndBtn.Text = "Exit";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            this.EndBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.EndBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // ControlBtn
            // 
            this.ControlBtn.BackgroundImage = global::pacman.Properties.Resources.btn;
            this.ControlBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlBtn.FlatAppearance.BorderSize = 0;
            this.ControlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ControlBtn.ForeColor = System.Drawing.Color.White;
            this.ControlBtn.Location = new System.Drawing.Point(109, 193);
            this.ControlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(129, 43);
            this.ControlBtn.TabIndex = 1;
            this.ControlBtn.Text = "Help";
            this.ControlBtn.UseVisualStyleBackColor = true;
            this.ControlBtn.Click += new System.EventHandler(this.ControlBtn_Click);
            this.ControlBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.ControlBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // StartBtn
            // 
            this.StartBtn.BackgroundImage = global::pacman.Properties.Resources.btn;
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(109, 143);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(129, 43);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            this.StartBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.StartBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // playGround
            // 
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Margin = new System.Windows.Forms.Padding(4);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(682, 623);
            this.playGround.TabIndex = 0;
            this.playGround.TabStop = false;
            this.playGround.Paint += new System.Windows.Forms.PaintEventHandler(this.playGround_Paint);
            this.playGround.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playGround_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 623);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.CoinLabel);
            this.Controls.Add(this.playGround);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playGround_PreviewKeyDown);
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playGround;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label CoinLabel;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Button ControlBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer GhostSpawnTimer;
        private System.Windows.Forms.Timer BoostSpawnTimer;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Timer ghostFearTimer;
        private System.Windows.Forms.Label EndScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer UpdateFrameTimer;
    }
}

