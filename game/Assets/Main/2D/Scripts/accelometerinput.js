#pragma strict

function Update () 
{
    transform.Translate(0.5*Input.acceleration.x,0.5* Input.acceleration.y , 0);
}