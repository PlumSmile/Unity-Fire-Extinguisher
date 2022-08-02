using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BF2000Smoke : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FireTypeA")
        {
            Debug.Log("FireA collision dectected");
            Destroy(collision.gameObject);
        }
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
        if (collision.gameObject.name == "FireTypeD")
        {
            Debug.Log("FireD collision dectected");
            Destroy(collision.gameObject);
        }
    }
}
