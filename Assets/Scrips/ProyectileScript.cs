using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileScript : MonoBehaviour {


	public float shootVelocity = 1000;
	public int damage = 10;
	// Use this for initialization
	void Start () {
		Rigidbody rb = this.GetComponent<Rigidbody>();
		rb.AddForce(this.transform.forward * shootVelocity);

	}

	void setDamage(int damage){
		this.damage = damage;
	}

	// Update is called once per frame
	void Update () {

	}

	private void OnCollisionEnter(Collision collision)
	{
		liveScript script = collision.gameObject.GetComponent<liveScript>();
		if (collision.gameObject.tag == "Player") {
			levelmainScript main = (GameObject.FindGameObjectWithTag ("Main")).GetComponent<levelmainScript> ();
			main.getDamage (damage);
			Destroy (this.gameObject,0.1);
		
		} else {
			Destroy (this.gameObject);
		}

	}
}
