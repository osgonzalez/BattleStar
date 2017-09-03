using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour {

	public GameObject spawnObject;
	public GameObject spawnEffect;
	public float waitTimeForFirstSpawn = 0f;
	public float DurationOfSpawnEffect = 2f;
	public float waitTimeForSpawnObject = 0f;

	public GameObject wall;

	private liveScript lScript;		//Created gloval variable for memory eficience in case of multiple spawn.
	private GameObject spawnEffectInstance;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void spawn(){

		if (waitTimeForFirstSpawn == 0) {
			StartCoroutine ("instanciateObjects");
		} else {
			StartCoroutine ("waitforSpawn");
		}

	}


	IEnumerator instanciateObjects(){
		if (spawnEffect != null) {		
			spawnEffectInstance = Instantiate (spawnEffect,this.transform.position,Quaternion.identity);
			Debug.Log(this.transform.position);
			Debug.Log(spawnEffectInstance.transform.position);
			Destroy (spawnEffectInstance, DurationOfSpawnEffect);
			yield return new WaitForSeconds (waitTimeForSpawnObject);
		}

		GameObject obj = Instantiate (spawnObject,this.transform.position,Quaternion.identity);

		if (wall != null) {
			lScript = obj.GetComponent<liveScript> ();
			lScript.setWall (wall);
		}
	}


	IEnumerator waitforSpawn(){
		yield return new WaitForSeconds (waitTimeForFirstSpawn);
		StartCoroutine ("instanciateObjects");
	
	}

}
