﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
  
     public float speed;
	GameObject player;
	private Rigidbody rb;
	public float tilt;
    
	public GameObject EnemyBolt;	
    public Transform EnemyShooting;
    
	public GameObject playerExplosion;
   public GManager gameController;

    void Start()
    {
 
       rb = GetComponent<Rigidbody>();
	   player =  GameObject.FindGameObjectWithTag("Player");
       InvokeRepeating("OnShooting", 1f, 2f);
    }


    void OnShooting()
    {
       Instantiate(EnemyBolt,EnemyShooting.position,Quaternion.identity);
    }



   void FixedUpdate()
    {
       if (player != null)   // กำหนดให้ศัตรูเคลื่อนที่ไปหาผู้เล่น Player 
       {
		   float moveX = 0f;

		   if (Mathf.Round(player.transform.position.x)>Mathf.Round(transform.position.x))
		   {
			  moveX=1f;   // กำหนดให้ Player เคลื่อนที่ไปแดนยวก  ศัตรูจะเคลื่อนที่ตามไปด้วย
		   }
			else if (Mathf.Round(player.transform.position.x)<Mathf.Round(transform.position.x))
		   {
			  moveX=-1f;    // กำหนดให้ Player เคลื่อนที่ไปแดนลบ  ศัตรูจะเคลื่อนที่ตามไปด้วย
		   }

		   rb.velocity = new Vector3(moveX,0f,-1f)*speed;  //การทำให้ศัตรูเคลื่อนที่เร็วขึ้น  เพราะไปคูณกับความเร็ว speed
           rb.rotation = Quaternion.Euler(0f,180f,rb.velocity.x*tilt); //การเอียงของยานเมื่อมีการเคลื่อนที่
        
       }
    }
}
