using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plants : MonoBehaviour
{
    public GameObject of;
    public GameObject but;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            of.SetActive(false);
            but.SetActive(true);
        }
        
    }
}
