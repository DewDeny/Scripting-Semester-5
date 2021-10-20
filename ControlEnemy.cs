using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemy : MonoBehaviour
{
     Transform target;
    public float walkSpeed = 2;
    public float turnSpeed = 360;
    Vector3 direction;
    bool walk = false;

     void Start()
    {
        
    }

    void Update()
    {
        direction = (target.right - transform.right) + (target.forward - transform.forward);
        if (walk==true)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turnSpeed * Time.deltaTime);

            transform.Translate(transform.forward * walkSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "StoneThrow")
        {
            target = other.transform;
            walk = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "StoneThrow")
        {
            walk = false;
            collision.gameObject.tag = "Stone";
        }
    }
}
