using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed; //speed of character

    public float jumpForce; //force of the jump, height in a way

    public float jumpTime; //time in air


    private Rigidbody2D myRigidbody; //interact with the rigidbody


    public bool grounded; //make sure player is on the ground
    public LayerMask whatIsGround; //what layer do you want the ground to be...which will be labeled the ground
    public Transform groundCheck;
    public float groundCheckRadius;


    private Animator myAnimator; //attach animator to player

    public GameManager theGameManager; //call the game manager script

    public AudioSource jumpSound; //player jump sound
    public AudioSource deathSound; //death sound



	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>(); //search/get the rigidbody to use
        myAnimator = GetComponent<Animator>(); //find animator to attach to our player
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y); //velocity of player is moveSpeed(so moves forward), and leave y value alone

        if(Input.GetKeyDown(KeyCode.Space)) //any time spacebar is pressed down, player jumps
        {
            if (grounded) //only jump if on ground
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce); //not change x value to keep moving, y is jumpForce which will be force of the jump
                jumpSound.Play(); //when you jump, a sound is played
            }
        }


        myAnimator.SetFloat ("Speed", myRigidbody.velocity.x); //set float value on animator, which is the velocity.x, so animator keeps up with the speed of player
        myAnimator.SetBool("Grounded", grounded); //run when grounded


	}

    void OnCollisionEnter2D (Collision2D other) //collision with another object, that has the tag "killbox"
    {
        if(other.gameObject.tag == "killbox") //killbox is a tag that if you collide with it, you will die
        {
            theGameManager.RestartGame(); //restart the game
            deathSound.Play(); //when you die, a sound is played
        }
    }

}