using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverbb : MonoBehaviour
{
    public float speed;
    void Start()
    {
       GetComponent<Rigidbody>().velocity = transform.forward*speed;
	   GetComponent<AudioSource>().Play();
    }

 
}
