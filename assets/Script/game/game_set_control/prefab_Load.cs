using UnityEngine;
using System.Collections;

public class prefab_Load : MonoBehaviour {
	public GameObject _enemySet_1;
	public GameObject _enemySet_2;
	public GameObject _enemySet_3;
	public GameObject _enemySet_4;
	public GameObject _enemySet_5;
	public GameObject _enemySet_6;
	public GameObject _enemySet_7;
	public GameObject _enemySet_8;
	public GameObject _enemySet_9;
	public GameObject _enemySet_10;
	public GameObject _enemySet_11;
	
	public float waitingTime = 3.0f;
	public int count;

	void Start () {
	}

	void OnEnable()
	{
		StartCoroutine(create (waitingTime));
	}

	void OnDisable()
	{
		StopCoroutine (create (waitingTime));
	}

	void Update () {
		//GameObject test = Resources.Load("prefab/pattern_1") as GameObject;프리펩 불러오기
	}
	IEnumerator create(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		count = Random.Range(1,12);

		switch (count) {
		case 1:
			if (gameObject.name != "pattern_1")
				Instantiate (_enemySet_1, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 2:
			if (gameObject.name != "pattern_2")
				Instantiate (_enemySet_2, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 3:
			if (gameObject.name != "pattern_3")
				Instantiate (_enemySet_3, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 4:
			if (gameObject.name != "pattern_4")
				Instantiate (_enemySet_4, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 5:
			if (gameObject.name != "pattern_5")
				Instantiate (_enemySet_5, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 6:
			if (gameObject.name != "pattern_6")
				Instantiate (_enemySet_6, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 7:
			if (gameObject.name != "pattern_7")
				Instantiate (_enemySet_7, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 8:
			if (gameObject.name != "pattern_8")
				Instantiate (_enemySet_8, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 9:
			if (gameObject.name != "pattern_9")
				Instantiate (_enemySet_9, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 10:
			if (gameObject.name != "pattern_10")
				Instantiate (_enemySet_10, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		case 11:
			if (gameObject.name != "pattern_11")
				Instantiate (_enemySet_11, new Vector3 (0, 1, -4), Quaternion.identity);
			break;
		}
		StartCoroutine(create (waitingTime));
	}
}
