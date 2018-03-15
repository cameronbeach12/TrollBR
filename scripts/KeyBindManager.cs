using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBindManager : MonoBehaviour {

	const string MOVE_FORWARD_KEY = "move_forward";

	// Use this for initialization
	public IEnumerator SetMoveForward(bool keyPressed){
		while (keyPressed == false) {
			Debug.Log ("I'm Here");
			if(Input.anyKeyDown){
				Debug.Log ("icecream");
				foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (vKey)) {
						string nKey = vKey.ToString ();
						PlayerPrefs.SetString (MOVE_FORWARD_KEY, nKey);
						keyPressed = true;
						yield break;
					}
				} 
			}if (keyPressed == false) {
				yield return null;
			}
		}
	}


	public static string GetMoveForward(){
		return PlayerPrefs.GetString(MOVE_FORWARD_KEY);
	}

	public void SetMF(){
		Debug.Log (GetMoveForward());
		StartCoroutine (SetMoveForward (false));
	}
}
