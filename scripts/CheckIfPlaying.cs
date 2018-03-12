using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfPlaying : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Awake() {
		DontDestroyOnLoad(gameObject);
	}

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (audioSource.isPlaying) {
			return;
		}
	}
}
