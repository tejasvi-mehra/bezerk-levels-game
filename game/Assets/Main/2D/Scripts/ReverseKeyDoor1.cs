using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReverseKeyDoor1 : MonoBehaviour {

	public GameObject door;
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "key") {
			Destroy (coll.gameObject);
			door.SetActive (true);
		}
	}
}
