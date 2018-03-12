using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Save : MonoBehaviour {

	private Slider MVslider;
	private float MVvalue;

	// Use this for initialization
	void Start () {
		MVslider = GameObject.Find ("MasterVolumeSlider").GetComponent<Slider> ();
		MVvalue = MVslider.value;
	}

	void OnDestroy(){
		PlayerPrefsManager.SetMasterVolume (MVvalue);
	}
	
	// Update is called once per frame
	void Update () {
		MVvalue = MVslider.value;
	}
}
