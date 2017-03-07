using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TouchScript.Gestures;

public class Card : MonoBehaviour {

	public int deckLayer = 8;
	public int id;
	public string role;
	public Text roleText;
	public Image image;
	public Image token;
	public Canvas tokenCanvas;

	public bool tapped= false;
	public bool swapPhase=false;
	public bool swapCard=false;

	private void Awake() {
		GetComponent<Renderer> ().material.color = Color.clear;
		//GetComponent<TransformGesture> ().enabled = false;
	}

	private void OnEnable() {
		GetComponent<TapGesture>().Tapped += TapHandler;
		GetComponent<LongPressGesture> ().StateChanged += LongTapHandler;
		GetComponent<ReleaseGesture> ().StateChanged += ReleaseHandler;
	}

	private void OnDisable() {
		GetComponent<TapGesture> ().Tapped -= TapHandler;
		GetComponent<LongPressGesture> ().StateChanged -= LongTapHandler;
		GetComponent<ReleaseGesture> ().StateChanged -= ReleaseHandler;
	}

	private void TapHandler (object sender, System.EventArgs e) {
//		tapped = !tapped;
//		if (swapPhase) {
//			swapCard = true;
//			return;
//		}
		flip ();
	}

	private void LongTapHandler(object sender, GestureStateChangeEventArgs e){
		if (e.State == Gesture.GestureState.Recognized) { 
			token.enabled = true;
		}
	}

	private void ReleaseHandler(object sender, GestureStateChangeEventArgs e){
		token.enabled = false;
	}

	public void setText(string s) {
		roleText.text = s;
	}

	public void flip() {
		iTween.RotateAdd (gameObject, iTween.Hash ("x", 0, "y", 180, "z", 0));
	}
}
