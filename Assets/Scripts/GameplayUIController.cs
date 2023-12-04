using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        LivesScript.livesScore = LivesScript.SCORE;
        GameOver.hideGameOver();
        ScoreScript.scoreValue = 0;
        LevelScript.LevelValue = 1;
    }
    public void HomeButton(){
        LivesScript.livesScore = LivesScript.SCORE;
        GameOver.hideGameOver();
        ScoreScript.scoreValue = 0;
        LevelScript.LevelValue = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
