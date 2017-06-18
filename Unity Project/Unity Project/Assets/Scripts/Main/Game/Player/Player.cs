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
        private Skills skills;

        
        public Player(string name,
            Gender gender)
        {
            this.name = name;
            this.gender = gender;
            this.appearance = new Appearance();
        }

        /// <summary>
        /// Name of the player
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Gender of the player
        /// </summary>
        public Gender Gender { get { return gender; } set { gender = value; } }

        /// <summary>
        /// All the apearance settings of the player
        /// </summary>
        public Appearance Appearance {
            get { return appearance; }

        }

        public Skills getSkills()
        {
            return skills;
        }
    }
}
