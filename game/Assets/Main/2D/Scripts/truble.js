#pragma strict

public var Door : GameObject;
public var obje : GameObject;
public var isKey : int = 0;
public var isDoor : int=0;

function OnCollisionEnter2D(obj : Collision2D)
{

var i=0;

if(obj.gameObject.name == "Main Base")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
	obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
if(obj.gameObject.name == "Left Base")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	if(obj.gameObject.name == "Top left")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
	   obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	   obj.collider.attachedRigidbody.isKinematic =true;
	}
	if(obj.gameObject.name == "Bottom Left")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
	  obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	if(obj.gameObject.name == "Top right")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
	  obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	  //obj.collider.attachedRigidbody.isKinematic =true;
	}
	if(obj.gameObject.name == "Top middle")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
	  obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	  //obj.collider.attachedRigidbody.isKinematic =true;
	  }

	if(obj.gameObject.name == "Bttom right")
	{
	  obj.rigidbody.constraints = RigidbodyConstraints2D.None;
	  obj.rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	 //obj.collider.attachedRigidbody.isKinematic =true;
	}

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


