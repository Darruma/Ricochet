using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	public GameObject failedGameCanvas;
	public GameObject gameCanvas;



	void Start ()
	{


	}


	void Update () {
		if (Shoot.bullets == 0  && GameObject.FindGameObjectsWithTag("Enemy").Length > 0 && GameObject.FindGameObjectsWithTag("Bullet").Length ==  0) {
            
            //Checks if enemies and bullets are gone from the scene
			
			gameCanvas.SetActive(false);
		failedGameCanvas.SetActive(true);


		}

	}

	public void RestartLevel() //Loads the same level again
	{

		Application.LoadLevel (Application.loadedLevel);

	}

	}
