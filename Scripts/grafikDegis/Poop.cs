using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float cd = 2;
    void Update()
    {
        cd -= 1 * Time.deltaTime;
        if (cd <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
