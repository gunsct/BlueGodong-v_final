//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2013 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;

/// <summary>
/// Simple example script of how a button can be offset visibly when the mouse hovers over it or it gets pressed.
/// </summary>

[AddComponentMenu("NGUI/Interaction/Button Offset")]
public class ui_startscene_button : MonoBehaviour
{
	public Transform tweenTarget;
	public Vector3 hover = Vector3.zero;
	public Vector3 pressed = new Vector3(2f, -2f);
	public float duration = 0.2f;

	Vector3 mPos;
	bool mStarted = false;
	bool mHighlighted = false;

	void Start ()
	{
		if (!mStarted)
		{
			mStarted = true;
			if (tweenTarget == null) tweenTarget = transform;
			mPos = tweenTarget.localPosition;
		}
	}

	void OnEnable () 
	{
		if (mStarted && mHighlighted) {
			OnHover (UICamera.IsHighlighted (gameObject)); 
		}
	}

	void OnDisable ()
	{
		if (mStarted && tweenTarget != null)
		{
			TweenPosition tc = tweenTarget.GetComponent<TweenPosition>();

			if (tc != null)
			{
				tc.position = mPos;
				tc.enabled = false;
			}
		}
	}

	void OnPress (bool isPressed)
	{
		//시작,종료버튼 생성하여 시작시 씬을 가져오고 종료시 프로그램 종료
		if(gameObject.name == "Button_start") Application.LoadLevel ("game");
		if (gameObject.name == "Button_end") Application.Quit ();
		if (enabled)
		{
			if (!mStarted) Start();
			TweenPosition.Begin(tweenTarget.gameObject, duration, isPressed ? mPos + pressed :
				(UICamera.IsHighlighted(gameObject) ? mPos + hover : mPos)).method = UITweener.Method.EaseInOut;

		}
	}

	void OnHover (bool isOver)
	{

		if (enabled)
		{
			if (!mStarted) Start();
			TweenPosition.Begin(tweenTarget.gameObject, duration, isOver ? mPos + hover : mPos).method = UITweener.Method.EaseInOut;
			mHighlighted = isOver;
		}
	}
}
