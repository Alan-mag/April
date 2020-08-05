using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int points;
   
    void Start()
    {
        // test idle animation
        // GetComponent<Animator>().Play("tr_idle");
    }

    public int Points
    {
        get { return points; }
    }


    public void addPoints(int points)
    {
        this.points = Mathf.Max(0, points);
    }
}
