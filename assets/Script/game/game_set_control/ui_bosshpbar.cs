using UnityEngine;
using System.Collections;

public class ui_bosshpbar : MonoBehaviour {
	
	//public float boss_HP = 100f;
	public float boss_HP1 = 98f;
	public GameObject boss;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 796.7f)//오른쪽 충돌처리
		{
			transform.position = new Vector2(796.7f, transform.position.y);
		}

		if (transform.position.x < 120f)//왼쪽 충돌처리
		{
			transform.position = new Vector2(120, transform.position.y);
		}


		if (boss_HP1 > boss.GetComponent<boss_HP> ().HP) 
		{
			transform.Translate (Time.deltaTime * -410, 0, 0);//누를 시 감소

			boss_HP1-=1f;
		}
			
	}
}
