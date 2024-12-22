using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	protected Animator animator;

	public Material PlayerTex1;

	public Material PlayerTex2;

	public Material PlayerTex3;

	public Material PlayerTex4;

	public Material PlayerTex5;

	public Material PlayerTex6;

	private GameObject KEEY;

	private Level1 level1;

	public Transform explosionPrefab;

	private Timerr timer;

	public int balloveride;

	public float boost;

	private float speed = 750f;

	public int mazelvl;

	public string mazelvlstring;

	public bool PlayModes;

	public bool runTimer;

	public float sec;

	public float intsec;

	public float sec2;

	public float intsec2;

	public float sec3;

	public float intsec3;

	private bool nopowerupjump;

	private bool normalspeed = true;

	private bool powerup;

	private bool powerupjump;

	private float moveHorizontal;

	private float moveVertical;

	public GameObject Guitext;

	private CamraController camraController;

	public GameObject inverttext;

	public GameObject speedthingy;

	private float sec1;

	private float inittime;

	private void Start()
	{
		camraController = (CamraController)Object.FindObjectOfType(typeof(CamraController));
		if (PlayerPrefs.GetInt("PlayerTex") == 2)
		{
			base.transform.gameObject.GetComponent<TrailRenderer>().enabled = false;
			base.GetComponent<Renderer>().material = PlayerTex2;
			speed *= 1.75f;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 1)
		{
			base.GetComponent<Renderer>().material = PlayerTex1;
			speed *= 1.5f;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 3)
		{
			base.GetComponent<Renderer>().material = PlayerTex3;
			speed *= 2f;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 4)
		{
			base.GetComponent<Renderer>().material = PlayerTex4;
			speed *= 3f;
		}
		if (PlayerPrefs.GetInt("PlayerTex") == 5)
		{
			camraController.offset2 = new Vector3(0f, 8f, 0f);
			base.GetComponent<Renderer>().material = PlayerTex5;
		}
		else if (PlayerPrefs.GetInt("PlayerTex") == 6)
		{
			base.GetComponent<Renderer>().material = PlayerTex6;
			speed *= 4f;
		}
	}

	private void Update()
	{
		if ((nopowerupjump && Input.touchCount > 0) || (Input.GetKeyDown("space") && nopowerupjump))
		{
			base.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 360f, 0f));
			Guitext.gameObject.SetActive(false);
			nopowerupjump = false;
		}
		if (PlayModes)
		{
			level1 = (Level1)Object.FindObjectOfType(typeof(Level1));
			PlayModes = false;
		}
	}

	private void AddScore(string name, float score)
	{
		if (PlayerPrefs.HasKey(mazelvl + "HScore"))
		{
			if (PlayerPrefs.GetFloat(mazelvl + "HScore") > score)
			{
				PlayerPrefs.SetFloat(mazelvl + "HScore", score);
				PlayerPrefs.SetString(mazelvl + "HScoreName", name);
			}
		}
		else
		{
			PlayerPrefs.SetFloat(0 + "HScore", score);
			PlayerPrefs.SetString(0 + "HScoreName", name);
			PlayerPrefs.SetFloat(mazelvl + "HScore", score);
			PlayerPrefs.SetString(mazelvl + "HScoreName", name);
		}
		PlayerPrefs.SetFloat(0 + "HScore", score);
		PlayerPrefs.SetString(0 + "HScoreName", name);
	}

	private void FixedUpdate()
	{

		if (SystemInfo.supportsAccelerometer){
			moveHorizontal = Input.acceleration.x;
			moveVertical = Input.acceleration.y;
		}else{
			moveHorizontal = Input.GetAxis("Horizontal");
			moveVertical = Input.GetAxis("Vertical");
		}
		Debug.Log("mH =" + moveHorizontal);
		Debug.Log("mV =" + moveVertical);
        if (normalspeed)
		{
			inittime = Time.deltaTime;
			sec3 = Time.deltaTime;
		}
		else if (inittime + 10f > sec3)
		{
			Debug.Log(sec3);
			sec3 += Time.deltaTime;
			moveHorizontal *= 1.5f;
			moveVertical *= 1.5f;
		}
		else
		{
			normalspeed = true;
		}
		if (!powerup)
		{
			inittime = Time.deltaTime;
			sec1 = Time.deltaTime;
		}
		else if (inittime + 10f > sec1)
		{
			Debug.Log(sec1);
			sec1 += Time.deltaTime;
			moveHorizontal = 0f - moveHorizontal;
			moveVertical = 0f - moveVertical;
		}
		else
		{
			powerup = false;
		}
		Vector3 vector = new Vector3(moveHorizontal, 0f, moveVertical);
		base.GetComponent<Rigidbody>().AddForce(vector * speed * Time.deltaTime);
	}

	private void PowerUpJump()
	{
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "StartCube")
		{
			other.gameObject.SetActive(false);
			timer = (Timerr)Object.FindObjectOfType(typeof(Timerr));
			timer.runTimer = true;
		}
	}

	private IEnumerator timererrrr(Collider col)
	{
		inverttext.SetActive(true);
		yield return new WaitForSeconds(10f);
		inverttext.SetActive(false);
	}

	private IEnumerator timererrr(Collider col)
	{
		speedthingy.SetActive(true);
		yield return new WaitForSeconds(10f);
		speedthingy.SetActive(false);
	}

	private IEnumerator AnimationDestroy()
	{
		animator.SetTrigger("Player");
		yield return new WaitForSeconds(0.55f);
		Object.Destroy(KEEY);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUpWin")
		{
			AddScore(mazelvlstring, (float)((int)timer.minutes * 60) + timer.sec);
			other.gameObject.SetActive(false);
			Application.LoadLevel("EndGameScreen");
		}
		if (other.gameObject.tag == "PowerUpInvers")
		{
			Object.Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);
			Object.Destroy(other.gameObject);
			StartCoroutine(timererrrr(other));
			powerup = true;
		}
		if (other.gameObject.tag == "PowerUpSpeed")
		{
			Object.Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);
			Object.Destroy(other.gameObject);
			StartCoroutine(timererrr(other));
			normalspeed = false;
		}
		if (other.gameObject.tag == "PowerUpJump")
		{
			Object.Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);
			Object.Destroy(other.gameObject);
			Guitext.gameObject.SetActive(true);
			nopowerupjump = true;
		}
		if (other.gameObject.tag == "FollowBot")
		{
			other.gameObject.SetActive(false);
			Application.LoadLevel("GameOver");
		}
		if (other.gameObject.tag == "PowerUpDestroy")
		{
		}
		if (other.gameObject.tag == "Key")
		{
			animator = other.gameObject.GetComponent<Animator>();
			GameObject.FindGameObjectWithTag("Door").SetActive(false);
			KEEY = other.gameObject;
			StartCoroutine(AnimationDestroy());
		}
	}
}
