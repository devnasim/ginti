using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float speed;
    private Renderer myRenderer;

    // Use this for initialization
    void Start () {
        myRenderer = GetComponent<Renderer>();

    }
	
	// Update is called once per frame
	void Update () {

        myRenderer.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);



    }
}
