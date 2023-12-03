using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private float health = 100;
    private Rigidbody2D myBody;
    private GameObject redParticles;
    private string BULLET_TAG = "Bullet";

    void Awake(){
        myBody = GetComponent<Rigidbody2D>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed,myBody.velocity.y);
    }

    public void TakeDamage(float damage){
        health -= damage;
    }

     private void OnTriggerEnter2D(Collider2D collision){
        health -= 20;
        if (collision.gameObject.CompareTag(BULLET_TAG) && health <= 0) {
            Destroy(gameObject);
        }
    }
}
