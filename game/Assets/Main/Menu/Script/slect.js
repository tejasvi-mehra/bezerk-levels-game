 #pragma strict
 public var Level : int;
 
 function LoadLevel()
 {
 Application.LoadLevel (Level);
 }

 function OnTriggerEnter(hit : Collider) 
 {
  Application.LoadLevel (Level);
 }