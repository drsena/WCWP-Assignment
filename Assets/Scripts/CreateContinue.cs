using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CreateContinue : MonoBehaviour {

	public Button continueButton;
	void Start()
	{
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		StartCoroutine (Wait ());
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds (1f);
		continueButton.gameObject.SetActive (true);
		this.gameObject.SetActive (false);
	}
}
