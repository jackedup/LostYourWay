using UnityEngine;

public class JumpNotafacation : MonoBehaviour
{
	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject.FindGameObjectWithTag("guiText").SetActive(true);
	}
}
