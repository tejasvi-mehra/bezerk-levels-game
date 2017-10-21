#pragma strict 
//using UnityEngine.SceneManagement ;

public var Level : int;

function OnCollisionEnter2D(myCollision: Collision2D)
{


if(myCollision.gameObject.name == "CharacterRobotBoy")
	{
	Application.LoadLevel(Level);
	}

}