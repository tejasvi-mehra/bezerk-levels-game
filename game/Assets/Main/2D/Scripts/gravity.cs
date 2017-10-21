using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {


	private float touchinput = 0;
	// Use this for initialization

	// Update is called once per frame
	void Update () {

		#if UNITY_ANDROID
		if (touchinput==1)
		{
		this.GetComponent<Rigidbody2D>().gravityScale*= -1;
		}
		#else
		if(Input.GetKeyDown(KeyCode.Space) )
		{
			this.GetComponent<Rigidbody2D>().gravityScale*= -1;
		}
		#endif
	}

	public void changeGravity()
	{
		if (touchinput == 1)
			touchinput = 0;
		else
			touchinput = 1;
	}

}