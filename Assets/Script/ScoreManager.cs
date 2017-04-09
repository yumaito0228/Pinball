using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoretext;
	public static int scorevalue;
	private GameObject score;


	// Use this for initialization
	void Start () {
		scorevalue = 0;
		this.score = GameObject.Find("Score");
		this.score.GetComponent<Text> ().text = "Score: " + scorevalue;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision other){
		if (other.gameObject.tag == "SmallStarTag") {
			scorevalue += 1000;
			this.score.GetComponent<Text> ().text = "Score: " + scorevalue;
		}
		if (other.gameObject.tag == "SmallCloudTag") {
			scorevalue += 2000;
			this.score.GetComponent<Text> ().text = "Score: " + scorevalue;
		}
		if (other.gameObject.tag == "LargeStarTag") {
			scorevalue += 1500;
			this.score.GetComponent<Text> ().text = "Score: " + scorevalue;
		}
		if (other.gameObject.tag == "LargeCloudTag") {
			scorevalue += 2500;
			this.score.GetComponent<Text> ().text = "Score: " + scorevalue;
		}

	}
}