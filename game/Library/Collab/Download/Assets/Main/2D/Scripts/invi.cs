using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invi : MonoBehaviour {

	int cnt = 0;

	// Use this for initialization
	void Start () {
		
		//gameObject.GetComponent<SpriteRenderer> ().enabled = false;

		//StartCoroutine (boi());

		//gameObject.GetComponent<SpriteRenderer> ().enabled = true;
	}

	void Update () {

		gameObject.GetComponent<SpriteRenderer> ().enabled = false;

		if (cnt%100 <= 50 ) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}

		cnt= cnt + 1;
	}

}

