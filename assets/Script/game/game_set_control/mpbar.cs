using UnityEngine;
using System.Collections;

public class mpbar : MonoBehaviour {
	public GameObject full;
	public GameObject normal;
	
	public UISprite _GuageBarWidget;
	
	public GameObject button;
	
	public float mp=100;

	bool ful;
	bool nor;
	//public float test=0;
	
	
	
	// Use this for initialization
	void Start () {
		ful = false;
		nor = true;
	}
	
	// Update is called once per frame
	void Update () {
		//gauge.fillAmount = 10*0.01f;


		full.SetActive(ful);
		ful = false;

		normal.SetActive (nor);
		nor = true;

	

		_GuageBarWidget.fillAmount =  mp * 0.01f;
		if (button.GetComponent<button1> ().bclick == false)//shield 버튼 눌렀을 때 
			mp-=0.6f;
		
		
		if (button.GetComponent<button1> ().bclick == true)//shield버튼 안눌렀을 때
			mp += 0.1f;
		
		if (mp > 100)
		{
			mp = 100;
			ful=true;
			nor=false;

		}
		if (mp < 0)
		{
			button.GetComponent<button1> ().bclick = true;
			//mp = 0;
		}
		
		
		
	}
	
	
	
	
	
	
	//public UISprite _GuageBarWidget; 
	
	
	
	//void OnTriggerEnter(Collider other)
	//{
	//gauge.fillAmount = 10*0.01f;
	//}
}
