using UnityEngine;

public class EndGameCube : MonoBehaviour
{
	private void Update()
	{
		base.transform.Rotate(new Vector3(45f, 45f, 45f) * Time.deltaTime);
	}
}
