using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamageCounter : MonoBehaviour {

	// Use this for initialization
	public static int DeathCount=10;
	public static int score=0;
	int scoreUpadter;

	public Text Shield;
	public Text Score;

	public Text finalScore;

	public Canvas gameOver;

	//public VAdScript vads;

	void Start () {
		gameOver.enabled = false;
		DeathCount = 50;
	}
	
	// Update is called once per frame
	void Update () {
		scoreUpadter = score;
		Shield.text = "" + DeathCount;
		Score.text = "" + scoreUpadter;


		if (DeathCount == 0) {
		//	vads.showInterstitialAd ();
			Handheld.Vibrate ();
			gameOver.enabled = true;
			finalScore.text = "" + score;

			Debug.Log ("Your Game Is Over");
		}	
	}
	public void Retry()
	{
		SceneManager.LoadScene ("GameScene");
	}

}
