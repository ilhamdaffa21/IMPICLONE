using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piano : MonoBehaviour {

	[SerializeField]
	Text codeText;
	string codeTextValue = "";
	public AudioSource wrongSound;

	// Update is called once per frame
	void Update () {
		codeText.text = codeTextValue;

		if (codeTextValue == "ABCDEFGHI") {
			wrongSound.Play();
			Puzzle2.isSafeOpened = true;
		}

		if (codeTextValue.Length >= 9)
			codeTextValue = "";
		}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}
