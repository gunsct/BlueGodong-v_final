using UnityEngine;
using System.Collections;

public class game_control : MonoBehaviour {
	public GameObject enemy;
	public GameObject warning;
	public GameObject boss;
	public GameObject boss_hpbar;
	public GameObject turret;
	public GameObject respawn_b;
	public GameObject player;
	public GameObject back_menu;
	public GameObject score_ui;

	public int wait_enemy = 1;
	public int wait_boss = 90;
	public int wait_turret = 30;
	public bool en,bo,tu,pl,wa, back_ground;
	public float timer;
	public int test=0;
	int life;
	AudioClip sound;
	public AudioClip back1_s;
	public AudioClip back2_s;
	public AudioClip warning_s;
	int sound_cnt = 0;
	/*private SpriteRenderer myRenderer;
	public Sprite back_1;
	public Sprite back_2;
	public Sprite back_3;*/
	// Use this for initialization
	void Start () {
		back_menu.SetActive (false);
		wa = en = bo = tu = back_ground= false;
		timer = 0;

	}
	void OnEnable(){

	}
	// Update is called once per fram

	void Update () {
		if(sound_cnt == 0){
			sound = back1_s;
			AudioSource.PlayClipAtPoint (sound, new Vector3 (5, 1, 2));

			sound_cnt++;
		}

		if(Application.platform == RuntimePlatform.Android)
		{
			if(Input.GetKey(KeyCode.Escape))
			{
				Application.LoadLevel ("start");
				Time.timeScale = 1;
			}
		}

		enemy.SetActive (en);
		warning.SetActive(wa);
		boss.SetActive(bo);
		boss_hpbar.SetActive (bo);
		turret.SetActive(tu);
		//플레이어 목숨에 따라 플레이어 살아있음 버튼꺼지고 죽으면 켜지고
		pl = player.GetComponent<player_move> ().stat;
		life = respawn_b.GetComponent<ui_respawn_button> ().life_point;
		//플레이어가 살아있음 버튼은 꺼져
		if (pl == true)
			respawn_b.SetActive (false);
		//플레이어가 죽어있으면 버튼은 계속 나오고목숨다되기 전엔 부활가능
		if (pl == false && life > 0)
			respawn_b.SetActive (true);
		//메뉴로 돌아가기 
		if(life <= 0 && pl == false )
			back_menu.SetActive (true);
		if(score_ui.GetComponent<ui_score>().Bstat == false)
			back_menu.SetActive (true);
		timer += Time.deltaTime;

		if (timer > wait_enemy) {
			en=true;
		}

		if (timer > wait_turret) {
			tu=true;
		}

		if (timer > wait_boss - 8.0f) {
			back_ground = true;

			if(sound_cnt == 1){
				sound = warning_s;
				AudioSource.PlayClipAtPoint (sound, new Vector3 (5, 1, 2));
				sound_cnt++;}
		}
		if (timer > wait_boss - 9.0f) {
			en=false;
			tu=false;
			wa=true;

		}


		if (timer > wait_boss - 15.0f) {
			en=false;
			tu=false;
		}

		if (timer > wait_boss) {
			bo=true;
			test=7;

			if(sound_cnt == 2){
				sound = back2_s;
				AudioSource.PlayClipAtPoint (sound, new Vector3 (5, 1, 2));
				sound_cnt++;
			}
		}


	}
}
