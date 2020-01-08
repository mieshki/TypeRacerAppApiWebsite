using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    public partial class ChooseRaceLevel : Form
    {
        public ChooseRaceLevel(string username)
        {
            InitializeComponent();

            this.lblHelloUser.Text = $"Hello {username}!";

            string[] row = { "pozycja", "nick", "wordsperminute", "czas" };
            var listViewItem = new ListViewItem(row);
            listviewHighscores.Items.Add(listViewItem);

            cmboxChooseLevel.Items.Add("1. Księżyc");
            cmboxChooseLevel.Items.Add("2. Betelgeza");
            cmboxChooseLevel.Items.Add("3. Enceladus");
            cmboxChooseLevel.Items.Add("4. Gwiazdozbiór Oriona");
            cmboxChooseLevel.Items.Add("5. Galaktyka Andromedy");
            cmboxChooseLevel.SelectedIndex = 0;

            UpdateLatestPlayedCount();
            UpdateHighscores();
        }

        public void UpdateLatestPlayedCount()
        {
            string url = ApiRequest.url + "api/userstatistics/playedcount";
            string parameters = "{\"Username\":\"" + LoginForm.actualUsername + "\",\"Password\":\"" + LoginForm.actualPassword + "\"}";

            int playedCount = int.Parse(ApiRequest.POST_WithResponse(url, parameters));

            lblPlayedGames.Text = $"Played games: {playedCount}";
        }

        public void UpdateHighscores()
        {
            string uri = ApiRequest.url + "api/highscores";
            string result = ApiRequest.GET(uri);

            List<Highscore> allHighscores = HighscoresParser.FromJson(result);

            listviewHighscores.Clear();
            listviewHighscores.View = View.Details;
            listviewHighscores.Columns.Add("No.", 32, HorizontalAlignment.Left);
            listviewHighscores.Columns.Add("Player", 94, HorizontalAlignment.Left);
            listviewHighscores.Columns.Add("Words/min", 67, HorizontalAlignment.Left);
            listviewHighscores.Columns.Add("Time", 36, HorizontalAlignment.Left);
            listviewHighscores.Columns.Add("Map", 77, HorizontalAlignment.Left);

            int position = 1;
            foreach (Highscore highscore in allHighscores)
            {
                string[] row = { position.ToString(), highscore.Player, highscore.WordsPerMinute.ToString(), highscore.TimeInSeconds.ToString(), highscore.Map};
                listviewHighscores.Items.Add(new ListViewItem(row));
                position++;
            }
        }

        public void DisplayReachedScore(float wordsPerMinute, int takenTime, string map)
        {
            lblReachedScore.Text = $"You have reached {wordsPerMinute} words/min in {takenTime}s on map {map}";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmboxChooseLevel.SelectedIndex >= 0)
            {
                int selectedIndex = cmboxChooseLevel.SelectedIndex;

                GameForm gameForm;
                switch (selectedIndex)
                {
                    case 0:
                        gameForm = new GameForm(Level.first, this);
                        break;
                    case 1:
                        gameForm = new GameForm(Level.second, this);
                        break;
                    case 2:
                        gameForm = new GameForm(Level.third, this);
                        break;
                    case 3:
                        gameForm = new GameForm(Level.fourth, this);
                        break;
                    case 4:
                        gameForm = new GameForm(Level.fifth, this);
                        break;
                    default:
                        gameForm = new GameForm(Level.first, this);
                        break;
                }

                gameForm.Show();
                this.Hide();
            }
        }
    }
}
