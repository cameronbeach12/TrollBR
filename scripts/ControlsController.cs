using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControlsController : MonoBehaviour {

	const string MOVE_FORWARD_KEY = "move_forward";
	const string MOVE_BACKWARD_KEY = "move_backward";
	const string MOVE_RIGHT_KEY = "move_right";
	const string MOVE_LEFT_KEY = "move_left";
	const string JUMP_KEY = "jump";
	const string SPRINT_KEY = "sprint";

	// Use this for initialization
	public static void SetMoveForward(){
			Event key = Event.current;

			if (key.isKey != null && key.isKey) {
				PlayerPrefs.SetString (MOVE_FORWARD_KEY, key.keyCode.ToString ());
				Debug.Log ("Change Move Forward Key To " + key.keyCode.ToString ());
			}
		}
	}
