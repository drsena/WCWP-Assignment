using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Continue23 : MonoBehaviour {

	public GameObject fadeScreen;
	public GameObject newText;

	void Start () {
		StartCoroutine (GoAhead ());
	}

	IEnumerator GoAhead() {
		yield return new WaitForSeconds (2.5f);
		newText.gameObject.SetActive (true);
		yield return new WaitForSeconds (6f);
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (24);
	}
}
