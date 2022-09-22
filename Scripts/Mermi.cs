using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    // Start is called before the first frame update
    public float dmg;
    public bool friendly;
    public float speed;
    public int vers;
    void Start()
    {
        //DİĞER TÜM ALT ÇOCUKLARI KAPALI TUT
        gameObject.transform.GetChild(vers).gameObject.SetActive(true);

    }
    private float cd = 2;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        cd-= 1 * Time.deltaTime;
        if (cd <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
