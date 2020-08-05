using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");

        ScoreText.score = 0;
        MoveActor.isPlaying = false;
        SpawnCoins.number = 0;
        Render.state = true;

    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu 1");
        ScoreText.score = 0;
        MoveActor.isPlaying = false;
        SpawnCoins.number = 0;
        Render.state = true;
    }
	
}
