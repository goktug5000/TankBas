using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kafam : MonoBehaviour
{
    // Start is called before the first frame update
    public int kafamKac;
    void Start()
    {

        try
        {
            kafamKac = GameObject.Find("SceneManager").GetComponent<WhoAmI>().kafamKacBenim;
        }
        catch
        {
            kafamKac = 0;
        }

        //DİĞER TÜM ALT ÇOCUKLARI KAPALI TUT
        gameObject.transform.GetChild(kafamKac).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
