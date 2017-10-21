using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

public class specialMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		InputSimulator.SimulateKeyPress (VirtualKeyCode.SPACE);		
	}
}
