using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmainScript : MonoBehaviour {


	public int playerLife = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void doDamage(int damage){
		playerLife -= damage;
		if (playerLife <= 0) {
			failLevel ();
		}
	}

	void failLevel(){
	}

}
