using UnityEngine;
using System.Collections;

public class test5 : MonoBehaviour {
	
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
			
			if (gameObject.name == "enemy5")
				Instantiate (gugu, transform.position, transform.rotation); // 오브젝트, 생성위치, 로테이션 값
			
			
			
			///////////
			timer = 0;
			
			
		}
		
		if (gameObject.name == "enemy5(Clone)")
		{
			transform.Translate (0, -0.1f,0);
		}
		
		if (gameObject.name == "enemy5(Clone)")
		{
			if (transform.position.y <-7)
			{
				Destroy(gameObject);
			}
		}
		
	}
}