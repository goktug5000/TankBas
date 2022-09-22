using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Move : MonoBehaviour
{
    public int jumpLeft = 2;
    public float speed = 30;
    private float padAcisi;
    private FixedJoystick joystickFixed;
    public Animator myAnim;
    public AudioSource Hoppa;
    // Start is called before the first frame update
    void Start()
    {
        joystickFixed = GameObject.Find("Fixed Joystick").GetComponent<FixedJoystick>();
        myAnim.SetBool("move", false);
    }

    
    // Update is called once per frame
    void Update()
    {


        if (joystickFixed.Vertical != 0 && joystickFixed.Horizontal != 0)
        {
            //speed = Convert.ToSingle(Math.Sqrt(joystickFixed.Vertical * joystickFixed.Vertical + joystickFixed.Horizontal * joystickFixed.Horizontal));
            padAcisi = Convert.ToSingle(joystickFixed.Horizontal);
        }
        if (joystickFixed.Vertical != 0 && joystickFixed.Horizontal != 0)
        {
            this.transform.Translate(padAcisi * speed * Time.deltaTime, 0, 0);
            myAnim.SetBool("move", true);
        }
        else
        {
            myAnim.SetBool("move", false);
        }






    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            jumpLeft = 2;
        }


    }
    public void jump()
    {
        if (jumpLeft > 0)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
            jumpLeft--;
            Hoppa.Play();
        }
        
    }
}
