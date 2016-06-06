using UnityEngine;
using System.Collections;

public class player_bullet_control : MonoBehaviour {
	public float speed = 5.0f;
	Vector2 moveX;
	Vector2 moveY;
	public float Power = 1.0f;
	public GameObject Player;
	public GameObject Self;
	public int mod = 1;

	float timer = 0.0f;
	float mod_limit = 0.05f;
	
	float item1_p;
	float item2_p;
	float item3_p;

	public Sprite str_1;
	public Sprite str_2;
	public Sprite str_3;
	public Sprite case_1;
	public Sprite case_2;
	public Sprite case_3;
	public Sprite rota_1;
	public Sprite rota_2;
	public Sprite rota_3;
	private SpriteRenderer myRenderer;

	void Start () {
	}

	void OnDisable(){
		if(gameObject.name == "bullet(Clone)")
			Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer < mod_limit)
			mod = Player.GetComponent<player_move> ().shot_mod;

		item1_p = Player.GetComponent<player_move> ().item1_p;
		item2_p = Player.GetComponent<player_move> ().item2_p;
		item3_p = Player.GetComponent<player_move> ().item3_p;

		myRenderer = gameObject.GetComponent<SpriteRenderer>();

		if (gameObject.name == "bullet(Clone)") {
			if(mod == 1)
			{	
				speed = 5.0f;
				Power = 1.0f + item1_p;

				if(Power < 2.0f)
					myRenderer.sprite = str_1;
				if(Power >= 2.0f && Power < 4.0f){
					myRenderer.sprite = str_2;
				}
				if(Power >= 4.0f){
					myRenderer.sprite = str_3;
				}
			}
			if(mod == 2)
			{
				speed = 7.0f;
				Power = 0.1f + item2_p;

				if(Power < 0.2f)
					myRenderer.sprite = case_1;
				if(Power >= 0.2f && Power < 0.3f){
					myRenderer.sprite = case_2;
				}
				if(Power >= 0.3f){
					myRenderer.sprite = case_3;
				}
			}
			if(mod == 3)
			{
				speed = 4.0f;
				Power = 0.5f + item3_p;

				if(Power < 1.0f)
					myRenderer.sprite = rota_1;
				if(Power >= 1.0f && Power < 1.5f){
					myRenderer.sprite = rota_2;
				}
				if(Power >= 1.5f){
					myRenderer.sprite = rota_3;
				}
			}
			
			transform.Translate (transform.up * speed * Time.deltaTime, Space.World);
		}
		
		if (transform.position.y > 6.0f) {
			GameObject.Destroy (this.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			GameObject.Destroy (this.gameObject);
		}
	}
}

