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
		GameManager.Instance.onUpdatePlayerPoints += UpdatePointsText;
	}

    private void Start()
	{
		UpdatePointsText();
	}

	//private void OnDestroy()
	//{
	//	GameManager.Instance.onUpdatePlayerPoints -= UpdatePointsText;
	//}

	public void UpdatePointsText()
    {
        if (pointsText)
            pointsText.text = GameManager.Instance.PlayerPoints.ToString() + "/" + "100";
    }
}
