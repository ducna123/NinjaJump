using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    [SerializeField]
    private Text scoreT, endScoreT, bestT;

    [SerializeField]
    private GameObject panelEnd;
    [SerializeField]
    private GameObject panelP;
    [SerializeField]
    private GameObject panelB;


    void Start()
    {

    }

    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Awake()
    {
        _MakeInstance();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _SetPoint(int score)
    {
        scoreT.text = "" + score;
    }

    public void endG(int point)
    {
        //panelP.SetActive(false);
        //panelB.SetActive(false);
        panelEnd.SetActive(true);
        panelP.SetActive(false);
        endScoreT.text = "" + point;
        if (point > GameManaer.instance._GetBest())
        {
            GameManaer.instance._SetBest(point);
            panelB.SetActive(true);
        }
       bestT.text = "" + GameManaer.instance._GetBest();
    }

    public void _reS()
    {
        SceneManager.LoadScene("ninja");
    }
    public void _home()
    {
        SceneManager.LoadScene("Menu");

    }
}
