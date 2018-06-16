using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Scene Stuff
public class GUILevel : MonoBehaviour {
	public GameObject LerpObj;
	public GameObject LerpObj2;
	public GameObject LerpObj3;
    int recentLevelint;
	public int speed;
	public int dur;
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
        recentLevelint = PlayerPrefs.GetInt("RecentLevel");
	}


	void Update () {
		transform.Rotate (Vector3.back, speed * Time.deltaTime);
        
       

	}

	public void RecentLevelStarter() 
	{

		SceneManager.LoadScene(recentLevelint);
	}
	public void moveScreenToLevels() //Move camera to next canvas and back
	{
		iTween.MoveTo (Camera.main.gameObject,LerpObj.transform.position, dur);
     
		}
	public void moveScreenBackToStart()
	{
		iTween.MoveTo (Camera.main.gameObject,LerpObj2.transform.position, dur);
	}

	public void moveScreenDown()
	{

iTween.MoveTo(Camera.main.gameObject,LerpObj3.transform.position,dur);

	}
	public void moveScreenUp()
	{
iTween.MoveTo(Camera.main.gameObject,LerpObj.transform.position,dur);

	}
}
