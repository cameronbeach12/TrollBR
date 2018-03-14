using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBindManager : MonoBehaviour {

	const string MOVE_FORWARD_KEY = "move_forward";

	// Use this for initialization
	public IEnumerator SetMoveForward(bool keyPressed){
			while (!Input.anyKeyDown && keyPressed == false) {
				if (Input.anyKeyDown) {
					foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
						if (Input.GetKey (vKey)) {
							string nKey = vKey.ToString ();
							PlayerPrefs.SetString (MOVE_FORWARD_KEY, nKey);
							keyPressed = true;
							yield break;
					}
				} 

			}
		}
	}

	public void SetMF(){
		StartCoroutine (SetMoveForward (false));
	}
}
