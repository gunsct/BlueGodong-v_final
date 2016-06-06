using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {
	public GameObject background1;
	public GameObject background2;
	public GameObject background3;
	
	float speed=1f;
	
	//float wait1=3;
	//float wait2=5;
	//float wait3=7;
	
	//float time1;
	//float time2;
	//float time3;
	
	
	
	void Start () {
		//StartCoroutine(background());
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		background1.transform.Translate (0, Time.deltaTime * -speed, 0);
		
		if (background1.transform.localPosition.y < -15f) 
		{
			background1.transform.localPosition = new Vector3 (0.0f, 18.00f,3.0f);
			
		}
		
		background2.transform.Translate (0, Time.deltaTime * -speed, 0);
		
		if (background2.transform.localPosition.y < -15f) 
		{
			background2.transform.localPosition = new Vector3 (0.0f, 18.00f,3.0f);
			
		}
		
		background3.transform.Translate (0, Time.deltaTime * -speed, 0);
		
		if (background3.transform.localPosition.y < -15f) 
		{
			background3.transform.localPosition = new Vector3 (0.0f, 18.00f,3.0f);
			
		}
		
	}
	
	
	
	
	
	
	
	
	
	/*
	IEnumerator background()
	{
		yield return null;

		background1.transform.Translate (0, Time.deltaTime * -speed, 0);


		if (background1.transform.position.y < -15f) 
		{
			background1.transform.position = new Vector3 (0.0f, 18f,3.0f);

			
		}


		background2.transform.Translate (0, Time.deltaTime * -speed, 0);
		
		if (background2.transform.position.y < -15f) 
		{
			background2.transform.position = new Vector3 (0.0f, 18f,3.0f);

			
		}

		
		background3.transform.Translate (0, Time.deltaTime * -speed, 0);
		
		if (background3.transform.position.y < -15f) 
		{
			background3.transform.position = new Vector3 (0.0f, 18f,3.0f);

			
		}

		StartCoroutine(background());
	}*/
	
}
