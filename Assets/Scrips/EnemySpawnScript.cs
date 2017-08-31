using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour {

	public GameObject spawnObject;
	public GameObject spawnEffect;
	public float timeOfSpawnEffect = 0f;
	public float waitTimeForSpawn = 0f;
	public GameObject wall;

	private liveScript lScript;		//Created gloval variable for memory eficience in case of multiple spawn.


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void spawn(){

		if (waitTimeForSpawn == 0) {
			StartCoroutine ("instanciateObjects");
		} else {
			StartCoroutine ("waitforSpawn");
		}

	}


	IEnumerator instanciateObjects(){
		if (spawnEffect != null) {		
			Instantiate (spawnEffect,this.transform.position,Quaternion.identity);
			yield return new WaitForSeconds (timeOfSpawnEffect);
		}

		GameObject obj = Instantiate (spawnObject,this.transform.position,Quaternion.identity);

		if (wall != null) {
			lScript = obj.GetComponent<liveScript> ();
			lScript.setWall (wall);
		}
	}


	IEnumerator waitforSpawn(){
		yield return new WaitForSeconds (waitTimeForSpawn);
		StartCoroutine ("instanciateObjects");
	
	}

}
