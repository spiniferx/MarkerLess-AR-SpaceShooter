using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

	public string backToMain;
	public string candyLand;
	public string iceLand;
	public string Desert;

	public void BackToMain()
	{
		Application.LoadLevel (backToMain);
	}
	public void CandyLand()
	{
		Application.LoadLevel (candyLand);
	}
	public void IceLand ()
	{
		Application.LoadLevel (iceLand);
	}
	public void desert()
	{
		Application.LoadLevel (Desert);
	}

}
