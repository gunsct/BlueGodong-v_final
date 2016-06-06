using UnityEngine;
using System.Collections;
using System;
//using System.Windows.Forms;
//using System.Drawing;

public class bullet : MonoBehaviour {

	public float speed = 100.0f;
	float spdX,spdY,spdZ;
	float moveX, moveY, moveZ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	/*	spdX = -Input.GetAxis ("Mouse Y") * speed;
		spdY =  Input.GetAxis ("Mouse X") * speed;
		spdZ =  Input.GetAxis ("Mouse Z") * speed;

		moveX = transform.position.x + (spdX * Time.deltaTime);
		moveY = transform.position.y + (spdY * Time.deltaTime);
		moveZ = transform.position.z + (spdZ * Time.deltaTime);

		transform.Translate (moveX,moveY,moveZ,Space.World);*/
		transform.Translate (Vector3.forward * speed*Time.deltaTime, Space.World);

		//GameObject clone = (GameObject)Instantiate (missile, transform.position, Quaternion.identity);
		//이건 플라이쪽에 총알 생성에나 응용하고

		//충돌판정
		//맵 나가면 삭제
		if (transform.position.z > 200) 
		{
			if( gameObject.name == "bullet(Clone)")
			{
				Destroy(gameObject);
			}
		}
	}
}
		
	