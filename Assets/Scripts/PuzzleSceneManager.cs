using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSceneManager : FrontierSceneManager
{
    public override void collectibleTapped(GameObject collectible)
    {
        print("clicked collectible");
        // GameManager.Instance.CurrentPlayer.addPoints(1);
        SceneTransitionManager.Instance.GoToScene(FrontierConstants.SCENE_WORLD, new List<GameObject>()); // shouldn't be new list
    }

    public override void playerTapped(GameObject player)
    {
        print("");
    }
}
