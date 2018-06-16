using UnityEngine;
using System.Collections;

public class TriggerExplosion : MonoBehaviour {

	public GameObject Explosion;

	public GameObject debris;
	void Start () {
	
	}
	

	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Bullet") {
			Instantiate(Explosion, this.transform.position, Explosion.transform.rotation);
			GameObject deb = (Instantiate(debris, this.transform.position, debris.transform.rotation) as GameObject);
			Debug.Log("Shot");
			Destroy(deb, 5);
			Destroy(this.gameObject);

		}
	}
}
