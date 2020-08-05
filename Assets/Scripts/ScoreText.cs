using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public static int score = 0;
    public Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (MenuScript.isStart)
        {
            text.text = "Score: " + score.ToString();
        }
	}
}
