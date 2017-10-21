﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class drag : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;


	void OnMouseDown()
	{
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10.0f));
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;
			
	}


}
