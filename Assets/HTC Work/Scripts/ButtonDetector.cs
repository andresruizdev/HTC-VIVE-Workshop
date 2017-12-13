using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetector : MonoBehaviour
{
	private ButtonManager buttonManager;
	private bool buttonReady = true;

	void Awake()
	{
		buttonManager = GetComponentInParent<ButtonManager> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (buttonManager.gameManager.buttonsAvailables)
		{
			if(buttonReady == true)
				StartCoroutine(TimerChoice());
		}
	}

	private IEnumerator TimerChoice()
	{
		buttonReady = false;
		buttonManager.CheckChoice (gameObject.name);
		yield return new WaitForSeconds(2);
		buttonReady = true;
	}
}