using System;
using Core;
using UnityEngine;

namespace Health
{
	[Serializable]
	public class PercentHealthSpendableConfig : ISpendableConfig
	{
		[SerializeField] [Range(0.0f, 100.0f)] private float value;
		public float Value => value;

		public ISpendable CreateInstance() => new PercentHealthSpendable(this);
	}
}