using UnityEngine;

public class pauseAnimationOnLoad : MonoBehaviour
{
	private void Start()
	{
		base.GetComponent<Animation>().Stop();
	}

	private void Update()
	{
	}
}
