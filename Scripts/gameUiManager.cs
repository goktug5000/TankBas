using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameUiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuPanel;
    private bool menuB;
    void Start()
    {
        menuB = false;
        menuPanel.SetActive(false);
    }
    public void menuAc()
    {
        menuB = !menuB;
        menuPanelGuncelle();
    }
    public void menuPanelGuncelle()
    {
        if (menuB == true)
        {
            Time.timeScale = 0;
        }
        if (menuB == false)
        {
            Time.timeScale = 1;
        }
        menuPanel.SetActive(menuB);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
