using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowText01 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public Button next;
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
			this.GetComponent<Text> ().text = displayText;
		}
		yield return new WaitForSeconds (3f);
		displayText = "";
		this.GetComponent<Text> ().text = displayText;
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			this.GetComponent<Text> ().text = displayText;
		}
		yield return new WaitForSeconds (0.5f);
		next.gameObject.SetActive (true);
	}
}
