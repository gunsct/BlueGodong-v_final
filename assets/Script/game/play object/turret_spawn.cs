using UnityEngine;
using System.Collections;

public class turret_spawn : MonoBehaviour {
	public GameObject turrents;
	float spawn_turret_rate = 5.0f;//수정필요
	Vector3 spawn_pos;
	// Use this for initialization
	void Start () {
	
	}

	void OnEnable()
	{
		StartCoroutine (create_turrent (spawn_turret_rate));
	
	}
	void OnDisable()
	{
		StopCoroutine (create_turrent (spawn_turret_rate));
	}
	// Update is called once per frame
	void Update () {
		spawn_pos = new Vector3 (Random.Range (-2.5f, 2.5f), 4.5f, 0.0f);
	}

	IEnumerator create_turrent(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		Instantiate(turrents, spawn_pos, Quaternion.identity);
		StartCoroutine (create_turrent (spawn_turret_rate));
	}
}
