using UnityEngine;
using System.Collections;

public class button1 : MonoBehaviour {
	//float speed=-500;
	public bool line;
	public bool bclick;
	public int test =0;
	
	void Start () {
		bclick = true;
		line = false;
		
		
	}
	
	
	void Update () {
		
		
		/*	if (mpbar.transform.position.x > 744f)//오른쪽 충돌처리
		{
			mpbar.transform.position = new Vector2(744f,7.5f);
		}
		
		if (mpbar.transform.position.x < 177f)//왼쪽 충돌처리
		{
			mpbar.transform.position = new Vector2(177, 7.5f);
		}
		
		if(a==1)
			mpbar.transform.Translate (Time.deltaTime * speed, 0, 0);//누를 시 감소
		
		if(a==0)
			mpbar.transform.Translate (Time.deltaTime*100,0,0);//자동충전
		*/
		
	}
	
	/// 버튼 클릭시 실행되는 함수
	/// /// 이미지 위치를 클릭될때마다 좌우로 변경
	void Buttonclick()
	{
		
		
		if (bclick)
		{
			bclick = !bclick;
			line=true;
			test = 1;
			
			
		}
		else
		{
			bclick = !bclick;
			line=false;
			test = 0;
			
		}
	}
	
}




