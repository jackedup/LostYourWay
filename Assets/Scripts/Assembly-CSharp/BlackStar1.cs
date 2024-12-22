using UnityEngine;

public class BlackStar1 : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetFloat(0 + "HScore") <= 40f)
		{
			base.gameObject.SetActive(false);
		}
	}
}
