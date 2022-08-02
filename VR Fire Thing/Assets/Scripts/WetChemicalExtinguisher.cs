using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BF2000Extinguisher : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "FireTypeA")
        {
            Debug.Log("FireA collision dectected");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "FireTypeK")
        {
            Debug.Log("FireK collision dectected");
            Destroy(collision.gameObject);
        }
    }
}