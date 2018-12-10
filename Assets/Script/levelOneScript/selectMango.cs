using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectMango : MonoBehaviour {

	public Text countText;
	public string nextLevel;
	public string gameOver;
	public string backButton;
	public float speed;
	public Color loadToColor = Color.white;
	private int count;
	public Text textTime;
	private int timeCounterLevelOne;

	void Start () {
		count = 0;
		setCountText ();

		StartCoroutine (Counter ());
		gameCountScore ();
	}

	void gameCountScore(){
		gameCont.control.countTextlevelOne = count;
		gameCont.control.countTimelevelOne = timeCounterLevelOne;
	}
		


	void setCountText(){

		countText.text = "SCORE:" + count.ToString ();
		if (count >= 20) {
			Initiate.Fade (nextLevel, loadToColor, speed);
		} else if (count == 17) {
			Initiate.Fade (gameOver, loadToColor, speed);
		}

	}
		
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);


			if (hit.collider.tag == "one") {
				Debug.Log ("one");
		    	Destroy (hit.collider.gameObject);
				count = count -2;
				gameCountScore ();
				setCountText ();


			} else if (hit.collider.tag == "two") {
				Debug.Log ("two");
				Destroy (hit.collider.gameObject);
				count = count + 5;
				setCountText ();
				gameCountScore ();
			} else if (hit.collider.tag == "three") {
				Debug.Log ("three");
				Destroy (hit.collider.gameObject);
				count = count -2;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "four") {
				Debug.Log ("four");
				Destroy (hit.collider.gameObject);
				count = count + 5;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "five") {
				Debug.Log ("five");
				Destroy (hit.collider.gameObject);
				count = count +5;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "six") {
				Debug.Log ("six");
				Destroy (hit.collider.gameObject);
				count = count + 5;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "seven") {
				Debug.Log ("seven");
				Destroy (hit.collider.gameObject);
				count = count - 2;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "eight") {
				Debug.Log ("eight");
				Destroy (hit.collider.gameObject);
				count = count + 5;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "nine") {
				Debug.Log ("nine");
				Destroy (hit.collider.gameObject);
				count = count + 5;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "ten") {
				Debug.Log ("nine");
				Destroy (hit.collider.gameObject);
				count = count - 2;
				gameCountScore ();
				setCountText ();
			} else if (hit.collider.tag == "ten") {
				Debug.Log ("nine");

			} else if (hit.collider.tag == "backbutton") {
				Debug.Log ("backButton");
				Initiate.Fade (backButton, loadToColor, speed);
			}
			else {
				Debug.Log ("nothing to click");
			}

				
		}
	}

	IEnumerator Counter(){
		while (count<=20) {
			textTime.text = "Time: " + timeCounterLevelOne;
			yield return new  WaitForSeconds (1);
			timeCounterLevelOne++;
		}
	}
}
