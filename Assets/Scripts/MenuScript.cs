using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class MenuScript : MonoBehaviour
{
    public static bool isStart = false;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isStart = true;
    }
    
}
