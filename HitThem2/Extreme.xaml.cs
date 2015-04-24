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
using System.Windows.Media.Imaging;

namespace HitThem2
{
    public partial class Extreme : PhoneApplicationPage
    {
       System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        Random random = new Random();
        int timeLeft, score;
        Boolean isMonsterTrue1, isMonsterTrue2, isMonsterTrue3, isMonsterTrue4, isMonsterTrue5, isMonsterTrue6, isMonsterTrue7, isMonsterTrue8, isMonsterTrue9;
        Boolean isMonsterTrue10, isMonsterTrue11, isMonsterTrue12, isMonsterTrue13, isMonsterTrue14, isMonsterTrue15;

        public Extreme()
        {
            InitializeComponent();
            if (GlobalVar.Username == " ")
            {
                GlobalVar.Username = "Player";
            }
        }

        public void generateMonsters()
        {
            int randomNumbers, numberOfMonsters;
            List<string> monsters = new List<string>();
            List<string> imageList = new List<string>
            {
            "image1",
            "image2",
            "image3",
            "image4",
            "image5",
            "image6",
            "image7",
            "image8",
            "image9",
            "image10",
            "image11",
            "image12",
            "image13",
            "image14",
            "image15",
            };
         
            numberOfMonsters = random.Next(1, 9);
            for (int i = 0; i <= numberOfMonsters; i++)
            {
                randomNumbers = random.Next(0, imageList.Count());
                monsters.Add(imageList[randomNumbers]);
                imageList.RemoveAt(randomNumbers);
            }

            for (int i = 0; i <= monsters.Count()-1; i++)
            {
                if (monsters[i].ToString() == "image1")
                {
                    image1.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue1 = true;
                }
                else if (monsters[i].ToString() == "image2")
                {
                    image2.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue2 = true;
                }
                else if (monsters[i].ToString() == "image3")
                {
                    image3.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue3 = true;
                }
                else if (monsters[i].ToString() == "image4")
                {
                    image4.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue4 = true;
                }
                else if (monsters[i].ToString() == "image5")
                {
                    image5.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue5 = true;
                }
                else if (monsters[i].ToString() == "image6")
                {
                    image6.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue6 = true;
                }
                else if (monsters[i].ToString() == "image7")
                {
                    image7.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue7 = true;
                }
                else if (monsters[i].ToString() == "image8")
                {
                    image8.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue8 = true;
                }
                else if (monsters[i].ToString() == "image10")
                {
                    image10.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue10 = true;
                }
                else if (monsters[i].ToString() == "image11")
                {
                    image11.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue11 = true;
                }
                else if (monsters[i].ToString() == "image12")
                {
                    image12.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue12 = true;
                }
                else if (monsters[i].ToString() == "image13")
                {
                    image13.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue13 = true;
                }
                else if (monsters[i].ToString() == "image14")
                {
                    image14.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue14 = true;
                }
                else if (monsters[i].ToString() == "image15")
                {
                    image15.Source = new BitmapImage(
                         new Uri(@"/HitThem2;component/Images/monster.png",
                            UriKind.RelativeOrAbsolute)
                         );
                    isMonsterTrue15 = true;
                }
                else
                {
                    image9.Source = new BitmapImage(
                        new Uri(@"/HitThem2;component/Images/monster.png",
                           UriKind.RelativeOrAbsolute)
                        );
                    isMonsterTrue9 = true;
                }
            }         
        }// end of generateMonsters

        public void clearMonsters()
        {
            image1.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue1 = false;
            image2.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue2 = false;
            image3.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue3 = false;
            image4.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue4 = false;
            image5.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue5 = false;
            image6.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue6 = false;
            image7.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue7 = false;
            image8.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue8 = false;
            image9.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue9 = false;
            image10.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue10 = false;
            image11.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue11 = false;
            image12.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue12 = false;
            image13.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue13 = false;
            image14.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue14 = false;
            image15.Source = new BitmapImage(
                    new Uri(@"/HitThem2;component/Images/hole.png",
                       UriKind.RelativeOrAbsolute)
                    );
            isMonsterTrue15 = false;
        }

