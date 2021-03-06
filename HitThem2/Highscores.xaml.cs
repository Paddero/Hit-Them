﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace HitThem2
{
    public partial class Highscores : PhoneApplicationPage
    {
        public Highscores()
        {
            InitializeComponent();
        }

        public void CheckHighScores()
        {
            // if first is 0, this means the highscores have been reset so set everything to blank
            if (GlobalVar.HighScoreOne == 0)
            {
                scoreBlockOne.Text = "";
                highscoreBlockOne.Text = "";

                scoreBlockTwo.Text = "";
                highscoreBlockTwo.Text = "";

                scoreBlockThree.Text = "";
                highscoreBlockThree.Text = "";

                scoreBlockFour.Text = "";
                highscoreBlockFour.Text = "";

                scoreBlockFive.Text = "";
                highscoreBlockFive.Text = "";
            }
            else
            {
                scoreBlockOne.Text = GlobalVar.HighScoreNameOne;
                highscoreBlockOne.Text = GlobalVar.HighScoreOne.ToString();

                scoreBlockTwo.Text = GlobalVar.HighScoreNameTwo;
                highscoreBlockTwo.Text = GlobalVar.HighScoreTwo.ToString();

                scoreBlockThree.Text = GlobalVar.HighScoreNameThree;
                highscoreBlockThree.Text = GlobalVar.HighScoreThree.ToString();

                scoreBlockFour.Text = GlobalVar.HighScoreNameFour;
                highscoreBlockFour.Text = GlobalVar.HighScoreFour.ToString();

                scoreBlockFive.Text = GlobalVar.HighScoreNameFive;
                highscoreBlockFive.Text = GlobalVar.HighScoreFive.ToString();
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            CheckHighScores();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/HighScoreLevelTwo.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/Level.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/Level.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }
    }
}