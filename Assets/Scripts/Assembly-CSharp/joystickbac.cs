using UnityEngine;

public class joystickbac : MonoBehaviour
{
	private void LateUpdate()
	{
		base.transform.position = Camera.current.ScreenToViewportPoint(new Vector3(110f, 140f, 1f));
	}
}
