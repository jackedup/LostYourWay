using UnityEngine;

public class storeload : MonoBehaviour
{
	public Texture2D itemTexture;

	private void Start()
	{
	}

	private void OnMouseUp()
	{
		Application.LoadLevel("Store");
	}
}
