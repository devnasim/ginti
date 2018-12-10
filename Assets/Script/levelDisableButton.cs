using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelDisableButton : MonoBehaviour {

	public Button[] levelsButton;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < levelsButton.Length; i++) {

			levelsButton [i].interactable = false;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
