using System;
using UnityEngine;

[Serializable]
public class PlayButton : MonoBehaviour
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
			Application.LoadLevel("MultiMenu");
		}
	}

	public virtual void Main()
	{
	}
}
