using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteController : MonoBehaviour {

    private GameObject ninja;
    // Use this for initialization
    void Start()
    {
        ninja = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(ninja.transform.position.x,0,0);
	}
}
