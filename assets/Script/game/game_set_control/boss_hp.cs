using UnityEngine;
using System.Collections;

public class boss_hp : MonoBehaviour {

	public UISprite _GuageBarWidget;

	public GameObject gamecontrol;
	public GameObject boss;
	public GameObject Sprite_hp;

	float hp=2000;
	public float test=100;

	public bool test1;


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		//_GuageBarWidget.fillAmount =  hp * 0.0005f;

		if (gamecontrol.GetComponent<game_control> ().bo == true)//보스가 나타나면 hp바도 같이 나타나게 하기.
			transform.position = new Vector3 (transform.position.x, transform.position.y,0);

	
		
		_GuageBarWidget.fillAmount = boss.GetComponent<boss_HP>().HP * 0.0005f;//수식 쓰기!!!


	
	}
}
