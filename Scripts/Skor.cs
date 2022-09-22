using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public Text skorUmuz;
    public int skorInt;

    // Start is called before the first frame update
    void Start()
    {
        skorInt = GameObject.Find("skorrr").GetComponent<skorHolder>().skoru;
        skorUmuz.text = skorInt.ToString();
    }
    public void skorGuncelle(int skorDegisimi)
    {
        skorInt += skorDegisimi;
        skorUmuz.text = skorInt.ToString();
    }
    public void atisBedeli()
    {
        skorGuncelle(-5);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
