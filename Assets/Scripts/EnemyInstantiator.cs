using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiator : MonoBehaviour {

	public GameObject[] ships;
	int count,i;
	public int waitTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		count++;

		i = Random.Range (0,ships.Length);

		if (count == waitTime) {
			count = 0;
			Instantiate (ships [i], transform.position, transform.rotation);
		}
	}
}
