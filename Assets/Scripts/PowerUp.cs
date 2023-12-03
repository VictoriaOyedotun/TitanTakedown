using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private static string PLAYER_TAG = "Player";
    
    private void OnCollisionEnter2D(Collision2D collision){
    if (collision.gameObject.CompareTag(PLAYER_TAG)){
        Destroy(gameObject);
        LivesScript.livesScore += 1;
    }
   }
}
