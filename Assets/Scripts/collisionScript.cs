using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour {

	// Use this for initialization
	private PlayerDamageCounter pdc;
	void Awake()
	{
		//pdc = GetComponent<PlayerDamageCounter>();
	}

	void Start () {
		//pdc = GetComponent<PlayerDamageCounter> ();


	}

	// Update is called once per frame
	void Update () {

	}

	//for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
	void OnTriggerEnter (Collider col)
	{
		//pdc.GetComponent<PlayerDamageCounter> ().score++;
		PlayerDamageCounter.score++;

		//Debug.Log ("Score is" + pdc.score);
		GameObject explosion = Instantiate(Resources.Load("explosion_asteroid", typeof(GameObject))) as GameObject;
		explosion.transform.position = transform.position;
		Destroy(col.gameObject);
		Destroy (explosion, 2);


		if (GameObject.FindGameObjectsWithTag("Player").Length == 0){

			GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
			GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
			GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
			GameObject enemy3 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;

		}

		Destroy (gameObject);


	}

}
