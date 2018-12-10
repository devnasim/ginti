using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lionAnimation : MonoBehaviour {

	public Animator animator;
	public bool lionAnimMoving;
	public bool lionAnimSlow;
	private string Tag;

	// Use this for initialization
	void Start () {
		animator.enabled = true;
		lionAnimSlow = false;
		lionAnimMoving = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (worldPoint, Vector2.zero);
			Tag = hit.collider.tag;
			if (Tag == "lion") {
				Debug.Log ("done");

			}
				
		}
		
	}
}
