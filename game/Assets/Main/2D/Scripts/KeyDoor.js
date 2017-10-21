#pragma strict

public var Door : GameObject;
public var isKey : int = 0;
public var isDoor : int=0;

function OnCollisionEnter2D(obj : Collision2D)
{


if(obj.gameObject.name == "key")
	{

		Destroy(obj.gameObject);
		isKey=1;
		

	}
	if(obj.gameObject.name == "door")
	{
		if(isKey==1)
		{
			Destroy(obj.gameObject);
		
		}
	}
}


