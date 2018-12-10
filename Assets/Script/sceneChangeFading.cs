using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneChangeFading : MonoBehaviour {


    public string scene;
    public float speed;
	public Color loadToColor = Color.white;


    public void ChangeScene(string scene)
    {
        Initiate.Fade(scene, loadToColor, speed);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
