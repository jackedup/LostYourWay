using UnityEngine;

public class ScoreReset : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnMouseUp()
	{
		PlayerPrefs.DeleteAll();
	}
}
