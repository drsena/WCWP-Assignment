using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonControl14 : MonoBehaviour {

	void Start()
	{
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		this.GetComponent<Button> ().interactable = false;
		TextControl14.stage++;
	}
}
