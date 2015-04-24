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
    public partial class HighScoreLevelThree : PhoneApplicationPage
    {
        public HighScoreLevelThree()
        {
            InitializeComponent();
        }

        public void CheckHighScores()
        {
            // if first is 0, this means the highscores have been reset so set everything to blank
            if (GlobalVar3.HighScoreOne == 0)
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
                scoreBlockOne.Text = GlobalVar3.HighScoreNameOne;
                highscoreBlockOne.Text = GlobalVar3.HighScoreOne.ToString();

                scoreBlockTwo.Text = GlobalVar3.HighScoreNameTwo;
                highscoreBlockTwo.Text = GlobalVar3.HighScoreTwo.ToString();

                scoreBlockThree.Text = GlobalVar3.HighScoreNameThree;
                highscoreBlockThree.Text = GlobalVar3.HighScoreThree.ToString();

                scoreBlockFour.Text = GlobalVar3.HighScoreNameFour;
                highscoreBlockFour.Text = GlobalVar3.HighScoreFour.ToString();

                scoreBlockFive.Text = GlobalVar3.HighScoreNameFive;
                highscoreBlockFive.Text = GlobalVar3.HighScoreFive.ToString();
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            CheckHighScores();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/HighScoreLevelTwo.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                    new Uri("/resetHighScores.xaml",
                        UriKind.RelativeOrAbsolute)
                    );
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/HighScoreLevelTwo.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }
    }
}