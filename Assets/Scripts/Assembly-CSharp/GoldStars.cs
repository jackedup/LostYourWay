using UnityEngine;

public class GoldStars : MonoBehaviour
{
	public int mintime;

	public int maxtime;

	public int level;

	public int levelstar;

	private void Update()
	{
		base.gameObject.SetActive(false);
		if (PlayerPrefs.GetFloat(level + "HScore") <= (float)maxtime && PlayerPrefs.GetFloat(level + "HScore") > (float)mintime)
		{
			PlayerPrefs.SetInt("S " + level + " " + levelstar, 1);
			base.gameObject.SetActive(true);
		}
		else
		{
			base.gameObject.SetActive(false);
		}
	}
}
