using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {
	float speed=-50;
	int a=3;
	public GameObject mpbar;
		bool bclick;

	void Start () {
		bclick = true;
	}
	

	void Update () {


		if (mpbar.transform.position.x > 464f)//오른쪽 충돌처리
		{
			mpbar.transform.position = new Vector3(464f,7.5f , 0);
		}
		
		if (mpbar.transform.position.x < 245f)//왼쪽 충돌처리
		{
			mpbar.transform.position = new Vector3(245,7.5f , 0);
		}

		if(a==1)
			mpbar.transform.Translate (Time.deltaTime * speed, 0, 0);//누를 시 감소

		if(a==0)
			mpbar.transform.Translate (Time.deltaTime*10,0,0);//자동충전


	}

	/// 버튼 클릭시 실행되는 함수
	/// /// 이미지 위치를 클릭될때마다 좌우로 변경
	void Buttonclick()
	{

	
		if (bclick)
		{
			bclick = !bclick;
			a=1;


		}
		else
		{
			bclick = !bclick;
			a=0;

		}
	}

}

