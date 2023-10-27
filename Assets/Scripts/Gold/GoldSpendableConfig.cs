using System;
using Core;
using UnityEngine;

namespace Gold
{
	[Serializable]
	public class GoldSpendableConfig : ISpendableConfig
	{
		[SerializeField] private int value;
		public int Value => value;

		public ISpendable CreateInstance() => new GoldSpendable(this);
	}
}