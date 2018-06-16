using UnityEngine;
using System.Collections;

public class CharacterSounds : MonoBehaviour {

	public AudioClip aah;
	public AudioClip aah2;
	void Start () {
	
	}
	

	void Update () {
	
	}
	public void DeathSound()
	{
		if (Time.timeScale == 0.5f)
		{	
			AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
			audio.clip = aah2;
			audio.Play ();

		}

	else
		{
				
			AudioSource audio = this.gameObject.GetComponent<AudioSource> ();
			audio.clip = aah;
			audio.Play ();
		}



	}
}
	