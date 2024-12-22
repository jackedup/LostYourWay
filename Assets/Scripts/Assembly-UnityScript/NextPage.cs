using System;
using UnityEngine;

[Serializable]
public class NextPage : MonoBehaviour
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
			Application.LoadLevel("StorePage2");
		}
	}

	public virtual void Main()
	{
	}
}