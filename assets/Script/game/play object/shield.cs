using UnityEngine;
using System.Collections;

public class shield : MonoBehaviour {
	public GameObject Sprite_shield;
	public GameObject button;

	public bool sh;

	// Use this for initialization
	void Start () {
		sh = false;
	}
	
	// Update is called once per frame
	void Update () {
		//sh = button.GetComponent<button1> ().line;
		Sprite_shield.SetActive (sh);
		//Sprite_shield.SetActive (button.GetComponent<button1> ().line);
	
		if (button.GetComponent<button1> ().test == 1)
			sh = true;
	}
}
