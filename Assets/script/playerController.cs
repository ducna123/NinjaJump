using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    private int force;
    private Rigidbody2D myBody;
    private BoxCollider2D box;
    private Animator anim;
    public bool isPut;
    private float down;
    private float up;
    private bool isJump;
    private bool isGround;
    public GameObject lx;
    public GameObject ninja;
    private bool first;
    public bool isNew;
    public static playerController instance;
    public GameObject mohoi;
    private GameObject nv;
    private int d;
    public int time;
    public bool isDead;
    private int point;
    private int p;
    public AudioSource audio;
    public AudioClip jump;
    public AudioClip die;

    // Use this for initialization
    void Start () {
        isDead = false;
        d = 0;
        force = 0;
        isPut = false;
        down = 0;
        up = 0;
        first = true;
        nv = GameObject.FindGameObjectWithTag("Player");
        isJump = false;
        isGround = true;
        isNew = false;
        time = 0;
	}

    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground" && isPut == false && isDead == false && first == false)
        {
            isGround = true;
            isJump = false;
            isNew = true;
            Debug.Log(1);
            point += p;
            force = 0;
            myBody.velocity = new Vector2(0, 0);
            if (GameController.instance != null)
            {
                GameController.instance._SetPoint(point);
            }
            lx.SetActive(true);
        }
        if (other.gameObject.tag == "delete")
        {
            Debug.Log("die");
            isDead = true;
            audio.PlayOneShot(die);
            if (GameController.instance != null)
            {
                GameController.instance.endG(point);
            }
            //Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "die")
        {
            Debug.Log("die");
            isDead = true;
        }
    }

    void Update () {
        if (Input.GetMouseButtonDown(0) && isDead == false && isJump == false && isGround == true)
        {
            isPut = true;
            anim.SetTrigger("jump");
            d = 0;
        }
        if (Input.GetMouseButtonUp(0) && isDead == false && isJump == false)
        {
            Debug.Log("bay");
            first = false;
            anim.SetTrigger("normal");
            if (force >= 30)
            {
                force = 30;
            }
            if (force <= 20)
            {
                force = 15;
            }
            if (force >= 28)
            {
                p = 4;
            }
            if (force < 28)
            {
                p = 1;
            }
            audio.PlayOneShot(jump);
            isPut = false;
            isJump = true;
            isGround = false;
            _Ninja();
        }
        if(isPut == true)
        {
            if(isJump == false)
            {
                force += 2;
            }

            if(lx.transform.localScale.y > 0.3f)
            {
                isGround = false;
                lx.transform.localScale = new Vector3(lx.transform.localScale.x, lx.transform.localScale.y - 0.02f, lx.transform.localScale.z);
                ninja.transform.position = new Vector3(ninja.transform.position.x, ninja.transform.position.y - 0.008f, ninja.transform.position.z);
            }
        }
        if(isPut == false && first == false && isGround == true)
        {
            if (lx.transform.localScale.y < 1f)
            {
                lx.transform.localScale = new Vector3(lx.transform.localScale.x, lx.transform.localScale.y + 0.02f, lx.transform.localScale.z);
                ninja.transform.position = new Vector3(ninja.transform.position.x, ninja.transform.position.y + 0.008f, ninja.transform.position.z);
            }
            if(d == 0)
            {
                GameObject mh = Instantiate(mohoi, transform.position, Quaternion.identity) as GameObject;
                mh.transform.position = new Vector3(nv.transform.position.x,nv.transform.position.y+1f,nv.transform.position.z);
                d = 1;
            }           
        }

    }
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = ninja.GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        _MakeInstance();
    }

    void _Ninja()
    {
        lx.SetActive(false);
        Debug.Log(force);
        myBody.velocity = new Vector2(force/5,force+5);
        force = 0;
    }


}
