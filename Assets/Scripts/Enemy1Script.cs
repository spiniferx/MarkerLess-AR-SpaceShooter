using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Script : MonoBehaviour {

	// Use this for initialization
	public float speed;

	int count;
	void Start () {

		//Move ();
	}
	
	void Update () {

		count++;
		if (count == 300) {
			speed = -speed;

			Vector3 lTemp = transform.localScale;
			lTemp.x *= -1;
			transform.localScale = lTemp;

			count = 0;
		}
		transform.Translate(Vector3.right * -speed * Time.deltaTime); 
	}

	/*IEnumerator Move() {


		while (true) {
			yield return new WaitForSeconds (3f);
			Vector3 lTemp = transform.localScale;
			lTemp.x *= -1;
			transform.localScale = lTemp;
			speed = -speed;
			//transform.localScale *= new Vector3(-1F, 0, 0);
			//transform.eulerAngles += new Vector3 (0, 180f, 180f);

		}
	}*/
}
