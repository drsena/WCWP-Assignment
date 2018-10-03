using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TextControl18 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Text text1;
	public Text text2;
	public RawImage friends;
	public RawImage gabriel;
	public RawImage background1;
	public RawImage background2;
	public GameObject fadeScreen;
	public string fullText;
	public string fullText2;
	private string displayText = "";

	void Start () {
		StartCoroutine (ShowText ());
	}

	IEnumerator ShowText() {
		yield return new WaitForSeconds (2f);
		friends.gameObject.SetActive (true);
		for (int i = 0; i <= fullText.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText.Substring (0, i);
			text1.text = displayText;
		}
		yield return new WaitForSeconds (4f);
		friends.gameObject.SetActive (false);
		text1.text = "";
		background1.gameObject.SetActive (false);
		background2.gameObject.SetActive (true);
		text2.text = "";
		yield return new WaitForSeconds (2f);
		gabriel.gameObject.SetActive (true);
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			text2.text = displayText;
		}
		yield return new WaitForSeconds (4f);
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (19);
	}
}