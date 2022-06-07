using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class Command
    {
        public static string prompt()
        {
            Console.Write("Command: ");
            return Console.ReadLine();
        }
        public static void Help()
        {
            Console.Clear();
            Console.WriteLine("==================== How to Play ====================");
            Console.WriteLine("|Objects on screen:                                 |");
            Console.WriteLine("| =@{  =  your ship                                 |");
            Console.WriteLine("| (F)  =  friendly base                             |");
            Console.WriteLine("| *    =  star                                      |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|Commands:                                          |");
            Console.WriteLine("| help = bring commands anytime                     |");
            Console.WriteLine("| nav  = navigate to other galaxies                 |");
            Console.WriteLine("| and space systems                                 |");
            Console.WriteLine("| las  = fire LaserBeam autocannons                 |");
            Console.WriteLine("| tor  = fire BlackMatter torpedos                  |");
            Console.WriteLine("| she  = restore shields[uses energy]               |");
            Console.WriteLine("| xxx  = restart the game                           |");
            Console.WriteLine("| exit = exit the game                              |");
            Console.WriteLine("| clear = clear the screen[if screen gets cluttered]|");
            Console.WriteLine("| refuel = Fill your energy when low, must be in    |");
            Console.WriteLine("| alpha dimension.                                  |");
            Console.WriteLine("| repair = Repair damaged ship, there must be no    |");
            Console.WriteLine("| enemies in Sector.                                |");
            Console.WriteLine("====================================================");
        }
        public static void Instruction()
        {
            Console.Clear();
            Console.WriteLine("==================== How to Play ====================");
            Console.WriteLine("|Objects on screen:                                 |");
            Console.WriteLine("| =@{  =  your ship                                 |");
            Console.WriteLine("| (F)  =  friendly base                             |");
            Console.WriteLine("| *    =  star                                      |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|Commands:                                          |");
            Console.WriteLine("| help = bring commands anytime                     |");
            Console.WriteLine("| nav  = navigate to other galaxies                 |");
            Console.WriteLine("| and space systems                                 |");
            Console.WriteLine("| las  = fire LaserBeam autocannons                 |");
            Console.WriteLine("| tor  = fire BlackMatter torpedos                  |");
            Console.WriteLine("| she  = restore shields[uses energy]               |");
            Console.WriteLine("| xxx  = restart the game                           |");
            Console.WriteLine("| exit = exit the game                              |");
            Console.WriteLine("| clear = Clear the screen[if screen gets cluttered]|");
            Console.WriteLine("| refuel = Fill your energy when low, must be in    |");
            Console.WriteLine("| earth dimension.                                  |");
            Console.WriteLine("| repair = Repair damaged ship, there must be no    |");
            Console.WriteLine("| enemies in Sector.                                |");
            Console.WriteLine("=====================================================");
            Console.WriteLine(" Note: you can only restore shields with no enemies nearby");
            Console.WriteLine(" It takes 200 energy to travel to different sectors.");
            Console.WriteLine(" And commands must be typed in correctly(the way they're spelled");
            Console.Write("Press enter to continue...");
            string quadeeeen = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your Navigation display:");
            Console.WriteLine("This displays your current location,");
            Console.WriteLine("in the sector and dimension.");
            Console.WriteLine("========== Navigation ===========");
            Console.WriteLine("|       2       |       3       |");
            Console.WriteLine("|               |               |");
            Console.WriteLine("|-------------- | --------------|");
            Console.WriteLine("|               |               |");
            Console.WriteLine("|   =@{ 1       |       4       |");
            Console.WriteLine("=================================");
            Console.WriteLine("Dimension: Alpha");
            Console.WriteLine("Sector: 1");
            Console.WriteLine("Technical Data-----");
            Console.WriteLine("SectorX: 1");
            Console.WriteLine("SectorY: 1");
            Console.WriteLine("As you can see, your ship is in sector: 1");
            Console.WriteLine("Note: you must type the name of the dimension correctly!");
            Console.WriteLine("Example: Alpha NOT alpha or ALPHA or AlPhA!!");
            Console.Write("press enter to continue...");
            string kfeugbweifbev = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("===================== Story =====================");
            Console.WriteLine("| 5 years ago while trying to explore the       |");
            Console.WriteLine("| Gamma Space a space ship called CSS Xevior    |");
            Console.WriteLine("| crash landed on an alien planet, Maktom.      |");
            Console.WriteLine("| Most of the crew was killed except for        |");
            Console.WriteLine("| Captain Thomas, Lutenant Bradson, and Chief   |");
            Console.WriteLine("| Engineer John Carlson. They abandoned their   |");
            Console.WriteLine("| ship, escaping the Xenon, an alien force      |");
            Console.WriteLine("| whose mission is to conquor the universe.     |");
            Console.WriteLine("| Thomas, Bradson, and Carlson made it off the  |");
            Console.WriteLine("| planet with an Xenonian ship, but doing so    |");
            Console.WriteLine("| gave the Xenon the location of Earth. Now     |");
            Console.WriteLine("| as a young Captain, you must save Earth,      |");
            Console.WriteLine("| and its anhabitants, from total annihilation. |");
            Console.WriteLine("=================================================");
            Console.WriteLine("Have fun!! ;-)");
            Console.Write("Press enter to continue...");
            string quaden = Console.ReadLine();
            Console.Clear();
        }
        public static void LoseGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================== Credits ====================");
            Console.WriteLine("C2014 By: Nathan Bunch / Taranoshi");
            Console.WriteLine("Designed, Written, and Programmed by: Taranoshi");
            Console.WriteLine("Gametesters: Mr. Cuddlesworth, and Skulker");
            Console.WriteLine("Thanks for Playing!!");
        }

        public static void WinGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have saved Earth from the Xenon!!");
            Console.WriteLine("Good work Captain!!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================== Credits ====================");
            Console.WriteLine("C2014 By:Taranoshi");
            Console.WriteLine("Designed, Written, and Programmed by:Taranoshi");
            Console.WriteLine("Gametesters: Mr. Cuddlesworth and Skulker");
            Console.WriteLine("Thanks for Playing!!");
            Console.WriteLine("Press enter to continue...");
            string WING = Console.ReadLine();
        }

    }
}
