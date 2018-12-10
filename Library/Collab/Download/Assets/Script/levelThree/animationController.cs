using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animationController : MonoBehaviour {

	// Pair One
	public Animator animatorpairOneImage;
	public Animator animatorpairOne;
	public bool pairOneImageCamera;
	public bool movePairOneCamera;

	//pair Two
	public Animator animatorpairTwo;
	public bool movePairTwoCamera;
	public bool movePairTwoOutside;
	public Animator animatorPairTwoImage;
	public bool pairTwoImageCamera;
	public bool pairTwoImageOutside;

	//Pair Three 
	public Animator animatorpairThree;
	public bool pairThreeCamera;
	public bool pairThreeOutside;
	public Animator animatorPairThreeImage;
	public bool pairThreeImageCamera;
	public bool pairThreeImageOutside;

	//pairFour

	public Animator animatorpairFour;
	public Animator animatorPairFourImage;
	public bool movePairFour;
	public bool pairFourImageOutside;

	private string Tag;
	public Text countText;
	public string nextLevel;
	public string gameOver;
	public float speed;
	public Color loadToColor = Color.white;
	private int count;
	public Text textTime;
	private int timeCounterLevelThree;

	private void GameOver(){
		Initiate.Fade (gameOver, loadToColor, speed);
	}


	void setCountText(){

		countText.text = "SCORE-" + count.ToString ();
		if (count == 15) {
			Initiate.Fade (nextLevel, loadToColor, speed);
		} else if(count==2) {
			GameOver ();
		}else if(count==7) {
			GameOver ();
		}else if(count==12) {
			GameOver ();
		}

	}

	void gameCountScoreThree(){
		gameCont.control.countTextlevelThree = count;
		gameCont.control.countTimelevelThree = timeCounterLevelThree;
	}

	void Start () {

		count = 0;
		setCountText ();
		StartCoroutine (CounterTwo ());
		gameCountScoreThree ();
		//pair One
		animatorpairOne.enabled = true;
	

		//Pair two
		animatorpairTwo.enabled = true;
		animatorPairTwoImage.enabled = true;


		//Pair three
		animatorpairThree.enabled = true;
		animatorPairThreeImage.enabled = true;
		pairThreeImageCamera = false;

		//pairFour
		animatorpairFour.enabled = true;
		animatorPairFourImage.enabled = true

;



	}

	private void PairOne(){
		pairOneImageCamera = true;
		movePairOneCamera = true;
		movePairTwoOutside = true;
		pairTwoImageOutside = true;

		if (pairOneImageCamera == true || movePairOneCamera == true || movePairTwoOutside == true || pairTwoImageOutside == true  ) {
			animatorpairOneImage.SetBool ("pairOneImageCamera", true);
			animatorpairOne.SetBool ("movePairOneCamera", true);
			animatorpairTwo.SetBool ("movePairTwoOutside", true);
			animatorPairTwoImage.SetBool ("pairTwoImageOutside", true);
		}

	}

	private void PairTwo(){
		movePairTwoCamera = true;
		pairTwoImageCamera = true;
		pairThreeOutside = true;
		pairThreeImageOutside = true;
		if(movePairTwoCamera==true){
			animatorpairTwo.SetBool ("movePairTwoCamera", true);
			animatorPairTwoImage.SetBool ("pairTwoImageCamera", true);
			animatorpairThree.SetBool ("pairThreeOutside", true);
			animatorPairThreeImage.SetBool ("pairThreeImageOutside", true);
		}

	}

	private void PairThree(){
		pairThreeCamera = true;
		pairThreeImageCamera = true;
		movePairFour = true;
		pairFourImageOutside = true;
		if(pairThreeCamera==true){
			animatorpairThree.SetBool ("pairThreeCamera", true);
			animatorpairFour.SetBool ("movePairFour", true);
			animatorPairFourImage.SetBool ("pairFourImageOutside", true);
		}
	}

	private void PairFour(){
		pairThreeCamera = true;
		pairThreeImageCamera = true;
		movePairFour = true;
		pairFourImageOutside = true;
		if(pairThreeCamera==true){
			animatorpairThree.SetBool ("pairThreeCamera", true);
			animatorpairFour.SetBool ("movePairFour", true);
			animatorPairFourImage.SetBool ("pairFourImageOutside", true);
		}
	}


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (worldPoint, Vector2.zero);
			Tag = hit.collider.tag;
			if (Tag == "leopard") {
				Debug.Log ("leopard");
				PairOne ();
				count = count + 5;
				setCountText ();
				gameCountScoreThree ();

			} else if (Tag == "whiteWolf") {
				Debug.Log ("White Wolf");
				PairOne ();
				count = count - 3;
				setCountText ();
				gameCountScoreThree ();
			} else if (Tag == "redWolf") {
				Debug.Log ("redWolf");
				PairTwo ();
				count = count -3;
				setCountText ();
				gameCountScoreThree ();

			} else if (Tag == "goat") {
				Debug.Log ("goat");
				PairTwo ();
				count = count + 5;
				setCountText ();
				gameCountScoreThree ();

			} else if (Tag == "whiteWolfOne") {
				Debug.Log ("goat");
				PairThree ();
				count = count + 5;
				setCountText ();
				gameCountScoreThree ();
		
			} else if (Tag == "blackWolf") {
				Debug.Log ("blackWolf");
				PairThree ();
				count = count - 3;
				setCountText ();
				gameCountScoreThree ();
			}
			else if (Tag == "leopardOne") {
				Debug.Log ("leopardOne");
				PairThree ();
				count = count + 5;
				setCountText ();
				gameCountScoreThree ();

			} else if (Tag == "goatOne") {
				Debug.Log ("goatOne");
				PairFour ();
				count = count - 3;
				setCountText ();
				gameCountScoreThree ();
			}
		}
	}

	IEnumerator CounterTwo(){
		while (count<=15) {
			textTime.text = "Time: " + timeCounterLevelThree;
			yield return new  WaitForSeconds (1);
			timeCounterLevelThree++;
		}
	}
}
