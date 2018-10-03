using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Continue17 : MonoBehaviour {

	public GameObject fadeScreen;

	void Start () {
		StartCoroutine (GoAhead ());
	}

	IEnumerator GoAhead() {
		yield return new WaitForSeconds (2.95f);
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (18);
	}
}
