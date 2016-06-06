using UnityEngine;
using System.Collections;

public class enemy_fly : MonoBehaviour
{
	public int maxspd = 1;
	public int minspd = -1;
	float moveX, moveY, moveZ;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//랜덤으로 위치 이동하면서 다가오기 
		System.Random rand = new System.Random (System.DateTime.Now.Millisecond);
		//UnityEngine.Random.Range (min,max);
		//Random rand = new Random ();
		//속도
		float speedX = Random.Range(minspd, maxspd);
		float speedY = Random.Range(minspd, maxspd);
		float speedZ = Random.Range(-5, -10);
		
		//위치
		
		
		moveX = transform.position.x + (speedX * Time.deltaTime);
		moveY = transform.position.y + (speedY * Time.deltaTime);
		moveZ = transform.position.z + (speedZ * Time.deltaTime);
		
		transform.position = new Vector3 (moveX, moveY, moveZ);

		if (gameObject.name == "enemy") {
			transform.position = new Vector3 (0, 50, 300);
		}
		//맵 나갈시 삭제
		if (transform.position.y < 130) {
			if (gameObject.name == "enemy(clone)")
			{
				Destroy (gameObject);
			}
		}
	}
}

