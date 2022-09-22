using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ucan : MonoBehaviour
{
    public float myDMG;
    public float hiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-hiz * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerHp>().ZumZum(myDMG);
            Debug.Log("adama vurdum");
            
        }


    }
}
