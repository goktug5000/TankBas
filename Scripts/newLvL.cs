using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class newLvL : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mySkorHolder;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        string a="";
        if (col.tag == "Player")
        {
            mySkorHolder = GameObject.Find("skorrr");
            mySkorHolder.GetComponent<skorHolder>().skoru = col.gameObject.GetComponent<Skor>().skorInt;

            a = SceneManager.GetActiveScene().name;
            if (a == "level2")
            {
                SceneManager.LoadScene("level3");
            }
            if (a == "level3")
            {
                SceneManager.LoadScene("level4");
            }
            if (a == "level4")
            {
                SceneManager.LoadScene("konusma");
            }
        }
    }
}
