using UnityEngine;

public class MainMenu : MonoBehaviour
{
	public Texture2D icon;

	public TextAsset lvl1;

	public TextAsset lvl2;

	public TextAsset lvl3;

	public GameObject variables;

	public MazeGeneration mazeGeneration;

	private GameObject player;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		player.gameObject.SetActive(false);
		mazeGeneration = (MazeGeneration)Object.FindObjectOfType(typeof(MazeGeneration));
	}

	private void OnGUI()
	{
		GUI.Box(new Rect(10f, 10f, 100f, 100f), new GUIContent("Launcher", icon));
		GUI.Box(new Rect(500f, 500f, 100f, 90f), "Loader Menu");
		if (GUI.Button(new Rect(20f, 40f, 80f, 20f), "Level 1"))
		{
			player.gameObject.SetActive(true);
			mazeGeneration.file = lvl1;
			mazeGeneration.run = true;
			mazeGeneration.init = true;
			Debug.Log("loaded lvl1");
		}
		if (GUI.Button(new Rect(Screen.width, Screen.height / 10, Screen.width / 10, Screen.height / 10), "Level 2"))
		{
			player.gameObject.SetActive(true);
			mazeGeneration.file = lvl2;
			mazeGeneration.run = true;
			mazeGeneration.init = true;
			Debug.Log("loaded lvl1");
		}
		if (GUI.Button(new Rect(Screen.width / 10, Screen.height / 10 - 20, Screen.width / 10, Screen.height / 10), "Level 3"))
		{
			player.gameObject.SetActive(true);
			mazeGeneration.file = lvl3;
			mazeGeneration.run = true;
			mazeGeneration.init = true;
			Debug.Log("loaded lvl1");
		}
		if (GUI.Button(new Rect(Screen.width, Screen.height / 10 - 40, Screen.width / 10, Screen.height / 10), "Level 4"))
		{
			player.gameObject.SetActive(true);
			mazeGeneration.file = lvl1;
			mazeGeneration.run = true;
			mazeGeneration.init = true;
			Debug.Log("loaded lvl1");
		}
	}
}
