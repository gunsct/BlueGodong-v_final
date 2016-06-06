using UnityEngine;
using System.Collections;

public class player_move : MonoBehaviour {
	public float speed = 1.2f;
	public GameObject Bullet;
	public GameObject ShootPoint;
	public GameObject Dron1;
	public GameObject Dron2;
	
	public float fire_rate = 0.2f;
	public int shot_mod = 1;
	
	public float item1_p = 0.0f;
	public float item2_p = 0.0f;
	public float item3_p = 0.0f;

	AudioClip sound;
	public AudioClip i1_s;
	public AudioClip i2_s;
	public AudioClip i3_s;
	public AudioClip item_s;
	public AudioClip powerup;

	public bool stat;
	bool sh;
	float timer;
	float imotal_time = 2.5f;
	
	// Use this for initialization
	void Start () {
	}
	void OnEnable()
	{
		stat = true;
		StartCoroutine(bullet_p (fire_rate));
	}
	void OnDisable()
	{
		stat = false;
		StopCoroutine (bullet_p (fire_rate));
	}
	// Update is called once per frame
	void Update () {
		sh = GetComponent<player_shield> ().sh;
		timer += Time.deltaTime;

		Movement ();
	}
	
	void Movement()
	{
		Vector2 TDP = Input.GetTouch (0).deltaPosition;
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position), Vector2.zero);//터치한지점에서 수직으로 꽂는다는거다
			if (hit && hit.collider.gameObject == this.gameObject) {
				this.gameObject.transform.Translate (TDP.x * speed * Time.deltaTime, TDP.y * speed * Time.deltaTime, 0.0f, Space.World);
			}
		}
		//이동 제한
		transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -2.8f, 2.8f), Mathf.Clamp (transform.position.y, -4.5f, 4.5f));
	}	
	
	
	//총알 자동발사
	IEnumerator bullet_p(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		
		//GetComponent<AudioSource>().Play ();//쏠때마다 소리남
		switch (shot_mod) {
		case 1:
			sound = i1_s;
			AudioSource.PlayClipAtPoint(sound, new Vector3(5, 1, 2));
			Dron1.SetActive(false);
			Dron2.SetActive(false);
			Instantiate (Bullet, ShootPoint.transform.position, Quaternion.identity);
			break;
		case 2:
			sound = i2_s;
			AudioSource.PlayClipAtPoint(sound, new Vector3(5, 1, 2));
			Dron1.SetActive(false);
			Dron2.SetActive(false);
			Caseshot ();
			break;
		case 3:
			sound = i3_s;
			AudioSource.PlayClipAtPoint(sound, new Vector3(5, 1, 2));
			Dron1.SetActive(true);
			Dron2.SetActive(true);
			Rotatedron();
			break;
		}
		StartCoroutine(bullet_p (fire_rate));
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		//죽었다 다시살아나면  2.5초 무적
		if (timer > imotal_time) {
			if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "enemy_bullet" ) {
				Handheld.Vibrate ();
				if (sh == false) {
					gameObject.SetActive (false);
					timer = 0.0f;
				}
			}
		}
		//파워아이템먹으면 더 쌔져
		if (other.gameObject.name == "item1(Clone)") {
			sound = item_s;
			AudioSource.PlayClipAtPoint(sound, new Vector3(5, 1, 2));
			shot_mod = 1;
			if(item1_p < 2.0f)
				fire_rate = 0.2f;

			if(item1_p >= 2.0f || item1_p < 4.0f)
				fire_rate = 0.15f;

			if(item1_p == 4.0f)
				fire_rate = 0.1f;

			if(item1_p < 4.0f)
				item1_p += 0.5f;

			item2_p = 0.0f;
			item3_p = 0.0f;
		}
		if (other.gameObject.name == "item2(Clone)") {
			sound = item_s;
			AudioSource.PlayClipAtPoint(sound, new Vector3(5, 1, 2));
			shot_mod = 2;
			fire_rate = 0.05f;
			if(item2_p <= 0.27f)
				item2_p += 0.03f;
			item1_p = 0.0f;
			item3_p = 0.0f;
		}
		if (other.gameObject.name == "item3(Clone)") {
			sound = item_s;
			AudioSource.PlayClipAtPoint(sound, new Vector3(5, 1, 2));
			shot_mod = 3;
			fire_rate = 0.1f;
			if(item3_p <= 1.35f)
				item3_p += 0.15f;
			item1_p = 0.0f;
			item2_p = 0.0f;
		}
		/*if (item3_p == 0.6f || item3_p == 1.5f || item2_p == 0.12f || item2_p == 0.21f || item1_p == 1.2f || item1_p == 2.1f) {
			sound = powerup;
			AudioSource.PlayClipAtPoint (sound, new Vector3 (5, 1, 2));
		}*/
	}
	
	void Caseshot(){
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-20.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-10.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,10.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,20.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
	}
	
	void Rotatedron(){
		Instantiate (Bullet, ShootPoint.transform.position, Quaternion.identity);
		
		Dron1.transform.RotateAround (gameObject.transform.position, Vector3.forward, 20.0f);//보스 주변 돌기
		Dron1.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
		Instantiate (Bullet, Dron1.transform.position, Dron1.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		Dron2.transform.RotateAround (gameObject.transform.position, Vector3.forward, -20.0f);//보스 주변 돌기
		Dron2.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
		Instantiate (Bullet, Dron2.transform.position, Dron2.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
	}
}

