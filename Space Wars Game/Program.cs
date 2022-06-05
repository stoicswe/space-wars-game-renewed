using System;
using System.Text;
using System.IO;

namespace GameObjects
{
    class Ship
    {
        public static void HUD(int Energy, int Shield, string SectorX, string SectorY, string Dimension, string Condition, int Damage, int Enemies)
        {
            if (Damage > 0 & Enemies > 0)
            {
                Condition = "Red";
                goto ColorSet;
            }
            else
                if (Damage > 0 & Enemies == 0)
            {
                Condition = "Yellow";
                goto ColorSet;
            }
            else
                    if (Damage > 50 & Enemies == 0)
            {
                Condition = "Red";
                goto ColorSet;
            }
            else
                        if (Damage == 0 & Enemies > 0)
            {
                Condition = "Yellow";
                goto ColorSet;
            }
            else
                            if (Damage == 0 & Enemies == 0)
            {
                Condition = "Green";
                goto ColorSet;
            }
        ColorSet:
            if (Condition == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                goto Alpha;
            }
            else
                if (Condition == "Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                goto Alpha;
            }
            else
                    if (Condition == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                goto Alpha;
            }
        Alpha:
            string Earth1 = "|.....*...*......*...|              | Dimension: Earth";
            string Earth2 = "|..*..........*......|              | SectorX:   " + SectorX;
            string Earth3 = "|.....*.....*.....*..|              | SectorY:   " + SectorY;
            string Earth4 = "|.*......(F).........|              | Shields:   " + Shield + "%";
            string Earth5 = "|.....*.......*......|              | Energy:    " + Energy + " dmu";
            string Earth6 = "|..*......*.*....**..|              | Condition: " + Condition;
            string Earth7 = "|....=@{......*.....*|              | Damage:    " + Damage + "%";
            string Earth8 = "----------------------              | Enemies:   " + Enemies;

            string Alpha1 = "|.....*...*......*...|              | Dimension: Alpha";
            string Alpha2 = "|..*..........*......|              | SectorX:   " + SectorX;
            string Alpha3 = "|.....*.....*.....*..|              | SectorY:   " + SectorY;
            string Alpha4 = "|.*.......*..........|              | Shields:   " + Shield + "%";
            string Alpha5 = "|.....*.......*......|              | Energy:    " + Energy + " dmu";
            string Alpha6 = "|..*......*.*....**..|              | Condition: " + Condition;
            string Alpha7 = "|....=@{......*.....*|              | Damage:    " + Damage + "%";
            string Alpha8 = "----------------------              | Enemies:   " + Enemies;

            string Beta1 = "|.....*..........*...|              | Dimension: Beta";
            string Beta2 = "|..*..........*......|              | SectorX:   " + SectorX;
            string Beta3 = "|.....*...........*..|              | SectorY:   " + SectorY;
            string Beta4 = "|.*.....*........*...|              | Shields:   " + Shield + "%";
            string Beta5 = "|.....*..............|              | Energy:    " + Energy + " dmu";
            string Beta6 = "|..*.....*...........|              | Condition: " + Condition;
            string Beta7 = "|....=@{......*.....*|              | Damage:    " + Damage + "%";
            string Beta8 = "----------------------              | Enemies:   " + Enemies;

            string Gamma1 = "|.....*...*......*...|              | Dimension: Gamma";
            string Gamma2 = "|..*.................|              | SectorX:   " + SectorX;
            string Gamma3 = "|....................|              | SectorY:   " + SectorY;
            string Gamma4 = "|.*..................|              | Shields:   " + Shield + "%";
            string Gamma5 = "|.....*.......*......|              | Energy:    " + Energy + " dmu";
            string Gamma6 = "|..*......*.*....**..|              | Condition: " + Condition;
            string Gamma7 = "|....=@{......*.....*|              | Damage:    " + Damage + "%";
            string Gamma8 = "----------------------              | Enemies:   " + Enemies;

            string Delta1 = "|.....*...*......*...|              | Dimension: Delta";
            string Delta2 = "|..*..........*......|              | SectorX:   " + SectorX;
            string Delta3 = "|.....*.....*.....*..|              | SectorY:   " + SectorY;
            string Delta4 = "|.*..................|              | Shields:   " + Shield + "%";
            string Delta5 = "|.....*.......*......|              | Energy:    " + Energy + " dmu";
            string Delta6 = "|..*......*.*....**..|              | Condition: " + Condition;
            string Delta7 = "|....=@{......*.....*|              | Damage:    " + Damage + "%";
            string Delta8 = "----------------------              | Enemies:   " + Enemies;
            Console.WriteLine("====================== USS Infatron ===========================");
            if (Dimension == "Earth")
            {
                Console.WriteLine(Earth1);
                Console.WriteLine(Earth2);
                Console.WriteLine(Earth3);
                Console.WriteLine(Earth4);
                Console.WriteLine(Earth5);
                Console.WriteLine(Earth6);
                Console.WriteLine(Earth7);
                Console.WriteLine(Earth8);
                goto ContinueHUD;
            }
            else
            if (Dimension == "Alpha")
            {
                Console.WriteLine(Alpha1);
                Console.WriteLine(Alpha2);
                Console.WriteLine(Alpha3);
                Console.WriteLine(Alpha4);
                Console.WriteLine(Alpha5);
                Console.WriteLine(Alpha6);
                Console.WriteLine(Alpha7);
                Console.WriteLine(Alpha8);
                goto ContinueHUD;
            }
            else
                if (Dimension == "Beta")
            {
                Console.WriteLine(Beta1);
                Console.WriteLine(Beta2);
                Console.WriteLine(Beta3);
                Console.WriteLine(Beta4);
                Console.WriteLine(Beta5);
                Console.WriteLine(Beta6);
                Console.WriteLine(Beta7);
                Console.WriteLine(Beta8);
                goto ContinueHUD;
            }
            else
                    if (Dimension == "Gamma")
            {
                Console.WriteLine(Gamma1);
                Console.WriteLine(Gamma2);
                Console.WriteLine(Gamma3);
                Console.WriteLine(Gamma4);
                Console.WriteLine(Gamma5);
                Console.WriteLine(Gamma6);
                Console.WriteLine(Gamma7);
                Console.WriteLine(Gamma8);
                goto ContinueHUD;
            }
            else
                        if (Dimension == "Delta")
            {
                Console.WriteLine(Delta1);
                Console.WriteLine(Delta2);
                Console.WriteLine(Delta3);
                Console.WriteLine(Delta4);
                Console.WriteLine(Delta5);
                Console.WriteLine(Delta6);
                Console.WriteLine(Delta7);
                Console.WriteLine(Delta8);
            }
        ContinueHUD:
            Console.WriteLine("===============================================================");
        }

    }
    class Command
    {
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

    }
    class Animation
    {
        public static void TravelAnimation(int TIME)
        {
            Console.Clear();
            int i;
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
            Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
            Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
            Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
            Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
            Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
            Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
            Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
            Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
            Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
            Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
            Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
            Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
            Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
            Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
            Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
            Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
            Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
            Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
            Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
            Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
            Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
            Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
            Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
            Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
            Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
            Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
            Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
            Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
            Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
            Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
            Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
            Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
            Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
            Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
            Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
            Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
            Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
            Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
            Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
            Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
            Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
            Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
            Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
            Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
            Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
            Console.Clear();

        }
        public static void LaserFireAnimation(string lstate)
        {
            int i;
            if (lstate == "hit")
            {
                int TIME = 30000000;
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" = -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("== -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=== -  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======- -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("=======-  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("======== - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("========= -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==========   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("===========- -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("============-   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=============  -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("==============-   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("===============  -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("================ -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("==================  -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("===================-   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====================  -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====================-  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======================   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine("======================  - = - - - -   -  - - ");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine("======================  - == - - - -   -  - -");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine(" =====================  - === - - - -   -  - ");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine("  ===================  - ==== - - - -   -  - ");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    - : \\-// :   -    - - -    ");
                Console.WriteLine("   ==================  - ===== - - - -   -  -");
                Console.WriteLine("-   -   -    -  -- : //-\\ : -    -   - --   ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - - : -\\ | //-:   -    -     - ");
                Console.WriteLine("-  -    -   -    - : \\-// :   -    - - -    ");
                Console.WriteLine("     ================  - ======= - - - -   - ");
                Console.WriteLine("-   -   -    -  -- : //-\\ : -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :  // | \\ : - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  -  : - \\  | -//  : -   - - -  - ");
                Console.WriteLine("- -   - -    - - : -\\ | //-:   -    -     - ");
                Console.WriteLine("-  -    -   -    - :   -   :   -    - - -    ");
                Console.WriteLine("       ==============  - ========= - - - -   ");
                Console.WriteLine("-   -   -    -  -- :   -   : -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :  // | \\ : - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -  // -|  \\  :- -- -  -  -- ");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -  \\ - |- -// -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -  : - \\  | -//  : -   - - -  - ");
                Console.WriteLine("- -   - -    - - : -   |   -:   -    -     - ");
                Console.WriteLine("-  -    -   -    - :   -   :   -    - - -    ");
                Console.WriteLine("       =============   -  ======== - - - -   ");
                Console.WriteLine("-   -   -    -  -- :   -   : -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :     |    : - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -  // -|  \\  :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - - // - |   \\- :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -  \\ - |- -// -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -  : -     | -    : -   - - -  - ");
                Console.WriteLine("- -   - -    - - : -       -:   -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       ===========     -    ====== - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :          : - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -  // -|  \\  :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - - // - |   \\- :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -     - |- -   -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -  : -       -    : -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       =========       -      ==== - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -     -       :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - - // - |   \\- :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -     -  - -   -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       =======         -        == - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -     -       :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - -    -       - :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -      -     -  - -   -   -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       ====            -           - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  -   -     -        - -- -  -  -- ");
                Console.WriteLine(" - -    -   : - -    -       - :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -      -     -  - -   -   -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       =               -           - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  -   -     -        - -- -  -  -- ");
                Console.WriteLine(" - -    -     - -    -       -     -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -      -     -  - -   -   -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("                       -           - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  -   -     -        - -- -  -  -- ");
                Console.WriteLine(" - -    -     - -    -       -     -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
            }
            if (lstate == "miss")
            {
                Console.Clear();
                int TIME = 30000000;
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" = -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("== -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=== -  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======- -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("=======-  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("======== - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("========= -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==========   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("===========- -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("============-   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=============  -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("==============-   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("===============  -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("================ -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("==================  -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("===================-   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====================  -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====================-  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======================   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("========================  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("=========================- - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==========================- - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("=========================== - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("============================ - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("============================= - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("============================== -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("===============================   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("================================- -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("=================================-   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("==================================  -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("===================================-  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==================================== - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("===================================== -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("======================================  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=======================================- -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("========================================-   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=========================================  --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("========================================== - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("===========================================  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("============================================ ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
            }
        }
        public static void TorpedoFireAnimation(string tstate)
        {
            int i;
            if (tstate == "hit")
            {
                int TIME = 30000000;
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" = -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("== -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=== -  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======- -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("=======-  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("======== - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("========= -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==========   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("===========- -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("============-   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=============  -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("==============-   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("===============  -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("================ -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("==================  -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("===================-   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====================  -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====================-  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======================   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine("======================  - = - - - -   -  - - ");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine("======================  - == - - - -   -  - -");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine(" =====================  - === - - - -   -  - ");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    -   \\-//    -    - - -     ");
                Console.WriteLine("  ===================  - ==== - - - -   -  - ");
                Console.WriteLine("-   -   -    -  ---  //-\\  -    -   - --    ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - -   -\\ | //-   -    -     -  ");
                Console.WriteLine("-  -    -   -    - : \\-// :   -    - - -    ");
                Console.WriteLine("   ==================  - ===== - - - -   -  -");
                Console.WriteLine("-   -   -    -  -- : //-\\ : -    -   - --   ");
                Console.WriteLine("- -  -  - - - - -   // | \\ - - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  - -  - \\  | -// - -   - - -  -  ");
                Console.WriteLine("- -   - -    - - : -\\ | //-:   -    -     - ");
                Console.WriteLine("-  -    -   -    - : \\-// :   -    - - -    ");
                Console.WriteLine("     ================  - ======= - - - -   - ");
                Console.WriteLine("-   -   -    -  -- : //-\\ : -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :  // | \\ : - -   - - - - -");
                Console.WriteLine("- -  -   -  - - -  // -|  \\  - -- -  -  -- -");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -  \\ - |- -// -  -   -  - - -");
                Console.WriteLine(" -  --   -  -  : - \\  | -//  : -   - - -  - ");
                Console.WriteLine("- -   - -    - - : -\\ | //-:   -    -     - ");
                Console.WriteLine("-  -    -   -    - :   -   :   -    - - -    ");
                Console.WriteLine("       ==============  - ========= - - - -   ");
                Console.WriteLine("-   -   -    -  -- :   -   : -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :  // | \\ : - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -  // -|  \\  :- -- -  -  -- ");
                Console.WriteLine(" - -    -     - - // - |   \\-    -  - --    ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -  \\ - |- -// -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -  : - \\  | -//  : -   - - -  - ");
                Console.WriteLine("- -   - -    - - : -   |   -:   -    -     - ");
                Console.WriteLine("-  -    -   -    - :   -   :   -    - - -    ");
                Console.WriteLine("       =============   -  ======== - - - -   ");
                Console.WriteLine("-   -   -    -  -- :   -   : -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :     |    : - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -  // -|  \\  :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - - // - |   \\- :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -  \\ - |- -// -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -  : -     | -    : -   - - -  - ");
                Console.WriteLine("- -   - -    - - : -       -:   -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       ===========     -    ====== - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -  :          : - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -  // -|  \\  :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - - // - |   \\- :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -     - |- -   -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -  : -       -    : -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       =========       -      ==== - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -     -       :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - - // - |   \\- :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    : -     -  - -   -:  -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       =======         -        == - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  - : -     -       :- -- -  -  -- ");
                Console.WriteLine(" - -    -   : - -    -       - :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -      -     -  - -   -   -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       ====            -           - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  -   -     -        - -- -  -  -- ");
                Console.WriteLine(" - -    -   : - -    -       - :   -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -      -     -  - -   -   -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("       =               -           - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  -   -     -        - -- -  -  -- ");
                Console.WriteLine(" - -    -     - -    -       -     -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -      -     -  - -   -   -   -  - - ");
                Console.WriteLine(" -  --   -  -    -       -      -   - - -  - ");
                Console.WriteLine("- -   - -    - -   -       -    -    -     - ");
                Console.WriteLine("-  -    -   -    -     -       -    - - -    ");
                Console.WriteLine("                       -           - - - -   ");
                Console.WriteLine("-   -   -    -  --     -     -    -   - --   ");
                Console.WriteLine("- -  -  - - - -               - -   - - - - -");
                Console.WriteLine("- -  -   -  -   -     -        - -- -  -  -- ");
                Console.WriteLine(" - -    -     - -    -       -     -  - --   ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" - -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("- -  - -  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine(" -  - -  - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
            }
            if (tstate == "miss")
            {
                Console.Clear();
                int TIME = 30000000;
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine(" = -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("== -  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=== -  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====  - -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====  - -  - -   -   -   -  - - - -   -  - -");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======- -  - -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("=======-  - -   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("======== - -   -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("========= -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==========   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("===========- -   -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("============-   -   -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=============  -   -   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("==============-   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("===============  -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("================ -   -   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("==================  -   -  - - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("===================-   -  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("====================  -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=====================-  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("======================   -  - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("========================  - - - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("=========================- - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==========================- - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("=========================== - - - -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("============================ - - -   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("============================= - -   -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("============================== -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("===============================   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("================================- -   -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("=================================-   -  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("==================================  -  - -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("===================================-  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("==================================== - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("===================================== -  - - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("======================================  - -  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("=======================================- -   ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("========================================-   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("=========================================  --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("-      -    -  --   - -   -   -  -  - -   ---");
                Console.WriteLine(" - - -   -    - -   - -  - - -  -   -  - - - ");
                Console.WriteLine("- -  --   -  - -  - -  - - - -   - - -  -  - ");
                Console.WriteLine(" - -   - -    - -   -    -   -    -     -   -");
                Console.WriteLine(" -  -    -   -    -    -    -    - - -     - ");
                Console.WriteLine("========================================== - ");
                Console.WriteLine(" -   -   -    -  ---   -  -    -   - --    - ");
                Console.WriteLine(" - -  -  - - - - -   -  - - - -   - - - -   -");
                Console.WriteLine(" - -  -   -  - - -  - - -   - -- -  -  -- -  ");
                Console.WriteLine("  - -    -     - -   -     -    -  - --     -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("      -    -  --   - -   -   -  -  - -   --- ");
                Console.WriteLine("- - -   -    - -   - -  - - -  -   -  - - -  ");
                Console.WriteLine(" -  --   -  - -  - -  - - - -   - - -  -  -  ");
                Console.WriteLine("- -   - -    - -   -    -   -    -     -   - ");
                Console.WriteLine("-  -    -   -    -    -    -    - - -     -  ");
                Console.WriteLine("===========================================  ");
                Console.WriteLine("-   -   -    -  ---   -  -    -   - --    -  ");
                Console.WriteLine("- -  -  - - - - -   -  - - - -   - - - -   - ");
                Console.WriteLine("- -  -   -  - - -  - - -   - -- -  -  -- -   ");
                Console.WriteLine(" - -    -     - -   -     -    -  - --     - ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("     -    -  --   - -   -   -  -  - -   ---  ");
                Console.WriteLine(" - -   -    - -   - -  - - -  -   -  - - -  -");
                Console.WriteLine("-  --   -  - -  - -  - - - -   - - -  -  -   ");
                Console.WriteLine(" -   - -    - -   -    -   -    -     -   -  ");
                Console.WriteLine("  -    -   -    -    -    -    - - -     -  -");
                Console.WriteLine("============================================ ");
                Console.WriteLine("   -   -    -  ---   -  -    -   - --    -  -");
                Console.WriteLine(" -  -  - - - - -   -  - - - -   - - - -   - -");
                Console.WriteLine(" -  -   -  - - -  - - -   - -- -  -  -- -    ");
                Console.WriteLine("- -    -     - -   -     -    -  - --     -  ");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
                Console.Clear();
                Console.WriteLine("    -    -  --   - -   -   -  -  - -   ---  -");
                Console.WriteLine("- -   -    - -   - -  - - -  -   -  - - -  - ");
                Console.WriteLine("  --   -  - -  - -  - - - -   - - -  -  -   -");
                Console.WriteLine("-   - -    - -   -    -   -    -     -   -   ");
                Console.WriteLine(" -    -   -    -    -    -    - - -     -  --");
                Console.WriteLine("-  - -  - -   -   -   -  - - - -   -  - -   -");
                Console.WriteLine("  -   -    -  ---   -  -    -   - --    -  - ");
                Console.WriteLine("-  -  - - - - -   -  - - - -   - - - -   - - ");
                Console.WriteLine("-  -   -  - - -  - - -   - -- -  -  -- -    -");
                Console.WriteLine(" -    -     - -   -     -    -  - --     -  -");
                for (i = 0; i < TIME; i++)
                {
                }
                Console.Clear();
                Console.WriteLine("   -    -  --   - -   -   -  -  - -   ---  --");
                Console.WriteLine(" -   -    - -   - -  - - -  -   -  - - -  - -");
                Console.WriteLine(" --   -  - -  - -  - - - -   - - -  -  -   --");
                Console.WriteLine("   - -    - -   -    -   -    -     -   -   -");
                Console.WriteLine("-    -   -    -    -    -    - - -     -  ---");
                Console.WriteLine("  - -  - -   -   -   -  - - - -   -  - -   --");
                Console.WriteLine(" -   -    -  ---   -  -    -   - --    -  - -");
                Console.WriteLine("  -  - - - - -   -  - - - -   - - - -   - - -");
                Console.WriteLine("  -   -  - - -  - - -   - -- -  -  -- -    --");
                Console.WriteLine("-    -     - -   -     -    -  - --     -  --");
                Console.Clear();
            }
        }
        public static void StartupAnimation()
        {
            int TIME = 30000000;
            int i;
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("...*.......*.......**...*....*......*..*...*...*...*..*.*");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*.*..**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*..*....*.......*....*..");
            Console.WriteLine("....*...*..*......*...*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*....*...*....*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.............*...*...");
            Console.WriteLine("***....*.......*..*.....*.....*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*...**....*...*.....*....*....*...*......**..");
            Console.WriteLine("*.....*....*....***....*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*..*.....*....*....*..*...*....");
            Console.WriteLine("**....*....**..........*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("..*.......*.......**...*....*......*..*...*...*...*..*.*.");
            Console.WriteLine("*.*...*..*....*.......*...*..*....*...*..*....**.*..*.*..");
            Console.WriteLine(".*..*...*..**..*...*....*..*..*.....*.....*...*....*....*");
            Console.WriteLine("*........*....*..*...*...*..*....*.......*.......*....*..");
            Console.WriteLine("....*...*..*..........*.....*..*.*...*...*...*..*...*....");
            Console.WriteLine(".*..*....*....*.....*....*....*....*...*..*.......*......");
            Console.WriteLine("*.*........*....*..*...*.........*...........*...*...*.*.");
            Console.WriteLine(".....*..*...A.Singularity.Studios.Creation......*...*....");
            Console.WriteLine("..*.............*.......*.......*.......*....*....*....*.");
            Console.WriteLine("*...*....*...*.......*......*......*.................*...");
            Console.WriteLine("***....*.......*..*...........*.......*.....*...*..*....*");
            Console.WriteLine("....*.....*.*.........*...*..........*....*...*......**..");
            Console.WriteLine("*.....*....*...........*......**....*....*.......*....**.");
            Console.WriteLine("..**.....*..........*.....*.............*.......*...*....");
            Console.WriteLine("**.....................*.........*....*...*...........*..");
            Console.WriteLine("...*.....*.....*...*......*....*....*.......*.....*......");
            for (i = 0; i < TIME; i++)
            {
            }
        }
        public static void MainAnimation()
        {
            try
            {
                Console.WindowHeight = 50;
                Console.WindowWidth = 60;
            }
            catch
            {
                Console.WriteLine("Minor resolution config error.....skipping resolution config.");
            }
            int TIME = 30000000;
            int i;
            Console.Clear();
            Console.WriteLine("==.=========================================================");
            Console.WriteLine("===.========================================================");
            Console.WriteLine("====.=======================================================");
            Console.WriteLine("=====.======================================================");
            Console.WriteLine("======.=====================================================");
            Console.WriteLine("=======.====================================================");
            Console.WriteLine("========.===================================================");
            Console.WriteLine("=========.==================================================");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.====================================================");
            Console.WriteLine("======.=====================================================");
            Console.WriteLine("=====.======================================================");
            Console.WriteLine("====.=======================================================");
            Console.WriteLine("===.========================================================");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.========================================================#");
            Console.WriteLine("===.======================================================#=");
            Console.WriteLine("====.====================================================#==");
            Console.WriteLine("=====.====================================================##");
            Console.WriteLine("======.=====================================================");
            Console.WriteLine("=======.====================================================");
            Console.WriteLine("========.===================================================");
            Console.WriteLine("=========.==============================================###=");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=================================================#==");
            Console.WriteLine("======.==================================================#==");
            Console.WriteLine("=====.===================================================#==");
            Console.WriteLine("====.====================================================#==");
            Console.WriteLine("===.======================================================##");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=======================================================##");
            Console.WriteLine("===.=====================================================#==");
            Console.WriteLine("====.===================================================#===");
            Console.WriteLine("=====.===================================================###");
            Console.WriteLine("======.=====================================================");
            Console.WriteLine("=======.====================================================");
            Console.WriteLine("========.==================================================#");
            Console.WriteLine("=========.=============================================###==");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.================================================#===");
            Console.WriteLine("======.=================================================#==#");
            Console.WriteLine("=====.==================================================#==#");
            Console.WriteLine("====.===================================================#==#");
            Console.WriteLine("===.=====================================================##=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.======================================================###");
            Console.WriteLine("===.====================================================#===");
            Console.WriteLine("====.==================================================#====");
            Console.WriteLine("=====.==================================================###=");
            Console.WriteLine("======.====================================================#");
            Console.WriteLine("=======.====================================================");
            Console.WriteLine("========.==================================================#");
            Console.WriteLine("=========.=============================================###==");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===============================================#====");
            Console.WriteLine("======.================================================#==#=");
            Console.WriteLine("=====.=================================================#==#=");
            Console.WriteLine("====.==================================================#==#=");
            Console.WriteLine("===.====================================================##=#");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=====================================================####");
            Console.WriteLine("===.===================================================#====");
            Console.WriteLine("====.=================================================#=====");
            Console.WriteLine("=====.=================================================###==");
            Console.WriteLine("======.===================================================#=");
            Console.WriteLine("=======.===================================================#");
            Console.WriteLine("========.=================================================#=");
            Console.WriteLine("=========.============================================###===");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==============================================#=====");
            Console.WriteLine("======.===============================================#==#==");
            Console.WriteLine("=====.================================================#==#==");
            Console.WriteLine("====.=================================================#==#==");
            Console.WriteLine("===.===================================================##=##");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.====================================================####=");
            Console.WriteLine("===.=================================================#======");
            Console.WriteLine("====.===============================================#=======");
            Console.WriteLine("=====.================================================###===");
            Console.WriteLine("======.==================================================#==");
            Console.WriteLine("=======.==================================================#=");
            Console.WriteLine("========.================================================#==");
            Console.WriteLine("=========.===========================================###====");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=============================================#=====#");
            Console.WriteLine("======.==============================================#==#==#");
            Console.WriteLine("=====.===============================================#==#==#");
            Console.WriteLine("====.================================================#==#==#");
            Console.WriteLine("===.==================================================##=##=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.===================================================####==");
            Console.WriteLine("===.================================================#=======");
            Console.WriteLine("====.==============================================#========");
            Console.WriteLine("=====.===============================================###====");
            Console.WriteLine("======.=================================================#===");
            Console.WriteLine("=======.=================================================#==");
            Console.WriteLine("========.==============================================#====");
            Console.WriteLine("=========.=========================================###======");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=========================================#=====#==##");
            Console.WriteLine("======.==========================================#==#==#==#=");
            Console.WriteLine("=====.===========================================#==#==#==##");
            Console.WriteLine("====.============================================#==#==#==#=");
            Console.WriteLine("===.==============================================##=##===#=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=================================================####===");
            Console.WriteLine("===.==============================================#========");
            Console.WriteLine("====.============================================#=========");
            Console.WriteLine("=====.==============================================###=====");
            Console.WriteLine("======.================================================#====");
            Console.WriteLine("=======.================================================#===");
            Console.WriteLine("========.=============================================#=====");
            Console.WriteLine("=========.========================================###=======");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.========================================#=====#==###");
            Console.WriteLine("======.=========================================#==#==#==#==");
            Console.WriteLine("=====.==========================================#==#==#==###");
            Console.WriteLine("====.===========================================#==#==#==#==");
            Console.WriteLine("===.=============================================##=##===#==");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=================================================####====");
            Console.WriteLine("===.==============================================#=========");
            Console.WriteLine("====.============================================#==========");
            Console.WriteLine("=====.=============================================###======");
            Console.WriteLine("======.===============================================#=====");
            Console.WriteLine("=======.===============================================#====");
            Console.WriteLine("========.============================================#======");
            Console.WriteLine("=========.=======================================###========");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=======================================#=====#==####");
            Console.WriteLine("======.========================================#==#==#==#===");
            Console.WriteLine("=====.=========================================#==#==#==####");
            Console.WriteLine("====.==========================================#==#==#==#===");
            Console.WriteLine("===.============================================##=##===#===");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.================================================####=====");
            Console.WriteLine("===.=============================================#=========#");
            Console.WriteLine("====.===========================================#==========#");
            Console.WriteLine("=====.============================================###======#");
            Console.WriteLine("======.==============================================#=====#");
            Console.WriteLine("=======.==============================================#====#");
            Console.WriteLine("========.===========================================#======#");
            Console.WriteLine("=========.======================================###========#");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.======================================#=====#==#####");
            Console.WriteLine("======.=======================================#==#==#==#====");
            Console.WriteLine("=====.========================================#==#==#==#####");
            Console.WriteLine("====.=========================================#==#==#==#====");
            Console.WriteLine("===.===========================================##=##===#====");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.===============================================####=====#");
            Console.WriteLine("===.============================================#=========#=");
            Console.WriteLine("====.==========================================#==========#=");
            Console.WriteLine("=====.===========================================###======##");
            Console.WriteLine("======.=============================================#=====#=");
            Console.WriteLine("=======.=============================================#====#=");
            Console.WriteLine("========.==========================================#======#=");
            Console.WriteLine("=========.=====================================###========#=");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.====================================#=====#==######=");
            Console.WriteLine("======.=====================================#==#==#==#====#=");
            Console.WriteLine("=====.======================================#==#==#==######=");
            Console.WriteLine("====.=======================================#==#==#==#====#=");
            Console.WriteLine("===.=========================================##=##===#====#=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.==============================================####=====##");
            Console.WriteLine("===.===========================================#=========#==");
            Console.WriteLine("====.=========================================#==========#==");
            Console.WriteLine("=====.==========================================###======###");
            Console.WriteLine("======.============================================#=====#==");
            Console.WriteLine("=======.============================================#====#==");
            Console.WriteLine("========.=========================================#======#==");
            Console.WriteLine("=========.====================================###========#==");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.====================================#=====#==######=");
            Console.WriteLine("======.=====================================#==#==#==#====#=");
            Console.WriteLine("=====.======================================#==#==#==######=");
            Console.WriteLine("====.=======================================#==#==#==#====#=");
            Console.WriteLine("===.=========================================##=##===#====#=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=============================================####=====###");
            Console.WriteLine("===.==========================================#=========#===");
            Console.WriteLine("====.========================================#==========#===");
            Console.WriteLine("=====.=========================================###======####");
            Console.WriteLine("======.===========================================#=====#===");
            Console.WriteLine("=======.===========================================#====#===");
            Console.WriteLine("========.========================================#======#===");
            Console.WriteLine("=========.===================================###========#===");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===================================#=====#==######==");
            Console.WriteLine("======.====================================#==#==#==#====#==");
            Console.WriteLine("=====.=====================================#==#==#==######==");
            Console.WriteLine("====.======================================#==#==#==#====#==");
            Console.WriteLine("===.========================================##=##===#====#==");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.============================================####=====####");
            Console.WriteLine("===.=========================================#=========#====");
            Console.WriteLine("====.=======================================#==========#====");
            Console.WriteLine("=====.========================================###======#####");
            Console.WriteLine("======.==========================================#=====#====");
            Console.WriteLine("=======.==========================================#====#====");
            Console.WriteLine("========.=======================================#======#====");
            Console.WriteLine("=========.==================================###========#====");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==================================#=====#==######===");
            Console.WriteLine("======.===================================#==#==#==#====#===");
            Console.WriteLine("=====.====================================#==#==#==######===");
            Console.WriteLine("====.=====================================#==#==#==#====#===");
            Console.WriteLine("===.=======================================##=##===#====#===");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.===========================================####=====#####");
            Console.WriteLine("===.========================================#=========#=====");
            Console.WriteLine("====.======================================#==========#=====");
            Console.WriteLine("=====.=======================================###======######");
            Console.WriteLine("======.=========================================#=====#=====");
            Console.WriteLine("=======.=========================================#====#=====");
            Console.WriteLine("========.======================================#======#=====");
            Console.WriteLine("=========.=================================###========#=====");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=================================#=====#==######===#");
            Console.WriteLine("======.==================================#==#==#==#====#===#");
            Console.WriteLine("=====.===================================#==#==#==######===#");
            Console.WriteLine("====.====================================#==#==#==#====#===#");
            Console.WriteLine("===.======================================##=##===#====#===#");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.==========================================####=====######");
            Console.WriteLine("===.=======================================#=========#======");
            Console.WriteLine("====.=====================================#==========#======");
            Console.WriteLine("=====.======================================###======#######");
            Console.WriteLine("======.========================================#=====#======");
            Console.WriteLine("=======.========================================#====#======");
            Console.WriteLine("========.=====================================#======#======");
            Console.WriteLine("=========.================================###========#======");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.================================#=====#==######===##");
            Console.WriteLine("======.=================================#==#==#==#====#===#=");
            Console.WriteLine("=====.==================================#==#==#==######===##");
            Console.WriteLine("====.===================================#==#==#==#====#===#=");
            Console.WriteLine("===.=====================================##=##===#====#===#=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=========================================####=====#######");
            Console.WriteLine("===.======================================#=========#=======");
            Console.WriteLine("====.====================================#==========#======#");
            Console.WriteLine("=====.=====================================###======#######=");
            Console.WriteLine("======.=======================================#=====#=======");
            Console.WriteLine("=======.=======================================#====#=======");
            Console.WriteLine("========.====================================#======#=======");
            Console.WriteLine("=========.===============================###========#=======");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===============================#=====#==######===###");
            Console.WriteLine("======.================================#==#==#==#====#===#==");
            Console.WriteLine("=====.=================================#==#==#==######===###");
            Console.WriteLine("====.==================================#==#==#==#====#===#==");
            Console.WriteLine("===.====================================##=##===#====#===#==");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.========================================####=====#######=");
            Console.WriteLine("===.=====================================#=========#=======#");
            Console.WriteLine("====.===================================#==========#======#=");
            Console.WriteLine("=====.====================================###======#######==");
            Console.WriteLine("======.======================================#=====#=======#");
            Console.WriteLine("=======.======================================#====#=======#");
            Console.WriteLine("========.===================================#======#=======#");
            Console.WriteLine("=========.==============================###========#=======#");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==============================#=====#==######===####");
            Console.WriteLine("======.===============================#==#==#==#====#===#===");
            Console.WriteLine("=====.================================#==#==#==######===####");
            Console.WriteLine("====.=================================#==#==#==#====#===#===");
            Console.WriteLine("===.===================================##=##===#====#===#===");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=======================================####=====#######==");
            Console.WriteLine("===.====================================#=========#=======#=");
            Console.WriteLine("====.==================================#==========#======#==");
            Console.WriteLine("=====.===================================###======#######===");
            Console.WriteLine("======.=====================================#=====#=======##");
            Console.WriteLine("=======.=====================================#====#=======#=");
            Console.WriteLine("========.==================================#======#=======##");
            Console.WriteLine("=========.=============================###========#=======#=");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=============================#=====#==######===#####");
            Console.WriteLine("======.==============================#==#==#==#====#===#====");
            Console.WriteLine("=====.===============================#==#==#==######===#####");
            Console.WriteLine("====.================================#==#==#==#====#===#====");
            Console.WriteLine("===.==================================##=##===#====#===#====");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.======================================####=====#######===");
            Console.WriteLine("===.===================================#=========#=======#==");
            Console.WriteLine("====.=================================#==========#======#===");
            Console.WriteLine("=====.==================================###======#######====");
            Console.WriteLine("======.====================================#=====#=======###");
            Console.WriteLine("=======.====================================#====#=======#==");
            Console.WriteLine("========.=================================#======#=======###");
            Console.WriteLine("=========.============================###========#=======#==");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.============================#=====#==######===######");
            Console.WriteLine("======.=============================#==#==#==#====#===#=====");
            Console.WriteLine("=====.==============================#==#==#==######===#####=");
            Console.WriteLine("====.===============================#==#==#==#====#===#====#");
            Console.WriteLine("===.=================================##=##===#====#===#=====");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=====================================####=====#######====");
            Console.WriteLine("===.==================================#=========#=======#===");
            Console.WriteLine("====.================================#==========#======#====");
            Console.WriteLine("=====.=================================###======#######=====");
            Console.WriteLine("======.===================================#=====#=======####");
            Console.WriteLine("=======.===================================#====#=======#===");
            Console.WriteLine("========.================================#======#=======####");
            Console.WriteLine("=========.===========================###========#=======#===");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===========================#=====#==######===#######");
            Console.WriteLine("======.============================#==#==#==#====#===#=====#");
            Console.WriteLine("=====.=============================#==#==#==######===#####==");
            Console.WriteLine("====.==============================#==#==#==#====#===#====#=");
            Console.WriteLine("===.================================##=##===#====#===#=====#");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.====================================####=====#######=====");
            Console.WriteLine("===.=================================#=========#=======#====");
            Console.WriteLine("====.===============================#==========#======#=====");
            Console.WriteLine("=====.================================###======#######======");
            Console.WriteLine("======.==================================#=====#=======#####");
            Console.WriteLine("=======.==================================#====#=======#====");
            Console.WriteLine("========.===============================#======#=======#####");
            Console.WriteLine("=========.==========================###========#=======#====");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==========================#=====#==######===#######=");
            Console.WriteLine("======.===========================#==#==#==#====#===#=====#=");
            Console.WriteLine("=====.============================#==#==#==######===#####===");
            Console.WriteLine("====.=============================#==#==#==#====#===#====#==");
            Console.WriteLine("===.===============================##=##===#====#===#=====#=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.===================================####=====#######======");
            Console.WriteLine("===.================================#=========#=======#=====");
            Console.WriteLine("====.==============================#==========#======#======");
            Console.WriteLine("=====.===============================###======#######=======");
            Console.WriteLine("======.=================================#=====#=======######");
            Console.WriteLine("=======.=================================#====#=======#====#");
            Console.WriteLine("========.==============================#======#=======######");
            Console.WriteLine("=========.=========================###========#=======#====#");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=========================#=====#==######===#######==");
            Console.WriteLine("======.==========================#==#==#==#====#===#=====#==");
            Console.WriteLine("=====.===========================#==#==#==######===#####====");
            Console.WriteLine("====.============================#==#==#==#====#===#====#===");
            Console.WriteLine("===.==============================##=##===#====#===#=====#==");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.==================================####=====#######=======");
            Console.WriteLine("===.===============================#=========#=======#======");
            Console.WriteLine("====.=============================#==========#======#=======");
            Console.WriteLine("=====.==============================###======#######========");
            Console.WriteLine("======.================================#=====#=======######=");
            Console.WriteLine("=======.================================#====#=======#====#=");
            Console.WriteLine("========.=============================#======#=======######=");
            Console.WriteLine("=========.========================###========#=======#====#=");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.========================#=====#==######===#######===");
            Console.WriteLine("======.=========================#==#==#==#====#===#=====#===");
            Console.WriteLine("=====.==========================#==#==#==######===#####=====");
            Console.WriteLine("====.===========================#==#==#==#====#===#====#====");
            Console.WriteLine("===.=============================##=##===#====#===#=====#===");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=================================####=====#######========");
            Console.WriteLine("===.==============================#=========#=======#=======");
            Console.WriteLine("====.============================#==========#======#========");
            Console.WriteLine("=====.=============================###======#######=========");
            Console.WriteLine("======.===============================#=====#=======######==");
            Console.WriteLine("=======.===============================#====#=======#====#==");
            Console.WriteLine("========.============================#======#=======######==");
            Console.WriteLine("=========.=======================###========#=======#====#==");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=======================#=====#==######===#######====");
            Console.WriteLine("======.========================#==#==#==#====#===#=====#===#");
            Console.WriteLine("=====.=========================#==#==#==######===#####======");
            Console.WriteLine("====.==========================#==#==#==#====#===#====#=====");
            Console.WriteLine("===.============================##=##===#====#===#=====#===#");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.================================####=====#######=========");
            Console.WriteLine("===.=============================#=========#=======#=======#");
            Console.WriteLine("====.===========================#==========#======#========#");
            Console.WriteLine("=====.============================###======#######=========#");
            Console.WriteLine("======.==============================#=====#=======######==#");
            Console.WriteLine("=======.==============================#====#=======#====#===");
            Console.WriteLine("========.===========================#======#=======######===");
            Console.WriteLine("=========.======================###========#=======#====#===");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.======================#=====#==######===#######====#");
            Console.WriteLine("======.=======================#==#==#==#====#===#=====#===#=");
            Console.WriteLine("=====.========================#==#==#==######===#####======#");
            Console.WriteLine("====.=========================#==#==#==#====#===#====#======");
            Console.WriteLine("===.===========================##=##===#====#===#=====#===##");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.===============================####=====#######==========");
            Console.WriteLine("===.============================#=========#=======#=======##");
            Console.WriteLine("====.==========================#==========#======#========#=");
            Console.WriteLine("=====.===========================###======#######=========#=");
            Console.WriteLine("======.=============================#=====#=======######==##");
            Console.WriteLine("=======.=============================#====#=======#====#====");
            Console.WriteLine("========.==========================#======#=======######====");
            Console.WriteLine("=========.=====================###========#=======#====#====");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=====================#=====#==######===#######====##");
            Console.WriteLine("======.======================#==#==#==#====#===#=====#===#==");
            Console.WriteLine("=====.=======================#==#==#==######===#####======##");
            Console.WriteLine("====.========================#==#==#==#====#===#====#=======");
            Console.WriteLine("===.==========================##=##===#====#===#=====#===###");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.==============================####=====#######===========");
            Console.WriteLine("===.===========================#=========#=======#=======###");
            Console.WriteLine("====.=========================#==========#======#========#==");
            Console.WriteLine("=====.==========================###======#######=========#==");
            Console.WriteLine("======.============================#=====#=======######==###");
            Console.WriteLine("=======.============================#====#=======#====#=====");
            Console.WriteLine("========.=========================#======#=======######=====");
            Console.WriteLine("=========.====================###========#=======#====#=====");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.====================#=====#==######===#######====###");
            Console.WriteLine("======.=====================#==#==#==#====#===#=====#===#===");
            Console.WriteLine("=====.======================#==#==#==######===#####======###");
            Console.WriteLine("====.=======================#==#==#==#====#===#====#========");
            Console.WriteLine("===.=========================##=##===#====#===#=====#===####");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=============================####=====#######============");
            Console.WriteLine("===.==========================#=========#=======#=======####");
            Console.WriteLine("====.========================#==========#======#========#===");
            Console.WriteLine("=====.=========================###======#######=========#===");
            Console.WriteLine("======.===========================#=====#=======######==####");
            Console.WriteLine("=======.===========================#====#=======#====#======");
            Console.WriteLine("========.========================#======#=======######======");
            Console.WriteLine("=========.===================###========#=======#====#======");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===================#=====#==######===#######====####");
            Console.WriteLine("======.====================#==#==#==#====#===#=====#===#====");
            Console.WriteLine("=====.=====================#==#==#==######===#####======####");
            Console.WriteLine("====.======================#==#==#==#====#===#====#=========");
            Console.WriteLine("===.========================##=##===#====#===#=====#===#####");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.============================####=====#######=============");
            Console.WriteLine("===.=========================#=========#=======#=======#####");
            Console.WriteLine("====.=======================#==========#======#========#====");
            Console.WriteLine("=====.========================###======#######=========#====");
            Console.WriteLine("======.==========================#=====#=======######==#####");
            Console.WriteLine("=======.==========================#====#=======#====#=======");
            Console.WriteLine("========.=======================#======#=======######=======");
            Console.WriteLine("=========.==================###========#=======#====#=======");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==================#=====#==######===#######====#####");
            Console.WriteLine("======.===================#==#==#==#====#===#=====#===#=====");
            Console.WriteLine("=====.====================#==#==#==######===#####======####=");
            Console.WriteLine("====.=====================#==#==#==#====#===#====#=========#");
            Console.WriteLine("===.=======================##=##===#====#===#=====#===#####=");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.===========================####=====#######==============");
            Console.WriteLine("===.========================#=========#=======#=======#####=");
            Console.WriteLine("====.======================#==========#======#========#=====");
            Console.WriteLine("=====.=======================###======#######=========#=====");
            Console.WriteLine("======.=========================#=====#=======######==#####=");
            Console.WriteLine("=======.=========================#====#=======#====#========");
            Console.WriteLine("========.======================#======#=======######========");
            Console.WriteLine("=========.=================###========#=======#====#========");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=================#=====#==######===#######====#####=");
            Console.WriteLine("======.==================#==#==#==#====#===#=====#===#======");
            Console.WriteLine("=====.===================#==#==#==######===#####======####==");
            Console.WriteLine("====.====================#==#==#==#====#===#====#=========#=");
            Console.WriteLine("===.======================##=##===#====#===#=====#===#####==");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.==========================####=====#######===============");
            Console.WriteLine("===.=======================#=========#=======#=======#####==");
            Console.WriteLine("====.=====================#==========#======#========#======");
            Console.WriteLine("=====.======================###======#######=========#======");
            Console.WriteLine("======.========================#=====#=======######==#####==");
            Console.WriteLine("=======.========================#====#=======#====#=========");
            Console.WriteLine("========.=====================#======#=======######=========");
            Console.WriteLine("=========.================###========#=======#====#=========");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.================#=====#==######===#######====#####==");
            Console.WriteLine("======.=================#==#==#==#====#===#=====#===#=======");
            Console.WriteLine("=====.==================#==#==#==######===#####======####===");
            Console.WriteLine("====.===================#==#==#==#====#===#====#=========#==");
            Console.WriteLine("===.=====================##=##===#====#===#=====#===#####===");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=========================####=====#######================");
            Console.WriteLine("===.======================#=========#=======#=======#####===");
            Console.WriteLine("====.====================#==========#======#========#=======");
            Console.WriteLine("=====.=====================###======#######=========#=======");
            Console.WriteLine("======.=======================#=====#=======######==#####===");
            Console.WriteLine("=======.=======================#====#=======#====#==========");
            Console.WriteLine("========.====================#======#=======######==========");
            Console.WriteLine("=========.===============###========#=======#====#==========");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===============#=====#==######===#######====#####===");
            Console.WriteLine("======.================#==#==#==#====#===#=====#===#========");
            Console.WriteLine("=====.=================#==#==#==######===#####======####====");
            Console.WriteLine("====.==================#==#==#==#====#===#====#=========#===");
            Console.WriteLine("===.====================##=##===#====#===#=====#===#####====");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.========================####=====#######=================");
            Console.WriteLine("===.=====================#=========#=======#=======#####====");
            Console.WriteLine("====.===================#==========#======#========#========");
            Console.WriteLine("=====.====================###======#######=========#========");
            Console.WriteLine("======.======================#=====#=======######==#####====");
            Console.WriteLine("=======.======================#====#=======#====#===========");
            Console.WriteLine("========.===================#======#=======######===========");
            Console.WriteLine("=========.==============###========#=======#====#===========");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==============#=====#==######===#######====#####====");
            Console.WriteLine("======.===============#==#==#==#====#===#=====#===#=========");
            Console.WriteLine("=====.================#==#==#==######===#####======####=====");
            Console.WriteLine("====.=================#==#==#==#====#===#====#=========#====");
            Console.WriteLine("===.===================##=##===#====#===#=====#===#####=====");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=======================####=====#######==================");
            Console.WriteLine("===.====================#=========#=======#=======#####=====");
            Console.WriteLine("====.==================#==========#======#========#=========");
            Console.WriteLine("=====.===================###======#######=========#=========");
            Console.WriteLine("======.=====================#=====#=======######==#####=====");
            Console.WriteLine("=======.=====================#====#=======#====#============");
            Console.WriteLine("========.==================#======#=======######============");
            Console.WriteLine("=========.=============###========#=======#====#============");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.=============#=====#==######===#######====#####=====");
            Console.WriteLine("======.==============#==#==#==#====#===#=====#===#==========");
            Console.WriteLine("=====.===============#==#==#==######===#####======####======");
            Console.WriteLine("====.================#==#==#==#====#===#====#=========#=====");
            Console.WriteLine("===.==================##=##===#====#===#=====#===#####======");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.======================####=====#######===================");
            Console.WriteLine("===.===================#=========#=======#=======#####======");
            Console.WriteLine("====.=================#==========#======#========#==========");
            Console.WriteLine("=====.==================###======#######=========#=========#");
            Console.WriteLine("======.====================#=====#=======######==#####=====#");
            Console.WriteLine("=======.====================#====#=======#====#============#");
            Console.WriteLine("========.=================#======#=======######============#");
            Console.WriteLine("=========.============###========#=======#====#============#");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.============#=====#==######===#######====#####======");
            Console.WriteLine("======.=============#==#==#==#====#===#=====#===#===========");
            Console.WriteLine("=====.==============#==#==#==######===#####======####=======");
            Console.WriteLine("====.===============#==#==#==#====#===#====#=========#======");
            Console.WriteLine("===.=================##=##===#====#===#=====#===#####=======");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.=====================####=====#######====================");
            Console.WriteLine("===.==================#=========#=======#=======#####=======");
            Console.WriteLine("====.================#==========#======#========#===========");
            Console.WriteLine("=====.=================###======#######=========#=========##");
            Console.WriteLine("======.===================#=====#=======######==#####=====#=");
            Console.WriteLine("=======.===================#====#=======#====#============##");
            Console.WriteLine("========.================#======#=======######============#=");
            Console.WriteLine("=========.===========###========#=======#====#============##");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.===========#=====#==######===#######====#####=======");
            Console.WriteLine("======.============#==#==#==#====#===#=====#===#============");
            Console.WriteLine("=====.=============#==#==#==######===#####======####========");
            Console.WriteLine("====.==============#==#==#==#====#===#====#=========#=======");
            Console.WriteLine("===.================##=##===#====#===#=====#===#####========");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
            Console.Clear();
            Console.WriteLine("==.====================####=====#######=====================");
            Console.WriteLine("===.=================#=========#=======#=======#####========");
            Console.WriteLine("====.===============#==========#======#========#============");
            Console.WriteLine("=====.================###======#######=========#=========###");
            Console.WriteLine("======.==================#=====#=======######==#####=====#==");
            Console.WriteLine("=======.==================#====#=======#====#============###");
            Console.WriteLine("========.===============#======#=======######============#==");
            Console.WriteLine("=========.==========###========#=======#====#============###");
            Console.WriteLine("==========..................................................");
            Console.WriteLine("==========''''''''''''''''''''''''''''''''''''''''''''''''''");
            Console.WriteLine("=======.==========#=====#==######===#######====#####========");
            Console.WriteLine("======.===========#==#==#==#====#===#=====#===#=============");
            Console.WriteLine("=====.============#==#==#==######===#####======####=========");
            Console.WriteLine("====.=============#==#==#==#====#===#====#=========#========");
            Console.WriteLine("===.===============##=##===#====#===#=====#===#####=========");
            Console.WriteLine("==.=========================================================");
            for (i = 0; i < TIME; i++)
            {
            }
        }
    }
    class EasterEggs
    {
        public static void InstructionEgg()
        {
            Console.WriteLine("If you wanted to win that badly then here is your reward:");
        }
        public static void MainLoopEgg()
        {
            Console.WriteLine("Why stop the music Secret Fangs? Keep on making!");
        }
        public static void TorpedoEgg()
        {
            Console.WriteLine("Achievement recieved: 'Nonsence Entered'");
        }
    }
}
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
        RESTART:
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                Console.WindowHeight = 50;
                Console.WindowWidth = 60;
            }
            catch
            {
                Console.WriteLine("Minor Resolution Error....skipping resolution config.");
            }
            Console.Title = "Space Wars";
            Random RandomNumberGenerator = new Random();
            GameObjects.Animation.StartupAnimation();
            int EarthEnemy = 0;
            int AlphaX1Y1 = RandomNumberGenerator.Next(1, 10);
            int AlphaX1Y2 = RandomNumberGenerator.Next(1, 10);
            int AlphaX2Y1 = RandomNumberGenerator.Next(1, 10);
            int AlphaX2Y2 = RandomNumberGenerator.Next(1, 10);
            int BetaX1Y1 = RandomNumberGenerator.Next(7, 12);
            int BetaX1Y2 = RandomNumberGenerator.Next(7, 12);
            int BetaX2Y1 = RandomNumberGenerator.Next(7, 12);
            int BetaX2Y2 = RandomNumberGenerator.Next(7, 12);
            int GammaX1Y1 = RandomNumberGenerator.Next(10, 15);
            int GammaX1Y2 = RandomNumberGenerator.Next(10, 15);
            int GammaX2Y1 = RandomNumberGenerator.Next(10, 15);
            int GammaX2Y2 = RandomNumberGenerator.Next(10, 15);
            int DeltaX1Y1 = RandomNumberGenerator.Next(15, 25);
            int DeltaX1Y2 = RandomNumberGenerator.Next(15, 25);
            int DeltaX2Y1 = RandomNumberGenerator.Next(15, 25);
            int DeltaX2Y2 = RandomNumberGenerator.Next(15, 25);
            int EarthPort = 10000000;
            int AlphaPort = 20000000;
            int BetaPort = 30000000;
            int GammaPort = 40000000;
            int DeltaPort = 50000000;
            string Dimension = "Earth";
            string SectorX = "1";
            string SectorY = "1";
            string Sector = "1";
            int EnergyLevel = 2000;
            int ShieldLevel = 100;
            string Condition = "Green";
            string LaserStatus = "Online";
            string TorpedoStatus = "Online";
            string LaserReady = "armed, and ready to fire!!";
            string TorpedoReady = "armed, and ready to fire!!";
            string LaserHitState = "";
            string TorpedoHitState = "";
            int Damage = 0;
            int Enemies = 0;
            GameObjects.Animation.MainAnimation();
        AnswereLoop:
            Console.WriteLine("Do you need instruction?");
            Console.Write("Y/N: ");
            string instrukt = Console.ReadLine();
            if (instrukt == "win")
            {
                Console.WriteLine("You have lost the game!!");
                GameObjects.EasterEggs.InstructionEgg();
                GameObjects.Command.LoseGame();
            }
            else
            if (instrukt == "Y")
            {
                GameObjects.Command.Instruction();
                Console.Clear();
                goto MainLoop;
            }
            else
                if (instrukt == "N")
            {
                Console.Clear();
                goto MainLoop;
            }
            else
                    if (instrukt == "y")
            {
                GameObjects.Command.Instruction();
                Console.Clear();
                goto MainLoop;
            }
            else
                        if (instrukt == "n")
            {
                Console.Clear();
                goto MainLoop;
            }
            else
                Console.Clear();
            Console.WriteLine("Incorrect answer!!");
            goto AnswereLoop;

        MainLoop:
            if (Damage == 100 || ShieldLevel == 0)
            {
                Console.WriteLine("Sorry, you have lost!!");
                GameObjects.Command.LoseGame();
            }
            if (AlphaX1Y1 == 0 & AlphaX1Y2 == 0 & AlphaX2Y1 == 0 & AlphaX2Y2 == 0 & BetaX1Y1 == 0 & BetaX1Y2 == 0 & BetaX2Y1 == 0 & BetaX2Y2 == 0 & GammaX1Y1 == 0 & GammaX1Y2 == 0 & GammaX2Y1 == 0 & GammaX2Y2 == 0 & DeltaX1Y1 == 0 & DeltaX1Y2 == 0 & DeltaX2Y1 == 0 & DeltaX2Y2 == 0)
            {
                goto WINGAME;
            }
            if (EnergyLevel == 0)
            {
                GameObjects.Command.LoseGame();
                goto RESTART;
            }
            if (EnergyLevel < 200 & Enemies == 0)
            {
                Console.WriteLine("You do not have enough energy for space travel, your ship is adrift in space!");
                GameObjects.Command.LoseGame();
                Console.Write("Press enter to continue...");
                string nnaaannaa = Console.ReadLine();
                goto RESTART;
            }
            GameObjects.Ship.HUD(EnergyLevel, ShieldLevel, SectorX, SectorY, Dimension, Condition, Damage, Enemies);
            Console.Write("Command: ");
            string command = Console.ReadLine();
            if (command == "die")
            {
                EnergyLevel = 120;
                Enemies = 0;
            }
            else
            if (command == "xxx")
            {
                goto RESTART;
            }
            else
                if (command == "help")
            {
                GameObjects.Command.Help();
                goto MainLoop;
            }
            else
                    if (command == "nav")
            {
                if (EnergyLevel < 200)
                {
                    Console.WriteLine("Cannot travel, too low on fuel!!");
                    goto MainLoop;
                }
                else
                if (Dimension == "Earth")
                {
                    goto EarthDisplay;
                }
                else
                    goto StartNavSys;
                StartNavSys:
                Console.Clear();
                if (SectorX == "1" & SectorY == "1")
                {
                    Console.WriteLine("========== Navigation ===========");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|-------------- | --------------|");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|   =@{         |               |");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Dimension: " + Dimension);
                    Console.WriteLine("Sector: " + Sector);
                    Console.WriteLine("Technical Data-----");
                    Console.WriteLine("SectorX: " + SectorX);
                    Console.WriteLine("SectorY:" + SectorY);
                    goto NAV;
                }
                else
                    if (SectorX == "1" & SectorY == "2")
                {
                    Console.WriteLine("========== Navigation ===========");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|-------------- | --------------|");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|               |         =@{   |");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Dimension: " + Dimension);
                    Console.WriteLine("Sector: " + Sector);
                    Console.WriteLine("Technical Data-----");
                    Console.WriteLine("SectorX: " + SectorX);
                    Console.WriteLine("SectorY:" + SectorY);
                    goto NAV;
                }
                else
                        if (SectorX == "2" & SectorY == "1")
                {
                    Console.WriteLine("========== Navigation ===========");
                    Console.WriteLine("|   =@{         |               |");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|-------------- | --------------|");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Dimension: " + Dimension);
                    Console.WriteLine("Sector: " + Sector);
                    Console.WriteLine("Technical Data-----");
                    Console.WriteLine("SectorX: " + SectorX);
                    Console.WriteLine("SectorY:" + SectorY);
                    goto NAV;
                }
                else
                            if (SectorX == "2" & SectorY == "2")
                {
                    Console.WriteLine("========== Navigation ===========");
                    Console.WriteLine("|               |          =@{  |");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|-------------- | --------------|");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("|               |               |");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Dimension: " + Dimension);
                    Console.WriteLine("Sector: " + Sector);
                    Console.WriteLine("Technical Data-----");
                    Console.WriteLine("SectorX: " + SectorX);
                    Console.WriteLine("SectorY:" + SectorY);
                    goto NAV;
                }
            EarthDisplay:
                Console.Clear();
                Console.WriteLine("========== Navigation ===========");
                Console.WriteLine("|                               |");
                Console.WriteLine("|                               |");
                Console.WriteLine("|              =@{              |");
                Console.WriteLine("|                               |");
                Console.WriteLine("|                               |");
                Console.WriteLine("=================================");
                Console.WriteLine("Dimension: " + Dimension);
                Console.WriteLine("Sector: " + Sector);
                Console.WriteLine("Technical Data-----");
                Console.WriteLine("SectorX: " + SectorX);
                Console.WriteLine("SectorY:" + SectorY);
                goto NAV;
            NAV:
                Console.WriteLine("");
                Console.WriteLine("Available Dimensions:");
                Console.WriteLine("Earth, Alpha, Beta, Gamma, Delta");
                string DimensionTemp = Dimension;
                Console.Write("Please enter a Dimension:");
                Dimension = Console.ReadLine();
                if (Dimension == "Earth" || Dimension == "Alpha" || Dimension == "Beta" || Dimension == "Gamma" || Dimension == "Delta")
                {
                    goto ContNav;
                }
                else
                    Console.WriteLine("No such Dimension found!!");
                Dimension = DimensionTemp;
                goto StartNavSys;
            ContNav:
                string SectorXTemp = SectorX;
                string SectorYTemp = SectorY;
                Console.WriteLine("");
                Console.WriteLine("Avialable Coordinates:");
                Console.WriteLine("Sector: 1, 2, 3, 4");
                Console.WriteLine("Note: Earth has only one set of");
                Console.WriteLine("coordinates(Sector 1)");
                Console.WriteLine("Please Enter the Coordinates:");
                Console.Write("Sector: ");
                Sector = Console.ReadLine();
                if (Sector == "1")
                {
                    SectorX = "1";
                    SectorY = "1";
                    goto SystemCheck;
                }
                else
                    if (Sector == "2")
                {
                    SectorX = "2";
                    SectorY = "1";
                    goto SystemCheck;
                }
                else
                        if (Sector == "3")
                {
                    SectorX = "2";
                    SectorY = "2";
                    goto SystemCheck;
                }
                else
                            if (Sector == "4")
                {
                    SectorX = "1";
                    SectorY = "2";
                    goto SystemCheck;
                }
                else
                    goto Error;
                SystemCheck:
                if (Dimension == "Earth" & SectorX == "1" & SectorY == "1")
                {
                    goto ExitLoop;
                }
                else
                    if (SectorX == "1" || SectorX == "2" || SectorX == "3" || SectorX == "4" && SectorY == "1" || SectorY == "2" || SectorY == "3" || SectorY == "4")
                {
                    goto ExitLoop;
                }
                else
                    goto Error;
                Error:
                Console.WriteLine("Please enter correct coordinates!");
                SectorX = SectorXTemp;
                SectorY = SectorYTemp;
                goto StartNavSys;
            ExitLoop:
                Console.Clear();
                if (Dimension == "Earth" & SectorX == "1" & SectorY == "1")
                {
                    Enemies = EarthEnemy;
                    GameObjects.Animation.TravelAnimation(EarthPort);
                    goto HERE;
                }
                else
                    if (Dimension == "Alpha" & SectorX == "1" & SectorY == "1")
                {
                    Enemies = AlphaX1Y1;
                    GameObjects.Animation.TravelAnimation(AlphaPort);
                    goto HERE;
                }
                else
                        if (Dimension == "Alpha" & SectorX == "1" & SectorY == "2")
                {
                    Enemies = AlphaX1Y2;
                    GameObjects.Animation.TravelAnimation(AlphaPort);
                    goto HERE;
                }
                else
                            if (Dimension == "Alpha" & SectorX == "2" & SectorY == "1")
                {
                    Enemies = AlphaX2Y1;
                    GameObjects.Animation.TravelAnimation(AlphaPort);
                    goto HERE;
                }
                else
                                if (Dimension == "Alpha" & SectorX == "2" & SectorY == "2")
                {
                    Enemies = AlphaX2Y2;
                    GameObjects.Animation.TravelAnimation(AlphaPort);
                    goto HERE;
                }
                else
                                    if (Dimension == "Beta" & SectorX == "1" & SectorY == "1")
                {
                    Enemies = BetaX1Y1;
                    GameObjects.Animation.TravelAnimation(BetaPort);
                    goto HERE;
                }
                else
                                        if (Dimension == "Beta" & SectorX == "1" & SectorY == "2")
                {
                    Enemies = BetaX1Y2;
                    GameObjects.Animation.TravelAnimation(BetaPort);
                    goto HERE;
                }
                else
                                            if (Dimension == "Beta" & SectorX == "2" & SectorY == "1")
                {
                    Enemies = BetaX2Y1;
                    GameObjects.Animation.TravelAnimation(BetaPort);
                    goto HERE;
                }
                else
                                                if (Dimension == "Beta" & SectorX == "2" & SectorY == "2")
                {
                    Enemies = BetaX2Y2;
                    GameObjects.Animation.TravelAnimation(BetaPort);
                    goto HERE;
                }
                else
                                                    if (Dimension == "Gamma" & SectorX == "1" & SectorY == "1")
                {
                    Enemies = GammaX1Y1;
                    GameObjects.Animation.TravelAnimation(GammaPort);
                    goto HERE;
                }
                else
                                                        if (Dimension == "Gamma" & SectorX == "1" & SectorY == "2")
                {
                    Enemies = GammaX1Y2;
                    GameObjects.Animation.TravelAnimation(GammaPort);
                    goto HERE;
                }
                else
                                                            if (Dimension == "Gamma" & SectorX == "2" & SectorY == "1")
                {
                    Enemies = GammaX2Y1;
                    GameObjects.Animation.TravelAnimation(GammaPort);
                    goto HERE;
                }
                else
                                                                if (Dimension == "Gamma" & SectorX == "2" & SectorY == "2")
                {
                    Enemies = GammaX2Y2;
                    GameObjects.Animation.TravelAnimation(GammaPort);
                    goto HERE;
                }
                else
                                                                    if (Dimension == "Delta" & SectorX == "1" & SectorY == "1")
                {
                    Enemies = DeltaX1Y1;
                    GameObjects.Animation.TravelAnimation(DeltaPort);
                    goto HERE;
                }
                else
                                                                        if (Dimension == "Delta" & SectorX == "1" & SectorY == "2")
                {
                    Enemies = DeltaX1Y2;
                    GameObjects.Animation.TravelAnimation(DeltaPort);
                    goto HERE;
                }
                else
                                                                            if (Dimension == "Delta" & SectorX == "2" & SectorY == "1")
                {
                    Enemies = DeltaX2Y1;
                    GameObjects.Animation.TravelAnimation(DeltaPort);
                    goto HERE;
                }
                else
                                                                                if (Dimension == "Delta" & SectorX == "2" & SectorY == "2")
                {
                    Enemies = DeltaX2Y2;
                    GameObjects.Animation.TravelAnimation(DeltaPort);
                    goto HERE;
                }
            HERE:
                int NavEnerg = EnergyLevel - 200;
                EnergyLevel = NavEnerg;
                goto MainLoop;
            }
            else
                        if (command == "las")
            {
                if (Enemies == 0)
                {
                    Console.WriteLine("No enemies in target!!");
                    goto MainLoop;
                }
                else
                    if (Damage == 100 || ShieldLevel == 0)
                {
                    GameObjects.Command.LoseGame();
                    Console.WriteLine("Sorry, you have lost!!");
                    goto RESTART;
                }
                else
                    goto LaserStart;
                LaserStart2:
                Console.Clear();
                if (Enemies == 0)
                {
                    Console.WriteLine("No enemies in target!!");
                    goto MainLoop;
                }
                else
                    if (Damage == 100 || ShieldLevel == 0)
                {
                    GameObjects.Command.LoseGame();
                    Console.WriteLine("Sorry you have lost!!");
                    goto RESTART;
                }
                else
                        if (EnergyLevel < 20)
                {
                    Console.WriteLine("Cannot fire lasers, energy too low!!");
                    goto MainLoop;
                }
                goto DDNN;
            DDNN:
                int EnemyHitShip = RandomNumberGenerator.Next(1, 10);
                Console.WriteLine("Enemy is firing cannons!!");
                if (EnemyHitShip == 2 || EnemyHitShip == 4 || EnemyHitShip == 6 || EnemyHitShip == 8 || EnemyHitShip == 10)
                {
                    int DamageLevel = RandomNumberGenerator.Next(10, 25);
                    int DamTemp = Damage + DamageLevel;
                    int ShieldTemp = ShieldLevel - DamageLevel;
                    Damage = DamTemp;
                    ShieldLevel = ShieldTemp;
                    Console.WriteLine("Damage has been taken!!");
                    goto LaserStart;
                }
                Console.WriteLine("Enemy has missed!!");
            LaserStart:
                Console.Clear();
                if (Enemies == 0)
                {
                    Console.WriteLine("No enemies in target!!");
                    goto MainLoop;
                }
                else
                    if (Damage > 60)
                {
                    LaserReady = "damaged and cannot be fired, must be reapired!";
                    LaserStatus = "offline";
                    goto ContLaser;
                }
                else
                    goto ContLaser;
                ContLaser:
                string FireLaser;
                Console.WriteLine("Lasers cost 20 energy per fire, use carefully!!");
                Console.WriteLine("===============================================");
                Console.WriteLine(" Laser status: " + LaserStatus);
                Console.WriteLine(" Enemy count: " + Enemies);
                Console.WriteLine(" Energy: " + EnergyLevel);
                Console.WriteLine(" Lasers are " + LaserReady);
                Console.WriteLine(" Damage:" + Damage);
                Console.WriteLine(" Shields: " + ShieldLevel);
                Console.WriteLine("===============================================");
                FireLaser = "";
                if (EnergyLevel < 20)
                {
                    Console.WriteLine("Insufficient energy to fire lasers!!");
                    goto MainLoop;
                }
                else
                    if (Damage > 60)
                {
                    Console.WriteLine("Cannot fire, lasers are damaged!!");
                    goto MainLoop;
                }
                else
                    Console.Write("Fire? (Y/N)");
                FireLaser = Console.ReadLine();
                if (FireLaser == "Y" || FireLaser == "y")
                {
                    int LaserHit = RandomNumberGenerator.Next(1, 10);
                    if (LaserHit == 1 || LaserHit == 3 || LaserHit == 5 || LaserHit == 7 || LaserHit == 9)
                    {
                        LaserHitState = "hit";
                        GameObjects.Animation.LaserFireAnimation(LaserHitState);
                        Console.WriteLine("An enemy has been destroyed!");
                        int EnemyHit = Enemies - 1;
                        int ENergyTemp = EnergyLevel - 20;
                        EnergyLevel = ENergyTemp;
                        Enemies = EnemyHit;
                        if (Dimension == "Alpha" & SectorX == "1" & SectorY == "1")
                        {
                            AlphaX1Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                            if (Dimension == "Alpha" & SectorX == "1" & SectorY == "2")
                        {
                            AlphaX1Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                if (Dimension == "Alpha" & SectorX == "2" & SectorY == "1")
                        {
                            AlphaX2Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                    if (Dimension == "Alpha" & SectorX == "2" & SectorY == "2")
                        {
                            AlphaX2Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                        if (Dimension == "Beta" & SectorX == "1" & SectorY == "1")
                        {
                            BetaX1Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                            if (Dimension == "Beta" & SectorX == "1" & SectorY == "2")
                        {
                            BetaX1Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                                if (Dimension == "Beta" & SectorX == "2" & SectorY == "1")
                        {
                            BetaX2Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                                    if (Dimension == "Beta" & SectorX == "2" & SectorY == "2")
                        {
                            BetaX2Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                                        if (Dimension == "Delta" & SectorX == "1" & SectorY == "1")
                        {
                            DeltaX1Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                                            if (Dimension == "Delta" & SectorX == "1" & SectorY == "2")
                        {
                            DeltaX1Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                                                if (Dimension == "Delta" & SectorX == "2" & SectorY == "1")
                        {
                            DeltaX2Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                                                    if (Dimension == "Delta" & SectorX == "2" & SectorY == "2")
                        {
                            DeltaX2Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                                                        if (Dimension == "Gamma" & SectorX == "1" & SectorY == "1")
                        {
                            GammaX1Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                                                            if (Dimension == "Gamma" & SectorX == "1" & SectorY == "2")
                        {
                            GammaX1Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                                                                                if (Dimension == "Gamma" & SectorX == "2" & SectorY == "1")
                        {
                            GammaX2Y1 = Enemies;
                            goto DamCont;
                        }
                        else
                                                                                    if (Dimension == "Gamma" & SectorX == "2" & SectorY == "2")
                        {
                            GammaX2Y2 = Enemies;
                            goto DamCont;
                        }
                        else
                            goto DamCont;
                        DamCont:
                        if (Enemies == 0)
                        {
                            Console.WriteLine("All enemies have been destoyed!!");
                            goto MainLoop;
                        }
                        else
                            Console.WriteLine(Enemies + " more enemies to destroy!!");
                        goto LaserStart2;
                    }
                    else
                        LaserHitState = "miss";
                    GameObjects.Animation.LaserFireAnimation(LaserHitState);
                    Console.WriteLine("Laser has missed the target!!");
                    goto LaserStart2;
                }
                else
                    if (FireLaser == "N" || FireLaser == "n")
                {
                    goto MainLoop;
                }
                else
                    GameObjects.EasterEggs.TorpedoEgg();
                Console.WriteLine("No understandable answer given!");
                goto LaserStart;
            }
            else
                            if (command == "tor")
            {
                if (Enemies == 0)
                {
                    Console.WriteLine("No enemies to target!!");
                    goto MainLoop;
                }
                else
                    if (Damage == 100 || ShieldLevel == 0)
                {
                    Console.WriteLine("Sorry, you have lost!!");
                    GameObjects.Command.LoseGame();
                    goto RESTART;
                }
                else
                        if (EnergyLevel < 40)
                {
                    Console.WriteLine("Cannot fire torpedos, energy too low!!");
                    goto MainLoop;
                }
                else
                    goto TorpedoStart;
                TorpedoStart2:
                Console.Clear();
                if (Enemies == 0)
                {
                    Console.WriteLine("No enemies to target!!");
                    goto MainLoop;
                }
                else
                    if (Damage == 100 || ShieldLevel == 0)
                {
                    Console.WriteLine("Sorry, you have lost!!");
                    GameObjects.Command.LoseGame();
                    goto RESTART;
                }
                else
                    goto NNHHSGAS;
                NNHHSGAS:
                int EnemyHitShip = RandomNumberGenerator.Next(1, 10);
                Console.WriteLine("Enemy is firing cannons!!");
                if (EnemyHitShip == 2 || EnemyHitShip == 4 || EnemyHitShip == 6 || EnemyHitShip == 8 || EnemyHitShip == 10)
                {
                    int DamageLevel2 = RandomNumberGenerator.Next(10, 25);
                    int DamTemp = Damage + DamageLevel2;
                    int ShieldTemp = ShieldLevel - DamageLevel2;
                    Damage = DamTemp;
                    ShieldLevel = ShieldTemp;
                    Console.WriteLine("Damage has been taken!!");
                    goto TorpedoStart;
                }
                Console.WriteLine("Enemy has Missed!!");
            TorpedoStart:
                Console.Clear();
                if (Damage > 60)
                {
                    TorpedoReady = "damaged and cannot be fired, must be reapired!";
                    TorpedoStatus = "offline";
                    goto ContTorpedo;
                }
                else
                    goto ContTorpedo;
                ContTorpedo:
                string FireTorpedo;
                Console.WriteLine("Torpedos cost 40 energy per fire, use carefully!!");
                Console.WriteLine("===============================================");
                Console.WriteLine(" Torpedo status: " + TorpedoStatus);
                Console.WriteLine(" Enemy count: " + Enemies);
                Console.WriteLine(" Energy: " + EnergyLevel);
                Console.WriteLine(" Torpedos are " + TorpedoReady);
                Console.WriteLine(" Damage:" + Damage);
                Console.WriteLine(" Shields: " + ShieldLevel);
                Console.WriteLine("===============================================");
                FireTorpedo = "";
                if (EnergyLevel < 40)
                {
                    Console.WriteLine("Insufficient energy to fire lasers!!");
                    goto MainLoop;
                }
                else
                    if (Damage > 40)
                {
                    Console.WriteLine("Cannot fire, torpedo cannons are damaged!!");
                    goto MainLoop;
                }
                else
                    Console.Write("Fire? (Y/N)");
                FireTorpedo = Console.ReadLine();
                if (FireTorpedo == "Y" || FireTorpedo == "y")
                {
                    int TorpedoHit = RandomNumberGenerator.Next(1, 10);
                    if (TorpedoHit == 1 || TorpedoHit == 2 || TorpedoHit == 3 || TorpedoHit == 7 || TorpedoHit == 8 || TorpedoHit == 9 || TorpedoHit == 10)
                    {
                        TorpedoHitState = "hit";
                        GameObjects.Animation.TorpedoFireAnimation(TorpedoHitState);
                        Console.WriteLine("An enemy has been destroyed!");
                        int EnemyHit = Enemies - 1;
                        int EnergyTemp2 = EnergyLevel - 40;
                        EnergyLevel = EnergyTemp2;
                        Enemies = EnemyHit;
                        if (Dimension == "Alpha" & SectorX == "1" & SectorY == "1")
                        {
                            AlphaX1Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                            if (Dimension == "Alpha" & SectorX == "1" & SectorY == "2")
                        {
                            AlphaX1Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                if (Dimension == "Alpha" & SectorX == "2" & SectorY == "1")
                        {
                            AlphaX2Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                    if (Dimension == "Alpha" & SectorX == "2" & SectorY == "2")
                        {
                            AlphaX2Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                        if (Dimension == "Beta" & SectorX == "1" & SectorY == "1")
                        {
                            BetaX1Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                            if (Dimension == "Beta" & SectorX == "1" & SectorY == "2")
                        {
                            BetaX1Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                if (Dimension == "Beta" & SectorX == "2" & SectorY == "1")
                        {
                            BetaX2Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                    if (Dimension == "Beta" & SectorX == "2" & SectorY == "2")
                        {
                            BetaX2Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                        if (Dimension == "Delta" & SectorX == "1" & SectorY == "1")
                        {
                            DeltaX1Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                            if (Dimension == "Delta" & SectorX == "1" & SectorY == "2")
                        {
                            DeltaX1Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                                if (Dimension == "Delta" & SectorX == "2" & SectorY == "1")
                        {
                            DeltaX2Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                                    if (Dimension == "Delta" & SectorX == "2" & SectorY == "2")
                        {
                            DeltaX2Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                                        if (Dimension == "Gamma" & SectorX == "1" & SectorY == "1")
                        {
                            GammaX1Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                                            if (Dimension == "Gamma" & SectorX == "1" & SectorY == "2")
                        {
                            GammaX1Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                                                if (Dimension == "Gamma" & SectorX == "2" & SectorY == "1")
                        {
                            GammaX2Y1 = Enemies;
                            goto DamCont2;
                        }
                        else
                                                                                    if (Dimension == "Gamma" & SectorX == "2" & SectorY == "2")
                        {
                            GammaX2Y2 = Enemies;
                            goto DamCont2;
                        }
                        else
                            goto DamCont2;
                        DamCont2:
                        if (Enemies == 0)
                        {
                            Console.WriteLine("All enemies have been destoyed!!");
                            goto MainLoop;
                        }
                        else
                            Console.WriteLine(Enemies + " more enemies to destroy!!");
                        goto TorpedoStart2;
                    }
                    else
                        TorpedoHitState = "miss";
                    GameObjects.Animation.TorpedoFireAnimation(TorpedoHitState);
                    Console.WriteLine("Torpedo has missed the target!!");
                    goto TorpedoStart2;
                }
                else
                    if (FireTorpedo == "N" || FireTorpedo == "n")
                {
                    goto MainLoop;
                }
                else
                    Console.WriteLine("No understandable answer given!");
                goto TorpedoStart;
            }
            else
                                if (command == "she")
            {
                if (Enemies == 0)
                {
                    int sheRe = EnergyLevel - 100;
                    EnergyLevel = sheRe;
                    ShieldLevel = 100;
                    Console.WriteLine("Shields have been restored!!");
                    goto MainLoop;
                }
                else
                    Console.WriteLine("Cannot repair shields!! Enemies are nearby!!");
                goto MainLoop;
            }
            else
                                    if (command == "exit")
            {
                goto EXIT;
            }
            else
                                        if (command == "clear")
            {
                Console.Clear();
                goto MainLoop;
            }
            else
                                            if (command == "repair")
            {
                if (Enemies == 0)
                {
                    Damage = 0;
                    Console.WriteLine("Repairs have been made.");
                    goto MainLoop;
                }
                else
                    Console.WriteLine("Cannot conduct repairs with enemies nearby!!");
                goto MainLoop;
            }
            else
                                                if (command == "refuel")
            {
                if (Dimension == "Earth")
                {
                    EnergyLevel = 2000;
                    Console.WriteLine("Energy has been refilled!!");
                    goto MainLoop;
                }
                else
                    Console.WriteLine("Cannot refuel, not friendly bases nearby!!");
                goto MainLoop;
            }
            else
                                                    if (command == "die")
            {
                GameObjects.EasterEggs.MainLoopEgg();
                EnergyLevel = 0;
                ShieldLevel = 0;
                Damage = 100;
                Console.Write("What would you like to say:");
                string dieing_wish = Console.ReadLine();
                goto MainLoop;
            }
            else
                Console.WriteLine("Incorrect command!!");
            goto MainLoop;
        WINGAME:
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
        EXIT:
            string ccceerr = Console.ReadLine();
        }
    }
}
