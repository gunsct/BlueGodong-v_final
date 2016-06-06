using UnityEngine;
using System.Collections;

public class enemy_p : MonoBehaviour {

	float speed = 2.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (0, -speed * Time.deltaTime,0);
		if(gameObject.transform.position.y < -13.0f)
			GameObject.Destroy(this.gameObject);
	}
}
