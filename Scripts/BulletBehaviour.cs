using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
public AudioClip tripleKill;
public AudioClip doubleKill;
public int NumberofKills;
bool alreadyPlayed = false;
bool alreadyPlayed2 = false;
public GameObject SecondsEffect;
	void Start () {

		StartCoroutine("Death");
        }

    void Update()
    {
        if (NumberofKills == 2 && alreadyPlayed == false )
        {
          alreadyPlayed = true;
            StartCoroutine("DoubleKill");
        }
        if (NumberofKills == 3 && alreadyPlayed2 == false )
        {
          alreadyPlayed2 = true;
            StartCoroutine("TripleKill");
        }
    }

	IEnumerator DoubleKill()
    {
        print("2 Enemies Killed");
        yield return new WaitForSeconds(1);
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        audio.clip = doubleKill;
        audio.Play();
        //D-D-Double K-I-L-L-L
    }

    IEnumerator TripleKill()
      {
          print("3 Enemies Killed");
          yield return new WaitForSeconds(1);
          AudioSource audio = this.gameObject.GetComponent<AudioSource>();
          audio.clip = tripleKill;
          audio.Play();
          //T-T-Triple K-I-L-L-L
      }
	IEnumerator Death() // Destroy the ball after 7 seconds
	{

		yield return new WaitForSeconds (7);
		Destroy (this.gameObject);

	}

  IEnumerator Gain5Secs() // powerup m9
  {

    yield return new WaitForSeconds (5);
    Destroy (this.gameObject);


  }

    void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "Enemy" ){
            NumberofKills++;
				GameObject Giant5Secs = Instantiate(SecondsEffect,new Vector3(col.gameObject.transform.position.x,col.gameObject.transform.position.y + 2,col.gameObject.transform.position.z - 17),Quaternion.identity) as GameObject;
				Destroy(Giant5Secs,1);
            StopCoroutine("Death");
            StopCoroutine("Gain5Secs");
            StartCoroutine("Gain5Secs");
        }


    }





	}
