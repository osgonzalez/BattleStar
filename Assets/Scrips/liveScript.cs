using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveScript : MonoBehaviour {

    public int life = 100;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doDamage(int damage)
    {
        this.life -= damage;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
