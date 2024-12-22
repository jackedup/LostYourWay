using UnityEngine;

public class Planeofgameover : MonoBehaviour
{
	private void Start()
	{
		base.transform.GetComponent<Renderer>().material.mainTextureScale = new Vector2(7f, 5f);
	}

	private void Update()
	{
	}
}
