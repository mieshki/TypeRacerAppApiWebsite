using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TypeRacer
{
    public class TypeRacer
    {
        public int currentWordNumber { get; set; } = 0;
        public int timePassed { get; set; } = 0;
        public int wordsPerMinute { get; set; } = 0;

        Color normalTextColor = Color.Black;
        Color wrongTextColor = Color.Red;

        TextBox txtActualWordToWrite,
                txtPassedTime,
                txtUserWordInput,
                txtWholeTextToBeWritten,
                txtWordsPerMinute;

        GameForm gameForm;
        ChooseRaceLevel chooseRaceLevelForm;
        Level playedLevel;

        string[] allWords;

        Timer t = new Timer();

        public TypeRacer(String textToWrite,
            GameForm gameForm,
            ChooseRaceLevel chooseRaceLevelForm,
            TextBox txtActualWordToWrite,
            TextBox txtPassedTime,
            TextBox txtUserWordInput,
            TextBox txtWholeTextToBeWritten,
            TextBox txtWordsPerMinute,
            Level level)
        {
            this.gameForm = gameForm;
            this.chooseRaceLevelForm = chooseRaceLevelForm;
            this.playedLevel = level;

            this.txtActualWordToWrite = txtActualWordToWrite;
            this.txtPassedTime = txtPassedTime;
            this.txtUserWordInput = txtUserWordInput;
            this.txtWholeTextToBeWritten = txtWholeTextToBeWritten;
            this.txtWordsPerMinute = txtWordsPerMinute;

            allWords = textToWrite.Split(' ');
            txtActualWordToWrite.Text = allWords[currentWordNumber];
            txtWholeTextToBeWritten.Text = textToWrite;
        }

        void StartTimer()
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        public void StartRace()
        {
            txtUserWordInput.Enabled = true;
            txtUserWordInput.Focus();

            StartTimer();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timePassed++;
            UpdateInformations();
        }

        public string levelEnumToStr(Level level)
        {
            switch (level)
            {
                case Level.first:
                    return "Księżyc";
                case Level.second:
                    return "Betelgeza";
                case Level.third:
                    return "Enceladus";
                case Level.fourth:
                    return "Orion";
                case Level.fifth:
                    return "Andromeda";
                default:
                    return "N/A";
            }

        }

        public void IncrementPlayedCount()
        {
            string url = ApiRequest.url + "api/userstatistics/incrementplayedcount";
            string parameters = "{\"Username\":\"" + LoginForm.actualUsername + "\",\"Password\":\"" + LoginForm.actualPassword + "\"}";

            ApiRequest.POST_WithResponse(url, parameters);

            chooseRaceLevelForm.UpdateLatestPlayedCount();
        }

        public void AddScoreToHighscore()
        {
            string url = ApiRequest.url + "api/highscores";
            string parameters = "{\"Player\":\"" + LoginForm.actualUsername + "\",\"WordsPerMinute\":" + wordsPerMinute + ",\"TimeInSeconds\":" + timePassed + ",\"Map\":\"" + levelEnumToStr(playedLevel) + "\"}";

            ApiRequest.POST_WithResponse(url, parameters);
        }

        void RaceFinished()
        {
            IncrementPlayedCount();
            AddScoreToHighscore();
            chooseRaceLevelForm.UpdateHighscores();


            CalculateWordsPerMinute();
            t.Stop();
            txtUserWordInput.Enabled = false;

            chooseRaceLevelForm.DisplayReachedScore(wordsPerMinute, timePassed, levelEnumToStr(playedLevel));
            gameForm.Hide();

            chooseRaceLevelForm.Refresh();
            chooseRaceLevelForm.Show();
        }

        void UpdateInformations()
        {
            CalculateWordsPerMinute();

            txtPassedTime.Text = "Time: " + timePassed.ToString() + " seconds";
            txtWordsPerMinute.Text = wordsPerMinute.ToString("0") + " words per minute";
        }
        void CalculateWordsPerMinute()
        {
            if (timePassed == 0)
                return;
            try
            {
                wordsPerMinute = currentWordNumber / (timePassed / 60);
            }
            catch (DivideByZeroException exc)
            {
                wordsPerMinute = 0;
            }
        }
        void UpdateNextWordToBeWritten()
        {
            if (currentWordNumber >= allWords.Length)
            {
                RaceFinished();
                return;
            }

            txtUserWordInput.Text = "";
            txtActualWordToWrite.Text = allWords[currentWordNumber];
        }
        void CheckWordCorrectness()
        {
            for (int i = 0; i < txtUserWordInput.Text.Length; i++)
            {
                if (i >= allWords[currentWordNumber].Length)
                    return;

                if (txtUserWordInput.Text[i] != allWords[currentWordNumber][i])
                {
                    txtUserWordInput.ForeColor = wrongTextColor;
                    return;
                }
                else
                    txtUserWordInput.ForeColor = normalTextColor;
            }
        }

        public void txtUserWordInput_TextChangedFunc()
        {
            if (txtUserWordInput.Text == allWords[currentWordNumber])
            {
                currentWordNumber++;
                UpdateNextWordToBeWritten();
            }
            else
            {
                CheckWordCorrectness();
            }
        }
    }
}
