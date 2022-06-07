using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public class GameState
    {
        // Port animation statics
        public static readonly int _EARTH_PORT = 10000000;
        public static readonly int _ALPHA_PORT = 20000000;
        public static readonly int _BETA_PORT = 30000000;
        public static readonly int _GAMMA_PORT = 40000000;
        public static readonly int _DELTA_PORT = 50000000;
        // Game statics
        public static readonly int _ENERGY_MAX = 2000;
        public static readonly int _SHIELD_MAX = 200;
        public static readonly int _LASER_ENERGY_COST = 20;
        public static readonly int _TORPEDO_ENERGY_COST = 40;

        private Random randomNumberGenerator;
        private int _EarthEnemy;
        private int _AlphaX1Y1;
        private int _AlphaX1Y2;
        private int _AlphaX2Y1;
        private int _AlphaX2Y2;
        private int _BetaX1Y1;
        private int _BetaX1Y2;
        private int _BetaX2Y1;
        private int _BetaX2Y2;
        private int _GammaX1Y1;
        private int _GammaX1Y2;
        private int _GammaX2Y1;
        private int _GammaX2Y2;
        private int _DeltaX1Y1;
        private int _DeltaX1Y2;
        private int _DeltaX2Y1;
        private int _DeltaX2Y2;
        private int _EarthPort;
        private int _AlphaPort;
        private int _BetaPort;
        private int _GammaPort;
        private int _DeltaPort;
        private Dimension _Dimension;
        private int _SectorX;
        private int _SectorY;
        private int _Sector;
        private int _EnergyLevel;
        private int _ShieldLevel;
        private Condition _Condition;
        private Status _LaserStatus;
        private Status _TorpedoStatus;
        private string _LaserHitState = "";
        private string _TorpedoHitState = "";
        private int _Damage;
        private int _Enemies;

        public GameState()
        {
            this.randomNumberGenerator = new Random();
            this.init();
        }

        private void init()
        {
            EarthEnemy = 0;
            AlphaX1Y1 = randomNumberGenerator.Next(1, 10);
            AlphaX1Y2 = randomNumberGenerator.Next(1, 10);
            AlphaX2Y1 = randomNumberGenerator.Next(1, 10);
            AlphaX2Y2 = randomNumberGenerator.Next(1, 10);
            BetaX1Y1 = randomNumberGenerator.Next(7, 12);
            BetaX1Y2 = randomNumberGenerator.Next(7, 12);
            BetaX2Y1 = randomNumberGenerator.Next(7, 12);
            BetaX2Y2 = randomNumberGenerator.Next(7, 12);
            GammaX1Y1 = randomNumberGenerator.Next(10, 15);
            GammaX1Y2 = randomNumberGenerator.Next(10, 15);
            GammaX2Y1 = randomNumberGenerator.Next(10, 15);
            GammaX2Y2 = randomNumberGenerator.Next(10, 15);
            DeltaX1Y1 = randomNumberGenerator.Next(15, 25);
            DeltaX1Y2 = randomNumberGenerator.Next(15, 25);
            DeltaX2Y1 = randomNumberGenerator.Next(15, 25);
            DeltaX2Y2 = randomNumberGenerator.Next(15, 25);
            EarthPort = 10000000;
            AlphaPort = 20000000;
            BetaPort = 30000000;
            GammaPort = 40000000;
            DeltaPort = 50000000;
            Dimension = Dimension.D_EARTH;
            SectorX = 1;
            SectorY = 1;
            Sector = 1;
            EnergyLevel = _ENERGY_MAX;
            ShieldLevel = 100;
            Condition = Condition.C_GREEN;
            LaserStatus = Status.ONLINE;
            TorpedoStatus = Status.ONLINE;
            Damage = 0;
            Enemies = 0;
        }

        public int EarthEnemy { get => _EarthEnemy; set => _EarthEnemy = value; }
        public int AlphaX1Y1 { get => _AlphaX1Y1; set => _AlphaX1Y1 = value; }
        public int AlphaX1Y2 { get => _AlphaX1Y2; set => _AlphaX1Y2 = value; }
        public int AlphaX2Y1 { get => _AlphaX2Y1; set => _AlphaX2Y1 = value; }
        public int AlphaX2Y2 { get => _AlphaX2Y2; set => _AlphaX2Y2 = value; }
        public int BetaX1Y1 { get => _BetaX1Y1; set => _BetaX1Y1 = value; }
        public int BetaX1Y2 { get => _BetaX1Y2; set => _BetaX1Y2 = value; }
        public int BetaX2Y1 { get => _BetaX2Y1; set => _BetaX2Y1 = value; }
        public int BetaX2Y2 { get => _BetaX2Y2; set => _BetaX2Y2 = value; }
        public int GammaX1Y1 { get => _GammaX1Y1; set => _GammaX1Y1 = value; }
        public int GammaX1Y2 { get => _GammaX1Y2; set => _GammaX1Y2 = value; }
        public int GammaX2Y1 { get => _GammaX2Y1; set => _GammaX2Y1 = value; }
        public int GammaX2Y2 { get => _GammaX2Y2; set => _GammaX2Y2 = value; }
        public int DeltaX1Y1 { get => _DeltaX1Y1; set => _DeltaX1Y1 = value; }
        public int DeltaX1Y2 { get => _DeltaX1Y2; set => _DeltaX1Y2 = value; }
        public int DeltaX2Y1 { get => _DeltaX2Y1; set => _DeltaX2Y1 = value; }
        public int DeltaX2Y2 { get => _DeltaX2Y2; set => _DeltaX2Y2 = value; }
        public int EarthPort { get => _EarthPort; set => _EarthPort = value; }
        public int AlphaPort { get => _AlphaPort; set => _AlphaPort = value; }
        public int BetaPort { get => _BetaPort; set => _BetaPort = value; }
        public int GammaPort { get => _GammaPort; set => _GammaPort = value; }
        public int DeltaPort { get => _DeltaPort; set => _DeltaPort = value; }
        public Dimension Dimension { get => _Dimension; set => _Dimension = value; }
        public int SectorX { get => _SectorX; set => _SectorX = value; }
        public int SectorY { get => _SectorY; set => _SectorY = value; }
        public int Sector { get => _Sector; set => _Sector = value; }
        public int EnergyLevel { get => _EnergyLevel; set => _EnergyLevel = value; }
        public int ShieldLevel { get => _ShieldLevel; set => _ShieldLevel = value; }
        public Condition Condition { get => _Condition; set => _Condition = value; }
        public Status LaserStatus { get => _LaserStatus; set => _LaserStatus = value; }
        public string LaserHitState { get => _LaserHitState; set => _LaserHitState = value; }
        public Status TorpedoStatus { get => _TorpedoStatus; set => _TorpedoStatus = value; }
        public string TorpedoHitState { get => _TorpedoHitState; set => _TorpedoHitState = value; }
        public int Damage { get => _Damage; set => _Damage = value; }
        public int Enemies { get => _Enemies; set => _Enemies = value; }

        public void repair()
        {
            this.Damage = 0;
        }

        public void refuel()
        {
            this.EnergyLevel = _ENERGY_MAX;
        }

        public void recharge()
        {
            this.ShieldLevel = _SHIELD_MAX / 2;
        }

        public void navigate()
        {
            this.EnergyLevel -= 200;
        }

        public bool canNavigate()
        {
            return EnergyLevel > 200;
        }

        public bool didIlose()
        {
            if (this.Damage == 100 || this.ShieldLevel == 0)
            {
                Console.WriteLine("Sorry, you have lost!!");
                GameObjects.Command.LoseGame();
                return true;
            }
            else if (this.EnergyLevel == 0)
            {
                Console.WriteLine("Sorry, you have run out of fuel!!");
                GameObjects.Command.LoseGame();
                return true;
            }
            else if (EnergyLevel < 200 & Enemies == 0)
            {
                Console.WriteLine("You do not have enough energy for space travel, your ship is adrift in space!");
                GameObjects.Command.LoseGame();
                return true;
            }
            return false;
        }

        public bool didIWin()
        {
            if (AlphaX1Y1 == 0 & 
                AlphaX1Y2 == 0 & 
                AlphaX2Y1 == 0 & 
                AlphaX2Y2 == 0 & 
                BetaX1Y1 == 0 & 
                BetaX1Y2 == 0 & 
                BetaX2Y1 == 0 & 
                BetaX2Y2 == 0 & 
                GammaX1Y1 == 0 & 
                GammaX1Y2 == 0 & 
                GammaX2Y1 == 0 & 
                GammaX2Y2 == 0 & 
                DeltaX1Y1 == 0 & 
                DeltaX1Y2 == 0 & 
                DeltaX2Y1 == 0 & 
                DeltaX2Y2 == 0)
            {
                GameObjects.Command.WinGame();
                return true;
            }
            return false;
        }

        public string getDamageMessage(Status status)
        {
            switch (status)
            {
                case Status.ONLINE: return "armed, and ready to fire!!";
                case Status.OFFLINE: return "damaged and cannot be fired, must be repaired!";
                case Status.UNKNOWN: return "disconnected, unknown status.";
                default: return "";
            }
        }

        public string getStatusMessage(Status status)
        {
            switch(status)
            {
                case Status.ONLINE: return "online and ready.";
                case Status.OFFLINE: return "offline, not ready.";
                case Status.UNKNOWN: return "disconnected unknown status.";
                default: return "";
            }
        }

        public string getColorMessage(Condition condition)
        {
            switch(condition)
            {
                case Condition.C_GREEN: return "Green";
                case Condition.C_YELLOW: return "Yellow";
                case Condition.C_RED: return "Red";
                default: return "Green";
            }
        }

        public ConsoleColor getConditionColor(Condition condition)
        {
            switch(condition)
            {
                case Condition.C_GREEN: return ConsoleColor.Green;
                case Condition.C_YELLOW: return ConsoleColor.Yellow;
                case Condition.C_RED: return ConsoleColor.Red;
                default: return ConsoleColor.White;
            }
        }
    }

    public enum Condition
    {
        C_GREEN,
        C_YELLOW,
        C_RED
    }

    public enum Dimension
    {
        D_EARTH,
        D_ALPHA,
        D_BETA,
        D_GAMMA,
        D_DELTA
    }

    public enum Status
    {
        ONLINE,
        OFFLINE,
        UNKNOWN
    }
}
