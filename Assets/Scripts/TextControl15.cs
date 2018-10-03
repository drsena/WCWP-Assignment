using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TextControl15 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Text text1;
	public Text text2;
	public Text text3;
	public Text text4;
	public Text text5;
	public GameObject fadeScreen;
	public string fullText;
	public string fullText2;
	public string fullText3;
	public string fullText4;
	public string fullText5;
	private string displayText = "";

	void Start () {
		StartCoroutine (ShowText ());
	}

	IEnumerator ShowText() {
		yield return new WaitForSeconds (1f);
		for (int i = 0; i <= fullText.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText.Substring (0, i);
			text1.text = displayText;
		}
		displayText = "";
		text2.text = displayText;
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			text2.text = displayText;
		}
		displayText = "";
		text3.text = displayText;
		for (int i = 0; i <= fullText3.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText3.Substring (0, i);
			text3.text = displayText;
		}
		yield return new WaitForSeconds (0.3f);
		displayText = "";
		text4.text = displayText;
		for (int i = 0; i <= fullText4.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText4.Substring (0, i);
			text4.text = displayText;
		}
		displayText = "";
		text5.text = displayText;
		for (int i = 0; i <= fullText5.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText5.Substring (0, i);
			text5.text = displayText;
		}
		yield return new WaitForSeconds (2.5f);
		fadeScreen.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (16);
	}
}
