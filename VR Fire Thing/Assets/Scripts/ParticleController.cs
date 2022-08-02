/* 
 This script can be placed on an empty game object.

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    public GameObject explosion;
    public GameObject fire;

    public GameObject balloonPop;
    public GameObject waterDrop;

    public List<GameObject> particles = new List<GameObject>();
    public List<GameObject> explosionParticles = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (particles.Count > 0)
        {
            // clean up any particles that have stopped playing
            // **Creating and Destroying gameObjects is not effcient if happening a lot, better to create an object pool to reuse objects.
            if (!particles[0].GetComponent<ParticleSystem>().isPlaying)
            {
                Destroy(particles[0]);
                particles.Remove(particles[0]);
            }
        }
        // gradually reduce explosion particles
        if (explosionParticles.Count > 0)
        {
            if (!explosionParticles[0].GetComponent<ParticleSystem>().isPlaying)
            {
                PlayFire(explosionParticles[0].transform.position);
                Destroy(explosionParticles[0]);
                explosionParticles.Remove(explosionParticles[0]);
            }
        }
    }

    public void PlayExplosion(Vector3 position)
    {
        GameObject temp = Instantiate(explosion);
        temp.transform.position = position;
        explosionParticles.Add(temp);
    }
    public void PlayFire(Vector3 position)
    {
        GameObject temp = Instantiate(fire);
        temp.transform.position = position;
        particles.Add(temp);
    }
    public void PlayBalloonPop(Vector3 position)
    {
        GameObject temp = Instantiate(balloonPop);
        temp.transform.position = position;
        particles.Add(temp);
    }
    public void PlayWaterDrop(Vector3 position)
    {
        GameObject temp = Instantiate(waterDrop);
        temp.transform.position = position;
        particles.Add(temp);
    }
}
