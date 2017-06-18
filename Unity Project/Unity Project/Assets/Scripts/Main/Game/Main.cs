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
        Player CurrentPlayer = LoadPlayer();


        print(CurrentPlayer.Name);
        print(CurrentPlayer.Gender);
        print(Constants.NAME);

        CurrentPlayer.Name = "test";
        print(CurrentPlayer.Name);
    }

    public Player LoadPlayer()
    {
        return new Player("aname", Gender.MALE);
    }
}
