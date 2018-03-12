using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfExists : MonoBehaviour {

	private GameObject[] getCount;
	private int count;

	// Use this for initialization
	void Start () {
		getCount = GameObject.FindGameObjectsWithTag ("Music Controllers");
		count = getCount.Length;
	}
	
	// Update is called once per frame
	void Update () {
		getCount = GameObject.FindGameObjectsWithTag ("Music Controllers");
		count = getCount.Length;
		if (GameObject.Find ("MenuMusic")) {
			while (count > 1) {
				Destroy (gameObject);
			}
		}
	}
}
