using UnityEngine;

public class raycaster : MonoBehaviour
{
	public GameObject raycastee;

	private RaycastHit hit;

	private void Start()
	{
	}

	private void Update()
	{
		base.transform.LookAt(raycastee.transform.position);
		if (Physics.Raycast(base.transform.position, base.transform.forward, out hit, 10f) && hit.collider.tag == "Player")
		{
			base.transform.position += base.transform.forward * Time.deltaTime * 2f;
		}
	}
}
