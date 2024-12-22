using UnityEngine;

public class Level1 : MonoBehaviour
{
	public TextAsset lvl1;

	public string lvlname;

	public int lvlidentifier;

	public bool playmodefs;

	private bool isQuit;

	private MazeGeneration mazeGeneration;

	private Timerr timerr;

	private PlayerController playerController;

	private GameObject player;

	private void Start()
	{
	}

	private void OnMouseUp()
	{
		if (isQuit)
		{
			Application.Quit();
			return;
		}
		playerController = (PlayerController)Object.FindObjectOfType(typeof(PlayerController));
		playerController.mazelvlstring = lvlname;
		playerController.mazelvl = lvlidentifier;
		playerController.PlayModes = true;
		playmodefs = true;
		GameObject.FindGameObjectWithTag("Lighting").SetActive(false);
		GameObject.FindGameObjectWithTag("GuiCamera").SetActive(false);
		player = GameObject.FindGameObjectWithTag("Player");
		player.gameObject.SetActive(false);
		mazeGeneration = (MazeGeneration)Object.FindObjectOfType(typeof(MazeGeneration));
		player.gameObject.SetActive(true);
		mazeGeneration.file = lvl1;
		mazeGeneration.run = true;
		mazeGeneration.init = true;
		Debug.Log("loaded lvl1");
		GameObject.FindGameObjectWithTag("MenuEasy").SetActive(false);
		GameObject.FindGameObjectWithTag("MainCamera").SetActive(true);
	}
}
