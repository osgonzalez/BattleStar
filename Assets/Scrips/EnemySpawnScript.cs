using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour {
	public float time=1f;
	public GameObject spawnObject;
	public GameObject spawnEffect;
	public float timeOfSpawnEffect = 0f;
	public float waitTimeForSpawn = 0f;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		if (time < Time.time) {
			time = Time.time + 2f;
			Debug.Log (this.gameObject.name + "   " + this.transform.position);
		}
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
		Debug.Log (this.transform.position);
		Instantiate (spawnObject,this.transform.position,Quaternion.identity);

	}


	IEnumerator waitforSpawn(){
		yield return new WaitForSeconds (waitTimeForSpawn);
		StartCoroutine ("instanciateObjects");
	
	}

}
