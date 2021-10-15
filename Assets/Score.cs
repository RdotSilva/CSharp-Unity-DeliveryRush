using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int scoreNum;
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        scoreText.text = "Score: " + scoreNum;
    }

    public void IncrementScore()
    {
        scoreNum++;
        scoreText.text = "Score: " + scoreNum;
    }
}
