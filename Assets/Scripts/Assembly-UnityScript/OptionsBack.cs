using System;
using UnityEngine;

[Serializable]
public class OptionsBack : MonoBehaviour
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
			Application.LoadLevel("MainMenu");
		}
	}

	public virtual void Main()
	{
	}
}
