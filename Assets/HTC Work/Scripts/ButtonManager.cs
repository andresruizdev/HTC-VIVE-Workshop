using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonManager : MonoBehaviour {
	public GameManager gameManager;

	private string[] arrayLetters;
	private string[] arrayRandom;

	private int currentArrayNumber;
	private int setNumbersCount = 4;
	private bool CurrentPatternCorrect {get; set;}

	void Awake()
	{
		arrayLetters = new string[4] { "A", "B", "C", "D" };
	}

	public void NumbersRandom(ref string[] stringUIManager)
	{
		SetNumberRandom();
		for (int i = 0; i < arrayRandom.Length; i++) 
		{
			int randomSelection = Random.Range (0, arrayLetters.Length);
			arrayRandom [i] = arrayLetters [randomSelection];
		}
		stringUIManager = arrayRandom;
	} 

	public void CheckChoice(string buttonName)
	{
		if (buttonName == arrayRandom [currentArrayNumber]) 
		{
			if(currentArrayNumber == arrayRandom.Length-1)
			{
				StartCoroutine(NextPattern());
				currentArrayNumber = 0;
				return;
			}
			print ("Correcto");
			currentArrayNumber++;
		} else 
		{
			print ("Incorrecto");
			currentArrayNumber = 0;
		}
	}

	private void SetNumberRandom()
	{
		arrayRandom = new string[setNumbersCount];
		setNumbersCount++;
	}

	private IEnumerator NextPattern()
	{
		if(setNumbersCount < 8)
			gameManager.Initialize();
		else
			print("Ganaste Prro");
			//TODO: Ejecutar animacion apertura de puerta en else
		yield return new WaitForSeconds(2f);
	}
}