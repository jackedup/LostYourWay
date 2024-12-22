using UnityEngine;

public class GuiTimerScore : MonoBehaviour
{
	private string[] Scores;

	public int level;

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
		base.gameObject.GetComponent<TextMesh>().text = PlayerPrefs.GetString(level + "HScoreName") + " High Score: " + PlayerPrefs.GetFloat(level + "HScore");
		GetHighScores();
	}
}
