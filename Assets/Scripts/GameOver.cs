using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static Text gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = GetComponent<Text>();  
    }

    // Update is called once per frame
    void Update()
    {
       isGameOver();
    }

    public static void isGameOver(){
         if(LivesScript.livesScore <= 0){
            gameOver.text = "Game Over"; 
        }
    }
     public static void hideGameOver(){
            gameOver.text = ""; 
    }

}
