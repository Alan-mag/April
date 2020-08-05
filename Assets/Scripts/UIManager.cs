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

    private void Update()
    {
        updatePoints();
    }

    public void updatePoints()
    {
        pointsText.text = GameManager.Instance.PlayerPoints.ToString() + "/" + "100";
    }
}
