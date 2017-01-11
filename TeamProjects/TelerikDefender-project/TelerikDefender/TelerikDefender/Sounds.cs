using System;
using WMPLib;

using System.Media;
namespace TelerikDefender
{
    class Sounds
    {
        //Sounds played with Windows Media PLayer library

        //Intro Theme
        private static string introThemePath = Environment.CurrentDirectory + @"\Assets\Sounds\intro.mp3";
        private static WindowsMediaPlayer introTheme = new WindowsMediaPlayer();
        // Main  Music Theme
        private static string mainThemePath = Environment.CurrentDirectory +@"\Assets\Sounds\main.mp3";
        private static  WindowsMediaPlayer MainTheme = new WindowsMediaPlayer();

        //The sound for the sword swiping
        private static string swordSwipePath = Environment.CurrentDirectory + @"\Assets\Sounds\swipe.mp3";
        private static WindowsMediaPlayer swordSwipe = new WindowsMediaPlayer();

        //The sound for collision of the fireball with the building
        private static string buildingCollisionPath = Environment.CurrentDirectory +@"\Assets\Sounds\scream.mp3";
        private static WindowsMediaPlayer collision = new WindowsMediaPlayer();

        //The sound of the ninja star hitting the enemy
        private static string enemyHitPath = Environment.CurrentDirectory + @"\Assets\Sounds\hit.mp3" ;
        private static WindowsMediaPlayer enemyHit = new WindowsMediaPlayer();

        //The sound of the player striking the fireball
        private static string fireballHitPath = Environment.CurrentDirectory + @"\Assets\Sounds\fireball_hit.mp3";
        private static WindowsMediaPlayer fireballHit = new WindowsMediaPlayer();

        //The sound of the enemy throwing a fireball
        private static string fireballThrowPath = Environment.CurrentDirectory + @"\Assets\Sounds\fireball.mp3";
        private static WindowsMediaPlayer fireballThrow = new WindowsMediaPlayer();

        
        // Sounds played with System.Media.SoundPlayer
        public static SoundPlayer GameOverSound = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "gameOver.wav");
        public static SoundPlayer LevelUpSound = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "levelUp.wav");
        public static SoundPlayer GameWinSound = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "Win.wav");
        
        

        public static void SetSoundsPaths()
        {
            introTheme.URL = introThemePath;
            introTheme.controls.stop();
            introTheme.settings.setMode("loop", true);

            MainTheme.URL = mainThemePath;
            MainTheme.controls.stop();
            MainTheme.settings.setMode("loop", true);

            fireballThrow.URL = fireballThrowPath;
            fireballThrow.controls.stop();

            swordSwipe.URL = swordSwipePath;
            swordSwipe.controls.stop();

            collision.URL = buildingCollisionPath;
            collision.controls.stop();

            enemyHit.URL = enemyHitPath;
            enemyHit.controls.stop();

            fireballHit.URL = fireballHitPath;
            fireballHit.controls.stop();
        }

        public static void PlayIntroTheme()
        {
            introTheme.controls.play();
        }
        public static void StopIntroTheme()
        {
            introTheme.controls.stop();
        }
        public static void PlayMainTheme()
        {
            
            MainTheme.controls.play();
        }
        public static void StopMainTheme()
        {
            MainTheme.controls.stop();
        }
        public static void PlaySwordSwipe()
        {
            swordSwipe.controls.play();
        }
        public static void PlayBuildingCollision()
        {
            collision.controls.play();
        }
        public static void PlayEnemyHit()
        {
            enemyHit.controls.play();
        }
        public static void PlayFireballHit()
        {
            fireballHit.controls.play();
        }
        public static void PlayFireballThrow()
        {
            fireballThrow.controls.play();
        }

    }
}
