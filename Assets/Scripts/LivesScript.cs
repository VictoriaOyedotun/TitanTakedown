using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{   
    public static int SCORE = 10;
    public static int livesScore = SCORE;
    public static Text lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();  
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void UpdateLives(){
       lives.text = "Lives: " + livesScore; 
    }
}
