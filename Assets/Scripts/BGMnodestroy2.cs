using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BGMnodestroy2 : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (this.gameObject);
	}

	void Update() {
		if (SceneManager.GetActiveScene ().name == "Main_Menu(0)") {
			Destroy (this.gameObject);
		}
	}
}
