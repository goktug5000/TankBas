using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScoreScene : MonoBehaviour
{
    public string whoIAm;
    public GameObject bir, iki, uc;
    // Start is called before the first frame update
    void Start()
    {
        whoIAm = GameObject.Find("SceneManager").GetComponent<WhoAmI>().myRealName;
        bir.SetActive(true);
        iki.SetActive(false);
        uc.SetActive(false);
        if (whoIAm== "goktug")
        {
            bir.SetActive(false);
            iki.SetActive(true);
            uc.SetActive(false);
        }
        if (whoIAm == "burak")
        {
            bir.SetActive(false);
            iki.SetActive(false);
            uc.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
