using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Continue21 : MonoBehaviour {

	public GameObject fadeScreen;
	public GameObject newText;

	void Start () {
		StartCoroutine (GoAhead ());
	}

	IEnumerator GoAhead() {
		yield return new WaitForSeconds (2.8f);
		newText.gameObject.SetActive (true);
		yield return new WaitForSeconds (4f);
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (22);
	}
}
