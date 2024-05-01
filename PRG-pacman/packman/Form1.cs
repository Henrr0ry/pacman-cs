using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //map size 20 x 20
        int[,] map = { 
                       { 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1},
                       { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
                       { 2, 0, 7, 3, 3, 1, 3, 3, 5, 0, 4, 0, 7, 3, 3, 1, 3, 3, 5, 0, 2},
                       { 2, 0, 0, 0, 0, 2, 0, 0, 0, 0, 2, 0, 0, 0, 0, 2, 0, 0, 0, 0, 2},
                       { 2, 3, 3, 5, 0, 6, 0, 7, 5, 0, 2, 0, 7, 5, 0, 6, 0, 7, 3, 3, 2},
                       { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
                       { 2, 0, 7, 3, 3, 3, 3, 3, 5, 0, 6, 0, 7, 3, 3, 3, 3, 3, 5, 0, 2},
                       { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
                       { 2, 0, 7, 3, 5, 0, 4, 0, 1, 5, 8, 7, 1, 0, 4, 0, 7, 3, 5, 0, 2},
                       { 2, 0, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 2},
                       { 2, 0, 7, 3, 5, 0, 2, 0, 1, 3, 3, 3, 1, 0, 2, 0, 7, 3, 5, 0, 2},
                       { 2, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 2},
                       { 2, 3, 3, 3, 5, 0, 1, 3, 3, 5, 0, 7, 3, 3, 1, 0, 7, 3, 3, 3, 2},
                       { 2, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 2},
                       { 2, 0, 4, 0, 4, 0, 6, 0, 7, 1, 3, 1, 5, 0, 6, 0, 4, 0, 4, 0, 2},
                       { 2, 0, 2, 0, 2, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 2, 0, 2, 0, 2},
                       { 2, 0, 2, 0, 1, 5, 0, 4, 0, 2, 0, 2, 0, 4, 0, 7, 1, 0, 2, 0, 2},
                       { 2, 0, 2, 0, 0, 0, 0, 2, 0, 2, 0, 2, 0, 2, 0, 0, 0, 0, 2, 0, 2},
                       { 2, 0, 1, 3, 3, 5, 0, 6, 0, 6, 0, 6, 0, 6, 0, 7, 3, 3, 1, 0, 2},
                       { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2},
                       { 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1},
                     };
        int[,] coins = { 
                       { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                       { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                       { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                       { 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0},
                       { 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0},
                       { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                       { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                       { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                       { 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0},
                       { 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0},
                       { 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0},
                       { 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
                       { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                       { 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
                       { 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                       { 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0},
                       { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0},
                       { 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0},
                       { 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                       { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                       { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                       };
        int part = 10;
        int longPart = 0;
        int[] wallparts = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        Random rand = new Random();
        int missingCoins = 100;

        //Player stats
        int score = 0;
        int move_vect = -1;
        Image packmanImg = Properties.Resources.packman;

        int playerX = 10;
        int playerY = 11;

        int PspeedX = 0;
        int PspeedY = 0;

        //Enemy stats

        int[] ghostX = {10, 9, 10, 11};
        int[] ghostY = { 7, 9, 9, 9 };
        bool[] continueWalk = { false, false, false, false };
        int[] GspeedX = { 0, 0, 0, 0 };
        int[] GspeedY = { 0, 0, 0, 0 };

        bool ghostFear = false;
        int way = 0;
        int ghostWayX = 0;
        int ghostWayY = 0;

        bool canTop = false;
        bool canLeft = false;
        bool canRight = false;
        bool canBottom = false;

        //Sounds
        SoundPlayer death = new SoundPlayer(Properties.Resources.pacman_death);
        SoundPlayer siren = new SoundPlayer(Properties.Resources.pacman_siren);
        SoundPlayer chomp = new SoundPlayer(Properties.Resources.pacman_chomp);
        SoundPlayer eatfruit = new SoundPlayer(Properties.Resources.pacman_eatfruit);
        SoundPlayer eatghost = new SoundPlayer(Properties.Resources.pacman_eatghost);

        //Main Program
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            playGround.Refresh();
            StartPanel.Top = (playGround.Height / 2) - (StartPanel.Height / 2);
            StartPanel.Left = (playGround.Width / 2) - (StartPanel.Width / 2);

            ControlPanel.Top = (playGround.Height / 2) - (StartPanel.Height / 2);
            ControlPanel.Left = (playGround.Width / 2) - (StartPanel.Width / 2);

            GameOverPanel.Top = (playGround.Height / 2) - (StartPanel.Height / 2);
            GameOverPanel.Left = (playGround.Width / 2) - (StartPanel.Width / 2);
        }

        private void playGround_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            int width = playGround.Width;
            int height = playGround.Height;
            int offset = (width / 2);

            Brush bg = new SolidBrush(Color.FromArgb(0, 6, 43));

            if (width >= height)
            {
                g.FillRectangle(bg, (width / 2) - (height / 2), 0, height, height);
                part = (height / 21);
                longPart = height;
            }
            if (width <= height)
            {
                g.FillRectangle(bg, (width / 2) - (width / 2), 0, width, width);
                part = (width / 21);
                longPart = width;
            }

            missingCoins = 0;
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                { 
                    if (map[j, i] == 1) //Wall
                        g.DrawImage(Properties.Resources.wall1, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 2) //Wall
                        g.DrawImage(Properties.Resources.wall2, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 3) //Wall
                        g.DrawImage(Properties.Resources.wall3, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 4) //Wall
                        g.DrawImage(Properties.Resources.wall4, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 5) //Wall
                        g.DrawImage(Properties.Resources.wall5, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 6) //Wall
                        g.DrawImage(Properties.Resources.wall6, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 7) //Wall
                        g.DrawImage(Properties.Resources.wall7, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                    if (map[j, i] == 8) //Wall
                        g.DrawImage(Properties.Resources.wall8, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);

                    if (coins[j, i] == 1) //Coins
                    {
                        g.DrawImage(Properties.Resources.coin, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                        missingCoins++;
                    }
                    if (coins[j, i] == 2)
                        g.DrawImage(Properties.Resources.boost, (width / 2) - (longPart / 2) + (i * part), (j * part), part, part);
                }
            }
            //Player
            g.DrawImage(packmanImg, (width / 2) - (longPart / 2) + (playerX * part) + (int)((double)(part) / 16 * p_offsetX), playerY * part + (int)((double)(part) / 16 * p_offsetY), part, part);
            //Ghost
            if (!ghostFear)
            {
                g.DrawImage(Properties.Resources.ghost, (width / 2) - (longPart / 2) + (ghostX[0] * part) + (int)((double)(part) / 16 * g_offsetX[0]), ghostY[0] * part + (int)((double)(part) / 16 * g_offsetY[0]), part, part);
                g.DrawImage(Properties.Resources.ghost1, (width / 2) - (longPart / 2) + (ghostX[1] * part) + (int)((double)(part) / 16 * g_offsetX[1]), ghostY[1] * part + (int)((double)(part) / 16 * g_offsetY[1]), part, part);
                g.DrawImage(Properties.Resources.ghost2, (width / 2) - (longPart / 2) + (ghostX[2] * part) + (int)((double)(part) / 16 * g_offsetX[2]), ghostY[2] * part + (int)((double)(part) / 16 * g_offsetY[2]), part, part);
                g.DrawImage(Properties.Resources.ghost3, (width / 2) - (longPart / 2) + (ghostX[3] * part) + (int)((double)(part) / 16 * g_offsetX[3]), ghostY[3] * part + (int)((double)(part) / 16 * g_offsetY[3]), part, part);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                    g.DrawImage(Properties.Resources.ghostFear, (width / 2) - (longPart / 2) + (ghostX[i] * part) + (int)((double)(part) / 16 * g_offsetX[i]), ghostY[i] * part + (int)((double)(part) / 16 * g_offsetY[i]), part, part);
            }
        }

        private void playGround_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    PspeedX = 0;
                    PspeedY = -1;
                    move_vect = 1;
                    break;
                case Keys.Down:
                    PspeedX = 0;
                    PspeedY = 1;
                    move_vect = 3;
                    break;
                case Keys.Left:
                    PspeedX = -1;
                    PspeedY = 0;
                    move_vect = 2;
                    break;
                case Keys.Right:
                    PspeedX = 1;
                    PspeedY = 0;
                    move_vect = 0;
                    break;
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            switch (move_vect)
            {
                case 0:
                    packmanImg = Properties.Resources.packman0;
                    break;
                case 1:
                    packmanImg = Properties.Resources.packman1;
                    break;
                case 2:
                    packmanImg = Properties.Resources.packman2;
                    break;
                case 3:
                    packmanImg = Properties.Resources.packman3;
                    break;
            }
            if (!wallparts.Contains(map[playerY + PspeedY, playerX + PspeedX]))
            {
                playerX += PspeedX;
                playerY += PspeedY;
                if (PspeedX > 0)
                    p_offsetX = -16;
                if (PspeedX < 0)
                    p_offsetX = 16;
                if (PspeedY > 0)
                    p_offsetY = -16;
                if (PspeedY < 0)
                    p_offsetY = 16;
            }
            if (coins[playerY,playerX] == 1)
            {
                coins[playerY, playerX] = 0;
                score += 10;
                CoinLabel.Text = "Score: " + score;
                if (!ghostFear)
                    chomp.Play();
            }
            if (coins[playerY, playerX] == 2)
            {
                coins[playerY, playerX] = 0;
                score += 20;
                CoinLabel.Text = "Score: " + score;
                ghostFear = true;
                ghostFearTimer.Stop();
                ghostFearTimer.Start();
                if (!ghostFear)
                    eatfruit.Play();
                siren.PlayLooping();
            }

            for (int i = 0; i < 4; i++)
            {
                checkColision(i);

                GhostMove(i);
                ghostX[i] += GspeedX[i];
                ghostY[i] += GspeedY[i];
                if (GspeedX[i] > 0)
                    g_offsetX[i] = -16;
                if (GspeedX[i] < 0)
                    g_offsetX[i] = 16;
                if (GspeedY[i] > 0)
                    g_offsetY[i] = -16;
                if (GspeedY[i] < 0)
                    g_offsetY[i] = 16;

                checkColision(i);
            }

            if (missingCoins == 0)
            {
                UpdateTimer.Stop();
                UpdateFrameTimer.Stop();
                BoostSpawnTimer.Stop();
                GhostSpawnTimer.Stop();

                EndLabel.Text = "You Won!";
                EndLabel.ForeColor = Color.Yellow;
                EndScoreLabel.Text = "Score: " + score;
                GameOverPanel.Visible = true;
            }
            //updateFrameTimer.Start();
        }

        private void checkColision(int i)
        {
            if (playerX == ghostX[i] && playerY == ghostY[i])
            {
                if (!ghostFear)
                {
                    UpdateTimer.Stop();
                    UpdateFrameTimer.Stop();
                    BoostSpawnTimer.Stop();
                    GhostSpawnTimer.Stop();

                    EndLabel.Text = "You Lose!";
                    EndLabel.ForeColor = Color.Red;
                    EndScoreLabel.Text = "Score: " + score;
                    GameOverPanel.Visible = true;
                    death.Play();
                }
                else
                {
                    ghostX[i] = 10;
                    ghostY[i] = 9;
                    score += 100;
                    eatghost.Play();
                }
            }
        }

        int p_offsetX = 0;
        int p_offsetY = 0;

        int[] g_offsetX = { 0, 0, 0, 0 };
        int[] g_offsetY = { 0, 0, 0, 0 };

        private void updateFrameTimer_Tick(object sender, EventArgs e)
        {
            if (p_offsetX > 0)
                p_offsetX--;
            if (p_offsetX < 0)
                p_offsetX++;
            if (p_offsetY > 0)
                p_offsetY--;
            if (p_offsetY < 0)
                p_offsetY++;
            for (int i = 0; i < 4; i++)
            {
                if (g_offsetX[i] > 0)
                    g_offsetX[i]--;
                if (g_offsetX[i] < 0)
                    g_offsetX[i]++;
                if (g_offsetY[i] > 0)
                    g_offsetY[i]--;
                if (g_offsetY[i] < 0)
                    g_offsetY[i]++;
            }
            playGround.Refresh();
        }


        private void GhostMove(int id)
        {
            canBottom = !wallparts.Contains(map[ghostY[id] +1, ghostX[id]]);
            canTop = !wallparts.Contains(map[ghostY[id] - 1, ghostX[id]]);
            canRight = !wallparts.Contains(map[ghostY[id], ghostX[id] + 1]);
            canLeft = !wallparts.Contains(map[ghostY[id], ghostX[id] - 1]);

            ghostWayX = ghostX[id] - playerX;
            ghostWayY = playerY - ghostY[id];

            if (continueWalk[id])
            {
                if (!canLeft && GspeedX[id] == -1)
                    continueWalk[id] = false;
                if (!canRight && GspeedX[id] == 1)
                    continueWalk[id] = false;
                if (!canBottom && GspeedY[id] == 1)
                    continueWalk[id] = false;
                if (!canTop && GspeedY[id] == -1)
                    continueWalk[id] = false;
            }

            if (!continueWalk[id])
            {
                GspeedX[id] = 0;
                GspeedY[id] = 0;

                if (!ghostFear)
                {
                    if (ghostWayX < 0 && canRight)
                        GspeedX[id] = 1;
                    else if (ghostWayX > 0 && canLeft)
                        GspeedX[id] = -1;
                    else if (ghostWayY < 0 && canTop)
                        GspeedY[id] = -1;
                    else if (ghostWayY > 0 && canBottom)
                        GspeedY[id] = 1;
                } else
                {
                    if (ghostWayX > 0 && canRight)
                        GspeedX[id] = 1;
                    else if (ghostWayX < 0 && canLeft)
                        GspeedX[id] = -1;
                    else if (ghostWayY > 0 && canTop)
                        GspeedY[id] = -1;
                    else if (ghostWayY < 0 && canBottom)
                        GspeedY[id] = 1;
                }

                if (GspeedX[id] == 0 && GspeedY[id] == 0)
                {
                    continueWalk[id] = true;
                    while (true)
                    {
                        way = rand.Next(0, 5);
                        if (way == 0 && canLeft)
                        {
                            GspeedX[id] = -1;
                            break;
                        }
                        if (way == 1 && canTop)
                        {
                            GspeedY[id] = -1;
                            break;
                        }
                        if (way == 2 && canRight)
                        {
                            GspeedX[id] = 1;
                            break;
                        }
                        if (way == 3 && canBottom)
                        {
                            GspeedY[id] = 1;
                            break;
                        }
                    }
                }
            }
        }

        private void BoostSpawnTimer_Tick(object sender, EventArgs e)
        {
            while (true)
            {
                int tempX = rand.Next(0, 21);
                int tempY = rand.Next(0, 21);
                if (coins[tempY, tempX] == 1)
                {
                    coins[tempY, tempX] = 2;
                    break;
                }
            }
        }

        private void ghostFearTimer_Tick(object sender, EventArgs e)
        {
            ghostFearTimer.Stop();
            ghostFear = false;
            siren.Stop();
        }

        int[] prisonX = { 9, 10, 11 };
        private void GhostSpawnTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (ghostY[i] == 9 && prisonX.Contains(ghostX[i]))
                {
                    ghostX[i] = 9;
                    ghostY[i] = 7;
                    break;
                }
            }
        }

        //Buttons Functions
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            this.Focus();
            UpdateTimer.Start();
            UpdateFrameTimer.Start();
            BoostSpawnTimer.Start();
            GhostSpawnTimer.Start();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GameOverPanel.Visible = false;
            ControlPanel.Visible = false;

            StartPanel.Visible = true;
        }

        private void ControlBtn_Click(object sender, EventArgs e)
        {
            ControlPanel.Visible = true;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.btnhover;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.btn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.packman01;
            playGround.Refresh();
            StartPanel.Top = (playGround.Height / 2) - (StartPanel.Height / 2);
            StartPanel.Left = (playGround.Width / 2) - (StartPanel.Width / 2);

            ControlPanel.Top = (playGround.Height / 2) - (StartPanel.Height / 2);
            ControlPanel.Left = (playGround.Width / 2) - (StartPanel.Width / 2);

            GameOverPanel.Top = (playGround.Height / 2) - (StartPanel.Height / 2);
            GameOverPanel.Left = (playGround.Width / 2) - (StartPanel.Width / 2);
        }

    }
}