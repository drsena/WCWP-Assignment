using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BGMnodestroy : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}

	void Update() {
		if (SceneManager.GetActiveScene ().name == "QuickEx(18)") {
			Destroy (this.gameObject);
		}
	}
}
