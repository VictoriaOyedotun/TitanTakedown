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
        if(LivesScript.livesScore <= 0){
            gameOver.text = "Game Over"; 
        }
    }


}
