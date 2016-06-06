using UnityEngine;
using System.Collections;

public class boss_HP : MonoBehaviour {

	public float HP = 2000.0f;
	public GameObject bullet;
	public GameObject self_bullet;
	public GameObject score_ui;
	void Start () {

	}
	

	void Update () {

}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "bullet" || other.gameObject.tag == "Player")//총알과 플레이어에 박을때 피 씩 까이는겨 
		{
			
			HP -= other.GetComponent<player_bullet_control>().Power;
			if(HP < 0.0f)
			{
				score_ui.GetComponent<ui_score>().Bstat = false;
				if(self_bullet.name == "boss_bullet(Clone)")
					GameObject.Destroy(self_bullet);

				GameObject.Destroy(this.gameObject);
			}
		}
	}
}
