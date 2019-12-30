using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public GameObject target;
    float x;
    float y;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(playerController.instance != null)
        {
            if(playerController.instance.isDead == false)
            {
                x = target.transform.position.x;
                y = target.transform.position.y;
                if(y > 3.2f)
                {
                    y = 3.2f;
                }
                if(y < 0f)
                {
                    y = 0f;
                }
                transform.position = new Vector3(x+2, transform.position.y, transform.position.z);
            }
        }
	}
}
