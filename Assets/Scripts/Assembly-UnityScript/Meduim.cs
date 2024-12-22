using System;
using UnityEngine;

[Serializable]
public class Meduim : MonoBehaviour
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
			Application.LoadLevel("Medium");
		}
	}

	public virtual void Main()
	{
	}
}
