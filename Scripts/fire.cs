using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform dusmanlarParent;
    public GameObject silah,namlu, mermiii;
    public int myMermiVers;
    public AudioSource disin;
    void Start()
    {
        //dusmanlarParent = GameObject.Find("").GetComponent<Transform>();
        try
        {
            myMermiVers = GameObject.Find("SceneManager").GetComponent<WhoAmI>().mermiVersiyonu;
        }
        catch
        {
            myMermiVers = 0;
        }
        
    }

    public Transform dusmanlar(Transform a)
    {
        Transform ennnYakin = null;
        try
        {
            ennnYakin = a.GetChild(0);
            float mesafe = Vector3.Distance(a.GetChild(0).position, GameObject.Find("Player").transform.position);
            float mesafecik;
            foreach (Transform child in a)
            {
                mesafecik = Vector3.Distance(child.position, GameObject.Find("Player").transform.position);
                if (mesafecik < mesafe)
                {
                    mesafe = mesafecik;
                    ennnYakin = child;
                }
            }
        }
        catch
        {
            Debug.Log("fire-> dusmanlar hatası");
            //ennnYakin = new Vector3(99999999999999999,0,0);
        }

        
        return ennnYakin;
    }
    public void aim()
    {
        Vector3 dir = dusmanlar(dusmanlarParent).position - silah.transform.position;

        if (dusmanlar(dusmanlarParent).position.y > gameObject.transform.position.y + 5)
        {
            dir = new Vector3(dusmanlar(dusmanlarParent).position.x, dusmanlar(dusmanlarParent).position.y + 5, dusmanlar(dusmanlarParent).position.z) - silah.transform.position;
        }
        if (dusmanlar(dusmanlarParent).position.y < gameObject.transform.position.y - 5)
        {
            dir = new Vector3(dusmanlar(dusmanlarParent).position.x, dusmanlar(dusmanlarParent).position.y - 5, dusmanlar(dusmanlarParent).position.z) - silah.transform.position;
        }
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        silah.transform.rotation = Quaternion.Euler(0, 0, angle);
        disin.Play();
        
    }
    public void fireee()
    {
        aim();
        var mermi=Instantiate(mermiii, namlu.transform.position, namlu.transform.rotation);
        mermi.GetComponent<Mermi>().friendly = true;
        mermi.GetComponent<Mermi>().vers = myMermiVers;
        /*
        Debug.Log(dusmanlar(dusmanlarParent).position.ToString());
        Debug.Log(silah.transform.position);
        Debug.Log(angle);
        */
        //silah.transform.LookAt(dusmanlar(dusmanlarParent), Vector2.one);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
