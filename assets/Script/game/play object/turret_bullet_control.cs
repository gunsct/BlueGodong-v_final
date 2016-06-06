using UnityEngine;
using System.Collections;

public class turret_bullet_control : MonoBehaviour {
	public GameObject player;
	public Vector2 bullet_dir;
	float timer;
	public float waitingTime = 10.0f;
	float speed = 2.0f;
	float read_spd;
	// Use this for initialization
	void Start () {

	}
	void OnEnable(){
		StartCoroutine (create (0.0f));
	}
	void OnDisable(){
		StopCoroutine (create (0.0f));
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log (player.gameObject.transform.position);
		if (gameObject.name == "turrets_bullet(Clone)") {
			gameObject.transform.Translate(bullet_dir * speed * Time.deltaTime, Space.World);
			//transform.Translate ((Tx - Px) * -read_spd * Time.deltaTime,(Ty - Py) * -read_spd * Time.deltaTime, 0.0f, Space.World);
		}
		timer += Time.deltaTime;
		if (gameObject.name != "turrets_bullet" && timer > waitingTime) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "background" || other.gameObject.tag == "Player" )
		{
			GameObject.Destroy(this.gameObject);
		}
	}

	IEnumerator create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		bullet_dir = (player.gameObject.transform.position - gameObject.transform.position).normalized;
		StartCoroutine(create (10.0f));
	}
}
