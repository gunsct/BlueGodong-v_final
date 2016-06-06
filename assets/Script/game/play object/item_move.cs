using UnityEngine;
using System.Collections;

public class item_move : MonoBehaviour {
	float speed;
	// Use this for initialization
	void Start () {
		speed = Random.Range (0.5f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.name == "item1(Clone)" || gameObject.name == "item2(Clone)" || gameObject.name == "item3(Clone)")
			transform.Translate (transform.up * -speed * Time.deltaTime, Space.World);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "player")
			GameObject.Destroy (this.gameObject);
	}
}
