using System;
using UnityEngine;

[Serializable]
public class BackToMenu : MonoBehaviour
{
	public string level;

	public bool isQuit;

	public BackToMenu()
	{
		level = string.Empty;
	}

	public virtual void OnMouseUp()
	{
		if (isQuit)
		{
			Application.Quit();
		}
		else
		{
			Application.LoadLevel(level);
		}
	}

	public virtual void Main()
	{
	}
}
