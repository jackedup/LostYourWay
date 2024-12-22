using UnityEngine;

public class textureshower : MonoBehaviour
{
	public Material PlayerTex1;

	public Material PlayerTex2;

	public Material PlayerTex3;

	public Material PlayerTex4;

	public Material PlayerTex5;

	public Material PlayerTex6;

	private void Start()
	{
	}

	private void Update()
	{
		if (PlayerPrefs.GetInt("PlayerTex") == 2)
		{
			base.GetComponent<Renderer>().material = PlayerTex2;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 1)
		{
			base.GetComponent<Renderer>().material = PlayerTex1;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 3)
		{
			base.GetComponent<Renderer>().material = PlayerTex3;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 4)
		{
			base.GetComponent<Renderer>().material = PlayerTex4;
		}
		if (PlayerPrefs.GetInt("PlayerTex") == 5)
		{
			base.GetComponent<Renderer>().material = PlayerTex5;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 6)
		{
			base.GetComponent<Renderer>().material = PlayerTex6;
		}
	}
}
