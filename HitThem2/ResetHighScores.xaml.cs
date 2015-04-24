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
    public partial class ResetHighScores : PhoneApplicationPage
    {
        public ResetHighScores()
        {
            InitializeComponent();
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
            resetHighScores();
            NavigationService.Navigate(
                     new Uri("/HighScoreLevelThree.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/HighScoreLevelThree.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
        }

        public void resetHighScores()
        {
            GlobalVar.HighScoreOne = 0;
            GlobalVar.HighScoreTwo = 0;
            GlobalVar.HighScoreThree = 0;
            GlobalVar.HighScoreFour = 0;
            GlobalVar.HighScoreFive = 0;
            GlobalVar.HighScoreNameOne = "";
            GlobalVar.HighScoreNameTwo = "";
            GlobalVar.HighScoreNameThree = "";
            GlobalVar.HighScoreNameFour = "";
            GlobalVar.HighScoreNameFive = "";

            GlobalVar2.HighScoreOne = 0;
            GlobalVar2.HighScoreTwo = 0;
            GlobalVar2.HighScoreThree = 0;
            GlobalVar2.HighScoreFour = 0;
            GlobalVar2.HighScoreFive = 0;
            GlobalVar2.HighScoreNameOne = "";
            GlobalVar2.HighScoreNameTwo = "";
            GlobalVar2.HighScoreNameThree = "";
            GlobalVar2.HighScoreNameFour = "";
            GlobalVar2.HighScoreNameFive = "";

            GlobalVar3.HighScoreOne = 0;
            GlobalVar3.HighScoreTwo = 0;
            GlobalVar3.HighScoreThree = 0;
            GlobalVar3.HighScoreFour = 0;
            GlobalVar3.HighScoreFive = 0;
            GlobalVar3.HighScoreNameOne = "";
            GlobalVar3.HighScoreNameTwo = "";
            GlobalVar3.HighScoreNameThree = "";
            GlobalVar3.HighScoreNameFour = "";
            GlobalVar3.HighScoreNameFive = "";
        }
    }
}