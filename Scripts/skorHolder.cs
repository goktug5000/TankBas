using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skorHolder : MonoBehaviour
{
    public int skoru;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
