using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        LivesScript.livesScore = LivesScript.SCORE;
    }
    public void HomeButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
