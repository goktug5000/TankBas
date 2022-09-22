using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonaGec : MonoBehaviour
{
    // Start is called before the first frame update
    public float a;
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        if (a >= 30)
        {
            SceneManager.LoadScene("highScore");
        }
    }
}
