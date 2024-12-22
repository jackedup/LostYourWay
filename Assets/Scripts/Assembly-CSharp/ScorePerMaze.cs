using UnityEngine;

public class ScorePerMaze : MonoBehaviour
{
	public TextAsset lvl;

	private void Start()
	{
		GetComponent<TextMesh>().text = PlayerPrefs.GetString(0 + "HScoreName") + " High Score: " + PlayerPrefs.GetFloat(0 + "HScore");
	}

	private void Update()
	{
	}
}
