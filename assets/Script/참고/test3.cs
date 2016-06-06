using UnityEngine;
using System.Collections;

public class test3 : MonoBehaviour {
	
	float timer;
	int waitingTime;
	
	public GameObject gugu;
	
	void Start()
	{
		timer = 0.0f;
		waitingTime = 2;
		
	}
	
	
	
	void Update()
	{
		//transform.Translate (0, -0.1f,0);
		timer += Time.deltaTime;
		if (timer > waitingTime) {
			//Action/////////////
			
			if (gameObject.name == "enemy3")
				Instantiate (gugu, transform.position, transform.rotation); // 오브젝트, 생성위치, 로테이션 값
			
			
			
			///////////
			timer = 0;
			
			
		}
		
		if (gameObject.name == "enemy3(Clone)")
		{
			transform.Translate (0, -0.1f,0);
		}
		
		if (gameObject.name == "enemy3(Clone)")
		{
			if (transform.position.y <-7)
			{
				Destroy(gameObject);
			}
		}
		
	}
	//충돌처리 부분!


	///총알과의 충돌처리!

}