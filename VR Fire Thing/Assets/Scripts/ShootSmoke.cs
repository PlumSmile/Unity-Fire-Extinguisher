using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSmoke : MonoBehaviour
{

    public float speed = 5;
    public GameObject smoke;
    public Transform handle;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Shoot()
    {
        GameObject spawnedsmoke = Instantiate(smoke, handle.position, handle.rotation);
        spawnedsmoke.GetComponent<Rigidbody>().velocity = speed * handle.forward;
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedsmoke, 5);
    }
}
