using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelScript : MonoBehaviour {


	private levelmainScript main;
	// Use this for initialization
	void Start () {
		main = GameObject.FindGameObjectWithTag ("Main").GetComponent<levelmainScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Player") {
			main.endLevel();
		}
	}

}
