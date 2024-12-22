using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class explosion : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Fire_00241 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal explosion _0024self__00242;

			public _0024(explosion self_)
			{
				_0024self__00242 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(_0024self__00242.explosiveDelay)) ? 1 : 0);
					break;
				case 2:
					UnityEngine.Object.Instantiate(_0024self__00242.explosionPrefab, _0024self__00242.transform.position, _0024self__00242.transform.rotation);
					UnityEngine.Object.Destroy(_0024self__00242.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal explosion _0024self__00243;

		public _0024Fire_00241(explosion self_)
		{
			_0024self__00243 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00243);
		}
	}

	public float radius;

	public float power;

	public float explosiveLift;

	public float explosiveDelay;

	public Transform explosionPrefab;

	public AudioClip explosionSound;

	public explosion()
	{
		radius = 5f;
		power = 10f;
		explosiveLift = 1f;
		explosiveDelay = 5f;
	}

	public virtual void Update()
	{
		StartCoroutine_Auto(Fire());
	}

	public virtual IEnumerator Fire()
	{
		return new _0024Fire_00241(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
