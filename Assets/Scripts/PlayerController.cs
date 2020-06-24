﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int points = 0;
   
    void Start()
    {
        // test idle animation
        // GetComponent<Animator>().Play("tr_idle");
    }


    public void addPoints(int points)
    {
        this.points = Mathf.Max(0, points);
    }
}
