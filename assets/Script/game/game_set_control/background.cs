using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	public GameObject background1;
	public GameObject background2;
	public GameObject background3;
	public Sprite background1_1;
	public Sprite background2_1;
	public Sprite background1_2;
	public Sprite background2_2;
	public Sprite background1_3;
	public Sprite background2_3;

	private SpriteRenderer myRenderer1;
	private SpriteRenderer myRenderer2;
	private SpriteRenderer myRenderer3;
	
	void Start () {

	}
	
	
	void Update () {
		myRenderer1 = background1.GetComponent<SpriteRenderer> ();
		myRenderer2= background2.GetComponent<SpriteRenderer> ();
		myRenderer3 = background3.GetComponent<SpriteRenderer> ();

		if (gameObject.GetComponent<game_control> ().back_ground == true) {
			
			
			myRenderer1.sprite = background2_1;
			myRenderer2.sprite = background2_2;
			myRenderer3.sprite = background2_3;
		} else {
			myRenderer1.sprite = background1_1;
			myRenderer2.sprite = background1_2;
			myRenderer3.sprite = background1_3;
		}
	}
}
