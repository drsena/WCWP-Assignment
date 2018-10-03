using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextControl22 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Text text1;
	public Text text2;
	public Button continueButton;
	public string fullText;
	public string fullText2;
	private string displayText = "";

	void Start () {
		StartCoroutine (ShowText ());
	}

	IEnumerator ShowText() {
		for (int i = 0; i <= fullText.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText.Substring (0, i);
			text1.text = displayText;
		}
		yield return new WaitForSeconds (0.5f);
		text2.text = "";
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			text2.text = displayText;
		}
		yield return new WaitForSeconds (1f);
		continueButton.gameObject.SetActive (true);
	}
}
