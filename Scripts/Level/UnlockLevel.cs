using UnityEngine;
using System.Collections;

public class UnlockLevel : MonoBehaviour {
	public Canvas myCanvas;
	public GameObject WinCanvas;
	public static int deathCounter = 3;
	public int deathCounterStart;

	bool urmum = false;


	//Level Booleans
	public bool Level1 = false;
	public bool Level2 = false;
	public bool Level3 = false;
	public bool Level4 = false;
	public bool Level5 = false;
	public bool Level6 = false;
	public bool Level7 = false;
    public bool Level8 = false;
    public bool Level9 = false;
    public bool Level10 = false;
    public bool Level11 = false;
    public bool Level12 = false;

	void Start () {
		deathCounter = deathCounterStart;
	}


	void Update () {

		if (deathCounter == 0 & urmum == false) {

			StartCoroutine("unlockNextLevel");
		}
	}



	IEnumerator unlockNextLevel()
	{

		urmum = true;
		yield return new WaitForSeconds (2);
		myCanvas.enabled = false;

		WinCanvas.SetActive (true);

		
		if (Level2 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel2", 1);
		}
		if (Level3 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel3", 1);
		}
		if (Level4 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel4", 1);
		}
		if (Level5 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel5", 1);
		}
		if (Level6 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel6", 1);
		}
		if (Level7 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel7", 1);
		}
        if (Level8 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel8", 1);
		}
        if (Level9 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel9", 1);
		}
        if (Level10 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel10", 1);
		}
        if (Level11 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel11", 1);
		}
		 if (Level12 == true)
		{
			PlayerPrefs.SetInt ("NumberEnabledLevel12", 1);
		}



		yield break;

	}
}
