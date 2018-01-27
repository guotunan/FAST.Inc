using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputerControl : MonoBehaviour
{
	public Text InputterText;
	public int CorrectNum = 3;
	public GameObject InputObjectFor;
	private bool canType = true;

	void Update ()
	{
		if (canType) {
			int answer;
			foreach (char c in Input.inputString) {
				answer = c & 15;
				// If player got correct Num, display it
				if (answer == CorrectNum) {
					Debug.Log (answer);
					InputterText.text = answer.ToString ();
					// Then tell the door the player got it
					InputObjectFor.GetComponent<doorControl> ().codeEnterCorrectly ();
					// Disable the canType so player cannot repeatly enter numbers
					canType = false;
				}
			}
		}
	}

	void OnTriggerStay2D (Collider2D coll)
	{
		if (coll.tag == "Player1" || coll.tag == "Player2") {
			InputterText.gameObject.SetActive (true);
			canType = true;
		}
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.tag == "Player1" || coll.tag == "Player2") {
			InputterText.gameObject.SetActive (false);
			canType = false;
		}
	}
}
