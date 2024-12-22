using UnityEngine;

public class PowerUpCrates : MonoBehaviour
{
	private void Update()
	{
		base.transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime);
	}
}
