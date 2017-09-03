using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplosibeCapsuleScript : MonoBehaviour {

	private Rigidbody rb;
	private GameObject player;
	public int velocity = 1;
	public int damage = 30;
	public int startDistance = 10;


	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.freezeRotation = true;
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if ((player.transform.position - this.transform.position).magnitude < startDistance) {
			this.transform.forward = (player.transform.position - this.transform.position);
			this.rb.velocity = this.transform.forward * velocity * Time.deltaTime;
		}
	}


	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") {
			levelmainScript main = (GameObject.FindGameObjectWithTag ("Main")).GetComponent<levelmainScript>();
			main.doDamage(damage);
			Destroy(this.gameObject,0.1f);

		}

	}
	
}
