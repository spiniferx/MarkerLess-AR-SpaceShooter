using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public float jump;
	private Rigidbody2D myRigidBody;
	public bool grounded;
	public LayerMask whatIsGround;
	//private Collider2D myCollider;
	private Animator myAnimator;

	public float speedMultiplier;
	public float speedIncreaseMilestone;
	private float speedMilestoneCount;

	public Transform groundCheck;
	public float groundCheckRadius;

	public float jumpTime;
	private float jumpTimeCounter;

	private bool stoppedJumping;

	public GameManager theGameManager;

	private float moveSpeedStore;
	private float speedMilestoneCountStore;
	private float speedIncreaseMilestoneStore;

	public AudioSource jumpSound;
	public AudioSource deathSound;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		//myCollider = GetComponent<Collider2D> ();
		myAnimator = GetComponent<Animator> ();

		jumpTimeCounter = jumpTime;

		speedMilestoneCount = speedIncreaseMilestone;

		moveSpeedStore = moveSpeed;
		speedMilestoneCountStore = speedMilestoneCount; 
		speedIncreaseMilestoneStore = speedIncreaseMilestone;

		stoppedJumping = true;


	}
	
	// Update is called once per frame
	void Update () {
		//grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);


		if (transform.position.x > speedMilestoneCount) {
		
			speedMilestoneCount += speedIncreaseMilestone;

			speedIncreaseMilestone = speedIncreaseMilestone+ speedMultiplier;
			moveSpeed = moveSpeed * speedMultiplier;
		
		}

		myRigidBody.velocity = new Vector2 (moveSpeed, myRigidBody.velocity.y);

		if (Input.GetKey (KeyCode.Space) || Input.touchCount==1) {
			if (grounded) {
				  myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jump);
				stoppedJumping = false;
				jumpSound.Play ();
			}
		}

		if ((Input.GetKey (KeyCode.Space) || Input.touchCount==1) && !stoppedJumping) {
		
			if (jumpTimeCounter > 0) {
			
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jump);
				jumpTimeCounter -= Time.deltaTime;
				jumpSound.Play ();
			}
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
		
			jumpTimeCounter = 0;
			stoppedJumping = true;
				
		
		}
	/*	if (TouchPhase.Ended) {

			jumpTimeCounter = 0;

		}*/

		if (grounded) {
		 
			jumpTimeCounter = jumpTime;
		
		}




		myAnimator.SetFloat ("Speed", myRigidBody.velocity.x);
		myAnimator.SetBool ("Gounded", grounded);

	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "killBox") {

			theGameManager.RestartGame ();
			moveSpeed = moveSpeedStore;
			speedMilestoneCount = speedMilestoneCountStore;
			speedIncreaseMilestone = speedIncreaseMilestoneStore;
			deathSound.Play ();
		}
	}


}
