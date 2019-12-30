using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {
    private GameObject nv;
	// Use this for initialization
	void Start () {
        nv = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x < nv.transform.position.x - 1)
        {
            //transform.position = new Vector2(ninja.transform.position.x, transform.position.y);
        }
	}
}
