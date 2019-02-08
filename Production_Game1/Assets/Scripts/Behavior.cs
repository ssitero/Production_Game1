using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
   // private RigidBody rb;

    // Use this for initialization
    void Start()
    {
       // rb = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pick Up"))
        {

            other.gameObject.SetActive(false);
        }

    }
}
