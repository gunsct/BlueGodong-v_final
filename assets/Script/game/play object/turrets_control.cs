using UnityEngine;
using System.Collections;

public class turrets_control : MonoBehaviour {

	public GameObject shootpoint;
	public GameObject bullet;
	float speed = 1.0f;

	float timer;

	float spawn_bullet_rate = 6.0f;//이것도. 둘 다 00 지우면 됨!

	void Start () {

	}

	void OnEnable()
	{
		StartCoroutine (create_bullet (spawn_bullet_rate));
	}
	void OnDisable()
	{
		StopCoroutine (create_bullet (spawn_bullet_rate));
	}
	// Update is called once per frame
	void Update () {


		
		if (gameObject.name != "turrets" && gameObject.tag == "turrets") {
			transform.Translate (Vector2.up * -speed * Time.deltaTime, Space.World);
		}

		if(gameObject.transform.position.y <  -5.5f)
			GameObject.Destroy(this.gameObject);

	}



	IEnumerator create_bullet(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		if (gameObject.name != "turrets" && gameObject.tag == "turrets") {
			Instantiate (bullet, shootpoint.transform.position, Quaternion.identity);
		}
		StartCoroutine (create_bullet (spawn_bullet_rate));
	}


}
