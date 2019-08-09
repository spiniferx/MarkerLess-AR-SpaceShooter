using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShip : MonoBehaviour {

	// Use this for initialization

	public int speed,count;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		count++;
		if (count == 240) {
			speed = -speed;
			count = 0;
		}
		transform.Translate (0,speed * Time.deltaTime,0);
	}
}
