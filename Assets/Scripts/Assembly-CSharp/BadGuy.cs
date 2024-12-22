using UnityEngine;

public class BadGuy : MonoBehaviour
{
	private Transform Player;

	private float AISpeed = 0.8f;

	private float MaxDistance = 100f;

	private float MinDistance = 0.53f;

	private void Start()
	{
		Player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Update()
	{
		base.transform.LookAt(Player);
		AI();
	}

	private void AI()
	{
		if (Vector3.Distance(base.transform.position, Player.position) >= MinDistance)
		{
			base.transform.position += base.transform.forward * AISpeed * Time.deltaTime;
			if (Vector3.Distance(base.transform.position, Player.position) >= MaxDistance)
			{
				AIDie();
			}
		}
	}

	private void AIDie()
	{
		Object.Destroy(base.gameObject);
	}
}
