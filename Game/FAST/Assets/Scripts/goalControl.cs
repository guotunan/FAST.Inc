using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalControl : MonoBehaviour
{
	void OnTiggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "PlayerOne" || coll.tag == "PlayerTwo") {
			Debug.Log ("YOU WIN");
		}
	}
}
