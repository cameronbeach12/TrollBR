using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBindManager : MonoBehaviour {

	const string MOVE_FORWARD_KEY = "move_forward";
	const string MOVE_BACKWARD_KEY = "move_backward";
	const string MOVE_LEFT_KEY = "move_left";
	const string MOVE_RIGHT_KEY = "move_right";
	const string JUMP_KEY = "jump";
	const string SPRINT_KEY = "sprint";
	const string FIRE_KEY = "fire";

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

	public IEnumerator SetMoveBackward(bool keyPressed){
		while (keyPressed == false) {
			Debug.Log ("I'm Here");
			if(Input.anyKeyDown){
				Debug.Log ("icecream");
				foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (vKey)) {
						string nKey = vKey.ToString ();
						PlayerPrefs.SetString (MOVE_BACKWARD_KEY, nKey);
						keyPressed = true;
						yield break;
					}
				} 
			}if (keyPressed == false) {
				yield return null;
			}
		}
	}

	public IEnumerator SetMoveLeft(bool keyPressed){
		while (keyPressed == false) {
			Debug.Log ("I'm Here");
			if(Input.anyKeyDown){
				Debug.Log ("icecream");
				foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (vKey)) {
						string nKey = vKey.ToString ();
						PlayerPrefs.SetString (MOVE_LEFT_KEY, nKey);
						keyPressed = true;
						yield break;
					}
				} 
			}if (keyPressed == false) {
				yield return null;
			}
		}
	}

	public IEnumerator SetMoveRight(bool keyPressed){
		while (keyPressed == false) {
			Debug.Log ("I'm Here");
			if(Input.anyKeyDown){
				Debug.Log ("icecream");
				foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (vKey)) {
						string nKey = vKey.ToString ();
						PlayerPrefs.SetString (MOVE_RIGHT_KEY, nKey);
						keyPressed = true;
						yield break;
					}
				} 
			}if (keyPressed == false) {
				yield return null;
			}
		}
	}

	public IEnumerator SetJump(bool keyPressed){
		while (keyPressed == false) {
			Debug.Log ("I'm Here");
			if(Input.anyKeyDown){
				Debug.Log ("icecream");
				foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (vKey)) {
						string nKey = vKey.ToString ();
						PlayerPrefs.SetString (JUMP_KEY, nKey);
						keyPressed = true;
						yield break;
					}
				} 
			}if (keyPressed == false) {
				yield return null;
			}
		}
	}

	public IEnumerator SetSprint(bool keyPressed){
		while (keyPressed == false) {
			Debug.Log ("I'm Here");
			if(Input.anyKeyDown){
				Debug.Log ("icecream");
				foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))) {
					if (Input.GetKeyDown (vKey)) {
						string nKey = vKey.ToString ();
						PlayerPrefs.SetString (SPRINT_KEY, nKey);
						keyPressed = true;
						yield break;
					}
				} 
			}if (keyPressed == false) {
				yield return null;
			}
		}
	}
		
	public void SetFire(){
		PlayerPrefs.SetString(FIRE_KEY,"Left Mouse Button")
	}

	public static string GetMoveForward(){
		return PlayerPrefs.GetString(MOVE_FORWARD_KEY);
	}

	public static string GetMoveBackward(){
		return PlayerPrefs.GetString(MOVE_BACKWARD_KEY);
	}

	public static string GetMoveLeft(){
		return PlayerPrefs.GetString(MOVE_LEFT_KEY);
	}

	public static string GetMoveRight(){
		return PlayerPrefs.GetString(MOVE_RIGHT_KEY);
	}

	public static string GetJump(){
		return PlayerPrefs.GetString(JUMP_KEY);
	}

	public static string GetSprint(){
		return PlayerPrefs.GetString(SPRINT_KEY);
	}

	public static string GetFire(){
		return PlayerPrefs.GetString(FIRE_KEY);
	}

	public void SetMF(){
		Debug.Log (GetMoveForward());
		StartCoroutine (SetMoveForward (false));
	}

	public void SetMB(){
		Debug.Log (GetMoveBackward());
		StartCoroutine (SetMoveBackward(false));
	}

	public void SetML(){
		Debug.Log (GetMoveLeft());
		StartCoroutine (SetMoveLeft(false));
	}

	public void SetMR(){
		Debug.Log (GetMoveRight());
		StartCoroutine (SetMoveRight(false));
	}

	public void SetJump(){
		Debug.Log (GetJump());
		StartCoroutine (SetJump(false));
	}

	public void SetSprint(){
		Debug.Log (GetSprint());
		StartCoroutine (SetSprint(false));
	}

	public void SetDefaults(){
		PlayerPrefs.SetString (MOVE_FORWARD_KEY, "W");
		PlayerPrefs.SetString (MOVE_LEFT_KEY, "A");
		PlayerPrefs.SetString (MOVE_BACKWARD_KEY, "S");
		PlayerPrefs.SetString(MOVE_RIGHT_KEY,"D");
		PlayerPrefs.SetString(JUMP_KEY,"Space");
		PlayerPrefs.SetString(SPRINT_KEY,"LeftShift");
		PlayerPrefs.SetString(FIRE_KEY,"Left Mouse Button");
	}
}
