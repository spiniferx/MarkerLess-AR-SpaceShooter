using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour {

	// Use this for initialization
	int count=0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count++;

		if (count == 180) {
			SceneManager.LoadScene ("Main");
		}
	}
}
