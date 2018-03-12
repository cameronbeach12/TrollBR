using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaults : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void SetOptionDefaults(){
		PlayerPrefsManager.SetMasterVolume (.5f);
		Debug.Log (PlayerPrefsManager.GetMasterVolume());
		OptionsController.MasterVolume.value = PlayerPrefsManager.GetMasterVolume ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
