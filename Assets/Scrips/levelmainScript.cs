using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelmainScript : MonoBehaviour {


	public int playerLife = 100;
	public Text lifeText;
	public string lifeTextMessage = "Life: ";
	public Text scoreText;
	public string scoreTextMessage = "Score: ";
	public int score = 0;
	private int originalLife =0; 

	public Text defeatText;
	public Text levelCompleteText;
	public Button resetLevelButton;
	public Button backToMenuButton;
	public Button nextLevelButton;


	// Use this for initialization
	void Start () {
		defeatText.gameObject.SetActive (false);
		levelCompleteText.gameObject.SetActive (false);
		resetLevelButton.gameObject.SetActive (false);
		backToMenuButton.gameObject.SetActive (false);
		nextLevelButton.gameObject.SetActive (false);

		originalLife = playerLife;
		lifeText.text = lifeTextMessage + playerLife + "/" + originalLife;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void doDamage(int damage){
		playerLife -= damage;

		if (playerLife <= 0) {
			failLevel ();
			playerLife = 0;
		}

		lifeText.text = lifeTextMessage + playerLife + "/" + originalLife;
	}

	public void addScore(int score){
		this.score += score; 
		scoreText.text = scoreTextMessage + this.score;

	}

	public void restartLevel(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void backToMenu(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);		//toDo
	}

	public void nextLevel(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);		//toDo
	}

	void failLevel(){
		defeatText.gameObject.SetActive (true);
		resetLevelButton.gameObject.SetActive (true);
		backToMenuButton.gameObject.SetActive (true);
		Time.timeScale = 0;
		
	}

	public void endLevel(){
		levelCompleteText.gameObject.SetActive (true);
		resetLevelButton.gameObject.SetActive (true);
		backToMenuButton.gameObject.SetActive (true);
		nextLevelButton.gameObject.SetActive (true);
	}



}
