using UnityEngine;
using System.Collections;

public class screen_set : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Screen.SetResolution (1080, 1920, true); //해상도 고정
		Screen.orientation = ScreenOrientation.Portrait; // 단말기의 세로 모드로 설정한다.
		Screen.sleepTimeout = SleepTimeout.NeverSleep; // 단말기 화면을 계속 켜지게 만든다.
	}
}
