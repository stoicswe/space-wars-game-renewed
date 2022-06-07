using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class Ship
    {
        public static Random randomNum = new Random();

        public static void EnemyHit(GameState gameState)
        {
            int EnemyHitShip = randomNum.Next(1, 10);
            Console.WriteLine("Enemy is firing cannons!!");
            if (EnemyHitShip == 2 ||
                EnemyHitShip == 4 ||
                EnemyHitShip == 6 ||
                EnemyHitShip == 8 ||
                EnemyHitShip == 10)
            {
                int DamageLevel = randomNum.Next(10, 25);
                double blockPercent = randomNum.NextDouble();
                int newDamage = (int)((DamageLevel * 1.0) * blockPercent);
                gameState.ShieldLevel -= newDamage;
                gameState.Damage += (DamageLevel - newDamage);
                Console.WriteLine("Damage has been taken!!");
            }
            else
            {
                Console.WriteLine("Enemy has missed!!");
            }
        }
        public static void HUD(GameState gameState, GameWindow gameWindow)
        {
            if (gameState.Damage > 0 & gameState.Enemies > 0){ gameState.Condition = Condition.C_RED; }
            else if (gameState.Damage > 0 & gameState.Enemies == 0){ gameState.Condition = Condition.C_YELLOW; }
            else if (gameState.Damage > 50 & gameState.Enemies == 0){ gameState.Condition = Condition.C_RED; }
            else if (gameState.Damage == 0 & gameState.Enemies > 0){ gameState.Condition = Condition.C_YELLOW; }
            else if (gameState.Damage == 0 & gameState.Enemies == 0){ gameState.Condition = Condition.C_GREEN; }
            gameWindow.apply(gameState.getConditionColor(gameState.Condition));
            // HUD Displays
            string Earth1 = "|.....*...*......*...|              | Dimension: Earth";
            string Earth2 = "|..*..........*......|              | SectorX:   " + gameState.SectorX;
            string Earth3 = "|.....*.....*.....*..|              | SectorY:   " + gameState.SectorY;
            string Earth4 = "|.*......(F).........|              | Shields:   " + gameState.ShieldLevel + "%";
            string Earth5 = "|.....*.......*......|              | Energy:    " + gameState.EnergyLevel + " dmu";
            string Earth6 = "|..*......*.*....**..|              | Condition: " + gameState.getColorMessage(gameState.Condition);
            string Earth7 = "|....=@{......*.....*|              | Damage:    " + gameState.Damage + "%";
            string Earth8 = "----------------------              | Enemies:   " + gameState.Enemies;

            string Alpha1 = "|.....*...*......*...|              | Dimension: Alpha";
            string Alpha2 = "|..*..........*......|              | SectorX:   " + gameState.SectorX;
            string Alpha3 = "|.....*.....*.....*..|              | SectorY:   " + gameState.SectorY;
            string Alpha4 = "|.*.......*..........|              | Shields:   " + gameState.ShieldLevel + "%";
            string Alpha5 = "|.....*.......*......|              | Energy:    " + gameState.EnergyLevel + " dmu";
            string Alpha6 = "|..*......*.*....**..|              | Condition: " + gameState.getColorMessage(gameState.Condition);
            string Alpha7 = "|....=@{......*.....*|              | Damage:    " + gameState.Damage + "%";
            string Alpha8 = "----------------------              | Enemies:   " + gameState.Enemies;

            string Beta1 = "|.....*..........*...|              | Dimension: Beta";
            string Beta2 = "|..*..........*......|              | SectorX:   " + gameState.SectorX;
            string Beta3 = "|.....*...........*..|              | SectorY:   " + gameState.SectorY;
            string Beta4 = "|.*.....*........*...|              | Shields:   " + gameState.ShieldLevel + "%";
            string Beta5 = "|.....*..............|              | Energy:    " + gameState.EnergyLevel + " dmu";
            string Beta6 = "|..*.....*...........|              | Condition: " + gameState.getColorMessage(gameState.Condition);
            string Beta7 = "|....=@{......*.....*|              | Damage:    " + gameState.Damage + "%";
            string Beta8 = "----------------------              | Enemies:   " + gameState.Enemies;

            string Gamma1 = "|.....*...*......*...|              | Dimension: Gamma";
            string Gamma2 = "|..*.................|              | SectorX:   " + gameState.SectorX;
            string Gamma3 = "|....................|              | SectorY:   " + gameState.SectorY;
            string Gamma4 = "|.*..................|              | Shields:   " + gameState.ShieldLevel + "%";
            string Gamma5 = "|.....*.......*......|              | Energy:    " + gameState.EnergyLevel + " dmu";
            string Gamma6 = "|..*......*.*....**..|              | Condition: " + gameState.getColorMessage(gameState.Condition);
            string Gamma7 = "|....=@{......*.....*|              | Damage:    " + gameState.Damage + "%";
            string Gamma8 = "----------------------              | Enemies:   " + gameState.Enemies;

            string Delta1 = "|.....*...*......*...|              | Dimension: Delta";
            string Delta2 = "|..*..........*......|              | SectorX:   " + gameState.SectorX;
            string Delta3 = "|.....*.....*.....*..|              | SectorY:   " + gameState.SectorY;
            string Delta4 = "|.*..................|              | Shields:   " + gameState.ShieldLevel + "%";
            string Delta5 = "|.....*.......*......|              | Energy:    " + gameState.EnergyLevel + " dmu";
            string Delta6 = "|..*......*.*....**..|              | Condition: " + gameState.getColorMessage(gameState.Condition);
            string Delta7 = "|....=@{......*.....*|              | Damage:    " + gameState.Damage + "%";
            string Delta8 = "----------------------              | Enemies:   " + gameState.Enemies;
            Console.WriteLine("====================== USS Infatron ===========================");
            if (gameState.Dimension == Dimension.D_EARTH)
            {
                Console.WriteLine(Earth1);
                Console.WriteLine(Earth2);
                Console.WriteLine(Earth3);
                Console.WriteLine(Earth4);
                Console.WriteLine(Earth5);
                Console.WriteLine(Earth6);
                Console.WriteLine(Earth7);
                Console.WriteLine(Earth8);
            }
            else if (gameState.Dimension == Dimension.D_ALPHA)
            {
                Console.WriteLine(Alpha1);
                Console.WriteLine(Alpha2);
                Console.WriteLine(Alpha3);
                Console.WriteLine(Alpha4);
                Console.WriteLine(Alpha5);
                Console.WriteLine(Alpha6);
                Console.WriteLine(Alpha7);
                Console.WriteLine(Alpha8);
            }
            else if (gameState.Dimension == Dimension.D_BETA)
            {
                Console.WriteLine(Beta1);
                Console.WriteLine(Beta2);
                Console.WriteLine(Beta3);
                Console.WriteLine(Beta4);
                Console.WriteLine(Beta5);
                Console.WriteLine(Beta6);
                Console.WriteLine(Beta7);
                Console.WriteLine(Beta8);
            }
            else if (gameState.Dimension == Dimension.D_GAMMA)
            {
                Console.WriteLine(Gamma1);
                Console.WriteLine(Gamma2);
                Console.WriteLine(Gamma3);
                Console.WriteLine(Gamma4);
                Console.WriteLine(Gamma5);
                Console.WriteLine(Gamma6);
                Console.WriteLine(Gamma7);
                Console.WriteLine(Gamma8);
            }
            else if (gameState.Dimension == Dimension.D_DELTA)
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
            Console.WriteLine("===============================================================");
        }

        public static void NAV(GameState gameState, GameWindow gameWindow)
        {
            if (gameState.canNavigate())
            {
                if (gameState.Dimension == Dimension.D_EARTH)
                {
                    Console.Clear();
                    Console.WriteLine("========== Navigation ===========");
                    Console.WriteLine("|                               |");
                    Console.WriteLine("|                               |");
                    Console.WriteLine("|              =@{              |");
                    Console.WriteLine("|                               |");
                    Console.WriteLine("|                               |");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Dimension: " + gameState.Dimension);
                    Console.WriteLine("Sector: " + gameState.Sector);
                    Console.WriteLine("Technical Data-----");
                    Console.WriteLine("SectorX: " + gameState.SectorX);
                    Console.WriteLine("SectorY:" + gameState.SectorY);
                }
                else
                {
                    Console.Clear();
                    if (gameState.SectorX == 1 & gameState.SectorY == 1)
                    {
                        Console.WriteLine("========== Navigation ===========");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|-------------- | --------------|");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|   =@{         |               |");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Dimension: " + gameState.Dimension);
                        Console.WriteLine("Sector: " + gameState.Sector);
                        Console.WriteLine("Technical Data-----");
                        Console.WriteLine("SectorX: " + gameState.SectorX);
                        Console.WriteLine("SectorY:" + gameState.SectorY);
                    }
                    else if (gameState.SectorX == 1 & gameState.SectorY == 2)
                    {
                        Console.WriteLine("========== Navigation ===========");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|-------------- | --------------|");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|               |         =@{   |");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Dimension: " + gameState.Dimension);
                        Console.WriteLine("Sector: " + gameState.Sector);
                        Console.WriteLine("Technical Data-----");
                        Console.WriteLine("SectorX: " + gameState.SectorX);
                        Console.WriteLine("SectorY:" + gameState.SectorY);
                    }
                    else if (gameState.SectorX == 2 & gameState.SectorY == 1)
                    {
                        Console.WriteLine("========== Navigation ===========");
                        Console.WriteLine("|   =@{         |               |");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|-------------- | --------------|");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Dimension: " + gameState.Dimension);
                        Console.WriteLine("Sector: " + gameState.Sector);
                        Console.WriteLine("Technical Data-----");
                        Console.WriteLine("SectorX: " + gameState.SectorX);
                        Console.WriteLine("SectorY:" + gameState.SectorY);
                    }
                    else if (gameState.SectorX == 2 & gameState.SectorY == 2)
                    {
                        Console.WriteLine("========== Navigation ===========");
                        Console.WriteLine("|               |          =@{  |");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|-------------- | --------------|");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("|               |               |");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Dimension: " + gameState.Dimension);
                        Console.WriteLine("Sector: " + gameState.Sector);
                        Console.WriteLine("Technical Data-----");
                        Console.WriteLine("SectorX: " + gameState.SectorX);
                        Console.WriteLine("SectorY:" + gameState.SectorY);
                    }
                }
                bool selected = false;
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Available Dimensions:");
                    Console.WriteLine("Earth, Alpha, Beta, Gamma, Delta");
                    Console.Write("Please enter a Dimension:");
                    string selectedDimension = Console.ReadLine();
                    switch (selectedDimension)
                    {
                        case "Earth":
                            {
                                gameState.Dimension = Dimension.D_EARTH;
                                selected = true;
                                break;
                            }
                        case "Alpha":
                            {
                                gameState.Dimension = Dimension.D_ALPHA;
                                selected = true;
                                break;
                            }
                        case "Beta":
                            {
                                gameState.Dimension = Dimension.D_BETA;
                                selected = true;
                                break;
                            }
                        case "Gamma":
                            {
                                gameState.Dimension = Dimension.D_GAMMA;
                                selected = true;
                                break;
                            }
                        case "Delta":
                            {
                                gameState.Dimension = Dimension.D_DELTA;
                                selected = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("The dimension entered does not exist.");
                                break;
                            }
                    }
                } while (!selected);
                bool selectedSector = false;
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Avialable Coordinates:");
                    Console.WriteLine("Sector: 1, 2, 3, 4");
                    Console.WriteLine("Note: Earth has only one set of");
                    Console.WriteLine("coordinates(Sector 1)");
                    Console.WriteLine("Please Enter the Coordinates:");
                    Console.Write("Sector: ");
                    int newSector = -1;
                    try
                    {
                        newSector = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: Non valid sector was entered.");
                    }
                    if (newSector > 0)
                    {
                        switch(newSector)
                        {
                            case 1:
                                {
                                    gameState.Sector = 1;
                                    selectedSector = true;
                                    break;
                                }
                            case 2:
                                {
                                    gameState.Sector = 2;
                                    selectedSector = true;
                                    break;
                                }
                            case 3:
                                {
                                    gameState.Sector = 3;
                                    selectedSector = true;
                                    break;
                                }
                            case 4:
                                {
                                    gameState.Sector = 4;
                                    selectedSector = true;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Please enter correct coordinates.");
                                    selectedSector = false;
                                    break;
                                }
                        }
                        if(gameState.Dimension == Dimension.D_EARTH && !(gameState.SectorX == 1 && gameState.SectorY == 1))
                        {
                            Console.WriteLine("Only sector 1 is allowed for the Earth dimension.");
                            selectedSector = false;
                        }
                    }
                } while (!selectedSector);
                // Set the enemies and display animation
                Console.Clear();
                switch (gameState.Dimension)
                {
                    case Dimension.D_EARTH:
                        {
                            GameObjects.Animation.TravelAnimation(GameObjects.GameState._EARTH_PORT);
                            gameState.Enemies = gameState.EarthEnemy;
                            break;
                        }
                    case Dimension.D_ALPHA:
                        {
                            GameObjects.Animation.TravelAnimation(GameObjects.GameState._ALPHA_PORT);
                            if (gameState.Sector == 1) { gameState.Enemies = gameState.AlphaX1Y1; }
                            if (gameState.Sector == 2) { gameState.Enemies = gameState.AlphaX2Y1; }
                            if (gameState.Sector == 3) { gameState.Enemies = gameState.AlphaX2Y2; }
                            if (gameState.Sector == 4) { gameState.Enemies = gameState.AlphaX1Y2; }
                            break;
                        }
                    case Dimension.D_BETA:
                        {
                            GameObjects.Animation.TravelAnimation(GameObjects.GameState._BETA_PORT);
                            if (gameState.Sector == 1) { gameState.Enemies = gameState.BetaX1Y1; }
                            if (gameState.Sector == 2) { gameState.Enemies = gameState.BetaX2Y1; }
                            if (gameState.Sector == 3) { gameState.Enemies = gameState.BetaX2Y2; }
                            if (gameState.Sector == 4) { gameState.Enemies = gameState.BetaX1Y2; }
                            break;
                        }
                    case Dimension.D_GAMMA:
                        {
                            GameObjects.Animation.TravelAnimation(GameObjects.GameState._GAMMA_PORT);
                            if (gameState.Sector == 1) { gameState.Enemies = gameState.GammaX1Y1; }
                            if (gameState.Sector == 2) { gameState.Enemies = gameState.GammaX2Y1; }
                            if (gameState.Sector == 3) { gameState.Enemies = gameState.GammaX2Y2; }
                            if (gameState.Sector == 4) { gameState.Enemies = gameState.GammaX1Y2; }
                            break;
                        }
                    case Dimension.D_DELTA:
                        {
                            GameObjects.Animation.TravelAnimation(GameObjects.GameState._DELTA_PORT);
                            if (gameState.Sector == 1) { gameState.Enemies = gameState.DeltaX2Y2; }
                            if (gameState.Sector == 2) { gameState.Enemies = gameState.DeltaX2Y1; }
                            if (gameState.Sector == 3) { gameState.Enemies = gameState.DeltaX2Y2; }
                            if (gameState.Sector == 4) { gameState.Enemies = gameState.DeltaX1Y2; }
                            break;
                        }
                    default:
                        break;
                }
                gameState.EnergyLevel -= 200;
            }
            else
            {
                Console.WriteLine("Cannot travel, too low on fuel!!");
            }
        }

        public static void LASER(GameState gameState, GameWindow gameWindow)
        {
            if (gameState.Enemies > 0)
            {
                if(gameState.EnergyLevel > 20 && (gameState.Damage < 100 || gameState.Damage > 0))
                {
                    while (true)
                    {
                        // Do some checks
                        if(gameState.Enemies == 0) { break; }
                        Console.Clear();
                        // Enemy fire calc
                        EnemyHit(gameState);
                        if(gameState.Damage > 75)
                        {
                            gameState.LaserStatus = Status.OFFLINE;
                            break;
                        }
                        if(gameState.EnergyLevel < 20)
                        {
                            Console.WriteLine("Insufficient energy to fire lasers!!");
                            break;
                        }
                        // Show the laser fire screen
                        Console.WriteLine("Lasers cost 20 energy per fire, use carefully!!");
                        Console.WriteLine("===============================================");
                        Console.WriteLine(" Laser status: " + gameState.LaserStatus);
                        Console.WriteLine(" Enemy count: " + gameState.Enemies);
                        Console.WriteLine(" Energy: " + gameState.EnergyLevel);
                        Console.WriteLine(" Lasers are " + gameState.getDamageMessage(gameState.LaserStatus));
                        Console.WriteLine(" Damage:" + gameState.Damage);
                        Console.WriteLine(" Shields: " + gameState.ShieldLevel);
                        Console.WriteLine("===============================================");
                        Console.Write("Fire? (y/n): ");
                        ConsoleKey key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.Y:
                                {
                                    int LaserHit = randomNum.Next(1, 10);
                                    if (LaserHit == 1 || 
                                        LaserHit == 3 || 
                                        LaserHit == 5 || 
                                        LaserHit == 7 || 
                                        LaserHit == 9)
                                    {
                                        gameState.LaserHitState = "hit";
                                        GameObjects.Animation.LaserFireAnimation(gameState.LaserHitState);
                                        Console.WriteLine("An enemy has been destroyed!");
                                        gameState.Enemies -= 1;
                                        gameState.EnergyLevel -= GameObjects.GameState._LASER_ENERGY_COST;
                                        switch(gameState.Dimension)
                                        {
                                            case Dimension.D_ALPHA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            case Dimension.D_BETA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            case Dimension.D_GAMMA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            case Dimension.D_DELTA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            default:
                                                {
                                                    break;
                                                }
                                        }
                                    } else
                                    {
                                        gameState.LaserHitState = "miss";
                                        GameObjects.Animation.LaserFireAnimation(gameState.LaserHitState);
                                        Console.WriteLine("Laser has missed the target!!");
                                    }
                                    break;
                                }
                            case ConsoleKey.N:
                                {
                                    return;
                                }
                            default:
                                {
                                    GameObjects.EasterEggs.TorpedoEgg();
                                    Console.WriteLine("No understandable answer given!");
                                    Console.WriteLine();
                                    break;
                                }
                        }
                    }
                } else
                {
                    Console.WriteLine("Cannot fire lasers, energy too low or severe damaged sustained!!");
                }
            } 
            else
            {
                Console.WriteLine("No enemies in target!!");
            }
        }

        public static void TORPEDO(GameState gameState, GameWindow gameWindow)
        {
            if (gameState.Enemies > 0)
            {
                if (gameState.EnergyLevel > 40 && (gameState.Damage < 100 || gameState.Damage > 0))
                {
                    while (true)
                    {
                        if(gameState.Enemies == 0) { break; }
                        Console.Clear();
                        EnemyHit(gameState);
                        if(gameState.Damage > 60)
                        {
                            gameState.TorpedoStatus = Status.OFFLINE;
                        }
                        if (gameState.EnergyLevel < 40)
                        {
                            Console.WriteLine("Insufficient energy to fire torpedos!!");
                            break;
                        }
                        Console.WriteLine("Torpedos cost 40 energy per fire, use carefully!!");
                        Console.WriteLine("===============================================");
                        Console.WriteLine(" Torpedo status: " + gameState.TorpedoStatus);
                        Console.WriteLine(" Enemy count: " + gameState.Enemies);
                        Console.WriteLine(" Energy: " + gameState.EnergyLevel);
                        Console.WriteLine(" Torpedos are " + gameState.getDamageMessage(gameState.TorpedoStatus));
                        Console.WriteLine(" Damage:" + gameState.Damage);
                        Console.WriteLine(" Shields: " + gameState.ShieldLevel);
                        Console.WriteLine("===============================================");
                        Console.Write("Fire? (y/n): ");
                        ConsoleKey key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.Y:
                                {
                                    int TorpedoHit = randomNum.Next(1, 10);
                                    if (TorpedoHit == 1 ||
                                        TorpedoHit == 2 ||
                                        TorpedoHit == 3 ||
                                        TorpedoHit == 7 ||
                                        TorpedoHit == 8 ||
                                        TorpedoHit == 9 ||
                                        TorpedoHit == 10)
                                    {
                                        gameState.TorpedoHitState = "hit";
                                        GameObjects.Animation.TorpedoFireAnimation(gameState.TorpedoHitState);
                                        Console.WriteLine("An enemy has been destroyed!");
                                        gameState.Enemies -= 1;
                                        gameState.EnergyLevel -= GameObjects.GameState._TORPEDO_ENERGY_COST;
                                        switch (gameState.Dimension)
                                        {
                                            case Dimension.D_ALPHA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            case Dimension.D_BETA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            case Dimension.D_GAMMA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            case Dimension.D_DELTA:
                                                {
                                                    if (gameState.Sector == 1) { gameState.AlphaX1Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 2) { gameState.AlphaX2Y1 = gameState.Enemies; }
                                                    if (gameState.Sector == 3) { gameState.AlphaX2Y2 = gameState.Enemies; }
                                                    if (gameState.Sector == 4) { gameState.AlphaX1Y2 = gameState.Enemies; }
                                                    break;
                                                }
                                            default:
                                                {
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        gameState.LaserHitState = "miss";
                                        GameObjects.Animation.TorpedoFireAnimation(gameState.LaserHitState);
                                        Console.WriteLine("Torpedo has missed the target!!");
                                    }
                                    break;
                                }
                            case ConsoleKey.N:
                                {
                                    return;
                                }
                            default:
                                {
                                    Console.WriteLine("No understandable answer given!");
                                    Console.WriteLine();
                                    break;
                                }
                        }
                    }
                } 
                else
                {
                    Console.WriteLine("Cannot fire torpedos, energy too low or severe damaged sustained!!");
                }
            } 
            else
            {
                Console.WriteLine("No enemies in target!!");
            }
        }
    }
}
