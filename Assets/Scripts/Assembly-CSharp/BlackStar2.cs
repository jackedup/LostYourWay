using UnityEngine;

public class BlackStar2 : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetFloat(0 + "HScore") <= 35f)
		{
			base.gameObject.SetActive(false);
		}
	}
}
