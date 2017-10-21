using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

public class keycontrol : MonoBehaviour {

	public float speed;
	public float jump;
	float moveVelocity;
	bool grounded = false;
	float touchjump=0;
	float touchinput=0;
	// Update is called once per frame
	void Update () {
		if (touchjump == 1) {
			if (grounded)
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
		}

		if (touchinput == 1) {
			Debug.Log (speed + " " + moveVelocity);
			moveVelocity = speed;
			Debug.Log (speed + " " + moveVelocity);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
		} else
			moveVelocity = 0;
		if (touchinput == -1) {
			moveVelocity = -speed;
		} else {
			moveVelocity = 0;
		}
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
	}

	 public void OnTriggerEnter2D()
	{
		grounded = true;
	}

	public void OnTriggerExit2D()
	{
		grounded = false;
	}

	public void startjump(float input)
	{
		touchjump = input;
	}

	public void startmoving(float input)
	{
		touchinput = input;
	}

	public void right()
	{
		Debug.Log ("yes");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (5, 0);
	}
}
