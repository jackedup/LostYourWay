using UnityEngine;

public class CamraController : MonoBehaviour
{
	public GameObject player;

	private Vector3 offset;

	public Vector3 offset2;

	private void Start()
	{
		offset = base.transform.position;
	}

	private void LateUpdate()
	{
		base.transform.position = player.transform.position + offset + offset2;
	}
}
