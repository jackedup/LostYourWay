using UnityEngine;

public class resetstarscore : MonoBehaviour
{
	private void Start()
	{
		PlayerPrefs.DeleteKey("StarCount");
	}

	private void Update()
	{
	}
}
