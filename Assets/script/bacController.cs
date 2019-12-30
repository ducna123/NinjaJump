using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacController : MonoBehaviour {
    private GameObject ninja;
	// Use this for initialization
	void Start () {
        ninja = GameObject.FindGameObjectWithTag("Player");
	}
	


	// Update is called once per frame
	void Update () {
		if(this.transform.position.x < ninja.transform.position.x-5)
        {
            Destroy(this.gameObject);
            for (int i = 0; i < 3; i++)
            {
                spawnController.instance._Spawn();
            }
        }
	}

}
