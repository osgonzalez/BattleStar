using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

    private GameObject player;

    private Vector3 diff;

    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");
        diff = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + diff;
    }
}
