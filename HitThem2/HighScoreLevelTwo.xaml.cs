using System;
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
    public partial class HighScoreLevelTwo : PhoneApplicationPage
    {
        public HighScoreLevelTwo()
        {
            InitializeComponent();
        }

        public void CheckHighScores()
        {
            // if first is 0, this means the highscores have been reset so set everything to blank
            if (GlobalVar2.HighScoreOne == 0)
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
                scoreBlockOne.Text = GlobalVar2.HighScoreNameOne;
                highscoreBlockOne.Text = GlobalVar2.HighScoreOne.ToString();

                scoreBlockTwo.Text = GlobalVar2.HighScoreNameTwo;
                highscoreBlockTwo.Text = GlobalVar2.HighScoreTwo.ToString();

                scoreBlockThree.Text = GlobalVar2.HighScoreNameThree;
                highscoreBlockThree.Text = GlobalVar2.HighScoreThree.ToString();

                scoreBlockFour.Text = GlobalVar2.HighScoreNameFour;
                highscoreBlockFour.Text = GlobalVar2.HighScoreFour.ToString();

                scoreBlockFive.Text = GlobalVar2.HighScoreNameFive;
                highscoreBlockFive.Text = GlobalVar2.HighScoreFive.ToString();
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            CheckHighScores();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/HighScoreLevelThree.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                 new Uri("/Highscores.xaml",
                     UriKind.RelativeOrAbsolute)
                 );
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/Highscores.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }
    }
}