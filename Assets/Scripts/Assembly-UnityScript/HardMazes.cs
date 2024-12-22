using System;
using UnityEngine;

[Serializable]
public class HardMazes : MonoBehaviour
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
			Application.LoadLevel("Hard");
		}
	}

	public virtual void Main()
	{
	}
}
