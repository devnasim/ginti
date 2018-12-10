using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasShowHide : MonoBehaviour {

	public Canvas CanvasA;
	private string Tag;
	private int count;
	public string nextLevel;
	public string gameOver;
	public float speed;
	public Color loadToColor = Color.white;
	public Text countText;
	public Text textTime;
	private int timeCounterLevelTwo;

	void Start () {

		StartCoroutine (CounterTwo ());
		gameCountScoreTwo ();
	}

	 void gameCountScoreTwo(){
		gameCont.control.countTextlevelTwo = count;
		gameCont.control.countTimelevelTwo = timeCounterLevelTwo;
	}

	void setCountText(){

		countText.text = "SCORE-" + count.ToString ();
		if (count >= 20) {
			Initiate.Fade (nextLevel, loadToColor, speed);
		} else if (count == 16) {
			Initiate.Fade (gameOver, loadToColor, speed);
		}

	}

	public void disableCanvas() {
		CanvasA.GetComponent<Canvas> ().enabled = true;
		Debug.Log ("hello");
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (worldPoint, Vector2.zero);
			Tag = hit.collider.tag;
			if (Tag=="one"){
				Destroy (hit.collider.gameObject);
			}else if (hit.collider.tag == "two") {
				Destroy (hit.collider.gameObject);
				count = count + 5;
				setCountText ();
				gameCountScoreTwo ();
			}else if (hit.collider.tag == "three") {
				Destroy (hit.collider.gameObject);
				count = count + 5;
				setCountText ();
				gameCountScoreTwo ();
			} else if (hit.collider.tag == "four") {
				Destroy (hit.collider.gameObject);
				count = count + 5;
				setCountText ();
				gameCountScoreTwo ();
			} else if (hit.collider.tag == "five") {
				Destroy (hit.collider.gameObject);
				count = count - 2;
				setCountText ();
				gameCountScoreTwo ();
			} else if (hit.collider.tag == "six") {
				Destroy (hit.collider.gameObject);
				count = count + 5;
				setCountText ();
				gameCountScoreTwo ();
			} else if (hit.collider.tag == "seven") {
				Destroy (hit.collider.gameObject);
				count = count - 2;
				setCountText ();
				gameCountScoreTwo ();
			}else{
				Debug.Log ("boom");
			}

		}
	}

	IEnumerator CounterTwo(){
		while (count<=20) {
			textTime.text = "Time: " + timeCounterLevelTwo;
			yield return new  WaitForSeconds (1);
			timeCounterLevelTwo++;
		}
	}
}
