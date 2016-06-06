using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {
	//public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "enemy3(Clone)") {
			//Instantiate(explosion, this.transform.position, Quaternion.identity);
			GameObject.Destroy (other.gameObject);
			GameObject.Destroy (this.gameObject);
		}
	}
}
