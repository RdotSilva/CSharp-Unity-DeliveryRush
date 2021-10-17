using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
    Text timeLeftText;
    public static float timeLeft = 10f;

    // Start is called before the first frame update
    void Start()
    {
        timeLeftText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
        DisplayTime(Mathf.Round(timeLeft));
    }

    // Display the new time left
    void DisplayTime(float timeToDisplay)
    {
        timeLeftText.text = string.Format("Time left: {0}", timeToDisplay);
    }
}
