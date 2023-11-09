using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private string WALK_ANIMATION = "Walk";
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
    }

    void PlayermMoveKeyboard(){
        movementX = Input.GetAxis("Horizontal");

        Debug.Log("move X value is: " + movementX);
    }
} // Class
