using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextControl14 : MonoBehaviour {

	[SerializeField]
	private float delay = 0.03f;

	public static int stage;
	public RawImage lia;
	public RawImage snow;
	public Text liaText;
	public Text snowText;
	public Button liaControl;
	public Button snowControl;
	public Text liaMainText;
	public Text snowMainText;
	public string fullText1;
	public string fullText2;
	public string fullText3;
	public string fullText4;
	public string fullText5;
	public string fullText6;
	public string fullText7;
	public string fullText8;
	public string fullText9;
	public string fullText10;
	public string fullText11;
	public string fullText12;
	public Button continueButton;
	private string displayText = "";
	private bool show1, show2, show3, show4;
	private bool show5, show6, show7, show8;
	private bool show9, show10, show11, show12;

	void Start () {
		stage = 1;
		show1 = show2 = show3 = show4 = true;
		show5 = show6 = show7 = show8 = true;
		show9 = show10 = show11 = show12 = true;
	}

	void Update() {
		if (stage == 1 && show1) {
			StartCoroutine (ShowText1 ());
		} else if (stage == 2 && show2) {
			StartCoroutine (ShowText2 ());
		} else if (stage == 3 && show3) {
			StartCoroutine (ShowText3 ());
		} else if (stage == 4 && show4) {
			StartCoroutine (ShowText4 ());
		} else if (stage == 5 && show5) {
			StartCoroutine (ShowText5 ());
		} else if (stage == 6 && show6) {
			StartCoroutine (ShowText6 ());
		} else if (stage == 7 && show7) {
			StartCoroutine (ShowText7 ());
		} else if (stage == 8 && show8) {
			StartCoroutine (ShowText8 ());
		} else if (stage == 9 && show9) {
			StartCoroutine (ShowText9 ());
		} else if (stage == 10 && show10) {
			StartCoroutine (ShowText10 ());
		} else if (stage == 11 && show11) {
			StartCoroutine (ShowText11 ());
		} else if (stage == 12 && show12) {
			StartCoroutine (ShowText12 ());
		}
	}

	IEnumerator ShowText1() {
		show1 = false;
		lia.gameObject.SetActive (true);
		snow.gameObject.SetActive (false);
		liaText.gameObject.SetActive (true);
		snowText.gameObject.SetActive (false);
		liaControl.gameObject.SetActive (true);
		snowControl.gameObject.SetActive (false);
		liaControl.interactable = false;
		displayText = "";
		liaMainText.text = displayText;
		for (int i = 0; i <= fullText1.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText1.Substring (0, i);
			liaMainText.text = displayText;
		}
		liaControl.interactable = true;
	}

	IEnumerator ShowText2() {
		show2 = false;
		lia.gameObject.SetActive (false);
		snow.gameObject.SetActive (true);
		liaText.gameObject.SetActive (false);
		snowText.gameObject.SetActive (true);
		liaControl.gameObject.SetActive (false);
		snowControl.gameObject.SetActive (true);
		snowControl.interactable = false;
		displayText = "";
		snowMainText.text = displayText;
		for (int i = 0; i <= fullText2.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText2.Substring (0, i);
			snowMainText.text = displayText;
		}
		snowControl.interactable = true;
	}

	IEnumerator ShowText3() {
		show3 = false;
		lia.gameObject.SetActive (true);
		snow.gameObject.SetActive (false);
		liaText.gameObject.SetActive (true);
		snowText.gameObject.SetActive (false);
		liaControl.gameObject.SetActive (true);
		snowControl.gameObject.SetActive (false);
		liaControl.interactable = false;
		displayText = "";
		liaMainText.text = displayText;
		for (int i = 0; i <= fullText3.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText3.Substring (0, i);
			liaMainText.text = displayText;
		}
		liaControl.interactable = true;
	}

	IEnumerator ShowText4() {
		show4 = false;
		lia.gameObject.SetActive (false);
		snow.gameObject.SetActive (true);
		liaText.gameObject.SetActive (false);
		snowText.gameObject.SetActive (true);
		liaControl.gameObject.SetActive (false);
		snowControl.gameObject.SetActive (true);
		snowControl.interactable = false;
		displayText = "";
		snowMainText.text = displayText;
		for (int i = 0; i <= fullText4.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText4.Substring (0, i);
			snowMainText.text = displayText;
		}
		snowControl.interactable = true;
	}

	IEnumerator ShowText5() {
		show5 = false;
		lia.gameObject.SetActive (true);
		snow.gameObject.SetActive (false);
		liaText.gameObject.SetActive (true);
		snowText.gameObject.SetActive (false);
		liaControl.gameObject.SetActive (true);
		snowControl.gameObject.SetActive (false);
		liaControl.interactable = false;
		displayText = "";
		liaMainText.text = displayText;
		for (int i = 0; i <= fullText5.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText5.Substring (0, i);
			liaMainText.text = displayText;
		}
		liaControl.interactable = true;
	}

	IEnumerator ShowText6() {
		show6 = false;
		lia.gameObject.SetActive (false);
		snow.gameObject.SetActive (true);
		liaText.gameObject.SetActive (false);
		snowText.gameObject.SetActive (true);
		liaControl.gameObject.SetActive (false);
		snowControl.gameObject.SetActive (true);
		snowControl.interactable = false;
		displayText = "";
		snowMainText.text = displayText;
		for (int i = 0; i <= fullText6.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText6.Substring (0, i);
			snowMainText.text = displayText;
		}
		snowControl.interactable = true;
	}

	IEnumerator ShowText7() {
		show7 = false;
		lia.gameObject.SetActive (true);
		snow.gameObject.SetActive (false);
		liaText.gameObject.SetActive (true);
		snowText.gameObject.SetActive (false);
		liaControl.gameObject.SetActive (true);
		snowControl.gameObject.SetActive (false);
		liaControl.interactable = false;
		displayText = "";
		liaMainText.text = displayText;
		for (int i = 0; i <= fullText7.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText7.Substring (0, i);
			liaMainText.text = displayText;
		}
		liaControl.interactable = true;
	}

	IEnumerator ShowText8() {
		show8 = false;
		lia.gameObject.SetActive (false);
		snow.gameObject.SetActive (true);
		liaText.gameObject.SetActive (false);
		snowText.gameObject.SetActive (true);
		liaControl.gameObject.SetActive (false);
		snowControl.gameObject.SetActive (true);
		snowControl.interactable = false;
		displayText = "";
		snowMainText.text = displayText;
		for (int i = 0; i <= fullText8.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText8.Substring (0, i);
			snowMainText.text = displayText;
		}
		snowControl.interactable = true;
	}

	IEnumerator ShowText9() {
		show9 = false;
		lia.gameObject.SetActive (true);
		snow.gameObject.SetActive (false);
		liaText.gameObject.SetActive (true);
		snowText.gameObject.SetActive (false);
		liaControl.gameObject.SetActive (true);
		snowControl.gameObject.SetActive (false);
		liaControl.interactable = false;
		displayText = "";
		liaMainText.text = displayText;
		for (int i = 0; i <= fullText9.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText9.Substring (0, i);
			liaMainText.text = displayText;
		}
		liaControl.interactable = true;
	}

	IEnumerator ShowText10() {
		show10 = false;
		lia.gameObject.SetActive (false);
		snow.gameObject.SetActive (true);
		liaText.gameObject.SetActive (false);
		snowText.gameObject.SetActive (true);
		liaControl.gameObject.SetActive (false);
		snowControl.gameObject.SetActive (true);
		snowControl.interactable = false;
		displayText = "";
		snowMainText.text = displayText;
		for (int i = 0; i <= fullText10.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText10.Substring (0, i);
			snowMainText.text = displayText;
		}
		snowControl.interactable = true;
	}

	IEnumerator ShowText11() {
		show11 = false;
		lia.gameObject.SetActive (true);
		snow.gameObject.SetActive (false);
		liaText.gameObject.SetActive (true);
		snowText.gameObject.SetActive (false);
		liaControl.gameObject.SetActive (true);
		snowControl.gameObject.SetActive (false);
		liaControl.interactable = false;
		displayText = "";
		liaMainText.text = displayText;
		for (int i = 0; i <= fullText11.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText11.Substring (0, i);
			liaMainText.text = displayText;
		}
		liaControl.interactable = true;
	}

	IEnumerator ShowText12() {
		show12 = false;
		lia.gameObject.SetActive (false);
		snow.gameObject.SetActive (true);
		liaText.gameObject.SetActive (false);
		snowText.gameObject.SetActive (true);
		liaControl.gameObject.SetActive (false);
		snowControl.gameObject.SetActive (true);
		snowControl.interactable = false;
		displayText = "";
		snowMainText.text = displayText;
		for (int i = 0; i <= fullText12.Length; i++) {
			yield return new WaitForSeconds (delay);
			displayText = fullText12.Substring (0, i);
			snowMainText.text = displayText;
		}
		snowControl.interactable = true;
		yield return new WaitForSeconds (2f);
		continueButton.gameObject.SetActive (true);
	}
}
