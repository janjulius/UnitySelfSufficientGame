using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Main.Game.Player
{
    public class Appearance
    {
        private int _playerHair = 0;
        private int _playerMustache = 0;
        private int _playerShirt = 0;
        private int _playerArm = 0;
        private int _playerWrist = 0;
        private int _playerLegs = 0;
        private int _playerFeet = 0;

        public Appearance(int hair, int mustache, int shirt, int arms, int wrist, int legs, int feet)
        {
            
        }

        public int PlayerHair
        {
            set { _playerHair = value; }
            get { return _playerHair; }
        }

        public int PlayerMustache
        {
            set { _playerMustache = value; }
            get { return _playerMustache; }
        }

        public int PlayerShirt
        {
            set { _playerShirt = value; }
            get { return _playerShirt; }
        }

        public int PlayerArm
        {
            set { _playerArm = value; }
            get { return _playerArm; }
        }

        public int PlayerWrist
        {
            set { _playerWrist = value; }
            get { return _playerWrist; }
        }

        public int PlayerLegs
        {
            set { _playerLegs = value; }
            get { return _playerLegs; }
        }

        public int PlayerFeet
        {
            set { _playerFeet = value; }
            get { return _playerFeet; }
        }
    }
}
