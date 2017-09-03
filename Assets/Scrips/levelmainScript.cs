using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelmainScript : MonoBehaviour {


	public int playerLife = 100;
	public Text lifeText;
	public Button defeatButton;
	public string lifeTextMessage = "Life: ";
	private int originalLife =0; 

	// Use this for initialization
	void Start () {
		defeatButton.gameObject.SetActive (false);
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

	public void restartLevel(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	void failLevel(){
		defeatButton.gameObject.SetActive (true);
		Time.timeScale = 0;
		
	}

}
