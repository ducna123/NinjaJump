using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buble : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime *0.5f);
        Destroy(gameObject, 1f);
	}
}
