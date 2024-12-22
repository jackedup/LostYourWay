using System;
using UnityEngine;

[Serializable]
public class OptionButton : MonoBehaviour
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
			Application.LoadLevel("OptionsMenu");
		}
	}

	public virtual void Main()
	{
	}
}
