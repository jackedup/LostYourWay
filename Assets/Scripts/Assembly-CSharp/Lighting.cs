using UnityEngine;

public class Lighting : MonoBehaviour
{
	public GameObject player;

	private Vector3 offset;

	private void Start()
	{
		offset = base.transform.position;
	}

	private void LateUpdate()
	{
		base.transform.position = player.transform.position + offset;
	}
}
