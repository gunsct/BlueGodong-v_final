using UnityEngine;
using System.Collections;

public class scene_change : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began || Input.GetTouch (0).phase == TouchPhase.Ended) 
		{
			Vector2 TDP = Input.GetTouch (0).deltaPosition;
			Vector2 TP = Input.GetTouch (0).position;
			Vector3 touchPosition = new Vector3 (TP.x, TP.y, 0.0f);
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (touchPosition), Vector2.zero);//터치한지점에서 수직으로 꽂는다는거다

			if (hit && hit.collider.gameObject == this.gameObject) Application.LoadLevel("game");
		}
	
	}
}
