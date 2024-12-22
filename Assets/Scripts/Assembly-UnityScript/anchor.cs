using System;
using UnityEngine;

[Serializable]
public class anchor : MonoBehaviour
{
	public GameObject guiCam;

	public Vector3 v3Pos;

	public anchor()
	{
		v3Pos = new Vector3(0f, 1f, 0.25f);
	}

	public virtual void Update()
	{
		transform.position = guiCam.GetComponent<Camera>().ViewportToWorldPoint(v3Pos);
	}

	public virtual void Main()
	{
	}
}
