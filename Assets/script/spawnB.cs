using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnB : MonoBehaviour {
    public GameObject b1;
    public GameObject b2;
    private GameObject ninja;
    int d;
	// Use this for initialization
	void Start () {
        d = 0;
        ninja = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if(d == 40)
        {
            StartCoroutine(Spawner());
            d = 0;
        }
        d++;
    }
    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(0.01f);
        Vector3 temp1 = transform.position;
        Vector3 temp2 = new Vector3(transform.position.x+0.3f,transform.position.y+0.09f,transform.position.z);
        Instantiate(b1, temp1, Quaternion.identity);
        Instantiate(b2, temp2, Quaternion.identity);
    }
}
