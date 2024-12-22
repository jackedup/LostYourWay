using System;
using UnityEngine;

[Serializable]
public class Previous : MonoBehaviour
{
	public bool isQuit;

	public virtual void OnMouseUp()
	{
		if (isQuit)
		{
			Application.Quit();
		}
		else
		{
			Application.LoadLevel("Store");
		}
	}

	public virtual void Main()
	{
	}
}
