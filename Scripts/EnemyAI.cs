using UnityEngine;
using System.Collections;


public class EnemyAI : MonoBehaviour {
	public CharacterSounds soundDeath;
	public GameObject deathPrefab;


	void Start () {


	}
	

	void Update () {


	}
	void OnTriggerEnter(Collider col) // check if bullet has collided with enemy
	{

		if (col.gameObject.tag == "Bullet")
		{
			soundDeath.DeathSound();
			StartCoroutine("Death");
		}
		if (col.gameObject.tag == "Barrel")
		{
			soundDeath.DeathSound();
			StartCoroutine("Death");
		}
	}
	IEnumerator Death() 
    //When enemy is killed, summon debris and shake camera
	{
		this.GetComponent<MeshCollider> ().enabled = false;
		UnlockLevel.deathCounter--;
		iTween.ShakePosition (Camera.main.gameObject, new Vector3(0.05f,0.05f,0.05f), 1);
		GameObject debris = (Instantiate(deathPrefab, this.gameObject.transform.position, deathPrefab.transform.rotation)as GameObject);
       
		Destroy(this.gameObject);



		yield break;



	
	}
}
