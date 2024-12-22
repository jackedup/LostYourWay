using System;
using UnityEngine;

[Serializable]
public class Credits : MonoBehaviour
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
			Application.LoadLevel("CreditsScene");
		}
	}

	public virtual void Main()
	{
	}
}
