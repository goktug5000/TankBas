using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private float playerX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerX = player.transform.position.x;
        this.gameObject.transform.position = new Vector3(playerX + 20, 0, -10);
    }
}
