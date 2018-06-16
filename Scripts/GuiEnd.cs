using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GuiEnd : MonoBehaviour {
    int RecentLevelnum;
	public Button Menu;
	public Button NextLevel;
	public int level;
	void Start () {
        RecentLevelnum = level - 1;
        PlayerPrefs.SetInt("RecentLevel",RecentLevelnum);

	}


	void Update () {

	}
	public void MenuLoad()
	{
		Application.LoadLevel (0);
	}
	public void NextLevelLoad()
	{

		Application.LoadLevel(level);
	}


}
