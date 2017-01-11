using System;
using System.Threading;

namespace TelerikDefender
{
    class MainClass
    {
        static void Main()
        {
            Console.ReadKey();
            #region Chande Console Settings
            
            
            Game.SystemCheck();
             
            #endregion
            
            #region Game Sequence

            #region Intro
            // intro screen
            Sounds.PlayIntroTheme();
            Game.Spash(SplashScreens.Intro);
            Console.Clear();

            // info screen 
            Game.Spash(SplashScreens.Info);
            Console.Clear();
            Sounds.StopIntroTheme();
            #endregion

            #region Level1
            if (!Game.gameOver)
            {
                
                // level 1 splash screen
                Sounds.LevelUpSound.Play();
                Game.Spash(SplashScreens.Level1);
                Console.Clear();
                
                // level  1
                Sounds.PlayMainTheme();
                Game.ConstructPlayField();
                Game.CreateBubbles();
                while (!Game.gameOver && Game.Level == 1)
                {
                    Game.Player.Control();
                }
                Game.Enemy.StopThrowing();
                Game.Enemy.Dispose();
                Console.Clear(); 
                Sounds.StopMainTheme();
            }
            #endregion

            #region Level 2
            if (!Game.gameOver)
            {
                // level 2 screen
                Sounds.LevelUpSound.Play();
                Game.Spash(SplashScreens.Level2);
                Console.Clear();

                // level 2
                Sounds.PlayMainTheme();
                Game.ConstructPlayField();
                Game.CreateButtercup();
                while (!Game.gameOver && Game.Level == 2)
                {
                    Game.Player.Control();
                }
                Game.Enemy.StopThrowing();
                Game.Enemy.Dispose();
                Console.Clear();  
                Sounds.StopMainTheme();
            }
            #endregion

            #region Level3
            if (!Game.gameOver)
            {
                // level 3 screen
                
                Sounds.LevelUpSound.Play();
                Game.Spash(SplashScreens.Level3);
                Console.Clear();
                

                // level 3 
                Sounds.PlayMainTheme();
                Game.ConstructPlayField();
                Game.CreateBlossom();
                while (!Game.gameOver && Game.Level == 3)
                {
                    Game.Player.Control();
                }
                Game.Enemy.StopThrowing();
                Game.Enemy.Dispose();
                Console.Clear(); 
                Sounds.StopMainTheme();
            } 
            #endregion

            #region Win
            if (!Game.gameOver)
            {
                //game win
                Game.Win();
                Console.Clear();
            }
            #endregion

            #region Loose
            //game over
            if (Game.gameOver)
            {
                Game.GameOver();
                Thread.Sleep(7000);
                Console.Clear();
            } 
            #endregion
            

            #endregion Game Sequence

            #region Reset Console Settings

            Console.SetWindowSize(80, 35);
            Console.SetBufferSize(80, 70);
            ConsoleHelper.SetConsoleFont(6);
            Console.ResetColor();
            Console.CursorVisible = true;

            #endregion
        }
        
        

        
        
    }
}
