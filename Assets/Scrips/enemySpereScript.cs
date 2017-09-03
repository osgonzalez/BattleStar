using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpereScript : MonoBehaviour {

	private Rigidbody rb;
	public float shootCadence = 0.5f;
	private float nextTimeForShoot = 0;
	public GameObject [] proyectileList;
	private GameObject shoot;						//Global variable for memory eficience

	public int rotation = 0;


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

			shoot = Instantiate(proyectileList[Random.Range(0,proyectileList.Length-1)], (this.transform.position + (this.transform.forward * -1)),this.transform.rotation);
			shoot.transform.Rotate (new Vector3 (0, 180, 0));

			shoot = Instantiate(proyectileList[Random.Range(0,proyectileList.Length-1)], (this.transform.position + (this.transform.right * 1)),this.transform.rotation);
			shoot.transform.Rotate (new Vector3 (0, 90, 0));

			shoot = Instantiate(proyectileList[Random.Range(0,proyectileList.Length-1)], (this.transform.position + (this.transform.right * -1)),this.transform.rotation);
			shoot.transform.Rotate (new Vector3 (0, -90, 0));

			//Instantiate(proyectileList[Random.Range(0,proyectileList.Length-1)], (this.transform.position + (this.transform.forward * -1)), this.transform.rotation.eulerAngles + 180f * Vector3.up );

			this.transform.Rotate (new Vector3 (0, rotation, 0));
		}

	
		
	}
}
