using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAstoroid : MonoBehaviour
{
  public GameObject playerExplosion;

	void OnTriggerEnter(Collider other)
	{
       	 
       if(other.gameObject.CompareTag("Fire Type A"))
		{
		    GetComponent<AudioSource>().Play(); 
           Instantiate(playerExplosion ,transform.position, transform.rotation);
          
		}

      Destroy (gameObject);    // ลบตัวเอง   gameObject เราพิมพ์เดี่ยวๆ  หมายถึงทำลายตัวเอง
      Destroy (other.gameObject); //ลบของที่ชน
	}
}
