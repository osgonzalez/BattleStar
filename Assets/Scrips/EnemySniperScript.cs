using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySniperScript : MonoBehaviour {

	private Rigidbody rb;
	public float shootCadence = 0.5f;
	private float nextTimeForShoot = 0;
	public GameObject [] proyectileList;
	private GameObject shoot;						//Global variable for memory eficience
	private GameObject player;
	public int rotation = 0;


	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.freezeRotation = true;
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

		this.transform.forward = (player.transform.position - this.transform.position);

		if (nextTimeForShoot<Time.time)
		{
			nextTimeForShoot = Time.time + shootCadence;

			Instantiate(proyectileList[Random.Range(0,proyectileList.Length-1)], (this.transform.position + (this.transform.forward * 1)),this.transform.rotation);




		}



	}
}
