﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextControl04 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Button next;
	public string fullText;
	public string fullText2;
	public string fullText3;
	private string displayText = "";

	void Start () {
		StartCoroutine (ShowText ());
	}

	IEnumerator ShowText() {
		for (int i = 0; i <= fullText.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText.Substring (0, i);
			this.GetComponent<Text> ().text = displayText;
		}
		yield return new WaitForSeconds (4f);
		displayText = "";
		this.GetComponent<Text> ().text = displayText;
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			this.GetComponent<Text> ().text = displayText;
		}
		yield return new WaitForSeconds (4f);
		displayText = "";
		this.GetComponent<Text> ().text = displayText;
		for (int i = 0; i <= fullText3.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText3.Substring (0, i);
			this.GetComponent<Text> ().text = displayText;
		}
		yield return new WaitForSeconds (0.5f);
		next.gameObject.SetActive (true);
	}
}
