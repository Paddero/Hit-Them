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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace HitThem2
{
    public partial class App : Application
    {
        private IsolatedStorageSettings HighScores = IsolatedStorageSettings.ApplicationSettings;
        /// <summary>
        /// Provides easy access to the root frame of the Phone Application.
        /// </summary>
        /// <returns>The root frame of the Phone Application.</returns>
        public PhoneApplicationFrame RootFrame { get; private set; }

        /// <summary>
        /// Constructor for the Application object.
        /// </summary>
        public App()
        {
            // Global handler for uncaught exceptions. 
            UnhandledException += Application_UnhandledException;

            // Standard Silverlight initialization
            InitializeComponent();

            // Phone-specific initialization
            InitializePhoneApplication();

            // Show graphics profiling information while debugging.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Display the current frame rate counters.
                Application.Current.Host.Settings.EnableFrameRateCounter = true;

                // Show the areas of the app that are being redrawn in each frame.
                //Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Enable non-production analysis visualization mode, 
                // which shows areas of a page that are handed off to GPU with a colored overlay.
                //Application.Current.Host.Settings.EnableCacheVisualization = true;

                // Disable the application idle detection by setting the UserIdleDetectionMode property of the
                // application's PhoneApplicationService object to Disabled.
                // Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
                // and consume battery power when the user is not using the phone.
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }

        }

        // Code to execute when the application is launching (eg, from Start)
        // This code will not execute when the application is reactivated
        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
            // try to load highscores that are saved 
            try
            {
                LoadHighScores();
            }
            // if  no highscores found then set everything to 0 and names to null
            catch
            {
                setHighScores();
            }
        }

        // Code to execute when the application is activated (brought to foreground)
        // This code will not execute when the application is first launched
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
            // try to load highscores that are saved 
            try
            {
                LoadHighScores();
            }
            // try to load highscores that are saved 
            catch
            {
                setHighScores(); // this should never be called
            }
        }

        // Code to execute when the application is deactivated (sent to background)
        // This code will not execute when the application is closing
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
            // try to load highscores that are saved 
            try
            {
                saveHighScores();//addHighScores();//LoadHighScores();
            }
            // if no highscores saved then add highscores
            catch
            {
                addHighScores();//saveHighScores();//addHighScores();
            }
        }

        // Code to execute when the application is closing (eg, user hit Back)
        // This code will not execute when the application is deactivated
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
            // save all highscores 
            try
            {
                saveHighScores();//addHighScores();
            }
            // if no highscores saved then add highscores
            catch
            {
                addHighScores();//saveHighScores();
            }
        }

        private void LoadHighScores()
        {
            GlobalVar.Username = (string)HighScores["DefaultName"];
            GlobalVar.HighScoreNameOne = (string)HighScores["HighScoreNameOne"];
            GlobalVar.HighScoreOne = (int)HighScores["HighScoreOne"];
            GlobalVar.HighScoreNameTwo = (string)HighScores["HighScoreNameTwo"];
            GlobalVar.HighScoreTwo = (int)HighScores["HighScoreTwo"];
            GlobalVar.HighScoreNameThree = (string)HighScores["HighScoreNameThree"];
            GlobalVar.HighScoreThree = (int)HighScores["HighScoreThree"];
            GlobalVar.HighScoreNameFour = (string)HighScores["HighScoreNameFour"];
            GlobalVar.HighScoreFour = (int)HighScores["HighScoreFour"];
            GlobalVar.HighScoreNameFive = (string)HighScores["HighScoreNameFive"];
            GlobalVar.HighScoreFive = (int)HighScores["HighScoreFive"];

            GlobalVar2.HighScoreNameOne = (string)HighScores["HighScoreNameOneLevelTwo"];
            GlobalVar2.HighScoreOne = (int)HighScores["HighScoreOneLevelTwo"];
            GlobalVar2.HighScoreNameTwo = (string)HighScores["HighScoreNameTwoLevelTwo"];
            GlobalVar2.HighScoreTwo = (int)HighScores["HighScoreTwoLevelTwo"];
            GlobalVar2.HighScoreNameThree = (string)HighScores["HighScoreNameThreeLevelTwo"];
            GlobalVar2.HighScoreThree = (int)HighScores["HighScoreThreeLevelTwo"];
            GlobalVar2.HighScoreNameFour = (string)HighScores["HighScoreNameFourLevelTwo"];
            GlobalVar2.HighScoreFour = (int)HighScores["HighScoreFourLevelTwo"];
            GlobalVar2.HighScoreNameFive = (string)HighScores["HighScoreNameFiveLevelTwo"];
            GlobalVar2.HighScoreFive = (int)HighScores["HighScoreFiveLevelTwo"];

            GlobalVar3.HighScoreNameOne = (string)HighScores["HighScoreNameOneLevelThree"];
            GlobalVar3.HighScoreOne = (int)HighScores["HighScoreOneLevelThree"];
            GlobalVar3.HighScoreNameTwo = (string)HighScores["HighScoreNameTwoLevelThree"];
            GlobalVar3.HighScoreTwo = (int)HighScores["HighScoreTwoLevelThree"];
            GlobalVar3.HighScoreNameThree = (string)HighScores["HighScoreNameThreeLevelThree"];
            GlobalVar3.HighScoreThree = (int)HighScores["HighScoreThreeLevelThree"];
            GlobalVar3.HighScoreNameFour = (string)HighScores["HighScoreNameFourLevelThree"];
            GlobalVar3.HighScoreFour = (int)HighScores["HighScoreFourLevelThree"];
            GlobalVar3.HighScoreNameFive = (string)HighScores["HighScoreNameFiveLevelThree"];
            GlobalVar3.HighScoreFive = (int)HighScores["HighScoreFiveLevelThree"];
        }

        private void setHighScores()
        {
            GlobalVar.Username = "";
            GlobalVar.HighScoreNameOne = "";
            GlobalVar.HighScoreOne = 0;
            GlobalVar.HighScoreNameTwo = "";
            GlobalVar.HighScoreTwo = 0;
            GlobalVar.HighScoreNameThree = "";
            GlobalVar.HighScoreThree = 0;
            GlobalVar.HighScoreNameFour = "";
            GlobalVar.HighScoreFour = 0;
            GlobalVar.HighScoreNameFive = "";
            GlobalVar.HighScoreFive = 0;

            GlobalVar2.HighScoreNameOne = "";
            GlobalVar2.HighScoreOne = 0;
            GlobalVar2.HighScoreNameTwo = "";
            GlobalVar2.HighScoreTwo = 0;
            GlobalVar2.HighScoreNameThree = "";
            GlobalVar2.HighScoreThree = 0;
            GlobalVar2.HighScoreNameFour = "";
            GlobalVar2.HighScoreFour = 0;
            GlobalVar2.HighScoreNameFive = "";
            GlobalVar2.HighScoreFive = 0;

            GlobalVar3.HighScoreNameOne = "";
            GlobalVar3.HighScoreOne = 0;
            GlobalVar3.HighScoreNameTwo = "";
            GlobalVar3.HighScoreTwo = 0;
            GlobalVar3.HighScoreNameThree = "";
            GlobalVar3.HighScoreThree = 0;
            GlobalVar3.HighScoreNameFour = "";
            GlobalVar3.HighScoreFour = 0;
            GlobalVar3.HighScoreNameFive = "";
            GlobalVar3.HighScoreFive = 0;
        }

        private void addHighScores()
        {
            HighScores.Add("DefaultName", GlobalVar.Username);
            HighScores.Add("HighScoreNameOne", GlobalVar.HighScoreNameOne);
            HighScores.Add("HighScoreOne", GlobalVar.HighScoreOne);
            HighScores.Add("HighScoreNameTwo", GlobalVar.HighScoreNameTwo);
            HighScores.Add("HighScoreTwo", GlobalVar.HighScoreTwo);
            HighScores.Add("HighScoreNameThree", GlobalVar.HighScoreNameThree);
            HighScores.Add("HighScoreThree", GlobalVar.HighScoreThree);
            HighScores.Add("HighScoreNameFour", GlobalVar.HighScoreNameFour);
            HighScores.Add("HighScoreFour", GlobalVar.HighScoreFour);
            HighScores.Add("HighScoreNameFive", GlobalVar.HighScoreNameFive);
            HighScores.Add("HighScoreFive", GlobalVar.HighScoreFive);

            HighScores.Add("HighScoreNameOneLevelTwo", GlobalVar2.HighScoreNameOne);
            HighScores.Add("HighScoreOneLevelTwo", GlobalVar2.HighScoreOne);
            HighScores.Add("HighScoreNameTwoLevelTwo", GlobalVar2.HighScoreNameTwo);
            HighScores.Add("HighScoreTwoLevelTwo", GlobalVar2.HighScoreTwo);
            HighScores.Add("HighScoreNameThreeLevelTwo", GlobalVar2.HighScoreNameThree);
            HighScores.Add("HighScoreThreeLevelTwo", GlobalVar2.HighScoreThree);
            HighScores.Add("HighScoreNameFourLevelTwo", GlobalVar2.HighScoreNameFour);
            HighScores.Add("HighScoreFourLevelTwo", GlobalVar2.HighScoreFour);
            HighScores.Add("HighScoreNameFiveLevelTwo", GlobalVar2.HighScoreNameFive);
            HighScores.Add("HighScoreFiveLevelTwo", GlobalVar2.HighScoreFive);

            HighScores.Add("HighScoreNameOneLevelThree", GlobalVar3.HighScoreNameOne);
            HighScores.Add("HighScoreOneLevelThree", GlobalVar3.HighScoreOne);
            HighScores.Add("HighScoreNameTwoLevelThree", GlobalVar3.HighScoreNameTwo);
            HighScores.Add("HighScoreTwoLevelThree", GlobalVar3.HighScoreTwo);
            HighScores.Add("HighScoreNameThreeLevelThree", GlobalVar3.HighScoreNameThree);
            HighScores.Add("HighScoreThreeLevelThree", GlobalVar3.HighScoreThree);
            HighScores.Add("HighScoreNameFourLevelThree", GlobalVar3.HighScoreNameFour);
            HighScores.Add("HighScoreFourLevelThree", GlobalVar3.HighScoreFour);
            HighScores.Add("HighScoreNameFiveLevelThree", GlobalVar3.HighScoreNameFive);
            HighScores.Add("HighScoreFiveLevelThree", GlobalVar3.HighScoreFive);
        }

        private void saveHighScores()
        {
            HighScores["DefaultName"] = GlobalVar.Username;
            HighScores["HighScoreNameOne"] = GlobalVar.HighScoreNameOne;
            HighScores["HighScoreOne"] = GlobalVar.HighScoreOne;
            HighScores["HighScoreNameTwo"] = GlobalVar.HighScoreNameTwo;
            HighScores["HighScoreTwo"] = GlobalVar.HighScoreTwo;
            HighScores["HighScoreNameThree"] = GlobalVar.HighScoreNameThree;
            HighScores["HighScoreThree"] = GlobalVar.HighScoreThree;
            HighScores["HighScoreNameFour"] = GlobalVar.HighScoreNameFour;
            HighScores["HighScoreFour"] = GlobalVar.HighScoreFour;
            HighScores["HighScoreNameFive"] = GlobalVar.HighScoreNameFive;
            HighScores["HighScoreFive"] = GlobalVar.HighScoreFive;

            HighScores["HighScoreNameOneLevelTwo"] = GlobalVar2.HighScoreNameOne;
            HighScores["HighScoreOneLevelTwo"] = GlobalVar2.HighScoreOne;
            HighScores["HighScoreNameTwoLevelTwo"] = GlobalVar2.HighScoreNameTwo;
            HighScores["HighScoreTwoLevelTwo"] = GlobalVar2.HighScoreTwo;
            HighScores["HighScoreNameThreeLevelTwo"] = GlobalVar2.HighScoreNameThree;
            HighScores["HighScoreThreeLevelTwo"] = GlobalVar2.HighScoreThree;
            HighScores["HighScoreNameFourLevelTwo"] = GlobalVar2.HighScoreNameFour;
            HighScores["HighScoreFourLevelTwo"] = GlobalVar2.HighScoreFour;
            HighScores["HighScoreNameFiveLevelTwo"] = GlobalVar2.HighScoreNameFive;
            HighScores["HighScoreFiveLevelTwo"] = GlobalVar2.HighScoreFive;

            HighScores["HighScoreNameOneLevelThree"] = GlobalVar3.HighScoreNameOne;
            HighScores["HighScoreOneLevelThree"] = GlobalVar3.HighScoreOne;
            HighScores["HighScoreNameTwoLevelThree"] = GlobalVar3.HighScoreNameTwo;
            HighScores["HighScoreTwoLevelThree"] = GlobalVar3.HighScoreTwo;
            HighScores["HighScoreNameThreeLevelThree"] = GlobalVar3.HighScoreNameThree;
            HighScores["HighScoreThreeLevelThree"] = GlobalVar3.HighScoreThree;
            HighScores["HighScoreNameFourLevelThree"] = GlobalVar3.HighScoreNameFour;
            HighScores["HighScoreFourLevelThree"] = GlobalVar3.HighScoreFour;
            HighScores["HighScoreNameFiveLevelThree"] = GlobalVar3.HighScoreNameFive;
            HighScores["HighScoreFiveLevelThree"] = GlobalVar3.HighScoreFive;
        }

        // Code to execute if a navigation fails
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // A navigation has failed; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }



        // Code to execute on Unhandled Exceptions
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        #region Phone application initialization

        // Avoid double-initialization
        private bool phoneApplicationInitialized = false;

        // Do not add any additional code to this method
        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized)
                return;

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            RootFrame = new PhoneApplicationFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            // Handle navigation failures
            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            phoneApplicationInitialized = true;
        }

        // Do not add any additional code to this method
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
            if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            // Remove this handler since it is no longer needed
            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }

        #endregion
    }
}