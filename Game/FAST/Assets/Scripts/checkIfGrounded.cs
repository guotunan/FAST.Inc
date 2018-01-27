using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkIfGrounded : MonoBehaviour {

	PlayerMovement playerOneMove;
	PlayerMovement playerTwoMove;
	GameObject playerOne;
	GameObject playerTwo;

	// Use this for initialization
	void Start () {
		playerOne = GameObject.FindGameObjectWithTag ("PlayerOne");
		playerTwo = GameObject.FindGameObjectWithTag ("PlayerTwo");
		playerOneMove = playerOne.GetComponent<PlayerMovement>();
		playerTwoMove = playerTwo.GetComponent<PlayerMovement> ();
	}
	
	void OnCollisionEnter2D(Collision2D other){

		Debug.Log ("In Enter function");

		if (other.gameObject.tag == "PlayerOne") {
			Debug.Log ("In player one conditional");
			playerOneMove.isOnGround = true;
		} else if (other.gameObject.tag == "PlayerTwo") {
			playerTwoMove.isOnGround = true;
		}
	}
	/*
	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "PlayerOne") {
			playerOneMove.isOnGround = false;
		}
	}
	*/
}
