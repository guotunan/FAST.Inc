using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalControl : MonoBehaviour
{

	void OnTiggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "Player1" || coll.tag == "Player2") {
			SceneManager.LoadScene (0);
		}
	}
}
