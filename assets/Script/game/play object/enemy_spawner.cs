using UnityEngine;
using System.Collections;

public class enemy_spawner : MonoBehaviour {
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;

	public float spawn_rate = 10.0f;

	GameObject[] enemy = new GameObject[5];
	Vector2[] spawn_pos = new Vector2[5];

	// Use this for initialization
	void Start () {
		spawn_pos[0] = new Vector2(-2.4f , 9.0f);
		for (int i=1; i<5; i++) {
			spawn_pos[i] = new Vector2(spawn_pos[i-1].x + 1.2f , 9.0f);
		}

		enemy [0] = enemy1;
		enemy [1] = enemy2;
		enemy [2] = enemy3;
		enemy [3] = enemy4;
		enemy [4] = enemy5;
	}

	void OnEnable()
	{
		StartCoroutine(create (spawn_rate));
	}
	void OnDisable()
	{
		StopCoroutine (create (spawn_rate));
	}
	// Update is called once per frame
	void Update () {
	}

	IEnumerator create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		for(int i=0; i<5; i++) {
			Instantiate(enemy[Random.Range (0, 5)], spawn_pos[i], Quaternion.identity);
		}
		StartCoroutine (create (spawn_rate));
	}
}
