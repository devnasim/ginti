using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour {
    public string scene;
    public Color loadToColor = Color.white;

    // Update is called once per frame
    void OnGUI()
    {
        //Button to load the new scene
        if (GUI.Button(new Rect(0, 0, 100, 30), "Start"))
        {
            Initiate.Fade(scene, loadToColor, 0.5f);
        }
    }
}
