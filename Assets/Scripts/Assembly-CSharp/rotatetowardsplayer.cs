using UnityEngine;

public class rotatetowardsplayer : MonoBehaviour
{
	private Transform Player;

	private void Start()
	{
		Player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Update()
	{
		base.transform.LookAt(Player);
	}
}
