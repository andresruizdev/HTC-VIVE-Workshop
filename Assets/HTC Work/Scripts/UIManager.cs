using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public GameManager gameManager;

	public Text lettersText;
		
	public void EventShowText(string[] randomLetters)
	{
		StartCoroutine (ShowText (randomLetters));
	}

	private IEnumerator ShowText(string[] randomLetters)
	{
		gameManager.buttonsAvailables = false;
		yield return new WaitForSeconds (3);
		for (int i = 0; i < randomLetters.Length; i++) 
		{
			lettersText.text = randomLetters [i] + i;
			yield return new WaitForSeconds (1);
		}
		lettersText.text = " ";
		gameManager.buttonsAvailables = true;
	}

	private Color RandomColor(int numberColor)
	{
		switch (numberColor)
		{
			case 0:
				return Color.red;
			  break;
			case 1:
				return Color.blue;
			  break;
			case 2:
				return Color.yellow;
			  break;
			case 3:
				return Color.green;
			  break;
			default:
				return Color.gray;
			  break;
		}
	}
}