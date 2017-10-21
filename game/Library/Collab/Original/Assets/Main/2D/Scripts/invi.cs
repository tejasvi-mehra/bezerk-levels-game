using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invi : MonoBehaviour {

	int cnt = 0;
	bool enabled = true;

	// Use this for initialization
	void Start () {
		
		//gameObject.GetComponent<SpriteRenderer> ().enabled = false;

		//StartCoroutine (boi());

		//gameObject.GetComponent<SpriteRenderer> ().enabled = true;
	}

	void Update () {

		/*gameObject.GetComponent<SpriteRenderer> ().enabled = false;

		if (cnt%500 <= 50 ) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}

		cnt= cnt + 1;
		*/
		int times = (int)(Time.time);
		Debug.Log (times);
		Invoke ("timer", 7f);

		
//		StartCoroutine (timer ());
	}

	void timer()
	{
		Debug.Log ("here");
		if (enabled == false) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			enabled = true;
			Debug.Log ("See");
		} else {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			enabled = false;
			Debug.Log ("NO");
		}
	}

	/*IEnumerator timer(){
		while (true) {

			yield return new WaitForSecondsRealtime (5);
			Debug.Log (Time.time);
			if (enabled == true) {
				enabled = false;
				Debug.Log ("See");

				gameObject.GetComponent<SpriteRenderer> ().enabled = false;

			} else {
				enabled = true;
				Debug.Log ("No");

				gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			}
		}
	}*/

}

