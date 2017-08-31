using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTriggerScript : MonoBehaviour {

	public GameObject [] SpawnsList; 
	//public float timeInterSpawns = 0;
	private bool isNotUsed;

	// Use this for initialization
	void Start () {
		isNotUsed = true;
	}
	
	// Update is called once per frame
	void Update () {



	}


	private void OnTriggerEnter(Collider collision)
	{
		if (isNotUsed && collision.gameObject.tag == "Player") {
			isNotUsed = false;

			EnemySpawnScript script;

			foreach (GameObject spawn in SpawnsList) {
				script = spawn.gameObject.GetComponent<EnemySpawnScript> ();
				script.spawn ();
			}

		
		}


	}
	

}
