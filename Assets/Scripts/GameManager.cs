using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using System;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private PlayerController currentPlayer;
	public FirebaseInit firebaseInit = null;
	private int playerPoints;
	private bool setInitialPoints;

	public event Action onUpdatePlayerPoints;

    public PlayerController CurrentPlayer
    {
        get { return currentPlayer; }
    }

    public void UpdatePlayerPoints(int points)
    {
        if (onUpdatePlayerPoints != null)
		{
			playerPoints += points;
            firebaseInit.SavePoints(playerPoints);
            onUpdatePlayerPoints();
		}
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
		firebaseInit = GetComponent<FirebaseInit>();
	}

	private void Update()
	{
		if (!setInitialPoints && firebaseInit.InitialPoints != -1)
		{
			playerPoints += firebaseInit.InitialPoints;
			setInitialPoints = true;
			onUpdatePlayerPoints();
		}
	}

}
