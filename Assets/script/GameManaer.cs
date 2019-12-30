using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManaer : MonoBehaviour {
    public static GameManaer instance;
    private const string best = "High";
    // Use this for initialization
    void Awake()
    {
        _MakeSingleInstance();
    }


    void _FirstTime()
    {
        if (!PlayerPrefs.HasKey("_FirstTime"))
        {
            PlayerPrefs.SetInt(best, 0);
            PlayerPrefs.SetInt("_FirstTime", 0);
        }
    }

    void _MakeSingleInstance()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
    }

    public void _SetBest(int point)
    {
        PlayerPrefs.SetInt(best, point);
    }

    public int _GetBest()
    {
        return PlayerPrefs.GetInt(best);
    }

    public void _play()
    {
        SceneManager.LoadScene("ninja");
    }

}
