using System;
using Core;
using UnityEngine;

namespace Health
{
	[Serializable]
	public class FixedHealthReward : IReward
	{
		[SerializeField] private float value;

		public void Apply() => HealthManage.Instance.CurrentHealthValue.Value += value;
	}
}