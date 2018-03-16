using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsTextController : MonoBehaviour {

	public Text MFText;
	public Text MBText;
	public Text MLText;
	public Text MRText;
	public Text JumpText;
	public Text SprintText;

	// Use this for initialization
	void Start () {
		MFText.text = KeyBindManager.GetMoveForward ();
		MBText.text = KeyBindManager.GetMoveBackward ();
		MLText.text = KeyBindManager.GetMoveLeft ();
		MRText.text = KeyBindManager.GetMoveRight ();
		JumpText.text = KeyBindManager.GetJump ();
		SprintText.text = KeyBindManager.GetSprint ();
	}
	
	// Update is called once per frame
	void Update () {
		MFText.text = KeyBindManager.GetMoveForward ();
		MBText.text = KeyBindManager.GetMoveBackward ();
		MLText.text = KeyBindManager.GetMoveLeft ();
		MRText.text = KeyBindManager.GetMoveRight ();
		JumpText.text = KeyBindManager.GetJump ();
		SprintText.text = KeyBindManager.GetSprint ();
	}
}
