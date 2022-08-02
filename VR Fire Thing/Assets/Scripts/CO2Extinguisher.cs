using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CO2Extinguisher : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FireTypeB")
        {
            Debug.Log("FireB collision dectected");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "FireTypeC")
        {
            Debug.Log("FireC collision dectected");
            Destroy(collision.gameObject);
        }
    }
}