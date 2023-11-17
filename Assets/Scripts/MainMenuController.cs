using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame(){
   //  string clickedObj = EventSystem.current.currentSelectedGameObject.name;
   //  Debug.Log("Index: " + clickedObj);
      // Debug.Log("Button is pressed");
   //  SceneManager.LoadScene("GamePlay");
   int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
   int[] a = new int[10];
   a[selectedCharacter] = 10;
   }
}


