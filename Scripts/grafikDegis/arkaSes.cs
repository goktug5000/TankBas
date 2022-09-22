using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaSes : MonoBehaviour
{
    // Start is called before the first frame update
    public string RealName;
    public GameObject sfx;
    public GameObject kucukKurbaga;
    public GameObject mutedIcon;
    void Start()
    {
        try
        {
            RealName = GameObject.Find("SceneManager").GetComponent<WhoAmI>().myRealName;
        }
        catch
        {
            RealName = null;
        }

        //DİĞER TÜM ALT ÇOCUKLARI KAPALI TUT
        if (RealName == "onur")
        {
            kucukKurbaga.SetActive(true);
        }
        if (RealName == "ibrahim")
        {
            mutedIcon.SetActive(true);
            sfx.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
