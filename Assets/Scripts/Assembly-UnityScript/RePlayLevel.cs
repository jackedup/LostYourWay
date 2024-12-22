using System;
using UnityEngine;

[Serializable]
public class RePlayLevel : MonoBehaviour
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
