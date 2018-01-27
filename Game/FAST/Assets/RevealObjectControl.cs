using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealObjectControl : MonoBehaviour
{
	public GameObject RevealingObject;

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "Player1" || coll.tag == "Player2") {
			RevealingObject.SetActive (true);
		}
	}

}
