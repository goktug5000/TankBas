using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void newGame()
    {
        SceneManager.LoadScene(1);
        //PLAYER PREFLER RES LENECEK
    }
    public void continueGame()
    {
        SceneManager.LoadScene(1);
    }
    public void oyundanCik()
    {
        Application.Quit();
    }
}
