using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	public UIManager uiManager;
	public ButtonManager buttonManager;

	private string[] randomLetters;

	internal bool gameReady;
	internal bool playerReady;
	public bool buttonsAvailables = false;

	private void OnTriggerEnter(Collider other)
	{
		if(!playerReady)
		{
			Initialize();
			playerReady = true;
		}
	}

	public void Initialize()
	{
		gameReady = false;
		if (gameReady == false) 
		{
			buttonManager.NumbersRandom(ref randomLetters);
			uiManager.EventShowText (randomLetters);
			gameReady = true;
		}
	}
}