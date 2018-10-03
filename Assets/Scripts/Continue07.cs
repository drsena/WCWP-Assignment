using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Continue07 : MonoBehaviour {

	public GameObject fadeScreen;

	void Start () {
		StartCoroutine (GoAhead ());
	}

	IEnumerator GoAhead() {
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (8);
	}
}
