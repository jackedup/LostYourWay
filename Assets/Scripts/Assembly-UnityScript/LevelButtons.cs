using System;
using UnityEngine;

[Serializable]
public class LevelButtons : MonoBehaviour
{
	public Texture2D level1Normal;

	public Texture2D level1Hover;

	public virtual void Start()
	{
	}

	public virtual void OnMouseEnter()
	{
		GetComponent<GUITexture>().texture = level1Hover;
	}

	public virtual void OnMouseExit()
	{
		GetComponent<GUITexture>().texture = level1Normal;
	}

	public virtual void Main()
	{
	}
}
