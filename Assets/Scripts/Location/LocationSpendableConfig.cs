using System;
using Core;
using UnityEngine;

namespace Location
{
	[Serializable]
	public class LocationSpendableConfig : ISpendableConfig
	{
		[SerializeField] private Location value;
		public Location Value => value;

		public ISpendable CreateInstance() => new LocationSpendable(this);
	}
}