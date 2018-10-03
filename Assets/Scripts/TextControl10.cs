﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextControl10 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Text text1;
	public Text text2;
	public Button next;
	public RawImage background2;
	public string fullText;
	public string fullText2;
	private string displayText = "";

	void Start () {
		StartCoroutine (ShowText ());
	}

	IEnumerator ShowText() {
		yield return new WaitForSeconds (2f);
		for (int i = 0; i <= fullText.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText.Substring (0, i);
			text1.text = displayText;
		}
		yield return new WaitForSeconds (3f);
		background2.gameObject.SetActive (true);
		yield return new WaitForSeconds (2f);
		displayText = "";
		text2.text = displayText;
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			text2.text = displayText;
		}
		yield return new WaitForSeconds (3f);
		next.gameObject.SetActive (true);
	}
}