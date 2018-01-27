using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 20.0f;
	public float jumpForce = 8.0f;
	public bool isOnGround = true;
	public bool playerOne = true;

	float moveHorizontal = 0f;
	float moveVertical = 0f;

	float gravity = 9.81f;
	Rigidbody2D rb; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Movement ();
	}

	void Movement (){
		if (playerOne) {

			moveVertical = Jump (moveVertical);

			moveHorizontal = Input.GetAxisRaw ("HorizontalOne");

			Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

			rb.velocity = movement * speed;
		} else if (!playerOne) {

			moveVertical = Jump (moveVertical);

			moveHorizontal = Input.GetAxisRaw ("HorizontalTwo");

			Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

			rb.velocity = movement * speed;
		}
	}

	float Jump(float moveVertical) {

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
