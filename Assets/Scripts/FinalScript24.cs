using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinalScript24 : MonoBehaviour {

	public Text theEnd;
	public Text references, manga, gabriel, bgm, bgm1, bgm2, thank;
	public GameObject fadeScreen;

	void Start () {
		StartCoroutine (Wait());
	}
	
	IEnumerator Wait() {
		yield return new WaitForSeconds (2f);
		theEnd.gameObject.SetActive (true);
		yield return new WaitForSeconds (4f);
		theEnd.GetComponent<Animator> ().enabled = true;
		yield return new WaitForSeconds (3f);
		references.gameObject.SetActive (true);
		yield return new WaitForSeconds (3.5f);
		manga.gameObject.SetActive (true);
		yield return new WaitForSeconds (3f);
		gabriel.gameObject.SetActive (true);
		yield return new WaitForSeconds (3.5f);
		bgm.gameObject.SetActive (true);
		yield return new WaitForSeconds (3f);
		bgm1.gameObject.SetActive (true);
		yield return new WaitForSeconds (3.5f);
		bgm2.gameObject.SetActive (true);
		yield return new WaitForSeconds (3.5f);
		thank.gameObject.SetActive (true);
		yield return new WaitForSeconds (6.5f);
		fadeScreen.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (0);
	}
}
