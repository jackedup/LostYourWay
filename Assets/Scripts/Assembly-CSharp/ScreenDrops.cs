using System;
using UnityEngine;

public class ScreenDrops : MonoBehaviour
{
	public Camera cam;

	public void Start()
	{
		if (cam == null)
		{
			cam = Camera.main;
		}
		if (cam == null)
		{
			base.enabled = false;
		}
		else if (cam.nearClipPlane >= 1f)
		{
			Debug.LogWarning("ScreenDrops::Start() Camera nearClipPlane should be lower than 1.0");
		}
		base.transform.localPosition = Vector3.forward;
		base.transform.localEulerAngles = Vector3.zero;
	}

	public void Update()
	{
		if (cam.pixelHeight >= cam.pixelWidth)
		{
			base.transform.localScale = 2f * Mathf.Tan(cam.fieldOfView / 2f * ((float)Math.PI / 180f)) * Vector3.one;
		}
		else
		{
			base.transform.localScale = 2f * Mathf.Tan(cam.fieldOfView / 2f * ((float)Math.PI / 180f)) * cam.aspect * Vector3.one;
		}
	}
}
