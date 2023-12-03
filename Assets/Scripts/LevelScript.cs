using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    public static int LevelValue = 1;
    public static LevelScript levelScriptInstance;
    Text level;
    private void Awake(){
        if(levelScriptInstance != null && levelScriptInstance != this){
            Destroy(this);
        }else{
            levelScriptInstance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
     level = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
      
        levelUp();
    }

    public void levelUp(){
          if(ScoreScript.scoreValue > 0 && ((ScoreScript.scoreValue % 100) == 0) ){
            LevelValue = LevelValue + 1;
        }
        level.text = "Level: " + LevelValue;
    }
}
