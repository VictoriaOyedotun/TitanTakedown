using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private GameObject[] characters;
    private int _charIndex;
    public int CharIndex{
        get { return _charIndex;}
        set { _charIndex = value;}
    }
    //Awake is the first function that is called when the unity project runs
    private void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    // onEnable/onDisable is the second function to run after awake
    private void onEnable(){
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    //Void start is usually the next function after onEnabled
    private void onDisable(){
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode){
        if(scene.name == "Gameplay"){
            Instantiate(characters[CharIndex]);
        }
    }

}
