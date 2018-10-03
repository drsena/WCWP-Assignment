using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class StartButton : MonoBehaviour {

	public Button startButton;
	public GameObject fadeScreen;

	void Start()
	{
		StartCoroutine (Wait ());
		Button btn = startButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		fadeScreen.gameObject.SetActive (true);
		StartCoroutine (Wait2 ());
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds (3f);
		startButton.gameObject.SetActive (true);
	}

	IEnumerator Wait2() {
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (1);
	}
}
