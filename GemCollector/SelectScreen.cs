using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace GemCollector
{
    public partial class SelectScreen : UserControl
    {
        public static int GridHeight, GridWidth, GemNum;
        public static string difficulty;
        public static SoundPlayer menuClick = new SoundPlayer(Properties.Resources.Click_menu);
        public static SoundPlayer gameClick = new SoundPlayer(Properties.Resources.Click_game);
        public static List<HighScore> scorelist = new List<HighScore>();
        public static List<SavedGrid> SavedGrids = new List<SavedGrid>();


        public SelectScreen()
        {
            LoadSC();
            InitializeComponent();
        }

        int temp1 = scorelist.Count();

        private void EasyButton_Click(object sender, EventArgs e)
        {
            GridHeight = GridWidth = 9;
            GemNum = 10;
            difficulty = "Easy";
            LoadGame();
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            GridHeight = GridWidth = 14;
            GemNum = 40;
            difficulty = "Medium";
            LoadGame();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            GridWidth = GridHeight = 19;
            GemNum = 70;
            difficulty = "Hard";
            LoadGame();
        }

        private void SelectScreen_Paint(object sender, PaintEventArgs e)
        {
            // Main Lblels
            e.Graphics.DrawString("High Scores", new Font("Broadway", 50), new SolidBrush(Color.Black), new Point(570, 180));
            e.Graphics.DrawString("Difficulty", new Font("Broadway", 30), new SolidBrush(Color.Black), new Point(400, 250));
            e.Graphics.DrawString("Clicks", new Font("Broadway", 30), new SolidBrush(Color.Black), new Point(700, 250));
            e.Graphics.DrawString("Time", new Font("Broadway", 30), new SolidBrush(Color.Black), new Point(1000, 250));

            for (int i = 0; i < scorelist.Count(); i++)
            {
                if(scorelist[i].clicks == 0)
                {
                    scorelist.RemoveAt(i);
                }
                if((300 + i * 20)< Screen.PrimaryScreen.Bounds.Height)
                {
                    // Lists the scores
                    e.Graphics.DrawString((scorelist[i].difficulty), new Font("Eras Bold ITC", 14), new SolidBrush(Color.Black), new Point(450, 300 + 20 * i));
                    e.Graphics.DrawString((scorelist[i].clicks).ToString(), new Font("Eras Bold ITC", 14), new SolidBrush(Color.Black), new Point(750, 300 + 20 * i));
                    e.Graphics.DrawString((scorelist[i].time).ToString(), new Font("Eras Bold ITC", 14), new SolidBrush(Color.Black), new Point(1050, 300 + 20 * i));
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomButtom_Click(object sender, EventArgs e)
        {
            Thread.Sleep(180);
            menuClick.Play();
            difficulty = "Custom";
            CustomLevel cl = new CustomLevel();
            cl.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - cl.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - cl.Height) / 2);
            Form a = this.FindForm();
            a.Controls.Remove(this);
            a.Controls.Add(cl);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SelectScreen.SavedGrids.Clear();
            string newX, newY, newV;
            string newName = "";
            bool start = true;
            List<GridBox> Grid = new List<GridBox>();
            XmlReader reader = XmlReader.Create("savedGrids.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newX = reader.ReadString();

                    reader.ReadToNextSibling("y");
                    newY = reader.ReadString();

                    if ((!start) && (newX == "0") && (newY == "0"))
                    {
                        SelectScreen.SavedGrids.Add(new SavedGrid(Grid, newName));
                        Grid.Clear();
                    }
                    reader.ReadToNextSibling("value");
                    newV = reader.ReadString();

                    reader.ReadToNextSibling("name");
                    newName = reader.ReadString();

                    GridBox hs = new GridBox(Convert.ToInt32(newX), Convert.ToInt32(newY), newV);
                    Grid.Add(hs);
                    start = false;
                }
            }
            reader.Close();

            Thread.Sleep(180);
            menuClick.Play();
            difficulty = "Saved";
            GameScreen.Grid.Clear();
            GameScreen.Grid = SavedGrids[0].Grid;
            SavedGrids[0].OnLoad();
            GameScreen.NewGrid = false;

            GameScreen gs = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            f.Controls.Add(gs);
        }

        private void SortByTime_Click(object sender, EventArgs e)
        {
            scorelist = scorelist.OrderBy(x => x.time).ThenBy(x => x.difficulty).ToList();
            this.Refresh();
        }

        private void SortByClicks_Click(object sender, EventArgs e)
        {
            scorelist = scorelist.OrderBy(x => x.clicks).ThenBy(x => x.difficulty).ToList();
            this.Refresh();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(180);
            menuClick.Play();
            HelpScreen gs = new HelpScreen();
            gs.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - gs.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - gs.Height) / 2);
            Form f = this.FindForm();
            f.Controls.Remove(this);
            f.Controls.Add(gs);
        }

        public void LoadGame()
        {
            GameScreen.NewGrid = true;
            Thread.Sleep(180);
            menuClick.Play();
            GameScreen gs = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            f.Controls.Add(gs);
        }

        public void LoadSC() // Load score
        {
            scorelist.Clear();
            string newD, newT, newC;
            XmlReader reader = XmlReader.Create("ScoreSaveFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newD = reader.ReadString();

                    reader.ReadToNextSibling("Clicks");
                    newT = reader.ReadString();

                    reader.ReadToNextSibling("Time");
                    newC = reader.ReadString();

                    HighScore hs = new HighScore(newD, Convert.ToInt32(newT), Convert.ToInt32(newC));
                    scorelist.Add(hs);
                }

            }

            reader.Close();
        }
    }
}