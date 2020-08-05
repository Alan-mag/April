using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private PlayerController currentPlayer;
    private int playerPoints;

    public PlayerController CurrentPlayer
    {
        get { return currentPlayer; }
    }

    public void UpdatePlayerPoints(int points)
    {
        playerPoints += points;
    }

    public int PlayerPoints
    {
        get { return playerPoints; }
    }

    public Scene CurrentScene
    {
        get { return SceneManager.GetActiveScene(); }
    }

    private void Awake()
    {
        Assert.IsNotNull(currentPlayer);   
    }
}
