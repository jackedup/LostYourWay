using System;
using UnityEngine;

[Serializable]
public class EasylvlBack : MonoBehaviour
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
			Application.LoadLevel("DifficultyMenu");
		}
	}

	public virtual void Main()
	{
	}
}
