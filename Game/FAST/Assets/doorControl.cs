using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{
	public int maxCodeNeeded = 3;
	int codeEntered = 0;
	bool startLifting = true;
	float liftTimer = 2f;

	public void codeEnterCorrectly ()
	{
		codeEntered++;
		if (codeEntered == maxCodeNeeded) {
			startLifting = true;
		}
	}

	void Update ()
	{
		if (startLifting) {
			liftTimer -= Time.fixedDeltaTime;
			if (liftTimer <= 0f) {
				startLifting = false;
				liftTimer = 1f;
			}
			transform.Translate (Vector2.up * Time.deltaTime);
		}
	}
}
