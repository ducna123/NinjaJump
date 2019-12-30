using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water3 : MonoBehaviour {
    private GameObject ninja;
    float z = 0.02f;
    // Use this for initialization
    void Start()
    {
        ninja = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5.1f)
        {
            z = Mathf.Abs(z);
        }
        else if (transform.position.y >= -4f)
        {
            z = -z;
        }
        transform.position = new Vector3(ninja.transform.position.x, transform.position.y + z, transform.position.z);
    }
}
