using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockDestroy : MonoBehaviour {

	public GameObject block0;
	public GameObject block1,block2,block3,block4,block5;

	public void blockRemove0()
	{
		Canvas.Destroy (block0);
	}

	public void blockRemove1()
	{
		Canvas.Destroy (block1);
	}

	public void blockRemove2()
	{
		Canvas.Destroy (block2);
	}

	public void blockRemove3()
	{
		Canvas.Destroy (block3);
	}

	public void blockRemove4()
	{
		Canvas.Destroy (block4);
	}

	public void blockRemove5()
	{
		Canvas.Destroy (block5);
	}

}
