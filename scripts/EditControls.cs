using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditControls : MonoBehaviour {

	public void ChangeMF(){
		while(true){
			if (Input.anyKeyDown) {
				ControlsController.SetMoveForward ();
				break;
			}
		}
	}
}
