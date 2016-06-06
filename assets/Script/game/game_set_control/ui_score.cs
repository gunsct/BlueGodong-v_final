using UnityEngine;
using System.Collections;

public class ui_score : MonoBehaviour {

	public GUIText score;
	public GUIText result;
	public int kill_count;
	public GameObject score_;
	public GameObject result_;
	public bool Pstat;
	public bool Bstat;
	int pnt_scr;

	void Start (){
		kill_count = 0;
		pnt_scr = 0;
		Pstat = true;
		Bstat = true;
		result_.SetActive (false);
	}

	void Update (){
		pnt_scr = kill_count * 10;
		score.text = "Score:" + pnt_scr;
		result.text = "CLEAR!!\nResult:" + pnt_scr;
		if (Pstat == false || Bstat == false) {
			score_.SetActive(false);
			result_.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
