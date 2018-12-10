using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundButton : MonoBehaviour {
	public AudioClip stone;
	private AudioSource audioSource;
	// Use this for initialization
	void Awake  () {
		audioSource = this.GetComponent<AudioSource>();
	}
	
	public void playSound(){
		audioSource.PlayOneShot (stone);
	}

}
