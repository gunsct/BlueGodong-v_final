using UnityEngine;
using System.Collections;

public class player_shield : MonoBehaviour {

	public GameObject Sprite_shield;
	public GameObject button;
	public GameObject no;

	public bool sh;

	void Start () {
		sh = false;
	}
	
	// Update is called once per frame
	void Update () {
		Sprite_shield.SetActive (sh);

		if (button.GetComponent<button1> ().bclick == false)//쉴드 킴 상태
			sh = true;
		else
			sh = false;//쉴드 끔 상태

		if(no.GetComponent<mpbar>().mp <0.5f)//마나가 다 닭았을 때 쉴드 강제로 끔
			sh =false;
	}
}
