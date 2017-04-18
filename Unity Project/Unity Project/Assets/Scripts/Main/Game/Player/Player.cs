using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.Main.Game.Player
{
    public class Player
    {
        private string name;
        private Gender gender;
        private Appearance appearance;

        
        public Player()
        {
            this.appearance = new Appearance(0,0,0,0,0,0,0);
        }

        /// <summary>
        /// Name of the player
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gender of the player
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// All the apearance settings of the player
        /// </summary>
        public Appearance Appearance { get; }
        
    }
}
