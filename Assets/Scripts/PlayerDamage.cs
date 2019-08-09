using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {

	// Use this for initialization

	public PlayerDamageCounter pdc;

	void Start () {

	//pdc = GameObject.Find ("Collider").GetComponent<PlayerDamageCounter> ();
		
	}
	public int deathCounter;
	public Transform target;
	public float speed;
	void Update() {
		Vector3 posi = new Vector3 (0,0,0);
	//	Debug.Log ("updata wala");

		transform.Rotate (5,5,5);

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position,posi, step);
	}
	void OnTriggerEnter(Collider other)
	{
		//Debug.Log ("If ke upar");
		if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
		//	Debug.Log ("If ke niche");
			PlayerDamageCounter.DeathCount--;
			//pdc.DeathCount--;

			/*deathCounter++;
			if (deathCounter == 3) {
				Debug.Log ("Player ka Game ho gaya");
			}*/
		}
	}

}
