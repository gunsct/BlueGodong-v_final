using UnityEngine;
using System.Collections;

public class boss_Move : MonoBehaviour {
	public float speed=1f;
	float waitingTime = 2.0f;
	float timer=0.0f;
	int select = 1;
	int a1=0;

	//int a=0; //pattern 1
	//	float sx=-2.7f;//pattern 1


	//float sx1=-2.7f;
	
	void Start () {
		select = Random.Range(1,4);

	}

	void Update () {


		if (select == 1)
		{
			if (a1 == 0) {
				speed = 6;
				transform.Translate (0, Time.deltaTime * -speed, 0);
			
				if (transform.position.y < -0.0f) {
					transform.position = new Vector2 (0, -0.0f);//왼쪽 벽 충돌설정.
				
					timer += Time.deltaTime;//2초 후에 다음으로 이동!
					if (timer > waitingTime) {
						a1 = 1;
						//sx1=0;
						timer = 0;
					}
				}
			}
			///////////////////////////////////////////////////////////////
		
			if (a1 == 1) {
			
				speed = 1;
				transform.Translate (0, Time.deltaTime * speed, 0);
			
				if (transform.position.y > 4.0f) {//오른쪽 충돌처리
					transform.position = new Vector2 (transform.position.x, 4.0f);
					timer+=Time.deltaTime;
					if(timer>waitingTime)
					{

						timer=0;
						select = Random.Range(1,4);
						a1 = 0;

					}
			
				}
			
			}


		}

		if (select == 2)
		{
			if (a1 == 0) {
				transform.Translate (Time.deltaTime * -3, 0, 0);
				
				if (transform.position.x <-2.3f) {//왼쪽 충돌처리
					transform.position = new Vector2 (-2.3f, transform.position.y);//왼쪽 벽 충돌설정.
					timer+=Time.deltaTime;
					if(timer>waitingTime)
					{
					a1=1;
						timer=0;
	
					}
				}
			}
			
			/////////////////////왼쪽으로 이동!///////////////////////////////////
			if (a1 == 1) {

				transform.Translate (Time.deltaTime * 3, Time.deltaTime * -3, 0);
				
				if (transform.position.y < 1.5f) 
				{
					transform.position = new Vector2 (0.5f,1.5f);//왼쪽 벽 충돌설정.
					a1=2;
				
				}
			}
			
			///////////////////////////////////////////////////////////////////////오른쪽 아래로 이동!
			if (a1 == 2) {
	
				transform.Translate (Time.deltaTime * 3, Time.deltaTime * 3, 0);
				
				if (transform.position.x > 2.5f) {//오른쪽 충돌처리
					transform.position = new Vector2 (2.5f, 3.5f);
					timer+=Time.deltaTime;
					if(timer>waitingTime)
					{
					a1=3;
					timer=0;
					}
				}
				
			}
			////////////////////////////////////////////////////////////////////////원점으로
			
			if (a1 == 3) {
		
				transform.Translate (Time.deltaTime *-3, 0, 0);
				
				if (transform.position.x < 0) {//오른쪽 충돌처리
					transform.position = new Vector2 (0, 3.5f);
					timer+=Time.deltaTime;
					if(timer>waitingTime)
					{
						timer=0;
						select = Random.Range(1,4);
						a1 = 0;
						waitingTime=3;
					}
				}
				
			}
		}





		if (select == 3)
		{
			if (a1 == 0) 
			{
				transform.Translate (Time.deltaTime * -3, Time.deltaTime * -2f, 0);
				
				if (transform.position.x < -2.7f) 
				{
					transform.position = new Vector2 (-2.7f, 2.3f);//왼쪽 벽 충돌설정.

						a1=1;
				
				}
			}
			///////////////////////////////////////////////////////////////
			
			if (a1 == 1) 
			{
				transform.Translate (Time.deltaTime * 2, Time.deltaTime * -2f, 0);
				
				if (transform.position.x > 2) 
				{
					transform.position = new Vector2 (2, -2f);// 충돌설정.
					a1=2;
					

				
				}
			}
			////////////////////////////////////////////////////////////////////////////
			if (a1 == 2) 
			{
				transform.Translate (Time.deltaTime * -3, Time.deltaTime * 3f, 0);
				
				if (transform.position.x < -2.3f) 
				{
					transform.position = new Vector2 (-2.3f, 2.3f);// 충돌설정.

					a1=3;
					
					
				}
			}
			
			///////////////////////////////////////////////////////////////////////////
			
			if (a1 == 3) 
			{
				transform.Translate (Time.deltaTime * 1, Time.deltaTime * 0.5f, 0);
				
				if (transform.position.x > 0) 
				{
					timer+=Time.deltaTime;
					if(timer>waitingTime)
					{
					transform.position = new Vector2 (0, 3.4f);// 충돌설정.
					select = Random.Range(1,4);
						timer=0;
						waitingTime=1;
					a1=0;					
					}
				}
			}

		}












		
		
	}
}








