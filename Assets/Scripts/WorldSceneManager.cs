using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : FrontierSceneManager
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void playerTapped(GameObject player)
    {

    }

    public override void collectibleTapped(GameObject collectible)
    {
        SceneManager.LoadScene(FrontierConstants.SCENE_PUZZLE, LoadSceneMode.Additive);
    }
}
