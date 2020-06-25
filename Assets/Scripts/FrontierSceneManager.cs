using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FrontierSceneManager : MonoBehaviour
{
    public abstract void playerTapped(GameObject player);
    public abstract void collectibleTapped(GameObject collectible);
}
