using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piano : MonoBehaviour {

	[SerializeField]
	Text codeText;
	string[] codeTextValue = { "6", "4", "6", "4#", "6", "5", "2#", "5", "2#", "5", "4#", "4", "3", "2#", "2", "2#", "3", "5#", "5", "2#", "3" };
	int mark = -1;
	public AudioSource wrongSound;


	// Update is called once per frame
	private void Start()
	{
	}
	void Update() {
		//codeText.text = codeTextValue;

		//if (codeTextValue == "ABCDEFGHI") {
		//	wrongSound.Play();
		//	Puzzle2.isSafeOpened = true;
		//}

		//if (codeTextValue.Length >= 9)
		//	codeTextValue = "";
		//
		}

	public void AddDigit(string digit)
	{
		if (digit != "")
		{
			print("input");
			mark += 1;
			print(codeTextValue[mark]);
			//print(mark);
			//print("ini digit " + digit);
			if (digit == codeTextValue[mark])
			{
				print("benar");
			}
			else
			{
				print("salah");
				mark = -1;
			}
		}
	}
}


