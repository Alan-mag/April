using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text pointsText;

    private void Awake()
    {
        Assert.IsNotNull(pointsText);
    }

    public void updatePoints(int points)
    {
        pointsText.text = points.ToString();
    }
}
