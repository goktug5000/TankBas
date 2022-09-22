using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Govdem : MonoBehaviour
{
    // Start is called before the first frame update
    public int govdemKac;
    public string kimimBen;
    public GameObject bokk;
    void Start()
    {
        try
        {
            govdemKac = GameObject.Find("SceneManager").GetComponent<WhoAmI>().govdeKacBenim;
        }
        catch
        {
            govdemKac = 0;
        }

        //DİĞER TÜM ALT ÇOCUKLARI KAPALI TUT
        gameObject.transform.GetChild(govdemKac).gameObject.SetActive(true);
    }
    public void jumpPoop()
    {
        if (GameObject.Find("SceneManager").GetComponent<WhoAmI>().myRealName == "sena")
        {
            //Debug.Log("senayım");
            if (GameObject.Find("Player").GetComponent<Skor>().skorInt < 0)
            {
                //Debug.Log("<400");
                try
                {
                    var bok = Instantiate(bokk, GameObject.Find("Player").transform.position, Quaternion.identity);
                }
                catch
                {

                }
                

                //bok.transform.parent = gameObject.transform;
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
