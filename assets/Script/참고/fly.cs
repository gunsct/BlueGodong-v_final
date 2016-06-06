using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour {

	public float speed=40.0f;
	public float FBspeed=60.0f;
	public GameObject shootPoint;
	public GameObject bullet;
	Vector3 Mpos;
	float turn_speed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//시점 변경 
		Mpos = new Vector3 (-Input.GetAxis ("Mouse Y"),Input.GetAxis ("Mouse X"),0);
		transform.Rotate (Mpos * turn_speed);

		//이동
		float key_Hor = Input.GetAxis ("Horizontal");
		float move_Hor = key_Hor * speed * Time.deltaTime;
		transform.Translate (Vector3.right * move_Hor, Space.World);

		float key_Ver = Input.GetAxis ("Vertical");
		float move_Ver = key_Ver * speed * Time.deltaTime;
		transform.Translate (Vector3.up * move_Ver, Space.World);

		float key_FB = Input.GetAxis ("FowardBack");
		float move_FB = key_FB * FBspeed * Time.deltaTime;
		transform.Translate (Vector3.forward * move_FB, Space.World);

		//충돌박스
		float x = Mathf.Clamp (transform.position.x, -200.0f, 200.0f);
		float y = Mathf.Clamp (transform.position.y, -100.0f, 100.0f);
		float z = Mathf.Clamp (transform.position.z, 0.0f, 300.0f);

		transform.position = new Vector3 (x, y, z);

		//총알 발사
		if (Input.GetButtonDown ("Fire1")) {
			FireBullet ();
		}
	}
		void FireBullet()
		{
			/*bullet = (GameObject)*/Instantiate (bullet, shootPoint.transform.position, Quaternion.identity);
			//위에 생략한거처럼하면 자기복제 미친듯이한다
		}
}
