using UnityEngine;

public class Joystick : MonoBehaviour
{
	private Vector3 mouse;

	private float mousey;

	public float movey;

	public float movex;

	private bool mousestuff;

	private Vector3 startingpostion;

	private void Start()
	{
		startingpostion = base.transform.position;
	}

	private void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < Input.touchCount; i++)
		{
			Debug.Log("pos: " + touches[i]);
			if (touches[i].position.x < 0.3f && touches[i].position.y < 0.3f)
			{
				Debug.Log("pos: " + touches[i]);
				base.transform.position = new Vector3(Mathf.Clamp(touches[i].position.x, startingpostion.x - 0.1f, startingpostion.x + 0.1f), Mathf.Clamp(touches[i].position.x, startingpostion.y - 0.1f, startingpostion.y + 0.1f), 1f);
			}
		}
		movex = base.transform.position.x - startingpostion.x;
		movey = base.transform.position.y - startingpostion.y;
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseUp()
	{
	}
}
