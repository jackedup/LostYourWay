using UnityEngine;

public class CountDaMonies : MonoBehaviour
{
	public int[] mintime;

	public int[] maxtime;

	private void Start()
	{
		PlayerPrefs.SetInt("StarCount", 0);
		for (int i = 1; i <= 40; i++)
		{
			for (int j = 1; j <= 3; j++)
			{
				if (PlayerPrefs.GetInt("S " + i + " " + j) == 1)
				{
					PlayerPrefs.SetInt("StarCount", PlayerPrefs.GetInt("StarCount") + 1);
				}
			}
		}
	}
}