        public void Each_Tick(object o, EventArgs sender)
        {           
            myTextBlock.Text = "Time Left: " + timeLeft--.ToString();

            if (isMonsterTrue1 == false && isMonsterTrue2 == false && isMonsterTrue3 == false && isMonsterTrue4 == false && isMonsterTrue5 == false && isMonsterTrue6 == false && isMonsterTrue7 == false && isMonsterTrue8 == false && isMonsterTrue9 == false && isMonsterTrue10 == false && isMonsterTrue11 == false && isMonsterTrue12 == false && isMonsterTrue13 == false && isMonsterTrue14 == false && isMonsterTrue15 == false)
            {
                generateMonsters();
            }
            if (timeLeft == 58)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 56)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 54)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 52)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 50)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 48)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 46)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 44)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == 42)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft < 40)
            {
                clearMonsters();
                generateMonsters();
            }
            if (timeLeft == -1)
            {
                gameOver();
            }
        }

        public void gameOver()
        {
            myDispatcherTimer.Stop();
            clearMonsters();
            scoreBlock.Text = "";
            String message;
            message =  GlobalVar.Username + ", your score was: "+ score.ToString();
            GlobalVar3.newHighScore = score;
            if (GlobalVar3.newHighScore > GlobalVar3.HighScoreOne)
            {
                GlobalVar3.HighScoreFive = GlobalVar3.HighScoreFour;
                GlobalVar3.HighScoreNameFive = GlobalVar3.HighScoreNameFour;
                GlobalVar3.HighScoreFour = GlobalVar3.HighScoreThree;
                GlobalVar3.HighScoreNameFour = GlobalVar3.HighScoreNameThree;
                GlobalVar3.HighScoreThree = GlobalVar3.HighScoreTwo;
                GlobalVar3.HighScoreNameThree = GlobalVar3.HighScoreNameTwo;
                GlobalVar3.HighScoreTwo = GlobalVar3.HighScoreOne;
                GlobalVar3.HighScoreNameTwo = GlobalVar3.HighScoreNameOne;
                GlobalVar3.HighScoreOne = GlobalVar3.newHighScore;
                GlobalVar3.HighScoreNameOne = GlobalVar.Username;
            }
            else if (GlobalVar3.newHighScore > GlobalVar3.HighScoreTwo)
            {
                GlobalVar3.HighScoreFive = GlobalVar3.HighScoreFour;
                GlobalVar3.HighScoreNameFive = GlobalVar3.HighScoreNameFour;
                GlobalVar3.HighScoreFour = GlobalVar3.HighScoreThree;
                GlobalVar3.HighScoreNameFour = GlobalVar3.HighScoreNameThree;
                GlobalVar3.HighScoreThree = GlobalVar3.HighScoreTwo;
                GlobalVar3.HighScoreNameThree = GlobalVar3.HighScoreNameTwo;
                GlobalVar3.HighScoreTwo = GlobalVar3.newHighScore;
                GlobalVar3.HighScoreNameTwo = GlobalVar.Username;
            }
            else if (GlobalVar3.newHighScore > GlobalVar3.HighScoreThree)
            {
                GlobalVar3.HighScoreFive = GlobalVar3.HighScoreFour;
                GlobalVar3.HighScoreNameFive = GlobalVar3.HighScoreNameFour;
                GlobalVar3.HighScoreFour = GlobalVar3.HighScoreThree;
                GlobalVar3.HighScoreNameFour = GlobalVar3.HighScoreNameThree;
                GlobalVar3.HighScoreThree = GlobalVar3.newHighScore;
                GlobalVar3.HighScoreNameThree = GlobalVar.Username;
            }
            else if (GlobalVar3.newHighScore > GlobalVar3.HighScoreFour)
            {
                GlobalVar3.HighScoreFive = GlobalVar3.HighScoreFour;
                GlobalVar3.HighScoreNameFive = GlobalVar3.HighScoreNameFour;
                GlobalVar3.HighScoreFour = GlobalVar3.newHighScore;
                GlobalVar3.HighScoreNameFour = GlobalVar.Username;
            }
            else if (GlobalVar3.newHighScore > GlobalVar3.HighScoreFive)
            {
                GlobalVar3.HighScoreFive = GlobalVar3.newHighScore;
                GlobalVar3.HighScoreNameFive = GlobalVar.Username;
            }
            MessageBox.Show(message);
             NavigationService.Navigate(
                 new Uri("/Level.xaml",
                 UriKind.RelativeOrAbsolute)
        );
        }

        public void clearMonster1()
        {
            image1.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue1 = false;
        }

        public void clearMonster2()
        {
            image2.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue2 = false;
        }

        public void clearMonster3()
        {
            image3.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue3 = false;
        }

        public void clearMonster4()
        {
            image4.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue4 = false;
        }

        public void clearMonster5()
        {
            image5.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue5 = false;
        }

        public void clearMonster6()
        {
            image6.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue6 = false;
        }

        public void clearMonster7()
        {
            image7.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue7 = false;
        }

        public void clearMonster8()
        {
            image8.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue8 = false;
        }

        public void clearMonster9()
        {
            image9.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue9 = false;
        }

        public void clearMonster10()
        {
            image10.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue10 = false;
        }

        public void clearMonster11()
        {
            image11.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue11 = false;
        }

        public void clearMonster12()
        {
            image12.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue12 = false;
        }

        public void clearMonster13()
        {
            image13.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue13 = false;
        }

        public void clearMonster14()
        {
            image14.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue14 = false;
        }

        public void clearMonster15()
        {
            image15.Source = new BitmapImage(
                   new Uri(@"/HitThem2;component/Images/hole.png",
                      UriKind.RelativeOrAbsolute)
                   );
            isMonsterTrue15 = false;
        }

        private void Guess_Tap(object sender, GestureEventArgs e)
        {
            Image temp = (Image)sender;
            string monsterGuess = temp.Tag.ToString();

            if (monsterGuess == "image1")
            {
                if (isMonsterTrue1 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster1();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image2")
            {
                if (isMonsterTrue2 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster2();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image3")
            {
                if (isMonsterTrue3 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster3();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image4")
            {
                if (isMonsterTrue4 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster4();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image5")
            {
                if (isMonsterTrue5 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster5();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image6")
            {
                if (isMonsterTrue6 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster6();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image7")
            {
                if (isMonsterTrue7 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster7();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image8")
            {
                if (isMonsterTrue8 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster8();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image9")
            {
                if (isMonsterTrue9 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster9();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image10")
            {
                if (isMonsterTrue10 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster10();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image11")
            {
                if (isMonsterTrue11 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster11();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image12")
            {
                if (isMonsterTrue12 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster12();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image13")
            {
                if (isMonsterTrue13 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster13();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image14")
            {
                if (isMonsterTrue14 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster14();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
            else if (monsterGuess == "image15")
            {
                if (isMonsterTrue15 == true)
                {
                    score += 5;
                    scoreBlock.Text = "Score: " + score.ToString();
                    clearMonster15();
                }
                else
                {
                    score = 0;
                    scoreBlock.Text = "Score: 0";
                }
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(
                     new Uri("/Level.xaml",
                         UriKind.RelativeOrAbsolute)
                     );
            myDispatcherTimer.Stop();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Collapsed;
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
            scoreBlock.Text = "Score: ";
            timeLeft = 60;
        }

    }
}