using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public string levelSelector;
	public string helpPage;
	public string creditPage;

	public void PlayGame()
	{
		Application.LoadLevel (levelSelector);

	}
	public void QuitGame()
	{
		Application.Quit ();

	}
	public void HelpPage()
	{
		Application.LoadLevel (helpPage);
	}
	public void CreditPage()
	{
		Application.LoadLevel (creditPage);

	}
}
