using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public float SpawnRate
    {
        get { return spawnRate; }
    }

    public float CatchRate
    {
        get { return catchRate; }
    }

    private void OnMouseDown()
    {
        FrontierSceneManager[] managers = FindObjectsOfType<FrontierSceneManager>();
        foreach(FrontierSceneManager frontierSceneManger in managers)
        {
            if (frontierSceneManger.gameObject.activeSelf)
            {
                frontierSceneManger.collectibleTapped(this.gameObject);
            }
        }
    }
}
