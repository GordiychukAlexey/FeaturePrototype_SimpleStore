using System;
using Core;
using UnityEngine;

namespace Health
{
	[Serializable]
	public class FixedHealthSpendableConfig : ISpendableConfig
	{
		[SerializeField] private float value;
		public float Value => value;

		public ISpendable CreateInstance() => new FixedHealthSpendable(this);
	}
}