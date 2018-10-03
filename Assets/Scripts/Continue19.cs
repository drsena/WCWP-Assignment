using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Continue19 : MonoBehaviour {

	public GameObject fadeScreen;

	void Start()
	{
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		fadeScreen.gameObject.SetActive (true);
		StartCoroutine (Wait ());
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (20);
	}
}
