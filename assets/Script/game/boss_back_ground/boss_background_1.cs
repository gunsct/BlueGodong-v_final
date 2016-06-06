using UnityEngine;
using System.Collections;

public class boss_background_1 : MonoBehaviour {

	public GameObject background;
	public Sprite background1_1;
	public Sprite background2_1;
	public bool test = false;
	private SpriteRenderer myRenderer;

	void Start () {
	
	}
	

	void Update () {
		myRenderer = gameObject.GetComponent<SpriteRenderer> ();

		if (background.GetComponent<game_control> ().back_ground == true) {

	
			myRenderer.sprite = background2_1;
		}

	}
}
