using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Threading;

namespace TelerikDefender
{
    public class Game
    {
        #region Game Settings
        public static int Level = 1;                // the current level
        public static int BuildingSrength = 7;      // the health bars of the building
        public static int EnemyHealth = 5;          // the health bars of the enemy
        public static int NinjaStars = 3;           // the starting number of ninja stars
        public static int starPoints = 50;         // the points needed to obtain a new ninja star
        public static int Score = 0;                // the total game score
        public static int tempScore = 0;            // a point counter for the stars
        public static int fireballPoints = 10;      // the amount of score points a destroyed fireball gives
        public static int playerSpeed = 5;          // the speed ( distance) at which the player moves around;
        public static int SplashScreenTimer = 5000; // the minimum time to display the splash screens 
        public static bool gameOver = false;
        #endregion

        public static Player Player = new Player("playerNinja.txt", 63, 20);        // Create Player using the .txt file provided at position row = 1, col = 1 ( default )
        public static Enemy Enemy;                                                  // Create Enemy using the .txt file provided at position row = 1, col = 1 ( default )
        private static List<GameObject> enemyHealth = new List<GameObject>();       //the enemy's health bars
        private static List<GameObject> buildingHealth = new List<GameObject>();    //the building's health bars
        private static List<GameObject> ninjaStars = new List<GameObject>();        //the ninja stars currently available  

        public static void ConstructPlayField()
        {
            
            Console.CursorVisible = false;
            GameObject building = new GameObject("building.txt", 1, 24);
            building.Color = ConsoleColor.DarkGray;
            building.Draw();
            GameObject enemyHealth = new GameObject("EnemyHealth.txt", 200, 3);
            enemyHealth.Color = ConsoleColor.Red;
            enemyHealth.Draw();
            GameObject ninjaStars = new GameObject("NinjaStars.txt", 10, 3);
            ninjaStars.Color = ConsoleColor.Green;
            ninjaStars.Draw();
            GameObject buildingStrength = new GameObject("BuildingStrength.txt", 90, 3);
            buildingStrength.Color = ConsoleColor.Yellow;
            buildingStrength.Draw();
            UpdateBuildingStrength();
            UpdateEnemyHealth();
            UpdateNinjaStars();
            Player.Color = ConsoleColor.DarkGreen;
            Player.TopConstraint = 20;
            Player.LeftConstraint = 63;
            Player.RightConstraint = 100;
            Player.Draw();
            
            
        }
        
        public static void UpdateBuildingStrength()
        {

            if (BuildingSrength<=0)
            {
                gameOver = true;
            }
            foreach (var bar in buildingHealth)
            {
                bar.Color = ConsoleColor.Black;
                bar.Draw();
            }
            buildingHealth.Clear();
            int buildingCol = 92;

            for (int i = 0; i < BuildingSrength; i++)
            {

                buildingHealth.Add(new GameObject("enemyHealthBar.txt", buildingCol, 12));
                buildingCol += 10;
            }
            foreach (var bar in buildingHealth)
            {
                bar.Color = ConsoleColor.Yellow;
                bar.Draw();
            }
        }

        public static void UpdateEnemyHealth()
        {
            int enemyCol = 202;                    // the column at which to draw the "Enemy Health" label 
            foreach (var bar in enemyHealth)
            {
                bar.Color = ConsoleColor.Black;
                bar.Draw();
            }
            enemyHealth.Clear();
            for (int i = 0; i < EnemyHealth; i++)
            {
                enemyHealth.Add(new GameObject("enemyHealthBar.txt", enemyCol, 12));
                enemyCol += 10;
            }
            foreach (var bar in enemyHealth)
            {
                bar.Clear();
                bar.Color = ConsoleColor.Red;
                bar.Draw();
            }
            
        }

        public static void UpdateNinjaStars()
        {
            int ninjaCol = 10;                      // the column at which to draw the "Ninja Stars" label
            foreach (var bar in ninjaStars)
            {

                bar.Color = ConsoleColor.Black;
                bar.Draw();
            }
            ninjaStars.Clear();
            for (int i = 0; i < NinjaStars; i++)
            {
                ninjaStars.Add(new GameObject("enemyHealthBar.txt", ninjaCol, 12));
                ninjaCol += 10;
            }
            foreach (var bar in ninjaStars)
            {
                bar.Color = ConsoleColor.Green;
                bar.Draw();
            }
        }

        public static void GameOver()
        {
            Thread.Sleep(500);
            Console.Clear();
            GameObject gameOverText = new GameObject("GameOver_new.txt", 1, 1);
            gameOverText.Color = ConsoleColor.Red;
            gameOverText.Draw();

            
            Sounds.GameOverSound.Play();
        }

        public static void Win()
        {
            
            Console.Clear();
            Sounds.GameWinSound.Play();
            GameObject gameWin = new GameObject("win_new.txt", 1, 1);
            gameWin.Color = ConsoleColor.Red;
            gameWin.Draw();
            Thread.Sleep(5000);
            
        }

        public static void CreateBubbles()
        {
            Enemy = new Enemy("bubbles.txt", 215, 30);
            Enemy.TopConstraint = 25;
            Enemy.Color = ConsoleColor.Yellow;
            Enemy.Draw();
            Enemy.AnimateUpDown(3000, 70, 1);
            EnemyHealth = 5; 
            UpdateEnemyHealth();
        }

        public static void CreateButtercup()
        {
            Game.Enemy = new Enemy("buttercup.txt", 250, 22);
            Enemy.TopConstraint = 25;
            Game.Enemy.Color = ConsoleColor.Green;
            Game.Enemy.AnimateUpDown(2200, 40, 1);
            EnemyHealth = 6;
            UpdateEnemyHealth();
        }

        public static void CreateBlossom()
        {
            Game.Enemy = new Enemy("blossom.txt", 225, 40);
            Enemy.TopConstraint = 25;
            Game.Enemy.Color = ConsoleColor.Red;
            Game.Enemy.AnimateUpDown(2000, 20, 1);
            EnemyHealth = 7;
            Enemy.fireballSpeedTimer.Interval = 50;
            UpdateEnemyHealth();
        }

        public static void Spash(string name, int time = 5000)
        {
            GameObject splashscreen = new GameObject(name, 1, 1);
            splashscreen.Draw();
            Thread.Sleep(time);
            Console.ReadKey();
        }

        public static void SystemCheck()
        {

            
            //resize the console 
            
            ConsoleHelper.SetConsoleFont(0);
            Console.CursorVisible = false;
            int maxWinHight = Console.LargestWindowHeight;
            int maxWinWidth = Console.LargestWindowWidth;
            if (maxWinHight < 116 || maxWinWidth < 300)
            {
                ConsoleHelper.SetConsoleFont(6);
                Console.WriteLine("System requirements not met.\nYour monitor resolution is too low.\nTry changing to a bigger setting.");
                Console.ReadKey();
            }

            try
            {
                ConsoleHelper.SetConsoleFont(0); //Set the font size to  the smallest possible
                Console.SetBufferSize(300, 116);
                Console.SetWindowSize(300, 116);
            }
            catch (ArgumentOutOfRangeException e)
            {
                ConsoleHelper.SetConsoleFont(6);
                Console.WriteLine("Resolution too low");
                Console.ReadKey();
                return;

            }
            Sounds.SetSoundsPaths();

            
        }
    }
}
