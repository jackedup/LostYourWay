using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
	private string[] Scores;

	private void GetHighScores()
	{
		for (int i = 0; i < 10; i++)
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		base.gameObject.GetComponent<GUIText>().text = PlayerPrefs.GetString(0 + "HScoreName") + " has a score of: " + PlayerPrefs.GetFloat(0 + "HScore");
		GetHighScores();
	}
}
