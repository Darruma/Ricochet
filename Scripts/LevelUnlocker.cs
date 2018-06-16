using UnityEngine;
using System.Collections;

public class LevelUnlocker : MonoBehaviour {

	public GameObject Locked2;
	public GameObject Unlocked2;
	public GameObject Locked3;
	public GameObject Unlocked3;
	public GameObject Locked4;
	public GameObject Unlocked4;
	public GameObject Locked5;
	public GameObject Unlocked5;
	public GameObject Locked6;
	public GameObject Unlocked6;
    public GameObject Locked7;
	public GameObject Unlocked7;
	public GameObject Locked8;
	public GameObject Unlocked8;
	public GameObject Locked9;
	public GameObject Unlocked9;
	public GameObject Locked10;
	public GameObject Unlocked10;
	public GameObject Locked11;
	public GameObject Unlocked11;
    public GameObject Locked12;
	public GameObject Unlocked12;

	public GameObject LerpToNextLevels;
    public GameObject LockedArrow;


	public int enabled;
	public int enabled2;
	public int enabled3;
	public int enabled4;
	public int enabled5;
	public int enabled6;
    public int enabled7;
	public int enabled8;
	public int enabled9;
	public int enabled10;
	public int enabled11;
	public int enabled12;
	bool isUnlocked2 = false;
	bool isUnlocked3 = false;
	bool isUnlocked4 = false;
	bool isUnlocked5 = false;
	bool isUnlocked6 = false;
    bool isUnlocked7 = false;
	bool isUnlocked8 = false;
	bool isUnlocked9 = false;
	bool isUnlocked10 = false;
	bool isUnlocked11 = false;
    bool isUnlocked12 = false;

	void Start () {              // Checks which levels have been unlocked
		enabled = PlayerPrefs.GetInt ("NumberEnabled");
		enabled2 = PlayerPrefs.GetInt("NumberEnabledLevel2");
		enabled3 = PlayerPrefs.GetInt ("NumberEnabledLevel3");
		enabled4  = PlayerPrefs.GetInt("NumberEnabledLevel4");
		enabled5  = PlayerPrefs.GetInt("NumberEnabledLevel5");
		enabled6  = PlayerPrefs.GetInt("NumberEnabledLevel5");
        enabled7 = PlayerPrefs.GetInt ("NumberEnabledLevel7");
		enabled8 = PlayerPrefs.GetInt("NumberEnabledLevel8");
		enabled9 = PlayerPrefs.GetInt ("NumberEnabledLevel9");
		enabled10  = PlayerPrefs.GetInt("NumberEnabledLevel10");
		enabled11 = PlayerPrefs.GetInt("NumberEnabledLevel11");
		enabled12  = PlayerPrefs.GetInt("NumberEnabledLevel12");

	}


	void Update () {


//Checks if the levels are locked or not and unlocks them if the level has been completed
		if (enabled2 == 1 && isUnlocked2 == false) {

			Locked2.SetActive(false);
			Unlocked2.SetActive(true);
			isUnlocked2 = true;
			print("Unlocked ");

		}
		if (enabled3 == 1 && isUnlocked3 == false) {

			Locked3.SetActive (false);
			Unlocked3.SetActive (true);
			isUnlocked3 = true;
		}
		if (enabled4 == 1 && isUnlocked4 == false) {

			Locked4.SetActive (false);
			Unlocked4.SetActive (true);
			isUnlocked4 = true;
		}
		if (enabled5 == 1 && isUnlocked5 == false) {

			Locked5.SetActive (false);
			Unlocked5.SetActive (true);
			isUnlocked5 = true;
		}
		if (enabled6 == 1 && isUnlocked6 == false) {

			Locked6.SetActive (false);
			Unlocked6.SetActive (true);
            LockedArrow.SetActive(false);
			LerpToNextLevels.SetActive(true);
			isUnlocked5 = true;
		}
        if (enabled7 == 1 && isUnlocked7 == false) {

			Locked7.SetActive (false);
			Unlocked7.SetActive (true);
			isUnlocked7 = true;
		}
        if (enabled8 == 1 && isUnlocked8 == false) {

			Locked8.SetActive (false);
			Unlocked8.SetActive (true);
			isUnlocked8 = true;
		}
        if (enabled9 == 1 && isUnlocked9 == false) {

			Locked9.SetActive (false);
			Unlocked9.SetActive (true);
			isUnlocked9 = true;
		}
        if (enabled10 == 1 && isUnlocked10 == false) {

			Locked10.SetActive (false);
			Unlocked10.SetActive (true);
			isUnlocked10 = true;
		}
          if (enabled11 == 1 && isUnlocked10 == false) {

			Locked11.SetActive (false);
			Unlocked11.SetActive (true);
			isUnlocked11 = true;
		}
        if (enabled12 == 1 && isUnlocked12 == false) {

			Locked12.SetActive (false);
			Unlocked12.SetActive (true);
			isUnlocked12 = true;
		}

	}

	public void Level1()               //Loads the first level, the second level etc..
	{
		Application.LoadLevel (1);
	}

	public void Level2()
	{
		Application.LoadLevel (2);
	}
	public void Level3()
	{
		Application.LoadLevel (3);
	}
	public void Level4()
	{
		Application.LoadLevel (4);
	}
	public void Level5()
	{
		Application.LoadLevel (5);
	}
	public void Level6()
	{
		Application.LoadLevel (6);
	}
    public void Level7()
    {

        Application.LoadLevel(7);
    }
    public void Level8()
    {

        Application.LoadLevel(8);
    }
    public void Level9()
    {

        Application.LoadLevel(9);
    }
    public void Level10()
    {

        Application.LoadLevel(10);
    }
    public void Level11()
    {

        Application.LoadLevel(11);	

    }
    public void Level12()
    {

        Application.LoadLevel(12);
    }
	public void MostRecent()
	{
		Application.LoadLevel (1);
	}

    public void resetPrefs()
    {
        //Debugging ONLY
        PlayerPrefs.DeleteAll();
				Debug.Log("Reseting PlayerPrefs...");
    }

}
