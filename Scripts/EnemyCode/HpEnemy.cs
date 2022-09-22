using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemy : MonoBehaviour
{
    public float HP;
    public GameObject playerr;

    public int skorKatkım;
    // Start is called before the first frame update
    void Start()
    {
        playerr = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(this.gameObject);
            playerr.GetComponent<Skor>().skorGuncelle(skorKatkım);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(this.gameObject.name + "'a vurdu " + col.gameObject.tag);
        if (col.gameObject.tag == "hit")
        {
            HP -= 5;
            Destroy(col.gameObject);
            //Debug.Log(this.gameObject.name + " vuruldu");

        }
        

    }
}
