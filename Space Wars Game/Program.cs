using System;
using System.Text;
using System.IO;

// Game objects
using GameObjects;

/*About and notes
 * 
 * Alpha = Earth/Milky Way
 * Beta = Blasad/Pin Wheel Galaxy, 21 million lightyears away
 * Gamma = Maktom/Whirlpool Galaxy, 35 million lightyears away
 * Delta = Home of the Xenon/Black Eye Galaxy, 19000 Kilolightyears away
 * 
 * Transport Systems:
 * transport is done by a ship traveling through large rings. These rings
 * decompile the whole ship and its crew into data streams and send the stream
 * to another ring at another planet or star system. These rings were created by the Xenon,
 * but some have been captured and re-programmed by the Federation.
 * 
 * Weapons systems:
 * There are two types of weapons: LaserBeams and BlackMatter torpedos.
 * LaserBeams obviously do less damage than BlackMatter torpedos.
 * 
 * LaserBeams:
 * 
 * 
 * BlackMatter Torpedos:
 * Makes a black hole when colliding with an object.
 * It explodes the ship on contact then casuses the debre to collapse in on itself,
 * leaving nothing left in space.
 */
namespace Space_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            BEGIN:
            while (true)
            {
                // We need random numbers
                Random randomGen = new Random();
                // Build the state
                GameState gameState = new GameState();
                GameWindow gameWindow = new GameWindow();
                // Play introduction animations
                GameObjects.Animation.StartupAnimation();
                GameObjects.Animation.MainAnimation();
                // Ask for instruction
                string instrukt = "";
                bool didInstrukt = false;
                do
                {
                    Console.WriteLine("Do you need instruction?");
                    Console.Write("Y/N: ");
                    instrukt = Console.ReadLine();
                    switch (instrukt)
                    {
                        case "win":
                            {
                                Console.WriteLine("You have lost the game!!");
                                GameObjects.EasterEggs.InstructionEgg();
                                GameObjects.Command.LoseGame();
                                break;
                            }
                        case "Y":
                        case "y":
                            {
                                GameObjects.Command.Instruction();
                                Console.Clear();
                                didInstrukt = true;
                                break;
                            }
                        case "N":
                        case "n":
                            {
                                Console.Clear();
                                didInstrukt = true;
                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Incorrect answer!!");
                                break;
                            }
                    }
                } while (!didInstrukt);
                // Begin main loop
                while (true)
                {
                    // If win or lose
                    if (gameState.didIWin() || gameState.didIlose())
                    {
                        Console.Write("Continue? (y/n): ");
                        ConsoleKey key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.N:
                                {
                                    Console.WriteLine("Thank you for playing!");
                                    // Quit the game
                                    Environment.Exit(0);
                                    break;
                                }
                            case ConsoleKey.Y:
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid response.");
                                    break;
                                }
                        }
                        if(key == ConsoleKey.Y)
                        {
                            // Clear the game state, replay animations
                            // and return back to the instruction screen
                            break;
                        }
                    }
                    // Continue with normal game functions
                    GameObjects.Ship.HUD(gameState, gameWindow);
                    switch (GameObjects.Command.prompt())
                    {
                        case "xxx": goto BEGIN;
                        case "help":
                            {
                                GameObjects.Command.Help();
                                break;
                            }
                        case "nav":
                            {
                                GameObjects.Ship.NAV(gameState, gameWindow);
                                break;
                            }
                        case "las":
                            {
                                GameObjects.Ship.LASER(gameState, gameWindow);
                                break;
                            }
                        case "tor":
                            {
                                GameObjects.Ship.TORPEDO(gameState, gameWindow);
                                break;
                            }
                        case "she":
                            {
                                if(gameState.Enemies <= 0)
                                {
                                    gameState.EnergyLevel -= 100;
                                    if(randomGen.Next(1,6) == 6) 
                                    {
                                        gameState.ShieldLevel = GameObjects.GameState._SHIELD_MAX;
                                    } 
                                    else 
                                    {
                                        gameState.ShieldLevel = GameObjects.GameState._SHIELD_MAX / 2;
                                    }
                                    Console.WriteLine("Shields have been restored!!");
                                }
                                else
                                {
                                    Console.WriteLine("Cannot recharge shields!! Enemies are nearby!!");
                                }
                                break;
                            }
                        case "exit":
                            {
                                Console.WriteLine("Thank you for playing!");
                                Console.WriteLine("Exiting game...");
                                Environment.Exit(0);
                                break;
                            }
                        case "clear":
                            {
                                Console.Clear();
                                break;
                            }
                        case "repair":
                            {
                                if(gameState.Enemies <= 0)
                                {
                                    gameState.Damage = 0;
                                    Console.WriteLine("Repairs have been made.");
                                }
                                else
                                {
                                    Console.WriteLine("Cannot conduct repairs with enemies nearby!!");
                                }
                                break;
                            }
                        case "refuel":
                            {
                                if(gameState.Dimension == Dimension.D_EARTH)
                                {
                                    gameState.EnergyLevel = GameObjects.GameState._ENERGY_MAX;
                                    Console.WriteLine("Energy has been refilled!!");
                                }
                                else
                                {
                                    Console.WriteLine("Cannot refuel, not friendly bases nearby!!");
                                }
                                break;
                            }
                        case "die":
                            {
                                GameObjects.EasterEggs.MainLoopEgg();
                                gameState.EnergyLevel = 0;
                                gameState.ShieldLevel = 0;
                                gameState.Damage = 100;
                                Console.Write("What would you like to say:");
                                string dieing_wish = Console.ReadLine();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Incorrect command!!");
                                break;
                            }
                    }
                }
            }
            string ccceerr = Console.ReadLine();
        }
    }
}
