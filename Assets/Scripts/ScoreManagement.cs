using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{
    [SerializeField]
    private Text scoreValueUI;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreValueUI.text = score.ToString();
    }

    public void IncreaseScore (int points)
    {
        score += points;
        scoreValueUI.text = score.ToString();
    }

    
}
