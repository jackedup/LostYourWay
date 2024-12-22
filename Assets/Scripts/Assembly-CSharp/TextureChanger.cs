using UnityEngine;

public class TextureChanger : MonoBehaviour
{
	public int tex;

	public int price;

	private bool spinfasterthannormal;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnMouseUp()
	{
		if (PlayerPrefs.GetInt("StarCount") >= price)
		{
			PlayerPrefs.SetInt("PlayerTex", tex);
			Debug.Log(PlayerPrefs.GetInt("PlayerTex"));
		}
	}
}
