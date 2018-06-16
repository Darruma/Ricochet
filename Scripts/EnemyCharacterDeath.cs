using UnityEngine;
using System.Collections;

public class EnemyCharacterDeath : MonoBehaviour {
    
    Rigidbody rb;

	void Start () {
		StartCoroutine("pushDebris");

	}


	void Update () {

	}


	IEnumerator pushDebris()
	{
       rb = GetComponent<Rigidbody>();
       rb.AddExplosionForce(100, this.gameObject.transform.position,20,30);
		
		
        yield break;
	}







}
