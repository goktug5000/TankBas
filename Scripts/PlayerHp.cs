using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    // Start is called before the first frame update
    public float HP;
    public float maxHP;
    public float regenHP;
    public GameObject HPbar;
    public GameObject bastanBasla;
    void Start()
    {
        /*
        bastanBasla.SetActive(false);
        try
        {
            HPbar = GameObject.Find("Green");
        }
        catch
        {

        }
        try
        {
            bastanBasla = GameObject.Find("bastan");
        }
        catch
        {

        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Time.timeScale = 0;
            bastanBasla.SetActive(true);
        }
        HPbar.transform.localScale = new Vector3((HP / maxHP), 1, 1);
    }
    public void bastanBaslaaa()
    {
        Time.timeScale = 1;
        HP = maxHP;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void hpBarGuncelle()
    {

        //HPbar.GetComponent<RectTransform>().localScale = new Vector2((HP/ maxHP), 1);
    }
    public void ZumZum(float dmgg)
    {
        //Debug.Log(dmgg);
        HP -= dmgg;
        hpBarGuncelle();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.tag);
        if (col.tag == "hit")
        {
            if(false == col.gameObject.GetComponent<Mermi>().friendly)
            {
                ZumZum(col.gameObject.GetComponent<Mermi>().dmg);
            }
        }  
    }
}
