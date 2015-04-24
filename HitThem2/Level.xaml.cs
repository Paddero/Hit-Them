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
    public partial class Level : PhoneApplicationPage
    {
        public Level()
        {
            InitializeComponent();
            
        }

        private void levelOneButton_Click(object sender, RoutedEventArgs e)
        {    
            NavigationService.Navigate(
                   new Uri("/MainPage.xaml",
                       UriKind.RelativeOrAbsolute)
                   );
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            GlobalVar.Username = nameBox.Text;
            nameBox.Visibility = Visibility.Collapsed;
            submitButton.Visibility = Visibility.Collapsed;
            levelOneButton.Visibility = Visibility.Visible;
            levelTwoButton.Visibility = Visibility.Visible;
            levelThreeButton.Visibility = Visibility.Visible;
            unlockLevelTwo.Visibility = Visibility.Visible;
            unlockLevelThree.Visibility = Visibility.Visible;

            if (GlobalVar.HighScoreOne < 650)
            {
                levelTwoButton.Visibility = Visibility.Collapsed;
                levelThreeButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                levelTwoButton.Visibility = Visibility.Visible;
                unlockLevelTwo.Visibility = Visibility.Collapsed;
                levelThreeButton.Visibility = Visibility.Collapsed;
            }

            if (GlobalVar2.HighScoreOne < 650)
            {
                levelThreeButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                unlockLevelThree.Visibility = Visibility.Collapsed;
                levelThreeButton.Visibility = Visibility.Visible;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            levelOneButton.Visibility = Visibility.Collapsed;
            levelTwoButton.Visibility = Visibility.Collapsed;
            levelThreeButton.Visibility = Visibility.Collapsed;
            unlockLevelTwo.Visibility = Visibility.Collapsed;
            unlockLevelThree.Visibility = Visibility.Collapsed;
            nameBox.Visibility = Visibility.Visible;
            submitButton.Visibility = Visibility.Visible;
            nameBox.Text = GlobalVar.Username;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {           
            NavigationService.Navigate(
                     new Uri("/Highscores.xaml",
                         UriKind.RelativeOrAbsolute)
                     );

        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.RemoveBackEntry() != null)
                {
                    NavigationService.RemoveBackEntry();
                }
            }
        }

        private void levelTwoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                    new Uri("/LevelTwo.xaml",
                        UriKind.RelativeOrAbsolute)
                    );
        }

        private void levelThreeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                    new Uri("/Extreme.xaml",
                        UriKind.RelativeOrAbsolute)
                    );
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (GlobalVar.HighScoreOne < 650)
            {
                levelTwoButton.Visibility = Visibility.Collapsed;
                levelThreeButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                levelTwoButton.Visibility = Visibility.Visible;
                unlockLevelTwo.Visibility = Visibility.Collapsed;
                levelThreeButton.Visibility = Visibility.Collapsed;
            }

            if (GlobalVar2.HighScoreOne < 650)
            {
                levelThreeButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                unlockLevelThree.Visibility = Visibility.Collapsed;
                levelThreeButton.Visibility = Visibility.Visible;
            }
        }
    }
}