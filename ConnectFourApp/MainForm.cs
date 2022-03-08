using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourApp
{
    public partial class ConnectFourBoard : Form
    {
        static int width = 10;
        static int height = 6;
        Button hoveredBtn = new Button();
        static Image whiteImg = new Bitmap(Image.FromFile("WhiteChecker.png"));
        static Image yellowImg = new Bitmap(Image.FromFile("YellowChecker.png"));
        static Image redImg = new Bitmap(Image.FromFile("RedChecker.png"));
        Image white = (Image)(new Bitmap(whiteImg, new Size(69, 69)));
        Image yellow = (Image)(new Bitmap(yellowImg, new Size(69, 69)));
        Image red = (Image)(new Bitmap(redImg, new Size(69, 69)));
        static Board ConnectBoard = new Board(width, height);
        static Button[,] btnTable = new Button[width, height];
        bool turn = true;
        bool winner = false;
        bool draw = false;
        Button prevButton;
        public SoundPlayer gameMusicPlayer;
        public SoundPlayer gameEffectPlayer1;
        public SoundPlayer gameEffectPlayer2;
        public SoundPlayer gameEffectPlayer3;
        public SoundPlayer gameEffectPlayer4;
        bool musicToggle = true;
        bool effectToggle = true;
        int redPlayerScore = 0;
        int yellowPlayerScore = 0;

        int btnSize = 0;
        private void generateTable()
        {
            //panel.BackgroundImage = red;
            btnSize = panel.Width / width;

            panel.Height = btnSize * height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    btnTable[i, j] = new Button();
                    btnTable[i, j].Height = btnSize;
                    btnTable[i, j].Width = btnSize;
                    btnTable[i, j].Click += TableBtnClick;
                    //ConnectBoard.table[i, j].isRed = true;

                    panel.Controls.Add(btnTable[i, j]);

                    btnTable[i, j].Location = new Point(i * btnSize, j * btnSize);

                    btnTable[i, j].Tag = new Point(i, j);

                    btnTable[i, j].BackgroundImage = white;
                }
            }
        }

        public ConnectFourBoard()
        {
            InitializeComponent();
            generateTable();
        }

        public void initLabel()
        {
            redPlayerScore = 0;
            yellowPlayerScore = 0;
            lblScoreNumRed.Text = redPlayerScore.ToString();
            lblScoreNumYellow.Text = yellowPlayerScore.ToString();
            lblTurnColour.Text = "Red";
            turn = true;
            gameMusicStart();
        }
        public void updateLabel()
        {
            lblScoreNumRed.Text = redPlayerScore.ToString();
            lblScoreNumYellow.Text = yellowPlayerScore.ToString();
            lblTurnColour.Text = "Red";
            turn = true;
        }
        private void ConnectFourBoard_Load(object sender, EventArgs e)
        {
            initLabel();
            gameSoundSetup();
        }

        private void TableBtnClick(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            Cell thisCell = ConnectBoard.table[clickedBtn.Location.X / btnSize, clickedBtn.Location.Y / btnSize];

            // Clicking on an occupied tile (red/yellow)
            if (thisCell.color != 0 && winner == false && draw == false)
            {
                // Check if sound effects are toggled on
                if (effectToggle == true)
                {
                    // Play this sound effect when clicking on an occupied tile (red/yellow)
                    gameEffectPlayer2.Play();
                }
            }

            // Clicking on an empty tile (white)
            if (thisCell.color == 0 && winner == false && draw == false)
            {
                // Check if sound effects are toggled on
                if (effectToggle == true)
                {
                    // Play this sound effect when clicking on an empty tile (white)
                    gameEffectPlayer1.Play();
                }

                if (turn == false)
                {
                    lblTurnColour.Text = "Red";
                }
                else
                {
                    lblTurnColour.Text = "Yellow";
                }

                // Call function to place tile
                placeStone(thisCell.column, thisCell.row);
            }
        }
        private List<List<Point>> getStoneList(int col, int row)
        {
            #region determine pairs of 4 points connected with each other and including Point(col, row)
            List<List<Point>> lists = new List<List<Point>>();
            //vertical connection
            int bottom = (row + 4) <= height ? (row + 3) : -1;
            if (bottom != -1)
            {
                List<Point> list = new List<Point>(new Point[]{new Point(col, row)
                                                           ,new Point(col, row + 1)
                                                           ,new Point(col, row + 2)
                                                           ,new Point(col, row + 3)});
                lists.Add(list);
            }
            int left = (col - 3) < 0 ? 0 : (col - 3);
            int right = (col + 4) >= width ? (width - 1) : (col + 3);
            for(int i = left; i <= right - 3; i++)
            {
                List<Point> list = new List<Point>(new Point[]{new Point(i, row)
                                                           ,new Point(i + 1, row)
                                                           ,new Point(i + 2, row)
                                                           ,new Point(i + 3, row)});
                lists.Add(list);
            }

            int w_row = (row + 4) <= height ? (row + 3) : (height - 1);
            int w_col = (col - 3) < 0 ? 0 : (col - 3);
            int dif = calcDif(col, row, w_col, w_row);
            Point lbottom = new Point(col - dif, row + dif);

            w_row = (row - 3) < 0 ? 0 : (row - 3);
            w_col = (col + 4) >= width ? (width - 1) : (col + 3);
            dif = calcDif(col, row, w_col, w_row);
            Point rtop = new Point(col + dif, row - dif);

            w_row = (row - 3) < 0 ? 0 : (row - 3);
            w_col = (col - 3) < 0 ? 0 : (col - 3);
            dif = calcDif(col, row, w_col, w_row);
            Point ltop = new Point(col - dif, row - dif);

            w_row = (row + 4) <= height ? (row + 3) : (height - 1);
            w_col = (col + 4) >= width ? (width - 1) : (col + 3);
            dif = calcDif(col, row, w_col, w_row);
            Point rbottom = new Point(col + dif, row + dif);

            // / direction
            if (rtop.X - lbottom.X >= 3)
            {
                for(int i = 0; i <= rtop.X - lbottom.X - 3; i++)
                {
                    List<Point> list = new List<Point>(new Point[]{new Point(lbottom.X + i, lbottom.Y - i)
                                                           ,new Point(lbottom.X + i + 1, lbottom.Y - i - 1)
                                                           ,new Point(lbottom.X + i + 2, lbottom.Y - i - 2)
                                                           ,new Point(lbottom.X + i + 3, lbottom.Y - i - 3)
                                                           });
                    lists.Add(list);
                }
            }
            // \ direction
            if (rbottom.X - ltop.X >= 3)
            {
                for (int i = 0; i <= rbottom.X - ltop.X - 3; i++)
                {
                    List<Point> list = new List<Point>(new Point[]{new Point(ltop.X + i, ltop.Y + i)
                                                           ,new Point(ltop.X + i + 1, ltop.Y + i + 1)
                                                           ,new Point(ltop.X + i + 2, ltop.Y + i + 2)
                                                           ,new Point(ltop.X + i + 3, ltop.Y + i + 3)
                                                           });
                    lists.Add(list);
                }
            }
            #endregion
            return lists;
        }
        private int calcDif(int col, int row, int col1, int row1)
        {
            int dif = Math.Abs(row1 - row);
            if (dif > Math.Abs(col - col1))
                dif = col - col1;
            return dif;
        }
        private void isWinner(int col, int row)
        {
            int orgCol = ConnectBoard.table[col, row].color;

            List<List<Point>> lists = getStoneList(col, row);
            foreach(List<Point> list in lists)
            {
                int count = 0;
                foreach(Point p in list)
                {
                    if (ConnectBoard.table[p.X, p.Y].color != orgCol)
                        break;
                    count++;
                }
                if (count == 4)
                {
                    string winner = (orgCol == 1) ? "Red" : "Yellow";
                    DialogResult dialogResult = MessageBox.Show($"{winner} win!");
                    if (orgCol == 1)
                    {
                        redPlayerScore++;
                        updateLabel();
                    }
                    else
                    {
                        yellowPlayerScore++;
                        updateLabel();
                    }
                    initTable();
                }
            }
        }

        private void initTable()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    btnTable[i, j].BackgroundImage = white;
                    ConnectBoard.table[i, j] = new Cell(i, j);
                }
            }
        }

        private void placeStone(int col, int row) { 
            Image putImg = white;
            if (turn)
            {
                putImg = red;
                turn = false;
            } else
            {
                putImg = yellow;
                turn = true;
            }

            //this put the checker at the bottom
            int i;
            for (i = height - 1; i >= 0; i--)
            {
                if (ConnectBoard.table[col, i].color == 0)
                {
                    if (!turn)
                        ConnectBoard.table[col, i].color = 1;
                    else
                        ConnectBoard.table[col, i].color = 2;
                    btnTable[col, i].BackgroundImage = putImg;
                    break;
                }
            }
            if (i != -1)
                isWinner(col, i);

            int count = 0;
            for(i = 0; i < width; i++)
            {
                if (ConnectBoard.table[i, 0].color == 0)
                    break;
                count++;
            }
            if (count == width)
            {
                MessageBox.Show("No winner!");
                initTable();
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            // Set all tiles to white (default)
            initTable();
            initLabel();
        }

        private void btnMusicToggle_Click(object sender, EventArgs e)
        {
            // Turn off music if currently on,
            // otherwise turn on music
            if (musicToggle == true)
            {
                // Stop music
                gameMusicPlayer.Stop();
                musicToggle = false;
            }
            else
            {
                // Resume music
                gameMusicPlayer.PlayLooping();
                musicToggle = true;
            }
        }

        private void btnEffectsToggle_Click(object sender, EventArgs e)
        {
            // Set effectToggle to false if currently true,
            // otherwise set effectToggle to true
            if (effectToggle == true)
            {
                effectToggle = false;
            }
            else
            {
                effectToggle = true;
            }
        }

        public void gameMusicStart()
        {
            // Create SoundPlayer object for music
            gameMusicPlayer = new SoundPlayer();
            gameMusicPlayer.SoundLocation = "GameMusic (djgriffin__video-game-7).wav";

            // Loop music
            gameMusicPlayer.PlayLooping();
        }

        public void gameSoundSetup()
        {
            // Create SoundPlayer objects
            gameEffectPlayer1 = new SoundPlayer();
            gameEffectPlayer2 = new SoundPlayer();
            gameEffectPlayer3 = new SoundPlayer();
            gameEffectPlayer4 = new SoundPlayer();

            // Assign SoundLocation to SoundPlayer objects
            gameEffectPlayer1.SoundLocation = "GameEffectTilePlace (japanyoshithegamer__8-bit-soft-hi-hat).wav";
            gameEffectPlayer2.SoundLocation = "GameEffectTileError (japanyoshithegamer__8-bit-wrong-sound).wav";
            gameEffectPlayer3.SoundLocation = "GameEffectWin (mativve__electro-success-sound).wav";
            gameEffectPlayer4.SoundLocation = "";
        }
    }
}
