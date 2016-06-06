using UnityEngine;
using System.Collections;

public class enemy3_control : MonoBehaviour {
	
	
	public GameObject bullet;
	public float HP = 20;
	public GameObject dest_cnt;
	float speed = 2.0f;

	AudioClip die_sound;
	public AudioClip die;

	void Start()
	{
		die_sound = die;
	}
	
	void Update()
	{
		if(gameObject.name == "enemy3(Clone)")
			gameObject.transform.Translate (0, -speed * Time.deltaTime, 0);
		
		if (gameObject.transform.position.y < -13.0f)
			GameObject.Destroy (gameObject);
	}
	
	
	
	
	//총알 피격
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "bullet(Clone)" || other.gameObject.name == "Player")//총알과 플레이어에 박을때 피 씩 까이는겨 
		{
			
			HP -= other.gameObject.GetComponent<player_bullet_control>().Power;
			if(HP <= 0)
			{
				dest_cnt.GetComponent<ui_score>().kill_count++;
				AudioSource.PlayClipAtPoint (die_sound, new Vector3 (5, 1, 2));
				GameObject.Destroy(this.gameObject);
			}
		}
	}
}