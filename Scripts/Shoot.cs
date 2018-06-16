using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour {
	public Transform Muzzle;
	public GameObject shootprefab;
	public int speed;
	public Text Bullets;
	public static int bullets = 5;
	public int bulletAmount;
	public AudioClip shoot;
	public GameObject player;
	public Vector3 pos;
	public AudioClip slowSoundEffect;



	void Start()
	{
		Time.timeScale = 1f; //Change timespeed at beginning
		bullets = bulletAmount;
		Screen.orientation = ScreenOrientation.LandscapeLeft;

	}
	void Update()

	{

		Bullets.text = "" + bullets;
	}
	public void ShootBullet()
	{
		Debug.Log("ShootingIsCalled");
		if (bullets != 0 )

			{
			bullets--;
			iTween.ShakePosition (Camera.main.gameObject, new Vector3(0.05f,0.05f,0.05f), 1); // Shakes Camera

		GameObject proj = (Instantiate (shootprefab, Muzzle.transform.position,Quaternion.identity) as GameObject);
		Rigidbody rb = proj.GetComponent<Rigidbody> ();// Summons the bullet at the muzzle of the gun

		rb.AddForce (transform.forward * speed);//Ads speed to bullet


		AudioSource audio =	player.GetComponent<AudioSource>();//Bullet Sound effect


			audio.clip = shoot;
			audio.Play();
			if (bullets == 0)
			{
				Time.timeScale = 0.5f;

			//plays slow motion sound effect
				AudioSource Slo = proj.GetComponent<AudioSource>();
				Slo.clip = slowSoundEffect;
				Slo.Play();

			}

	}








}





}
