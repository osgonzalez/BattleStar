using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour {

	GameObject destroyEffect ;
	public float delayForDestroy;

	public int enemysForOpen = 0;
	private bool activate = false;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (activate && enemysForOpen <= 0) {
			open ();
		}
	}

	public void setenemysForOpen(int enemysForOpen){
		this.enemysForOpen = enemysForOpen;
		this.activate = true;
	}

	public void addEnemyForOpen(){
		this.enemysForOpen++;
		this.activate = true;
	}

	public void removeEnemyForOpen(){
		this.enemysForOpen--;
	}

	public void open(){
		if (destroyEffect != null) {		
			Instantiate (destroyEffect,this.transform.position,Quaternion.identity);
		}

		Destroy (this.gameObject,delayForDestroy);
	}


}
