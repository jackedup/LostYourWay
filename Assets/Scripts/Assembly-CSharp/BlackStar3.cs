using UnityEngine;

public class BlackStar3 : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetFloat(0 + "HScore") <= 30f)
		{
			base.gameObject.SetActive(false);
		}
	}
}
