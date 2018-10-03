using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextButton : MonoBehaviour {

	public Button nextButton;
	public GameObject fadeScreen;

	void Start()
	{
		Button btn = nextButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		nextButton.gameObject.SetActive (false);
		fadeScreen.gameObject.SetActive (true);
		StartCoroutine (Wait2 ());
	}

	IEnumerator Wait2() {
		yield return new WaitForSeconds (0.95f);
		SceneManager.LoadScene (2);
	}
}
