using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealObjectControl : MonoBehaviour
{
	public GameObject RevealingObject;

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "PlayerOne" || coll.tag == "PlayerTwo") {
			RevealingObject.SetActive (true);
		}
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.tag == "PlayerOne" || coll.tag == "PlayerTwo") {
			RevealingObject.SetActive (false);
		}
	}

}
