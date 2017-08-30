using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpereScript : MonoBehaviour {

	private Rigidbody rb;
	public float shootCadence = 0.5f;
	private float nextTimeForShoot = 0;
	public GameObject [] proyectileList;



	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.freezeRotation = true;
	}

	// Update is called once per frame
	void Update () {

		if (nextTimeForShoot<Time.time)
		{
			nextTimeForShoot = Time.time + shootCadence;

			Instantiate(proyectileList[Random.Range(0,proyectileList.Length-1)], (this.transform.position + (this.transform.forward * 1)),this.transform.rotation);


		}

	
		
	}
}
