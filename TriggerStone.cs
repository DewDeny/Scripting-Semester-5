using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStone : MonoBehaviour
{
    bool awake = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            gameObject.tag = "StoneThrow";
            awake = false;
        }
        if (collision.gameObject.tag == "Babi"| collision.gameObject.tag == "Player")
        {
            gameObject.tag = "Stone";
        }
    }
}
