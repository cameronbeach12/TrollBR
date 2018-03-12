using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionsController : MonoBehaviour {

	public static Slider MasterVolume;
	private float vol;

	// Use this for initialization
	void Start () {
		MasterVolume = GameObject.Find ("MasterVolumeSlider").GetComponent<Slider>();
		vol = PlayerPrefsManager.GetMasterVolume ();
		Debug.Log (vol);
		if (vol < 0f && vol > 1f) {
			PlayerPrefsManager.SetMasterVolume (.5f);
			vol = PlayerPrefsManager.GetMasterVolume ();
			MasterVolume.value = vol;
		} else {
			MasterVolume.value = vol;
		}
	}

	
	// Update is called once per frame
	void Update () {
		vol = MasterVolume.value;
		MusicManager.ChangeVolume (vol);
	}
}
