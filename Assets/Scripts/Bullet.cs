using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed;
    private Rigidbody2D rb;
    private string ENEMY_TAG = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();   
    rb.velocity = transform.right * speed;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag(ENEMY_TAG)) {
            Destroy(gameObject);
        }
    }
}
