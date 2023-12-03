using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;
    private float movementX;
    private Rigidbody2D myBody;
    private SpriteRenderer  sr;
    private Animator anim;
    private bool isGrounded;
    private string GROUND_TAG = "Ground";
    private string WALK_ANIMATION = "Walk";
    private string ENEMY_TAG = "Enemy";



    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayermMoveKeyboard();
        AnimatePlayer();
    }
    
    // This function is called every fixed framerate Frame
    private void FixedUpdate(){
        PlayerJump();
    }

    void PlayermMoveKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0f,0f) * Time.deltaTime * moveForce;


        //Debug.Log("move X value is: " + movementX);
    }

    void AnimatePlayer(){
        if(movementX > 0){
            //We are going to the riht side
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = false;
        }else if (movementX < 0){
            //We are going to the left side
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = true;
        }else {
            anim.SetBool(WALK_ANIMATION,false);
        }
    }

    void PlayerJump(){
        if(Keyboard.current.upArrowKey.wasPressedThisFrame && isGrounded){
            isGrounded = false;
            // Adding force to a rigid body
            // ForceMode2D.Impulse: adding instance force
            myBody.AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
        }
    }
    // This method listens to a contact with an other object
    private void OnCollisionEnter2D(Collision2D collision){
        //An object with tag 'Ground' collides with an object
        if(collision.gameObject.CompareTag(GROUND_TAG)){
            isGrounded = true;
        }

        if(collision.gameObject.CompareTag(ENEMY_TAG)){
            if(LivesScript.livesScore > 0){
                LivesScript.livesScore -= 1;
            }else{
                Destroy(gameObject);
            }
                
        }
        LivesScript.UpdateLives();
    }

    private void OnTriggerEnter2D(Collider2D collision){

        if (collision.gameObject.CompareTag(ENEMY_TAG)) {
            Destroy(gameObject);
        }
    }
} 


