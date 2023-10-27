using System;
using Core;
using UnityEngine;

namespace Location
{
	[Serializable]
	public class LocationReward : IReward
	{
		[SerializeField] private Location value;

		public void Apply() => LocationManager.Instance.CurrentLocation.Value = value;
	}
}