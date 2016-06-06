using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;

	GameObject[] Item = new GameObject[3];
	Vector2 spawn_pos;
	float Timer;
	float waitingTime = 5.0f;
	float spawnTime = 3.0f;
	// Use this for initialization
	void Start () {
		Item [0] = item1;
		Item [1] = item2;
		Item [2] = item3;
	
	}
	void OnEnable()
	{
		StartCoroutine (create_item (spawnTime));
	}
	void OnDisable()
	{
		StopCoroutine (create_item (spawnTime));
	}

	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;

		if(Timer > waitingTime){
			spawnTime = Random.Range(2.0f,5.0f);
				Timer = 0.0f;
		}

		spawn_pos = new Vector2 (Random.Range (-3.0f, 3.0f), 6.0f);
	}

	IEnumerator create_item(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		Instantiate (Item[Random.Range(0,3)], spawn_pos, Quaternion.identity);
		StartCoroutine (create_item (spawnTime));
	}
}
