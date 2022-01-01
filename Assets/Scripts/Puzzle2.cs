using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {


	[SerializeField]
	GameObject piano, closedSafe, openedSafe;

	public static bool isSafeOpened = false;

	// Use this for initialization
	void Start () {
		piano.SetActive (false);
		closedSafe.SetActive (true);
		openedSafe.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (isSafeOpened) {
			piano.SetActive (false);
			closedSafe.SetActive (false);
			openedSafe.SetActive (true);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Safe") && !isSafeOpened) {
			piano.SetActive (true);
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Safe")) {
			piano.SetActive (false);
		}
	}
}
