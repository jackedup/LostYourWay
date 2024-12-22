using UnityEngine;

public class SampleAgentStript : MonoBehaviour
{
	public Transform target;

	private NavMeshAgent agent;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		agent.SetDestination(target.position);
	}
}
