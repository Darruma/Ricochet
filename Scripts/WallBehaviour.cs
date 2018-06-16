using UnityEngine;
using System.Collections;

public class WallBehaviour : MonoBehaviour {

    public GameObject ParticleSplash;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag == "Bullet") {

			ContactPoint contact = col.contacts[0];
           Instantiate(ParticleSplash,contact.point,transform.rotation);
		}
	}

}