/*pattern 1

		if (a == 0) {
			transform.Translate (Time.deltaTime * -speed, 0, 0);

			if (transform.position.x < sx) {//왼쪽 충돌처리
			//	transform.position = new Vector2 (transform.position.x, transform.position.y);//왼쪽 벽 충돌설정.
				a=1;
				sx=2.5f;
				
			}
					}

		/////////////////////왼쪽으로 이동!///////////////////////////////////
		if (a == 1) {
			speed = 3;
			transform.Translate (Time.deltaTime * speed, Time.deltaTime * -speed, 0);

			if (transform.position.y < 1.5f) {//왼쪽 충돌처리
			//	transform.position = new Vector2 (transform.position.x, transform.position.y);//왼쪽 벽 충돌설정.
				a=2;
			}
					}

		///////////////////////////////////////////////////////////////////////오른쪽 아래로 이동!
		if (a == 2) {
			speed = 3;
			transform.Translate (Time.deltaTime * speed, Time.deltaTime * speed, 0);
		
			if (transform.position.x > sx) {//오른쪽 충돌처리
				//transform.position = new Vector2 (transform.position.x, transform.position.y);
				a=3;
				sx=0;
		}

				}
		////////////////////////////////////////////////////////////////////////원점으로

		 	if (a == 3) {
		speed = 3;
		transform.Translate (-Time.deltaTime * speed, 0, 0);
		
		if (transform.position.x < sx) {//오른쪽 충돌처리
			//transform.position = new Vector2 (transform.position.x, transform.position.y);
			a=4;
			sx=0;
		}
		
	}
	*/



/*pattern 2

		if (a1 == 0) 
		{
			transform.Translate (Time.deltaTime * -speed, Time.deltaTime * -2f, 0);
			
			if (transform.position.x < sx1) 
			{
				transform.position = new Vector2 (-2.7f, 2.4f);//왼쪽 벽 충돌설정.

				timer += Time.deltaTime;//2초 후에 다음으로 이동!
				if (timer > waitingTime) 
				{
					a1=1;
					sx1=0;
					timer=0;
				}
			}
		}
		///////////////////////////////////////////////////////////////

		if (a1 == 1) 
		{
			transform.Translate (Time.deltaTime * speed, Time.deltaTime * -2f, 0);
			
			if (transform.position.x > sx1) 
			{
				//transform.position = new Vector2 (-2.7f, 2.4f);// 충돌설정.
				a1=2;

					sx1=2.5f;
					timer=0;
			}
		}
		////////////////////////////////////////////////////////////////////////////
		if (a1 == 2) 
		{
			transform.Translate (Time.deltaTime * speed, Time.deltaTime * 2f, 0);
			
			if (transform.position.x > sx1) 
			{
				//transform.position = new Vector2 (-2.7f, 2.4f);// 충돌설정.
				sx1=0;
				a1=3;

	
			}
		}

		///////////////////////////////////////////////////////////////////////////

		if (a1 == 3) 
		{
			transform.Translate (-Time.deltaTime * speed, Time.deltaTime * 2f, 0);
			
			if (transform.position.x < sx1) 
			{
				//transform.position = new Vector2 (-2.7f, 2.4f);// 충돌설정.
				a1=4;
				
				
			}
		}
 
*/