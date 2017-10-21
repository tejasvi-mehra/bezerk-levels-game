using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {

	public GameObject CharacterRobotBoy;
	private Vector3 offset;


	void Start () {
		offset = transform.position - CharacterRobotBoy.transform.position + new Vector3(-10f,0,0);

	}

	void LateUpdate () {

		transform.position = CharacterRobotBoy.transform.position + offset;
	}

}