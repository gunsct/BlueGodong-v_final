using UnityEngine;
using System.Collections;

public class boss_HP_Back : MonoBehaviour {

	public GameObject gamecontrol;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (gamecontrol.GetComponent<game_control> ().bo == true)
			transform.position = new Vector3 (transform.position.x, transform.position.y,0);
	}
}
