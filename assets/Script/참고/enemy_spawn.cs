using UnityEngine;
using System.Collections;
using System.Threading;

public class enemy_spawne: MonoBehaviour {

	public GameObject enemy;
	Vector3 StartPos;
	// Use this for initialization
	void Start () {
		StartCoroutine (create (3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		
		StartPos = new Vector3(Random.Range(-180.0f, 180.0f),Random.Range(-80.0f,80.0f),Random.Range(200.0f,280.0f));
		Instantiate(enemy, StartPos, Quaternion.identity);
		StartCoroutine(create (2.0f));
	}
	//1초마다 무한 생성
	/*while (true) {
		SpawnEnemy ();
		Thread.Sleep(500);//0.5초씩 쉬기
	}*/

	/*void SpawnEnemy(){
		System.Random rand = new System.Random (System.DateTime.Now.Millisecond);
		int spawnX = rand.Next (-180, 180);
		int spawnY = rand.Next (-80, 80);
		int spawnZ = rand.Next (200, 280);

		enemy.transform.position = new Vector3 (spawnX, spawnY, spawnZ);

		Instantiate(enemy, enemy.transform.position, Quaternion.identity);

	}*/
}
