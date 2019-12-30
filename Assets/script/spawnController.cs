using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour {
    public GameObject cot;
    private float start;
    public static spawnController instance;
    // Use this for initialization
    void Start () {
        start = 3.04f;
        _MakeInstance();
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void _Spawn()
    {
        Vector3 temp = cot.transform.position;
        float x = Random.Range(3,4);
        temp.x = x + start;
        start += x;
        temp.y = Random.Range(-2f,0.5f);
        float sY = Random.Range(-0.001f, 0.02f);
        cot.transform.localScale = new Vector3(cot.transform.localScale.x + sY, cot.transform.localScale.y, cot.transform.localScale.z);
        Instantiate(cot, temp, Quaternion.identity);
        cot.transform.localScale = new Vector3(cot.transform.localScale.x - sY, cot.transform.localScale.y, cot.transform.localScale.z);
    }
}
