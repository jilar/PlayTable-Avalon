using System.Collections;
using System;
using UnityEngine;
using TouchScript.Gestures;

public class Start : MonoBehaviour {
	public Canvas openingScene;

	void OnEnable() {
		GetComponent<TapGesture> ().Tapped += TapHandler;
	}

	void OnDisable() {
		GetComponent<TapGesture> ().Tapped -= TapHandler;
	}

	public void TapHandler(object sender, EventArgs e) {
		openingScene.gameObject.SetActive (false);
	}
}
