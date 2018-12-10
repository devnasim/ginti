using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCont : MonoBehaviour {

	public static gameCont control;
	public int countTextlevelOne;
	public int countTimelevelOne;
	public int countTextlevelTwo;
	public int countTimelevelTwo;
	public int countTextlevelThree;
	public int countTimelevelThree;

	void Awake() {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}

	}
}
