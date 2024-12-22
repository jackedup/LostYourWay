using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
	public Texture2D texture;

	private static LoadingScreen instance;

	private void Awake()
	{
		if ((bool)instance)
		{
			Object.Destroy(base.gameObject);
			hide();
			return;
		}
		instance = this;
		base.gameObject.AddComponent<GUITexture>().enabled = false;
		base.GetComponent<GUITexture>().texture = texture;
		base.transform.position = new Vector3(0.5f, 0.5f, 1f);
		Object.DontDestroyOnLoad(this);
	}

	public static void show()
	{
		if (InstanceExists())
		{
			instance.GetComponent<GUITexture>().enabled = true;
		}
	}

	public static void hide()
	{
		if (InstanceExists())
		{
			instance.GetComponent<GUITexture>().enabled = false;
		}
	}

	private static bool InstanceExists()
	{
		if (!instance)
		{
			return false;
		}
		return true;
	}
}
