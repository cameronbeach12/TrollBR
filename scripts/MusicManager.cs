using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private static AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	}

	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray[level];

		Debug.Log ("Playing clip: " + thisLevelMusic);

		if(thisLevelMusic){//If there is music attached to element
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

	public static void ChangeVolume(float vol){
		audioSource.volume = vol;
	}
}
