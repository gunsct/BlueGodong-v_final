using UnityEngine;
using System.Collections;

public class boss_bullet_control : MonoBehaviour {
	
	public GameObject Player;
	public GameObject Bullet;
	public GameObject Bullet2;
	public GameObject ShootPoint;
	public GameObject ShootPoint2;
	public GameObject ShootPoint3;

	Vector2 boss_pos;
	public Vector2 bullet_dir;
	public int shot_mod = 1;
	public float fire_rate = 0.3f;
	float angle = 10.0f;

	float timer = 0.0f;
	float wait_timer = 10.0f;


	// Use this for initialization
	void Start () {
	}

	void OnEnable()
	{
		StartCoroutine(create (fire_rate));
	}
	void OnDisable()
	{
		StopCoroutine (create (fire_rate));
	}

	// Update is called once per frame
	void Update () {
		boss_pos = gameObject.transform.position;
		timer += Time.deltaTime;
		if (timer > wait_timer) {
			ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
			ShootPoint.transform.position = new Vector2 (boss_pos.x, boss_pos.y - 0.5f);
			ShootPoint2.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
			ShootPoint2.transform.position = new Vector2 (boss_pos.x - 0.85f , boss_pos.y);
			ShootPoint3.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
			ShootPoint3.transform.position = new Vector2 (boss_pos.x + 0.85f , boss_pos.y);
			shot_mod = Random.Range (1, 7);
			timer = 0.0f;
		}
			
		if (shot_mod == 1 || shot_mod == 2)
			fire_rate = 0.3f;
		if (shot_mod == 3 || shot_mod == 6)
			fire_rate = 0.03f;
		if (shot_mod == 4)
			fire_rate = 1.0f;
		if (shot_mod == 5 )
			fire_rate = 0.03f;

	}

	IEnumerator create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);

		switch (shot_mod) {
		case 1:
			Straightshot();
			break;
		case 2:
			Caseshot();
			break;
		case 3:
			Rotate();
			break;
		case 4:
			Simingshot();
			break;
		case 5:
			Dual_Rotate();
			break;
		case 6:
			Triangle_Rotate();
			break;
		}
		StartCoroutine (create (fire_rate));
	}

	void Rotate(){

		ShootPoint.transform.RotateAround (gameObject.transform.position, Vector3.forward, angle);//보스 주변 돌기 
		angle += 3.0f;//도는각 설정해주는거

		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
	}

	void Dual_Rotate(){
		ShootPoint2.transform.rotation =  Quaternion.Euler(0.0f,0.0f,10.0f);
		ShootPoint2.transform.position = new Vector2 (boss_pos.x - 2.0f, boss_pos.y + 0.866f);
		ShootPoint2.transform.RotateAround (gameObject.transform.position, Vector3.forward, angle);//보스 주변 돌기 
		angle += 5.0f;//도는각 설정해주는거

		Instantiate (Bullet, ShootPoint2.transform.position, ShootPoint2.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}

		ShootPoint3.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-10.0f);
		ShootPoint3.transform.position = new Vector2 (boss_pos.x + 2.0f, boss_pos.y + 0.866f);
		ShootPoint3.transform.RotateAround (gameObject.transform.position, Vector3.forward, -angle);//보스 주변 돌기 
		angle += 5.0f;//도는각 설정해주는거

		Instantiate (Bullet2, ShootPoint3.transform.position, ShootPoint3.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
	}

	void Triangle_Rotate(){
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-150.0f);
		ShootPoint.transform.position = new Vector2 (boss_pos.x, boss_pos.y - 0.866f);
		ShootPoint.transform.RotateAround (gameObject.transform.position, Vector3.forward, angle);//보스 주변 돌기 
		angle += 2.0f;//도는각 설정해주는거

		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}

		ShootPoint2.transform.rotation =  Quaternion.Euler(0.0f,0.0f,90.0f);
		ShootPoint2.transform.position = new Vector2 (boss_pos.x - 1.0f, boss_pos.y + 0.866f);
		ShootPoint2.transform.RotateAround (gameObject.transform.position, Vector3.forward, angle);//보스 주변 돌기 
		angle += 2.0f;//도는각 설정해주는거

		Instantiate (Bullet, ShootPoint2.transform.position, ShootPoint2.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}

		ShootPoint3.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-30.0f);
		ShootPoint3.transform.position = new Vector2 (boss_pos.x + 1.0f, boss_pos.y + 0.866f);
		ShootPoint3.transform.RotateAround (gameObject.transform.position, Vector3.forward, angle);//보스 주변 돌기 
		angle += 2.0f;//도는각 설정해주는거

		Instantiate (Bullet, ShootPoint3.transform.position, ShootPoint3.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
	}

	void Caseshot(){
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-40.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산

		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,-20.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,0.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,20.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산

		ShootPoint.transform.rotation =  Quaternion.Euler(0.0f,0.0f,40.0f);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
	}

	
	void Straightshot(){
		ShootPoint.transform.position = new Vector2 (boss_pos.x - 1.6f, ShootPoint.transform.position.y);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.position = new Vector2 (boss_pos.x - 0.8f, ShootPoint.transform.position.y);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.position = new Vector2 (boss_pos.x, ShootPoint.transform.position.y);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
		
		ShootPoint.transform.position = new Vector2 (boss_pos.x + 0.8f, ShootPoint.transform.position.y);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산

		ShootPoint.transform.position = new Vector2 (boss_pos.x + 1.6f, ShootPoint.transform.position.y);
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산
	}

	void Simingshot(){
		bullet_dir = (Player.gameObject.transform.position - gameObject.transform.position).normalized;
		
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}	
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}
		ShootPoint.transform.position = new Vector2 (boss_pos.x - Random.Range (- 3.0f, 3.0f), boss_pos.y + Random.Range (0.5f, 1.0f));
		Instantiate (Bullet, ShootPoint.transform.position, ShootPoint.transform.rotation);//샷포인트에 맞춰 각도도 맞춰 총알생산}

	}
}
		