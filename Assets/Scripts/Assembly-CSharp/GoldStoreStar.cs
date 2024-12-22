using UnityEngine;

public class GoldStoreStar : MonoBehaviour
{
	private void Update()
	{
		base.transform.Rotate(new Vector3(90f, 0f, 0f) * Time.deltaTime);
	}
}
