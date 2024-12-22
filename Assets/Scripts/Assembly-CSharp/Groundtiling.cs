using UnityEngine;

public class Groundtiling : MonoBehaviour
{
	private void Start()
	{
		base.transform.GetComponent<Renderer>().material.mainTextureScale = new Vector2(250f, 200f);
	}

	private void Update()
	{
	}
}
