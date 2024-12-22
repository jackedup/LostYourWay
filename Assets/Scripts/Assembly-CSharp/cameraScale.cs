using UnityEngine;

public class cameraScale : MonoBehaviour
{
	public float targetaspect = 1.7777778f;

	private void Update()
	{
		float num = (float)Screen.width / (float)Screen.height;
		float num2 = num / targetaspect;
		Camera component = GetComponent<Camera>();
		if (num2 < 1f)
		{
			Rect rect = component.rect;
			rect.width = 1f;
			rect.height = num2;
			rect.x = 0f;
			rect.y = (1f - num2) / 2f;
			component.rect = rect;
		}
		else
		{
			float num3 = 1f / num2;
			Rect rect2 = component.rect;
			rect2.width = num3;
			rect2.height = 1f;
			rect2.x = (1f - num3) / 2f;
			rect2.y = 0f;
			component.rect = rect2;
		}
	}
}
