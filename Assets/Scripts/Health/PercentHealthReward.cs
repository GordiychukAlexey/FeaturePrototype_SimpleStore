using System;
using Core;
using UnityEngine;

namespace Health
{
	[Serializable]
	public class PercentHealthReward : IReward
	{
		[SerializeField] private float value;

		public void Apply() => HealthManage.Instance.CurrentHealthValue.Value *= 1.0f + value / 100.0f;
	}
}