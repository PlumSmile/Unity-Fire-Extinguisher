using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    public GameObject danger;
	public int dangerCount;
    public float astroWait;
	public Vector3 astroValues;
	public float astroExWait;
	public float astroStart;
    
	public Text GameOvertxt;
	public Text Scoretxt;
    public Text Restarttxt;
    private bool Bo_gameover;
    private bool Bo_restart;
    private bool Bo_quit;
    public int score;

    void Start()
    {
       Bo_gameover = false;
       Bo_restart = false;
	   Bo_quit = true;
       GameOvertxt.text = "";
       Restarttxt.text = "";
       score = 0;       
	   UpdateScore();
       StartCoroutine(AstroWave());
                
    }

   public void AddScore(int newScoreValues){
     score += newScoreValues;
     UpdateScore();    
   }


   void UpdateScore()   //แปลงคะแนน integer เป็นข้อความ
    {
       Scoretxt.text = "Score: "+score.ToString();
    }


   public void GameOver()
	{
        GameOvertxt.text = "GAME OVER";
        Bo_gameover = true;
		Bo_quit = true;


	}
//--------------------------------------------------------------------
   void Update()
	{
      if(Bo_gameover)
	  {
         Bo_restart = true;
		 Bo_quit = true;
         Restarttxt.text = "Press 'R' for Restart";
	  }

      if(Bo_quit)
	  {
         if(Input.GetKey("escape"))
		  {
             Application.Quit();
		  }
	  }

      if(Bo_restart)
	  {
		 if(Input.GetKeyDown(KeyCode.R))
		  {
             Application.LoadLevel(Application.loadedLevel);
		  }
	  }
	}
//--------------------------------------------------------------------

  IEnumerator AstroWave()   //กำหนดการ Random ของวัตถุ
  {    
      yield return new WaitForSeconds(astroStart);   
 
    while(true)   // เล่นวนซ้ำไปเรื่อยๆ  ไม่มีหยุด  แสดงชุดอุกกาบาตทีละชุด  ชุดละ 5 ลูก
	{
     for(int i=0;i<dangerCount;i++){  //วนลูปจำนวนการสร้างอุกกาบาต
   	 //คำสั่งสร้างอุุกกาบาต  และกำหนดตำแหน่ง
	   Vector3 astroPosition = new Vector3(Random.Range(-astroValues.x, astroValues.x), astroValues.y, astroValues.z);
	   Quaternion astroRotation = Quaternion.identity;
       Instantiate(danger ,astroPosition , astroRotation);  //เป็นคำสั่งแสดงอันตรายของวัตถุ อุุกกาบาต  
 
       yield return new WaitForSeconds(astroWait);  // คำสั่งนี้ใช้ในการหยุดเวลาชั่วคราว  หน่วงเวลา  แล้วแต่เราจะกำหนด, คำสั่งนี้ใช้กับ IEnumerator
                                   // ใช้กับ คำสั่ง StartCoroutine
        }
       
      yield return new WaitForSeconds(astroExWait);

	 }
   }
}
