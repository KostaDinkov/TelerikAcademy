/*
 * Lecture 4 : Console Input Output
 * Problem 11: Falling Rocks Game.
 */

/* Note: I have decided to take a bit different aproach in implementing the solution
 * - Not using Console.Clear();
 * - The objects are of bigger size than 1 symbol
 * - Collision Detection is a pain in the A**, and needs to be optimized for better performance
 * - Added some bonus functionality - difficulty, score, and power-ups
 * - Using the little knowledge of classes that i have, for learning purposes.
 * ToDo :
 * Some bugs with the missplaced symbols on the screen
 * Restart the NextLevel timer after getting a white power-up
 * Remove the delay of repeating a keystroke when a key is continuously pressed
 * Add some music
 * Add Bosses ;)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;


namespace _12.FallingRocksV2
{
    class FallingRocksV2
    {
        static void Main()
        {
            DrawPlayfield();
            StarShip myStarShip = new StarShip();
            List<Meteors> meteors = new List<Meteors>();
            Random randomGenerator = new Random();
            Player newPlayer = new Player();
            Game newGame = new Game();
            myStarShip.DrawShip();
            newPlayer.UpdateLives(0);
            while (true)
            {
                myStarShip.Move();
                //add a new meteor to the playfield depending on the frequency (lower value = higher freq)
                if (randomGenerator.Next(0, newGame.Frequency) == 0)
                {
                    Meteors newMeteor = new Meteors(randomGenerator.Next(0, Console.WindowWidth - 3),'@',ConsoleColor.Red);
                    meteors.Add(newMeteor);
                }
                if (randomGenerator.Next(0, 70) == 5)
                {
                    Meteors newMeteor = new Meteors(randomGenerator.Next(0, Console.WindowWidth - 3),'+',ConsoleColor.Green);
                    meteors.Add(newMeteor);
                }
                if (randomGenerator.Next(0, 70) == 5)
                {
                    Meteors newMeteor = new Meteors(randomGenerator.Next(0, Console.WindowWidth - 3), '$', ConsoleColor.Yellow);
                    meteors.Add(newMeteor);
                }
                if (randomGenerator.Next(0, 80) == 5)
                {
                    Meteors newMeteor = new Meteors(randomGenerator.Next(0, Console.WindowWidth - 3), '#', ConsoleColor.White);
                    meteors.Add(newMeteor);
                }
                for (int i = 0; i < meteors.Count; i++)
                {
                    if (meteors[i].Y + 12 >= Console.WindowHeight)
                    {
                        meteors[i].ClearMeteorite();
                        meteors.Remove(meteors[i]);
                        newPlayer.Score += 1;
                        newPlayer.UpdateScore();
                    }
                    meteors[i].Move();
                    //collision detection
                    for (int j = 0; j < meteors[i].Shape.GetLength(0); j++)
                    {
                        for (int k = 0; k < myStarShip.Shape.GetLength(0); k++)
                        {
                            if (meteors[i].Shape[j, 0] == myStarShip.Shape[k, 0] && meteors[i].Shape[j, 1] == myStarShip.Shape[k, 1])
                            {
                                if (meteors[i].Color == ConsoleColor.Red)
                                {
                                    Console.Beep();
                                    meteors[i].ClearMeteorite();
                                    meteors.Remove(meteors[i]);
                                    newPlayer.UpdateLives(-1);
                                }
                                else if (meteors[i].Color == ConsoleColor.Green)
                                {
                                    newPlayer.UpdateLives(1);
                                    meteors[i].ClearMeteorite();
                                    meteors.Remove(meteors[i]);
                                }
                                else if (meteors[i].Color == ConsoleColor.Yellow)
                                {
                                    newPlayer.Score += 50;
                                    meteors[i].ClearMeteorite();
                                    meteors.Remove(meteors[i]);
                                }
                                else if (meteors[i].Color == ConsoleColor.White)
                                {
                                    newGame.GameSpeed += 10;
                                    newGame.Frequency += 1;
                                    meteors[i].ClearMeteorite();
                                    meteors.Remove(meteors[i]);
                                }
                                
                            }
                        }
                    }
                }
                Thread.Sleep(newGame.GameSpeed);
                if (newPlayer.Lives == 0)
                {
                    newPlayer.GameOver();
                }
            }
        }
        static void DrawPlayfield()
        {
            Console.WindowHeight = 45;
            Console.WindowWidth = 90;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            //Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.CursorVisible = false;
            //draw info section
            Console.SetCursorPosition(0, Console.WindowHeight - 8);
            Console.Write(new string('_', Console.WindowWidth));
            Console.SetCursorPosition(5, Console.WindowHeight - 7);
            Console.Write("Player Lives: ");
            Console.SetCursorPosition(5, Console.WindowHeight - 5);
            Console.Write("Player Score: ");
            Console.SetCursorPosition(5, Console.WindowHeight - 3);
            Console.Write("Difficulty Level: ");
            Console.SetCursorPosition(59, Console.WindowHeight - 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Green  -> +1 Life. ");
            Console.SetCursorPosition(59, Console.WindowHeight - 5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Yellow -> +50 points ");
            Console.SetCursorPosition(59, Console.WindowHeight - 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red    -> DANGER!");
            Console.SetCursorPosition(59, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("White  -> Decrease Difficulty");
            
        }
    }
    public class Game
    {
        private int gameSpeed;
        private int level;
        private int frequency;
        public System.Timers.Timer timer = new System.Timers.Timer();
        public Game()
        {
            this.gameSpeed = 100;
            this.level = 1;
            this.frequency = 5;
            timer.Elapsed += new ElapsedEventHandler(LevelUp);
            this.timer.Interval = 10000 ;
            this.timer.Enabled = true;
            
        }
        private  void LevelUp(object source, ElapsedEventArgs e)
        {
            this.level += 1;
            if (this.gameSpeed>0)
            {
                this.gameSpeed -= 10;
            }
            if (this.frequency>1)
            {
                frequency--;
            }
            Console.SetCursorPosition(23, Console.WindowHeight - 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0  }",this.level);
            
        }
        public int Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                this.frequency = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }
        public int GameSpeed
        {
            get
            {
                return this.gameSpeed;
            }
            set
            {
                this.gameSpeed = value;
            }

        }
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.level += 1;
        }
    }
    public class Player
    {
        private int lives;
        private int score;
        

        public int Lives
        {
            get
            {
                return this.lives;
            }
            set
            {
                this.lives = value;
            }
        }
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }

        }
        
        public Player()
        {
            lives = 5;
            score = 0;
            
        }
        public void UpdateLives(int x)
        {
            this.lives += x;
            Console.SetCursorPosition(21, Console.WindowHeight - 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.lives+"   ");
        }
        public void UpdateScore()
        {
            Console.SetCursorPosition(21, Console.WindowHeight - 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.score);
        }
        
        public void GameOver()
        {
            Console.SetCursorPosition(30, Console.WindowHeight - 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("GAME OVER!!!    ");
            Console.SetCursorPosition(30, Console.WindowHeight - 2);
            Environment.Exit(0);

        }
    }
    public class StarShip
    {
        private char symbol;
        private int x;
        private int y;
        ConsoleColor color;
        private int[,] shape;
        public int[,] Shape
        {
            get
            {
                return this.shape;
            }
        }
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
        }
        public StarShip()
        {
            this.x = Console.WindowWidth / 2;
            this.y = Console.WindowHeight - 11;
            this.color = ConsoleColor.Yellow;
            this.symbol = '^';


        }
        public void Move()
        {

            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                ClearShip();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (this.x - 2 >= 0)
                    {
                        this.x -= 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (this.x + 2 < Console.WindowWidth)
                    {
                        this.x += 1;
                    }
                }
                DrawShip();
            }
        }
        private void ClearShip()
        {
            this.shape = new int[,]
            {
                {this.x,this.y},
                {this.x-1,this.y+1},
                {this.x,this.y+1},
                {this.x+1,this.y+1}
            };
            for (int i = 0; i < this.shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(this.shape[i, 0], this.shape[i, 1]);
                Console.ForegroundColor = this.color;
                Console.Write(' ');
            }
        }
        public void DrawShip()
        {
            this.shape = new int[,]
            {
                {this.x,this.y},
                {this.x-1,this.y+1},
                {this.x,this.y+1},
                {this.x+1,this.y+1}
            };
            for (int i = 0; i < this.shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(this.shape[i, 0], this.shape[i, 1]);
                Console.ForegroundColor = this.color;
                Console.Write(this.symbol);
            }
        }
    }
    public class Meteors
    {
        private int x;
        private int y;
        private char symbol;
        private ConsoleColor color;
        private int[,] shape;
        public int[,] Shape
        {
            get
            {
                return this.shape;
            }
        }
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
        }
        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }
        public Meteors(int x, char symbol,ConsoleColor color)
        {
            this.x = x;
            this.y = 3;
            this.color = color;
            this.symbol = symbol;
        }
        public void Move()
        {
            ClearMeteorite();
            if (this.y < Console.WindowHeight - 10)
            {
                this.y += 1;
            }
            DrawMeteorite();
        }
        public void ClearMeteorite()
        {
            this.shape = new int[,]
            {
                {this.x,this.y},
                {this.x+1,this.y},
                {this.x+2,this.y},
                {this.x,this.y+1},
                {this.x+1,this.y+1},
                {this.x+2,this.y+1}
            };
            for (int i = 0; i < this.shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(this.shape[i, 0], this.shape[i, 1]);
                Console.Write(' ');
            }
        }
        private void DrawMeteorite()
        {
            this.shape = new int[,]
            {
                {this.x,this.y},
                {this.x+1,this.y},
                {this.x+2,this.y},
                {this.x,this.y+1},
                {this.x+1,this.y+1},
                {this.x+2,this.y+1}
            };

            for (int i = 0; i < this.shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(this.shape[i, 0], this.shape[i, 1]);
                Console.ForegroundColor = this.color;
                Console.Write(this.symbol);
            }
        }

    }

}
