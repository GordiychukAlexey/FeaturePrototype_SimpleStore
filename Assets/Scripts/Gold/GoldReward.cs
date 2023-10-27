using System;
using Core;
using UnityEngine;

namespace Gold
{
	[Serializable]
	public class GoldReward : IReward
	{
		[SerializeField] private int value;

		public void Apply() => GoldManage.Instance.CurrentGoldCount.Value += value;
	}
}