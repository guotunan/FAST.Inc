using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public float speed = 20.0f;
	public float jumpForce = 8.0f;
	public bool isOnGround = true;
	public bool playerOne = true;
	public Transform groundCheck;
	public LayerMask whatIsGround;

	float moveHorizontal = 0f;
	float moveVertical = 0f;

	float gravity = 9.81f;
	Rigidbody2D rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		Movement ();
	}

	void Movement ()
	{

		moveVertical = Jump (moveVertical);

		moveHorizontal = playerOne ? Input.GetAxisRaw ("HorizontalOne") : Input.GetAxisRaw ("HorizontalTwo");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//check if player is standing on ground
		isOnGround = Physics2D.Linecast (transform.position, groundCheck.position, whatIsGround) ||
		Physics2D.Linecast (transform.position + new Vector3 (0.5f, 0, 0), groundCheck.position + new Vector3 (0.5f, 0, 0), whatIsGround) ||
		Physics2D.Linecast (transform.position - new Vector3 (0.5f, 0, 0), groundCheck.position - new Vector3 (0.5f, 0, 0), whatIsGround);

		rb.velocity = movement * speed;

	}

	float Jump (float moveVertical)
	{

		if (isOnGround) {
			moveVertical = -gravity * Time.deltaTime;

			if (Input.GetKeyDown (KeyCode.LeftShift) && playerOne) {
				moveVertical = jumpForce;
				isOnGround = false;
			} else if (Input.GetKeyDown (KeyCode.Space) && !playerOne) {
				moveVertical = jumpForce;
				isOnGround = false;
			}
		} else {
			moveVertical -= gravity * Time.deltaTime;
		}

		return moveVertical;
	}
}
