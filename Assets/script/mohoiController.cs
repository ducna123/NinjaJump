using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mohoiController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * Time.deltaTime * 0.00001f);
        Destroy(gameObject,0.5f);
	}
}
