using System.Collections;
using UnityEngine;

public class MazeGeneration : MonoBehaviour
{
	private GameObject player;

	private int x = 1;

	private int num;

	private int y = 1;

	public TextAsset file;

	private string line = string.Empty;

	private int z = 1;

	private string[] block;

	private string[] charr;

	private Texture2D tex;

	private int i;

	private char[] delimiterChars2 = new char[1] { ',' };

	public bool init;

	public bool run;

	public Camera MainCamera;

	public Camera topDownCamera;

	public GameObject invertSpeed;

	public GameObject boost;

	public GameObject Jump;

	public GameObject Deactivate;

	public GameObject KeyKey;

	public GameObject Door;

	private NavMeshAgent agent;

	public void Start()
	{
		tex = (Texture2D)Resources.Load("norT Walls", typeof(Texture2D));
		num = 1;
	}

	public void Place()
	{
		GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.transform.position = new Vector3(x, y, z);
		gameObject.GetComponent<Renderer>().material.mainTexture = tex;
		gameObject.tag = "wall";
		gameObject.layer = 8;
	}

	private IEnumerator timererrrr()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		player.SetActive(false);
		yield return new WaitForSeconds(1f);
		player.SetActive(true);
	}

	public void Update()
	{
		while (run)
		{
			if (init)
			{
				line = file.text;
				charr = line.Split(delimiterChars2);
			}
			make();
		}
	}

	public void make()
	{
		if (charr[num] == "3")
		{
			player = GameObject.FindGameObjectWithTag("Player");
			player.SetActive(true);
			player.transform.position = new Vector3(x, y, z);
			GameObject gameObject = GameObject.FindGameObjectWithTag("StartCube");
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.transform.position = new Vector3(x, y, z);
			x++;
			num++;
		}
		else if (charr[num] == "2")
		{
			player = GameObject.FindGameObjectWithTag("PickUpWin");
			player.transform.position = new Vector3(x, y, z);
			x++;
			num++;
		}
		else if (charr[num] == "0")
		{
			x++;
			num++;
		}
		else if (charr[num] == "1")
		{
			Place();
			num++;
			x++;
		}
		else if (charr[num] == "4")
		{
			Object.Instantiate(KeyKey, new Vector3(x, (float)y - 0.3f, z), Quaternion.identity);
			num++;
			x++;
		}
		else if (charr[num] == "5")
		{
			StartCoroutine(timererrrr());
			run = false;
		}
		else if (charr[num] == "6")
		{
			Object.Instantiate(invertSpeed, new Vector3(x, (float)y - 0.5f, z), Quaternion.identity);
			num++;
			x++;
		}
		else if (charr[num] == "7")
		{
			Object.Instantiate(boost, new Vector3(x, (float)y - 0.5f, z), Quaternion.identity);
			num++;
			x++;
		}
		else if (charr[num] == "8")
		{
			Object.Instantiate(boost, new Vector3(x, (float)y - 0.5f, z), Quaternion.identity);
			num++;
			x++;
		}
		else if (charr[num] == "9")
		{
			Object.Instantiate(Jump, new Vector3(x, (float)y - 0.5f, z), Quaternion.identity);
			num++;
			x++;
		}
		else if (charr[num] == "D")
		{
			Object.Instantiate(Door, new Vector3(x, y, z), Quaternion.identity);
			num++;
			x++;
		}
		else
		{
			x = 1;
			z--;
			num++;
		}
	}
}
