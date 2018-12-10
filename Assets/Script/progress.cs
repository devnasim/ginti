using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress : MonoBehaviour {

	public Text LevelOnePoints;
	public Text LevelOneTime;
	public Text statuslevelOne;

	public Text LevelTwoPoints;
	public Text LevelTwoTime;
	public Text statuslevelTwo;

	public Text LevelThreePoints;
	public Text LevelThreeTime;
	public Text statuslevelThree;
	private int boom;
	private int boom2;
	private int boom3;

	void Awake () {
		LevelOnePoints.text = gameCont.control.countTextlevelOne.ToString();
		LevelOneTime.text = gameCont.control.countTimelevelOne.ToString();
		boom = gameCont.control.countTextlevelOne.GetHashCode();
		Status ();

		LevelTwoPoints.text = gameCont.control.countTextlevelTwo.ToString();
		LevelTwoTime.text = gameCont.control.countTimelevelTwo.ToString();
		boom2 = gameCont.control.countTextlevelTwo.GetHashCode();
		Status2 ();


		LevelThreePoints.text = gameCont.control.countTextlevelThree.ToString();
		LevelThreeTime.text = gameCont.control.countTimelevelThree.ToString();
		boom3 = gameCont.control.countTextlevelThree.GetHashCode();
		Status3 ();

	}

	private void Status(){
		if (boom >= 20) {
			statuslevelOne.text = "Passed";
		}else if(boom == 0) {
			statuslevelOne.text = "---";
		} else if(boom < 20) {
			statuslevelOne.text = "Failed";
			statuslevelOne.color = Color.red;
		} 
	}
	private void Status2(){
		if (boom2 >= 20) {
			statuslevelTwo.text = "Passed";
		}else if(boom2 == 0) {
			statuslevelTwo.text = "---";
		} else if(boom2 < 20) {
			statuslevelTwo.text = "Failed";
			statuslevelTwo.color = Color.red;
		} 
	}
	private void Status3(){
		if (boom3 >= 15) {
			statuslevelThree.text = "Passed";
		}else if(boom3 == 0) {
			statuslevelThree.text = "---";
		} else if(boom3 < 15) {
			statuslevelThree.text = "Failed";
			statuslevelThree.color = Color.red;
		} 
	}

}
