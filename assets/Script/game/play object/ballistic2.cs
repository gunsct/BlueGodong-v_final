using UnityEngine;
using System.Collections;

public class ballistic2 : MonoBehaviour {
	public GameObject Boss;
	public GameObject ShotPoint;
	
	public float bsd = 2.0f;
	Vector2 ball_dir;
	float timer = 0.0f;
	float mod_limit = 0.1f;
	int mod;
	
	public Sprite str;
	public Sprite ball;
	public Sprite ball2;
	private SpriteRenderer myRenderer;
	// Use this for initialization
	void Start () {
	}
	
	void OnDisable(){
		if (gameObject.name == "boss_bullet2(Clone)")
			Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer < mod_limit) 
			mod = Boss.GetComponent<boss_bullet_control> ().shot_mod;
		myRenderer = gameObject.GetComponent<SpriteRenderer>();
		
		if (gameObject.name == "boss_bullet2(Clone)") {
			if(mod == 1 || mod == 2)bsd = 2.0f;
			if(mod == 3 || mod == 4 || mod == 5)bsd = 1.5f;
			
			if (mod == 1 || mod == 2 || mod == 3 || mod == 5 || mod == 6) {
				ball_dir = transform.up;//생성될때 이미 방향도 돌려져있으니 보는 방향으로 발사
			}
			
			if(mod == 4){
				ball_dir = -Boss.GetComponent<boss_bullet_control> ().bullet_dir;
			}
			gameObject.transform.Translate (ball_dir * -bsd * Time.deltaTime, Space.World);//생성될때 이미 방향도 돌려져있으니 보는 방향으로 발사
			
			//이미지교체
			if(mod == 1 || mod == 2 || mod == 6)
				myRenderer.sprite = str;
			if(mod == 3 || mod ==5)
				myRenderer.sprite = ball;
			if( mod == 4)
				myRenderer.sprite = ball2;
		}
		if(gameObject.name == "boss_bullet2(Clone)")
		if(gameObject.transform.position.x > 3.0f || gameObject.transform.position.x < -3.0f ||
		   gameObject.transform.position.y > 5.5f || gameObject.transform.position.y < -5.5f)
			GameObject.Destroy(this.gameObject);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "background")
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
