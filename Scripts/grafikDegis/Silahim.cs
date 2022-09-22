using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silahim : MonoBehaviour
{
    // Start is called before the first frame update
    public int silahimKac;
    void Start()
    {
        try
        {
            silahimKac = GameObject.Find("SceneManager").GetComponent<WhoAmI>().silahimKacBenim;
        }
        catch
        {
            silahimKac = 0;
        }

        //DİĞER TÜM ALT ÇOCUKLARI KAPALI TUT
        gameObject.transform.GetChild(silahimKac).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
