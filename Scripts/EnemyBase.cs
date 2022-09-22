using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bir, iki, uc;
    public int b = 1;
    void Start()
    {
        
    }
    public float spawnCD;
    // Update is called once per frame
    void Update()
    {
        string lastCharacter = SceneManager.GetActiveScene().name.Substring(SceneManager.GetActiveScene().name.Length - 1);
        b = int.Parse(lastCharacter);
        spawnCD -= b * Time.deltaTime;
        if (spawnCD <= 0)
        {
            spawn();
        }
        
        
    }
    public void spawn()
    {
        int a;
        a = Random.Range(1, 3);

        
        if (a == 1)
        {
            var enem = Instantiate(bir, new Vector3(1000, Random.Range(-8, 13), 0), Quaternion.identity);

            enem.transform.parent = gameObject.transform;
        }
        if (a == 2)
        {
            var enem = Instantiate(iki, new Vector3(1000, Random.Range(-8, 5), 0), Quaternion.identity);

            enem.transform.parent = gameObject.transform;
        }


        spawnCD = Random.Range(1, 15);
    }
}
