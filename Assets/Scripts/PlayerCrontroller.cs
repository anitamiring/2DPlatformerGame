using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrontroller : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidbody;
	public float jumpSpeed;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool isGrouded;

	//private Animator myAnim;

	// Use this for initialization
	void Start () {

		myRigidbody = GetComponent<Rigidbody2D> ();
		//myAnim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		isGrouded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (Input.GetAxisRaw ("Horizontal") > 0f) {
			myRigidbody.velocity = new Vector3 (moveSpeed, myRigidbody.velocity.y, 0f);
			transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (Input.GetAxisRaw ("Horizontal") < 0f) {

			myRigidbody.velocity = new Vector3 (-moveSpeed, myRigidbody.velocity.y, 0f);
			transform.localScale = new Vector3 (-1f, 1f, 1f);

		} else
			myRigidbody.velocity = new Vector3 (0f, myRigidbody.velocity.y, 0f);

		if (Input.GetButtonDown ("Jump") ) {
			myRigidbody.velocity = new Vector3 (myRigidbody.velocity.x, jumpSpeed, 0f);
		}

	//	myAnim.SetFloat ("speed", Mathf.Abs (myRigidbody.velocity.x));
	//	myAnim.SetBool ("grounded", isGrouded); 

	}
}
