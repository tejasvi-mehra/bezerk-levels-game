using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseplay: MonoBehaviour {

	GameObject[] pauseObjects;
	bool pauseyes=false;
	public GameObject Door ;
	public GameObject CDoor ;

	public void destoryDoor1()
	{
		Destroy (Door);
		Canvas.Destroy (CDoor);
	}

	public void destroyDoor()
	{
		Destroy (Door);
		//		Canvas.Destroy (CDoor);
	}

	public void setPause()
	{
		if (pauseyes == false)
			pauseyes = true;
		else
			pauseyes = false;

	}

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

	// Update is called once per frame
	void Update () {

		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.P))
		{
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				Debug.Log ("high");
				Time.timeScale = 1;
				hidePaused();
			}
		}

		/*if (Input.GetMouseButtonDown (0)) {
			if ((Input.mousePosition.x >= 275.0 && Input.mousePosition.x <= 306.0) && (Input.mousePosition.y >= 144.0 && Input.mousePosition.y <= 180.0) && Time.timeScale == 0) {
				Time.timeScale = 1;
				hidePaused ();
			} else if ((Input.mousePosition.x >= 7.0 && Input.mousePosition.x <= 47.0) && (Input.mousePosition.y >= 277.0 && Input.mousePosition.y <= 311.0) && Time.timeScale == 1) {
				Time.timeScale = 0;
				showPaused ();
			} else if ((Input.mousePosition.x >= 329.0 && Input.mousePosition.x <= 370.0) && (Input.mousePosition.y >= 144.0 && Input.mousePosition.y <= 180.0) && Time.timeScale == 0) {
				Time.timeScale = 1;
				hidePaused ();
				SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
			}

			else if ((Input.mousePosition.x >= 203.0 && Input.mousePosition.x <= 246.0) && (Input.mousePosition.y >= 144.0 && Input.mousePosition.y <= 180.0) && Time.timeScale == 0) {
				SceneManager.LoadScene (0);
			}

			Debug.Log(Input.mousePosition);
		}*/
		if (pauseyes) {
			pauseControl1 ();
		} 
		else
			pauseControl2();

	}


	//Reloads the Level
	/*	public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}
*/
	//controls the pausing of the scene
	public void pauseControl1(){

		Time.timeScale = 1;
		showPaused();
	} 
	public void pauseControl2(){
		Time.timeScale = 0;
		hidePaused();
	}

	public void reloadgame()
	{
		Time.timeScale = 1;
		hidePaused ();
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
	}

	public void mainMenu()
	{
		SceneManager.LoadScene (0);
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}



	//loads inputted level
	/*	public void LoadLevel(string level){
		Application.LoadLevel(level);
}*/
}
