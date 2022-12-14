using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBolt : MonoBehaviour
{
   public GameObject playerExplosion;
   public GManager gameController;
   public float speed;
    

    void Start()
    {
       GetComponent<Rigidbody>().velocity = transform.forward*speed;
       GameObject gameControllerObject= GameObject.FindGameObjectWithTag("GameController");
  
     if(gameControllerObject != null)
		{
		 gameController = gameControllerObject.GetComponent<GManager>();
		}
	 if(gameControllerObject == null)
		{
		 Debug.Log("Cannot find 'GameController' script");
		}
	  GetComponent<AudioSource>().Play();
    }

    void OnTriggerEnter(Collider other)
	{
       	 
       if(other.gameObject.CompareTag("Player"))
		{
		   GetComponent<AudioSource>().Play(); 
           Instantiate(playerExplosion ,transform.position, transform.rotation);  
		   gameController.GameOver();
		     
           Destroy (gameObject);    // ลบตัวเอง   gameObject เราพิมพ์เดี่ยวๆ  หมายถึงทำลายตัวเอง
           Destroy (other.gameObject); //ลบของที่ชน
		}
	}
}
