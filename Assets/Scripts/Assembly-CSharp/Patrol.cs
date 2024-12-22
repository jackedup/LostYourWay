using System.Collections;
using UnityEngine;

public class Patrol : MonoBehaviour
{
	private bool stalker;

	public RaycastHit hit;

	public GameObject raycastee;

	public Transform[] Waypoints;

	public float Speed;

	public int curWayPoint;

	public bool doPatrol = true;

	public Vector3 Target;

	public Vector3 MoveDirection;

	public Vector3 Velocity;

	private IEnumerator Stalk()
	{
		stalker = true;
		yield return new WaitForSeconds(5f);
		stalker = false;
	}

	private void Update()
	{
		base.transform.LookAt(raycastee.transform.position);
		if (Physics.Raycast(base.transform.position, base.transform.forward, out hit, 30f) && hit.collider.tag == "Player")
		{
			base.transform.position += base.transform.forward * Time.deltaTime * 3f;
			StartCoroutine("Stalk");
		}
		if (stalker)
		{
			return;
		}
		if (curWayPoint < Waypoints.Length)
		{
			Target = Waypoints[curWayPoint].position;
			MoveDirection = Target - base.transform.position;
			Velocity = base.GetComponent<Rigidbody>().velocity;
			if (MoveDirection.magnitude < 1f)
			{
				curWayPoint++;
			}
			else
			{
				Velocity = MoveDirection.normalized * Speed;
			}
		}
		else if (doPatrol)
		{
			curWayPoint = 0;
		}
		else
		{
			Velocity = Vector3.zero;
		}
		base.GetComponent<Rigidbody>().velocity = Velocity;
	}
}
