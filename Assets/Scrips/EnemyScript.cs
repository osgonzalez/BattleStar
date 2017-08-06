using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


 
   
}
