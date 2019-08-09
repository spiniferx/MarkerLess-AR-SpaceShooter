using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileProducer : MonoBehaviour {

	public GameObject missile;
	public int counttime;
	int count;

	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count++;

		if (count == counttime) {
			Instantiate (missile,transform.position,Quaternion.identity);

		}


		
	}
}
