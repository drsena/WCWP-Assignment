using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TextControl12 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Text text1;
	public Text text2;
	public Text text3;
	public RawImage background2;
	public RawImage background3;
	public RawImage example;
	public GameObject fadeScreen;
	public string fullText;
	public string fullText2;
	public string fullText3;
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
		yield return new WaitForSeconds (2f);
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
		background3.gameObject.SetActive (true);
		yield return new WaitForSeconds (2f);
		displayText = "";
		text3.text = displayText;
		for (int i = 0; i <= fullText3.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText3.Substring (0, i);
			text3.text = displayText;
		}
		yield return new WaitForSeconds (2f);
		example.gameObject.SetActive (true);
		yield return new WaitForSeconds (5f);
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (13);
	}
}
