using UnityEngine;

public class StarCount : MonoBehaviour
{
	private void Update()
	{
		base.gameObject.GetComponent<TextMesh>().text = PlayerPrefs.GetInt("StarCount") + string.Empty;
	}
}
