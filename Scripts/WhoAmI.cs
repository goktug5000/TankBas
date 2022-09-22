using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhoAmI : MonoBehaviour
{
    public string myRealName;
    public float maxHP;
    public int mermiVersiyonu;
    public int kafamKacBenim;
    public int govdeKacBenim;
    public int silahimKacBenim;
    public GameObject deneme;

    public string sceneName, currentScene;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        deneme = GameObject.Find("Player");
    }
    public void goktug()
    {
        myRealName = "goktug";
        maxHP = 100000000000000;
        mermiVersiyonu = 0;
        kafamKacBenim = 11;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void berk()
    {
        myRealName = "berk";
        maxHP = 10;
        mermiVersiyonu = 0;
        kafamKacBenim = 1;
        govdeKacBenim = 1;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void ceren()
    {
        myRealName = "ceren";
        maxHP = 10;
        mermiVersiyonu = 5;
        kafamKacBenim = 2;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void cihan()
    {
        myRealName = "cihan";
        maxHP = 10;
        mermiVersiyonu = 6;
        kafamKacBenim = 3;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void elif()
    {
        myRealName = "elif";
        maxHP = 10;
        mermiVersiyonu = 3;
        kafamKacBenim = 4;
        govdeKacBenim = 0;
        silahimKacBenim = 1;
        loadLevelOne();
    }
    public void irem()
    {
        myRealName = "irem";
        maxHP = 10;
        mermiVersiyonu = 2;
        kafamKacBenim = 5;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void pinar()
    {
        myRealName = "pinar";
        maxHP = 10;
        mermiVersiyonu = 0;
        kafamKacBenim = 6;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void onur()
    {
        myRealName = "onur";
        maxHP = 10;
        mermiVersiyonu = 0;
        kafamKacBenim = 9;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void ibrahim()
    {
        myRealName = "ibrahim";
        maxHP = 10;
        mermiVersiyonu = 0;
        kafamKacBenim = 7;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void sena()
    {
        myRealName = "sena";
        maxHP = 10;
        mermiVersiyonu = 0;
        kafamKacBenim = 10;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void kubra()
    {
        myRealName = "kubra";
        maxHP = 10;
        mermiVersiyonu = 4;
        kafamKacBenim = 8;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }
    public void burak()
    {
        myRealName = "burak";
        maxHP = 10;
        mermiVersiyonu = 0;
        kafamKacBenim = 12;
        govdeKacBenim = 0;
        silahimKacBenim = 0;
        loadLevelOne();
    }

    public void loadLevelOne()
    {
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        sceneName = "level2";
        loadTheLevel();

    }
    public void loadTheLevel()
    {
        DontDestroyOnLoad(this.gameObject);


        SceneManager.LoadScene(sceneName);


        if (SceneManager.GetActiveScene().name != sceneName)
        {
            StartCoroutine("waitForSceneLoad", sceneName);
        }
        Debug.Log("sanırım yükledim");

        //beniDiz();
    }
    public void beniDiz()
    {
        //GameObject.Find("Player").GetComponent<fire>().myMermiVers = mermiVersiyonu;
        
        //GameObject.Find("Player").GetComponent<fire>().myMermiVers = mermiVersiyonu;
    }

    IEnumerator waitForSceneLoad(string mySceneName)
    {
        while (SceneManager.GetActiveScene().name != mySceneName)
        {
            yield return null;
        }

        // Do anything after proper scene has been loaded
        if (SceneManager.GetActiveScene().name == mySceneName)
        {
            Debug.Log(SceneManager.GetActiveScene().name);

        }
        currentScene = mySceneName;
    }
}
