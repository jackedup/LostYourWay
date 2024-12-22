using UnityEngine;

public class WallTile : MonoBehaviour
{
	private void Start()
	{
		base.transform.GetComponent<Renderer>().material.mainTextureScale = new Vector2(15f, 8f);
	}

	private void Update()
	{
	}
}
