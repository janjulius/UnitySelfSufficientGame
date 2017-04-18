using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Main.Game.Player;
using Assets.Scripts.Utilities.Game;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Player CurrentPlayer;

    public void Start()
    {
        CurrentPlayer = LoadPlayer();


        print(CurrentPlayer.Name);
        print(CurrentPlayer.Appearance);
        print(Constants.NAME);
    }

    public Player LoadPlayer()
    {
        return new Player();
    }
}
